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
    public partial class Moto_Yamaha : FrmBaseModelo
    {
        //Variables para la conexion 
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public Moto_Yamaha()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=CARLOS-COMPUTER;Database=BaseAutos_ProyectoMDB;Uid=sa;Pwd=C1a2a3c4"; //SA Y CONTRA DESDE MAQUINA LOCAL --BD_AC211104
            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn = new SqlConnection(sCn1);
            conn.Open();
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
                labelmonto.Text = "17,100";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "21";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.yamaha_xmax_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "17,100";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "22";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.yamahamt7negra;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "16,450";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "23";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.Yamaha_MT07_azul;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "16,450";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "24";
            }
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    string insertFactura;
                    insertFactura = "INSERT INTO Factura(Id_Cliente,Id_Vehiculo,IVA,Tipo_Vehiculo,Marca_Modelo_Vehiculo,Color,Precio_Vehiculo,Fecha_Factura)";
                    insertFactura += "VALUES(@Id_Cliente,@Id_Vehiculo,@IVA,@Tipo_Vehiculo,@Marca_Modelo_Vehiculo,@Color,@Precio_Vehiculo,@Fecha_Factura)";
                    insert1 = new SqlCommand(insertFactura, conn);
                    insert1.Parameters.Add(new SqlParameter("@Id_Cliente", SqlDbType.Int));
                    insert1.Parameters["@Id_Cliente"].Value = txbcodcliente.Text;
                    insert1.Parameters.Add(new SqlParameter("@Id_Vehiculo", SqlDbType.Int));
                    insert1.Parameters["@Id_Vehiculo"].Value = IdVehiculoL.Text;
                    insert1.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Money));
                    insert1.Parameters["@IVA"].Value = Convert.ToDouble(labelmonto.Text) * 0.13;
                    insert1.Parameters.Add(new SqlParameter("@Tipo_Vehiculo", SqlDbType.VarChar));
                    insert1.Parameters["@Tipo_Vehiculo"].Value = "Motocicleta";
                    insert1.Parameters.Add(new SqlParameter("@Marca_Modelo_Vehiculo", SqlDbType.VarChar));
                    insert1.Parameters["@Marca_Modelo_Vehiculo"].Value = combomodelo.SelectedItem;
                    insert1.Parameters.Add(new SqlParameter("@Color", SqlDbType.VarChar));
                    insert1.Parameters["@Color"].Value = combocolor.SelectedItem;
                    insert1.Parameters.Add(new SqlParameter("@Precio_Vehiculo", SqlDbType.VarChar));
                    insert1.Parameters["@Precio_Vehiculo"].Value = labelmonto.Text;
                    insert1.Parameters.Add(new SqlParameter("@Fecha_Factura", SqlDbType.DateTime));
                    insert1.Parameters["@Fecha_Factura"].Value = DateTime.Now;
                    insert1.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado...", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("El registro no fue agregado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
