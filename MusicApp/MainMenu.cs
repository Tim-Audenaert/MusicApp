using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MainMenu : Form
    {
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblPlaylists;
        }
        public MainMenu()
        {
            InitializeComponent();
            lvwSongs.View = View.Details;
            lvwSongs.CheckBoxes = true;
            lvwSongs.FullRowSelect = true;
            lvwSongs.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            ColumnHeader title = new ColumnHeader();
            title.Text = "Title";
            title.TextAlign = HorizontalAlignment.Left;
            title.Width = 100;
            lvwSongs.Columns.Add(title);

            ColumnHeader artist = new ColumnHeader();
            artist.Text = "Artist";
            artist.TextAlign = HorizontalAlignment.Left;
            artist.Width = 100;
            lvwSongs.Columns.Add(artist);

            ColumnHeader album = new ColumnHeader();
            album.Text = "Album";
            album.TextAlign = HorizontalAlignment.Left;
            album.Width = 100;
            lvwSongs.Columns.Add(album);

            ColumnHeader length = new ColumnHeader();
            length.Text = "Length";
            length.TextAlign = HorizontalAlignment.Left;
            length.Width = 100;
            lvwSongs.Columns.Add(length);

            using (var ctx = new AccountContext())
            {
                var playlists = ctx.Playlists.Where(x => x.User.Id == Global.UserId).ToArray();
                lstPlaylists.DataSource = playlists;
                lstPlaylists.DisplayMember = "Name";
                lstPlaylists.ValueMember = "Id";
            }

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            AddArtist newArtist = new AddArtist();
            newArtist.Show();
            Close();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum newAlbum = new AddAlbum();
            newAlbum.Show();
            Close();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSong newSong = new AddSong();
            newSong.Show();
            Close();
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            AddPlaylist newPlaylist = new AddPlaylist();
            newPlaylist.Show();
            Close();
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwSongs.SelectedItems.Clear();
            lvwSongs.Items.Clear();
            Playlist selectedPlaylist = lstPlaylists.SelectedItem as Playlist;
            using (var ctx = new AccountContext())
            {
                //HIER VERDER               
                var playlists = ctx.Playlists.Include(nameof(Playlist.Songs)).Where(p => p.Id == selectedPlaylist.Id).ToList();


                foreach (var item in playlists)
                {
                    var songs = item.Songs.Join(ctx.Artists,
                        s => s.Artist.Id,
                        a => a.Id,
                        (s, a) => new { s, a })
                   .Join(ctx.Albums,
                        sa => sa.a.Id,
                        alb => alb.Id,
                        (sa, alb) => new { sa, alb });

                    foreach (var song in songs)
                    {
                        var liked = ctx.Interactions.FirstOrDefault(l => l.User.Id == Global.UserId && l.Song.Id == song.sa.s.Id);
                        var addSong = lvwSongs.Items.Add(new ListViewItem(new string[]
                            {
                                song.sa.s.Title,
                                song.sa.a.Name,
                                song.alb.Name,
                                (TimeSpan.FromSeconds(song.sa.s.Length).ToString(@"mm\:ss"))
                            }));
                        addSong.Tag = song.sa.s;
                        addSong.Checked = (liked != null && liked.Liked) ? true : false;
                    }
                }
            }
        }

        private void lvwSongs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            Song song = item.Tag as Song;

            if (song != null)
            {
                using (var ctx = new AccountContext())
                {
                    var interaction = ctx.Interactions
                        .Join(ctx.Users,
                            i => i.User.Id,
                            user => user.Id,
                            (i, user) => new { i, user })
                        .Join(ctx.Songs,
                            si => si.i.Song.Id,
                            s => s.Id,
                            (si, s) => new { si, s })
                        .FirstOrDefault(x => x.si.user.Id == Global.UserId && x.s.Id == song.Id);

                    if (interaction == null)
                    {
                        ctx.Interactions.Add(new Interaction()
                        {
                            User = ctx.Users.FirstOrDefault(u => u.Id == Global.UserId),
                            Song = ctx.Songs.FirstOrDefault(s => s.Id == song.Id),
                            Liked = item.Checked ? true : false,
                            PlayCount = 0,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                        });
                    }
                    else
                    {
                        interaction.si.i.Liked = item.Checked ? true : false;
                        interaction.si.i.UpdatedAt = DateTime.Now;
                    }
                    ctx.SaveChanges();
                }
            }
        }

        private void lvwSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnPlay.Enabled = lvwSongs.SelectedItems.Count > 0 ? true : false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                Song song = lvwSongs.SelectedItems[0].Tag as Song;
                if (song != null)
                {
                    var interaction = ctx.Interactions
                        .Join(ctx.Users,
                            i => i.User.Id,
                            user => user.Id,
                            (i, user) => new { i, user })
                        .Join(ctx.Songs,
                            si => si.i.Song.Id,
                            s => s.Id,
                            (si, s) => new { si, s })
                        .FirstOrDefault(x => x.si.user.Id == Global.UserId && x.s.Id == song.Id);

                    if (interaction == null)
                    {
                        ctx.Interactions.Add(new Interaction()
                        {
                            User = ctx.Users.FirstOrDefault(u => u.Id == Global.UserId),
                            Song = ctx.Songs.FirstOrDefault(s => s.Id == song.Id),
                            Liked = false,
                            PlayCount = 1,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                        });
                    }
                    else
                    {
                        interaction.si.i.PlayCount++;
                        interaction.si.i.UpdatedAt = DateTime.Now;
                    }
                    ctx.SaveChanges();
                    MessageBox.Show("click");
                }
            }
        }
    }
}

