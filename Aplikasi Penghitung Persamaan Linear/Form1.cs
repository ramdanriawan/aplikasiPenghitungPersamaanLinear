using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penghitung_Persamaan_Linear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //menyimpan data list persamaan

            var b1 = txtPers1.Text.Split(',');
            MessageBox.Show(b1[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
