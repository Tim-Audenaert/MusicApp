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
    public partial class AddArtist : Form
    {
        public AddArtist()
        {
            InitializeComponent();          
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                ctx.Artists.Add(new Artist
                {
                    Name = txtArtistName.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }) ;
                ctx.SaveChanges();
            }
            MessageBox.Show($"{txtArtistName.Text} has been added.");
        }
    }
}
