using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            UserAccountService service = new UserAccountService();
            string email = txtEmail.Text;
            UserAccount acc = service.CheckLogin(email);
            if (acc != null)
            {
                if (acc.Role == 1)
                {
                    if (acc.Password == txtPassword.Text)
                    {
                        BookManagerMainUI bookManagerMainUI = new BookManagerMainUI();
                        bookManagerMainUI.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect email or password");
                    }
                }
                else
                {
                    MessageBox.Show("You dont have permmission to access!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
