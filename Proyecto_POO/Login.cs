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
    public partial class Login : Form
    {
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {//LOS LOGINS VALIDOS SON: 
         //Usuario=Admin y contraseña=123
         //Usuario=Carlos y contraseña=456
            string seleccion;
            seleccion = "Select*From Usuario Where usuario= '" + txtnombre.Text + "' AND clave= '" + txtcontraseña.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("usuario", SqlDbType.VarChar);
            prm.Value = txtnombre.Text;
            da1.SelectCommand.Parameters.Add(prm);
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                txtnombre.Text = dr1["usuario"].ToString().Trim();
                txtcontraseña.Text = dr1["clave"].ToString().Trim();
            }
            if (dr1.HasRows)
            {//VALIDO QUE EL USUARIO Y CONTRASEÑA SE ENCUENTREN EN LA BASE DE DATOS
                MessageBox.Show("Usuario y clave validas");
                dr1.Close();
                Vehiculos menu = new Vehiculos();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave no validos");
                dr1.Close();
                txtnombre.Clear();
                txtcontraseña.Clear();
            }
      
        }
      
        private void btnsalir_Click(object sender, EventArgs e)
        {//puse una advertencia para decirle al usuario si realmente desea salir de la aplicaccion
            if (MessageBox.Show("Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
