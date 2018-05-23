using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KU_Digital_Medi_File
{
    public partial class Doctor_s_Advice : Form
    {
        public Doctor_s_Advice()
        {
            InitializeComponent();
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font1 = new Font("arial", 16, FontStyle.Regular);
            e.Graphics.DrawString(richTextBox1.Text, font1, Brushes.Black, 100, 100);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter Some Text");
            }
            else
            {
                printPreviewDialog1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
