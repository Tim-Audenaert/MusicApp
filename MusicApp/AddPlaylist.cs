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
    public partial class AddPlaylist : Form
    {
        public AddPlaylist()
        {
            InitializeComponent();
            using (var ctx = new AccountContext())
            {
                lstSongs.DataSource = ctx.Songs.ToArray();
                lstSongs.DisplayMember = "Title";
                lstSongs.ValueMember = "Id";            
            }
            lstPlaylistSongs.DisplayMember = "Title";
            lstPlaylistSongs.ValueMember = "Id";
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                Playlist newPlaylist = new Playlist()
                {
                    User = ctx.Users.FirstOrDefault(u => u.Id == Global.UserId),
                    Name = txtPlaylistName.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                foreach (var item in lstPlaylistSongs.Items)
                {
                    ctx.Songs.Attach(item as Song);
                    newPlaylist.Songs.Add(item as Song);
                }                
                ctx.Playlists.Add(newPlaylist);
                ctx.SaveChanges();
                MessageBox.Show($"Playlist {txtPlaylistName.Text} has been added.");
                MainMenu main = new MainMenu();
                main.Show();
                Close();
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (var item in lstPlaylistSongs.Items)
            {
                if (item == lstSongs.SelectedItem)
                {
                    exists = true;
                }
            }

            if (!exists)
            {
                lstPlaylistSongs.Items.Add(lstSongs.SelectedItem as Song);
            }
            else
            {
                MessageBox.Show("This song is already in your playlist");
            }
            

        }
    }
}
