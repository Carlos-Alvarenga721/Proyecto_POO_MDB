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
    public partial class camioneta_ford : FrmBaseModelo
    {
        public camioneta_ford()
        {
            InitializeComponent();
        }

        private void camioneta_ford_Load(object sender, EventArgs e)
        {//agrego elementos al combobox del modelo
            combomodelo.Items.Clear();
            combomodelo.Items.Add("Ford Escape");
            combomodelo.Items.Add("Ford Xplorer");
            //agrego elementos al combobox del color
            combocolor.Items.Clear();
            combocolor.Items.Add("Blanco");
            combocolor.Items.Add("Rojo");

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta();
            this.Hide();
            camioneta.Show();
        }

        private void btnsolicitar_Click(object sender, EventArgs e)
        {
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.ford_escape_blanca;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$23,000";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.ford_escape_roja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$23,000";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.ford_xplorer_blanca;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$30,200";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.ford_xplorer_roja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "$30,200";
            }
        }
    }
}
