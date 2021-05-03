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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                var exists = ctx.Users.FirstOrDefault(u => u.Email == txtEmail.Text);
                if (exists == null)
                {
                    ctx.Users.Add(new User
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text
                    });
                    MessageBox.Show("Your account has been created! Redirecting...");
                    ctx.SaveChanges();
                }
                else MessageBox.Show("This e-mail is already registered. Please log in or use a different e-mail");
            }

            Close();
        }
    }
}
