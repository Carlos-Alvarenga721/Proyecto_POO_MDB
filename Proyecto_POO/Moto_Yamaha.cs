using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Moto_Yamaha : FrmBaseModelo
    {
        public Moto_Yamaha()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Motocicleta moto = new Motocicleta();
            this.Hide();
            moto.Show();
        }

        private void Moto_Yamaha_Load(object sender, EventArgs e)
        {   //agrego elementos al combobox del modelo
            combomodelo.Items.Clear();
            combomodelo.Items.Add("Yamaha XMAX 125");
            combomodelo.Items.Add("Yamaha MT-07");
            //agrego elementos al combobox del color
            combocolor.Items.Clear();
            combocolor.Items.Add("Negro");
            combocolor.Items.Add("Azul");
        }

        private void btnsolicitar_Click(object sender, EventArgs e)
        {           
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.yamaha_xmax_negra;                
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$17,100";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.yamaha_xmax_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$17,100";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.yamahamt7negra;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$16,450";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.Yamaha_MT07_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$16,450";
            }
        }
    }
}
