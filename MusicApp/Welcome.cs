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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount newCreate = new CreateAccount();
            newCreate.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var ctx = new AccountContext())
            {
                var user = ctx.Users.FirstOrDefault(u => u.Email == txtEmail.Text);
                if (user == null)
                {
                    MessageBox.Show("This e-mail is not registered.");
                }
                else
                {
                    if (user.Password == txtPassword.Text)
                    {
                        Global.UserId = user.Id;
                        MessageBox.Show("Successfully logged in. Redirecting...");
                        MainMenu main = new MainMenu();
                        Hide();
                        main.Show();
                    }
                    else MessageBox.Show("Incorrect password.");
                }
            }
        }
    }
}
