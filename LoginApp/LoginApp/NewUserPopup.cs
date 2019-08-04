using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MessagingToolkit.Barcode;

namespace LoginApp
{
    public partial class NewUserPopup : Form
    {
        public NewUserPopup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        //Button to Generate Barcodes off of user inputed data
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Logic for printing the barcode page
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        Bitmap bitmap;

        //Print the document
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        //Dialog to save the image
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Logic for saving image
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images |*.jpg,*.png,*.bmp";
            saveFileDialog1.Title = "Save Image";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                ProcessGenerate();
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            ProcessGenerate();
        }

        private void ProcessGenerate()
        {
            string userInput = txtFirstName.Text.Trim() + " "+ txtLastName.Text.Trim();
            userInput = userInput.Trim();

            BarcodeEncoder Generator;

            Generator = new BarcodeEncoder();
            Generator.IncludeLabel = true;
            Generator.CustomLabel = userInput;

            const int ID = 1;

            string genID = ID.ToString();

            label4.Visible = true;
            txtID.Visible = true;
            txtID.Text = genID;
            btnUpload.Visible = true;

            if (userInput != "")
            {
                pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.Code128, genID));
            }
            else
            {
                pictureBox1.Image = null;
                label4.Visible = false;
                txtID.Visible = false;
                btnUpload.Visible = false;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                ProcessGenerate();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if ((txtFirstName.Text != "") && (txtLastName.Text != ""))
            {
                btnGen.Enabled = true;
            }
            else
            {
                btnGen.Enabled = false;
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserPopup_Load(object sender, EventArgs e)
        {
            txtAdmin.Text = AdminLogin.value;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //All code for exporting data to SQL server
        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if ((txtFirstName.Text != "") && (txtLastName.Text != ""))
            {
                btnGen.Enabled = true;
            }
            else
            {
                btnGen.Enabled = false;
            }
        }
    }
}
