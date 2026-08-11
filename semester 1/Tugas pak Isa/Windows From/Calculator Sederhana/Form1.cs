using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Sederhana
{
    public partial class txtAngka1 : Form
    {
        public txtAngka1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textAngka1.Text);
            int angka2 = Convert.ToInt32(textAngka2.Text);

            int hasil = angka1 + angka2;

            lblHasil.Text = "Hasil :  " + hasil.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textAngka1.Text);
            int angka2 = Convert.ToInt32(textAngka2.Text);

            int hasil = angka1 - angka2;

            lblHasil.Text = "Hasil :  " + hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textAngka1.Text);
            int angka2 = Convert.ToInt32(textAngka2.Text);

            int hasil = angka1 * angka2;

            lblHasil.Text = "Hasil :  " + hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(textAngka1.Text);
            double angka2 = Convert.ToDouble(textAngka2.Text);

            double hasil = angka1 / angka2;

            lblHasil.Text = "Hasil :  " + hasil.ToString();
        }
    }
}
