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
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            AddArtist newArtist = new AddArtist();
            newArtist.Show();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum newAlbum = new AddAlbum();
            newAlbum.Show();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSong newSong = new AddSong();
            newSong.Show();
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            AddPlaylist newPlaylist = new AddPlaylist();
            newPlaylist.Show();
        }
    }
}
