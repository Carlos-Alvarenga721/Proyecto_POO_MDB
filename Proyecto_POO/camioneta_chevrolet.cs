using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Proyecto_POO
{
    public partial class camioneta_chevrolet : FrmBaseModelo
    {
        //Variables para la conexion 
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();

        public camioneta_chevrolet()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=CARLOS-COMPUTER;Database=BaseAutos_ProyectoMDB;Uid=sa;Pwd=C1a2a3c4"; //SA Y CONTRA DESDE MAQUINA LOCAL --BD_AC211104
            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn = new SqlConnection(sCn1);
            conn.Open();
        }

        private void camioneta_chevrolet_Load(object sender, EventArgs e)
        {
            //agrego elementos al combobox del modelo
            combomodelo.Items.Clear();
            combomodelo.Items.Add("Chevrolet Tracker");
            combomodelo.Items.Add("Chevrolet Colorado");
            //agrego elementos al combobox del color
            combocolor.Items.Clear();
            combocolor.Items.Add("Blanco");
            combocolor.Items.Add("Rojo");
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Camioneta camioneta = new Camioneta();
            camioneta.Show();
            this.Hide();
        }

        private void btnsolicitar_Click(object sender, EventArgs e)
        {
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.chevrolet_tracker_blanca;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "36,745";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "29";
            }
            if (combomodelo.SelectedIndex == 0 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.chevrolet_tracker_roja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "36,745";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "30";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 0)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.chevrolet_colorado_blanca;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "45,150";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "31";
            }
            if (combomodelo.SelectedIndex == 1 && combocolor.SelectedIndex == 1)
            {
                Image imagenmoto = Proyecto_POO.Properties.Resources.chevrolet_colorado_roja;
                Picbox.Image = imagenmoto;
                labelprecio.Visible = true;
                labelmonto.Visible = true;
                labelmonto.Text = "45,150";
                labelCodVeh.Visible = true;
                IdVehiculoL.Visible = true;
                IdVehiculoL.Text = "32";
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
                    insert1.Parameters["@Tipo_Vehiculo"].Value = "Camioneta";
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
