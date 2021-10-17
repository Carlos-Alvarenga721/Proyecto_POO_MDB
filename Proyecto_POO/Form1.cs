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
    public partial class Splash : Form
    {
        private int Tiempo { get; set; } //creo un atributo para manejar el tiempo
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tiempo > 0)
            {
                Tiempo = Tiempo - 1;
            }
            else
            {
                timer1.Stop();
                new Login().Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //aqui es donde empieza a correr el tiempo del timer
            Tiempo = 30;
            timer1.Start();
        }
    }
}
