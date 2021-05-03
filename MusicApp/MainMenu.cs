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
        public MainMenu()
        {
            InitializeComponent();
            using (var ctx = new AccountContext())
            {
                lstPlaylists.DataSource = ctx.Playlists.Where(x => x.User.Id == Global.UserId).ToArray();
                lstPlaylists.DisplayMember = "Name";
                lstPlaylists.ValueMember = "Id";

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
    }
}
