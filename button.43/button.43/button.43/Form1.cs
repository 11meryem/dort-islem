using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Islemler islem = new Islemler();
            islem.sayi1=Convert.ToInt32(txtSayi1.Text);
            islem.sayi2=Convert.ToInt32(txtSayi2.Text);
            lblSonuc.Text = "Sonuç   " + islem.Toplama();

            lblSonuc2.Text = "Sonuç   " + islem.Cikarma();

            lblSonuc3.Text = "Sonuç   " + islem.Carpma();

            lblSonuc4.Text = "Sonuç   " + islem.Bolme();

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
