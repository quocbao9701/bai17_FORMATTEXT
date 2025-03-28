using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17_FORMATTEXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Text = txtnhapten.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
            txtnhapten.ForeColor = Color.Red;   

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Green;
            txtnhapten.ForeColor= Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
            txtnhapten.ForeColor=Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Black;
            txtnhapten.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name,lblLaptrinh.Font.Size,FontStyle.Bold);

        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name,lblLaptrinh.Font.Size,FontStyle.Underline);
        }
    }
}
