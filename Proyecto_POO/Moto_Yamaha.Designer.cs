
namespace Proyecto_POO
{
    partial class Moto_Yamaha
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
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnvender
            // 
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(741, 51);
            this.label1.Text = "Seleccione el modelo y detalles de su motocicleta:";
            // 
            // combomodelo
            // 
            this.combomodelo.Size = new System.Drawing.Size(203, 21);
            // 
            // labelprecio
            // 
            this.labelprecio.Size = new System.Drawing.Size(464, 25);
            this.labelprecio.Text = "El precio de la motocicleta solicitada es igual a: ";
            // 
            // combocolor
            // 
            this.combocolor.Size = new System.Drawing.Size(203, 21);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(661, 183);
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.Location = new System.Drawing.Point(662, 109);
            // 
            // NombreClienteL
            // 
            this.NombreClienteL.Location = new System.Drawing.Point(662, 149);
            // 
            // Moto_Yamaha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Name = "Moto_Yamaha";
            this.Text = "Moto_Yamaha";
            this.Load += new System.EventHandler(this.Moto_Yamaha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}