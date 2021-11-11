using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Motocicleta : FrmBaseMarca
    {
        public Motocicleta()
        {
            InitializeComponent();
        }

        private void btnmarca1_Click(object sender, EventArgs e)
        {
            Moto_Yamaha yamaha = new Moto_Yamaha();
            this.Hide();
            yamaha.Show();
        }

        private void btnmarca2_Click(object sender, EventArgs e)
        {
            Moto_susuki susuki = new Moto_susuki();
            this.Hide();
            susuki.Show();
        }

        private void btnmarca3_Click(object sender, EventArgs e)
        {
            Moto_Honda Honda = new Moto_Honda();
            Honda.Show();
            this.Hide();
        }
    }
}
