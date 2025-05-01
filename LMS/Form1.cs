using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LMSEntities1 content = new LMSEntities1();
            string username = UserTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            var admins = content.LMSAdmins.ToList();
            MessageBox.Show("Found " + admins.Count + " admins");

            var user = admins
                .Where(x => x.UserName.ToLower() == username.ToLower())
                .FirstOrDefault();

            if (user != null)
            {
                if (user.Password.ToLower() == password.ToLower())
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
        }
    }
}

