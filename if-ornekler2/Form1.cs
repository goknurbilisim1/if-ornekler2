﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_ornekler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float yazili1, yazili2, ortalama;

            yazili1=Convert.ToSingle(txtYazili1.Text);
            yazili2=Convert.ToSingle(txtYazili2.Text);

            ortalama = (yazili1 + yazili2) / 2;

            if (ortalama >= 50)
            {
                lblDurum.Text = "Durum: Gecti";
                lblDurum.ForeColor= Color.Green;
            }
            else
            {
                lblDurum.Text = "Durum: Kaldı";
                lblDurum.ForeColor=Color.Red;
            }
            lblOrtalama.Text = "ortalama: " + ortalama.ToString();

        }
    }
}
