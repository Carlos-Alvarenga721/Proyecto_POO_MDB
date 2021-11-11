using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Proyecto_POO
{
    public partial class FrmBaseModelo : Form
    {
        //Variables para la conexion 
        private SqlConnection conn;
        private SqlDataAdapter da1;
        private SqlCommand insert1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();

        public FrmBaseModelo()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=CARLOS-COMPUTER;Database=BaseAutos_ProyectoMDB;Uid=sa;Pwd=C1a2a3c4"; //SA Y CONTRA DESDE MAQUINA LOCAL --BD_AC211104
            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn = new SqlConnection(sCn1);
            conn.Open();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txbcodcliente_Leave(object sender, EventArgs e)
        {
            buscarclientes();
            NombreClienteL.Visible = true;
            labelnombre.Visible = true;
        }

        //funcion para obtener el nombre del cliente en la base de datos
        public void buscarclientes()
        {
            string seleccion;
            seleccion = "Select Nombres,PrimerApellido From Clientes where Id= '" + txbcodcliente.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Id", SqlDbType.Int);
            prm.Value = txbcodcliente.Text;
            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                NombreClienteL.Text = dr1["Nombres"].ToString().Trim() + " " + dr1["PrimerApellido"].ToString().Trim();
            }
            if (dr1.HasRows)
            {
                //MessageBox.Show("Datos Encontrados");
                dr1.Close();
            }
            else
            {
                MessageBox.Show("Nombre del cliente inexistente");
                txbcodcliente.Clear();
                labelnombre.Visible = false;
                NombreClienteL.Visible = false;
            }
        }

    }
}
