using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Carro_nissan : FrmBaseModelo
    {
        public Carro_nissan()
        {
            InitializeComponent();
        }


        private void btnregresar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            this.Hide();
            carro.Show();
        }

        private void Carro_nissan_Load(object sender, EventArgs e)
        {
            //agrego elementos al combobox del modelo
            combomodelo.Items.Clear();
            combomodelo.Items.Add("Nissan Sentra");
            combomodelo.Items.Add("Nissan Versa");
            //agrego elementos al combobox del color
            combocolor.Items.Clear();
            combocolor.Items.Add("Naranja");
            combocolor.Items.Add("Azul");
        }

        private void btnsolicitar_Click(object sender, EventArgs e)
        {
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.nissan_sentra_naranja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$20,450";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.nissan_sentra_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$20,450";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.nissan_versa_naranja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$23,000";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.nissan_versa_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$23,000";
            }
        }
    }
}
