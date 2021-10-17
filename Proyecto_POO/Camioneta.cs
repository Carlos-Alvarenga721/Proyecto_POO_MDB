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
    public partial class Camioneta : FrmBaseMarca
    {
        public Camioneta()
        {
            InitializeComponent();
        }

        private void btnmarca2_Click(object sender, EventArgs e)
        {
            camioneta_ford ford = new camioneta_ford();
            this.Hide();
            ford.Show();
        }
    }
}
