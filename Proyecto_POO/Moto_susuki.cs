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
    public partial class Moto_susuki : FrmBaseModelo
    {
        public Moto_susuki()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Motocicleta moto = new Motocicleta();
            this.Hide();
            moto.Show();
        }

        private void Moto_susuki_Load(object sender, EventArgs e)
        {//agrego elementos al combobox del modelo
            combomodelo.Items.Clear();
            combomodelo.Items.Add("Susuki GSX-S1000 GT");
            combomodelo.Items.Add("Susuki HAYABUSA 1300");
            //agrego elementos al combobox del color
            combocolor.Items.Clear();
            combocolor.Items.Add("Negro");
            combocolor.Items.Add("Azul");
        }

        private void btnsolicitar_Click(object sender, EventArgs e)
        {
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.susuki_gsx_negra;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$15,150";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.susuki_GSX_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$15,150";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.susuki_hayabusa_negra;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$12,300";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.susuki_hayabusa_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$12,300";
            }
        }
    }
}
