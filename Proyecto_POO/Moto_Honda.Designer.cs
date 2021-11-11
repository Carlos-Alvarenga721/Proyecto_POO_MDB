
namespace Proyecto_POO
{
    partial class Moto_Honda
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
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(669, 442);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(411, 432);
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(79, 454);
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(26, 88);
            this.Picbox.Size = new System.Drawing.Size(326, 236);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(741, 51);
            this.label1.Text = "Seleccione el modelo y detalles de su motocicleta:";
            // 
            // labelprecio
            // 
            this.labelprecio.Size = new System.Drawing.Size(464, 25);
            this.labelprecio.Text = "El precio de la motocicleta solicitada es igual a: ";
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // labelCodVeh
            // 
            this.labelCodVeh.Location = new System.Drawing.Point(96, 361);
            // 
            // IdVehiculoL
            // 
            this.IdVehiculoL.Location = new System.Drawing.Point(113, 392);
            // 
            // Moto_Honda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 547);
            this.Name = "Moto_Honda";
            this.Text = "Moto_Honda";
            this.Load += new System.EventHandler(this.Moto_Honda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}