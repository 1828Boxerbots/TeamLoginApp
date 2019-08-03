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
        //private PrintDocument printDocument2 = new PrintDocument();

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
            string userInput = textBox1.Text + textBox2.Text;

            BarcodeEncoder Generator;

            Generator = new BarcodeEncoder();
            Generator.IncludeLabel = true;
            Generator.CustomLabel = userInput;

            if(userInput != "")
            {
                pictureBox1.Image = new Bitmap(Generator.Encode(BarcodeFormat.Code128, userInput));
            }
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
    }
}
