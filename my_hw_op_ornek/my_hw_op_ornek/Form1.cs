using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_hw_op_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double s1, s2, proje, ort;
            string adsoyad, durum;
            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            proje = Convert.ToDouble(txtProje.Text);
            adsoyad = textBox1.Text;
            ort = (s1 + s2 + proje) / 3;

            if (ort>=50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            txtSonuc.Text = ort.ToString("0.00") + " - " + durum;
            listBox1.Items.Add(adsoyad + " - " + ort.ToString("0.00") + " - " + durum);


        }
    }
}
