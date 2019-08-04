using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    //A a const login for testing purposes.
    public partial class AdminLogin : Form
    {
        const string USER = "Master";
        const string PASSWORD = "MasterPassword";

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Clsoe the Login Form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            //getUser();
            if ((txtUser.Text == USER) && (txtPass.Text == PASSWORD))
            {
                this.Hide();
                NewUserPopup popup = new NewUserPopup();
                popup.ShowDialog();
            }
            if ((txtUser.Text != USER) || (txtPass.Text != PASSWORD))
            {
                lblWrong.Visible = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Login();
            }
        }
    }
}
