using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmHesapMakinesi
{
    public partial class Form1 : Form

    {
        int secim = 0;
        double sayi1, sayi2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 1;
            txtDisplay.Text = "0";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 2;
            txtDisplay.Text = "0";
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 3;
            txtDisplay.Text = "0";
        }

        private void btnBolu_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 4;
            txtDisplay.Text = "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(txtDisplay.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            }
            txtDisplay.Text = sonuc.ToString();

        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.IndexOf(",")<1)
            {
                txtDisplay.Text += ",";
            }
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text!="0")
            {
                if(txtDisplay.Text.StartsWith("-"))
                {
                    txtDisplay.Text=txtDisplay.Text.Replace("-", "");    
                } 
                else if(txtDisplay.Text.StartsWith(""))
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;    
                }
            }
        }

        private void Butonlar(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + ((Button)sender).Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}
