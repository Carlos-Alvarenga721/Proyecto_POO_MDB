using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {//puse una advertencia para decirle al usuario si realmente desea salir de la aplicaccion
            if (MessageBox.Show("Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmoto_Click(object sender, EventArgs e)
        {
            Motocicleta moto = new Motocicleta();
            this.Hide();
            moto.Show();
        }

        private void btncarro_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            this.Hide();
            carro.Show();
        }

        private void btncamioneta_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta();
            this.Hide();
            camioneta.Show();
        }
    }
}
