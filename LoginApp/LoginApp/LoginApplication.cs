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
    public partial class LoginApplication : Form
    {
        public LoginApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Login Application";
        }

        //New User Dialog Code
        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin popup = new AdminLogin();
            DialogResult dialogresult = popup.ShowDialog();
        }

        //I think this is the File Menu?
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //Print Menu
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
