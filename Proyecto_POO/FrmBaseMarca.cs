using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_POO
{/*este formulario sera el formulario base que herederara a los otros formularios
y es aqui donde aplicamos la herencia entre formularios, en este caso se utilizo esa
 herencia de formato para evitar diseñar lo mismo 3 veces*/
    public partial class FrmBaseMarca : Form
    {
        public FrmBaseMarca()
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

        private void btnregresar_Click(object sender, EventArgs e)
        {//me regresa al menu principal
            Vehiculos menu = new Vehiculos();
            this.Hide();
            menu.Show();
        }
    }
}
