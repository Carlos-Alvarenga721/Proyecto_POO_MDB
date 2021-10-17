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
    public partial class Carro : FrmBaseMarca
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void btnmarca1_Click(object sender, EventArgs e)
        {
            Carro_nissan nissan = new Carro_nissan();
            this.Hide();
            nissan.Show();
        }
    }
}
