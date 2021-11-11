
namespace Proyecto_POO
{
    partial class FrmBaseModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combomodelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.combocolor = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnvender = new System.Windows.Forms.Button();
            this.labelmonto = new System.Windows.Forms.Label();
            this.btnsolicitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcodcliente = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.NombreClienteL = new System.Windows.Forms.Label();
            this.labelCodVeh = new System.Windows.Forms.Label();
            this.IdVehiculoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(45, 88);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(307, 210);
            this.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione el modelo y detalles de su vehiculo:";
            // 
            // combomodelo
            // 
            this.combomodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomodelo.FormattingEnabled = true;
            this.combomodelo.Location = new System.Drawing.Point(407, 183);
            this.combomodelo.Name = "combomodelo";
            this.combomodelo.Size = new System.Drawing.Size(169, 21);
            this.combomodelo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(407, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(407, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelprecio.Location = new System.Drawing.Point(406, 298);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(418, 25);
            this.labelprecio.TabIndex = 13;
            this.labelprecio.Text = "El precio del vehiculo solicitado es igual a: ";
            this.labelprecio.Visible = false;
            // 
            // combocolor
            // 
            this.combocolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocolor.FormattingEnabled = true;
            this.combocolor.Location = new System.Drawing.Point(407, 253);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(169, 21);
            this.combocolor.TabIndex = 14;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsalir.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(672, 402);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(150, 56);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnregresar.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnregresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregresar.Location = new System.Drawing.Point(392, 402);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(157, 56);
            this.btnregresar.TabIndex = 16;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            // 
            // btnvender
            // 
            this.btnvender.BackColor = System.Drawing.Color.Red;
            this.btnvender.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnvender.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvender.Location = new System.Drawing.Point(45, 402);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(163, 56);
            this.btnvender.TabIndex = 17;
            this.btnvender.Text = "VENDER";
            this.btnvender.UseVisualStyleBackColor = false;
            // 
            // labelmonto
            // 
            this.labelmonto.AutoSize = true;
            this.labelmonto.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelmonto.ForeColor = System.Drawing.Color.Red;
            this.labelmonto.Location = new System.Drawing.Point(406, 342);
            this.labelmonto.Name = "labelmonto";
            this.labelmonto.Size = new System.Drawing.Size(83, 25);
            this.labelmonto.TabIndex = 18;
            this.labelmonto.Text = "Modelo";
            this.labelmonto.Visible = false;
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnsolicitar.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnsolicitar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsolicitar.Location = new System.Drawing.Point(640, 183);
            this.btnsolicitar.Name = "btnsolicitar";
            this.btnsolicitar.Size = new System.Drawing.Size(161, 91);
            this.btnsolicitar.TabIndex = 20;
            this.btnsolicitar.Text = "Solicitar Vehiculo";
            this.btnsolicitar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(403, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Codigo Cliente";
            // 
            // txbcodcliente
            // 
            this.txbcodcliente.Location = new System.Drawing.Point(411, 113);
            this.txbcodcliente.Name = "txbcodcliente";
            this.txbcodcliente.Size = new System.Drawing.Size(138, 20);
            this.txbcodcliente.TabIndex = 22;
            this.txbcodcliente.Leave += new System.EventHandler(this.txbcodcliente_Leave);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.labelnombre.Location = new System.Drawing.Point(641, 97);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(160, 21);
            this.labelnombre.TabIndex = 23;
            this.labelnombre.Text = "Nombre del cliente";
            this.labelnombre.Visible = false;
            // 
            // NombreClienteL
            // 
            this.NombreClienteL.AutoSize = true;
            this.NombreClienteL.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.NombreClienteL.ForeColor = System.Drawing.Color.Navy;
            this.NombreClienteL.Location = new System.Drawing.Point(641, 137);
            this.NombreClienteL.Name = "NombreClienteL";
            this.NombreClienteL.Size = new System.Drawing.Size(160, 21);
            this.NombreClienteL.TabIndex = 24;
            this.NombreClienteL.Text = "Nombre del cliente";
            this.NombreClienteL.Visible = false;
            // 
            // labelCodVeh
            // 
            this.labelCodVeh.AutoSize = true;
            this.labelCodVeh.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.labelCodVeh.Location = new System.Drawing.Point(106, 328);
            this.labelCodVeh.Name = "labelCodVeh";
            this.labelCodVeh.Size = new System.Drawing.Size(168, 21);
            this.labelCodVeh.TabIndex = 25;
            this.labelCodVeh.Text = "Codigo del Vehiculo";
            this.labelCodVeh.Visible = false;
            // 
            // IdVehiculoL
            // 
            this.IdVehiculoL.AutoSize = true;
            this.IdVehiculoL.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.IdVehiculoL.ForeColor = System.Drawing.Color.Navy;
            this.IdVehiculoL.Location = new System.Drawing.Point(123, 358);
            this.IdVehiculoL.Name = "IdVehiculoL";
            this.IdVehiculoL.Size = new System.Drawing.Size(134, 21);
            this.IdVehiculoL.TabIndex = 26;
            this.IdVehiculoL.Text = "codigo vehiculo";
            this.IdVehiculoL.Visible = false;
            // 
            // FrmBaseModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(924, 485);
            this.Controls.Add(this.IdVehiculoL);
            this.Controls.Add(this.labelCodVeh);
            this.Controls.Add(this.NombreClienteL);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.txbcodcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsolicitar);
            this.Controls.Add(this.labelmonto);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.combocolor);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combomodelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picbox);
            this.Name = "FrmBaseModelo";
            this.Text = "FrmBaseModelo";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnsalir;
        protected System.Windows.Forms.Button btnregresar;
        protected System.Windows.Forms.Button btnvender;
        protected System.Windows.Forms.PictureBox Picbox;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox combomodelo;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label labelprecio;
        protected System.Windows.Forms.ComboBox combocolor;
        protected System.Windows.Forms.Label labelmonto;
        protected System.Windows.Forms.Button btnsolicitar;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label labelnombre;
        protected System.Windows.Forms.Label NombreClienteL;
        protected System.Windows.Forms.TextBox txbcodcliente;
        protected System.Windows.Forms.Label labelCodVeh;
        protected System.Windows.Forms.Label IdVehiculoL;
    }
}