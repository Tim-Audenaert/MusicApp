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
    public partial class AddSong : Form
    {
        public AddSong()
        {
            InitializeComponent();
            using(var ctx = new AccountContext())
            {
                lstArtists.DataSource = ctx.Artists.ToArray();
                lstArtists.DisplayMember = "Name";
                lstArtists.ValueMember = "Id";

                lstAlbums.DataSource = ctx.Albums.ToArray();
                lstAlbums.DisplayMember = "Name";
                lstAlbums.ValueMember = "Id";
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                ctx.Songs.Add(new Song
                {
                    Title = txtTitle.Text,
                    Album = ctx.Albums.FirstOrDefault(x => x.Id == ((Album)lstAlbums.SelectedItem).Id),
                    Artist = ctx.Artists.FirstOrDefault(x => x.Id == ((Artist)lstArtists.SelectedItem).Id),
                    Length = DateTime.Now,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }); ;
                ctx.SaveChanges();
            }
            MessageBox.Show($"{txtTitle.Text} has been added to the album.");
            Close();
            MainMenu main = new MainMenu();
            main.Show();
        }
    }
}
