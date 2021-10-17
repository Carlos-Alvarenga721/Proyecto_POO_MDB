
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
            this.btncomprar = new System.Windows.Forms.Button();
            this.labelmonto = new System.Windows.Forms.Label();
            this.btnsolicitar = new System.Windows.Forms.Button();
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
            this.combomodelo.Location = new System.Drawing.Point(411, 110);
            this.combomodelo.Name = "combomodelo";
            this.combomodelo.Size = new System.Drawing.Size(169, 21);
            this.combomodelo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(411, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(411, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelprecio.Location = new System.Drawing.Point(375, 227);
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
            this.combocolor.Location = new System.Drawing.Point(411, 180);
            this.combocolor.Name = "combocolor";
            this.combocolor.Size = new System.Drawing.Size(169, 21);
            this.combocolor.TabIndex = 14;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsalir.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(608, 315);
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
            this.btnregresar.Location = new System.Drawing.Point(380, 315);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(157, 56);
            this.btnregresar.TabIndex = 16;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = false;
            // 
            // btncomprar
            // 
            this.btncomprar.BackColor = System.Drawing.Color.Red;
            this.btncomprar.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btncomprar.ForeColor = System.Drawing.SystemColors.Control;
            this.btncomprar.Location = new System.Drawing.Point(106, 315);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(163, 56);
            this.btncomprar.TabIndex = 17;
            this.btncomprar.Text = "COMPRAR";
            this.btncomprar.UseVisualStyleBackColor = false;
            // 
            // labelmonto
            // 
            this.labelmonto.AutoSize = true;
            this.labelmonto.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelmonto.ForeColor = System.Drawing.Color.Red;
            this.labelmonto.Location = new System.Drawing.Point(410, 262);
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
            this.btnsolicitar.Location = new System.Drawing.Point(615, 110);
            this.btnsolicitar.Name = "btnsolicitar";
            this.btnsolicitar.Size = new System.Drawing.Size(161, 91);
            this.btnsolicitar.TabIndex = 20;
            this.btnsolicitar.Text = "Solicitar Vehiculo";
            this.btnsolicitar.UseVisualStyleBackColor = false;
            // 
            // FrmBaseModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(814, 429);
            this.Controls.Add(this.btnsolicitar);
            this.Controls.Add(this.labelmonto);
            this.Controls.Add(this.btncomprar);
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
        protected System.Windows.Forms.Button btncomprar;
        protected System.Windows.Forms.PictureBox Picbox;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox combomodelo;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label labelprecio;
        protected System.Windows.Forms.ComboBox combocolor;
        protected System.Windows.Forms.Label labelmonto;
        protected System.Windows.Forms.Button btnsolicitar;
    }
}