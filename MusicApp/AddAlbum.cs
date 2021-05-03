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
    public partial class AddAlbum : Form
    {
        public AddAlbum()
        {
            InitializeComponent();
            using(var ctx = new AccountContext())
            {
                lstArtists.DataSource = ctx.Artists.ToArray();
                lstArtists.DisplayMember = "Name";
                lstArtists.ValueMember = "Id";
            }

        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                ctx.Albums.Add(new Album
                {
                    Name = txtName.Text,
                    Artist = lstArtists.SelectedItem as Artist,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                ctx.SaveChanges();
            }
            MessageBox.Show($"Album \"{txtName.Text}\" created!");

        }
    }
}
