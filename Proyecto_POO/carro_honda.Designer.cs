
namespace Proyecto_POO
{
    partial class carro_honda
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
            this.btnsalir.Location = new System.Drawing.Point(700, 409);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(419, 418);
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(82, 430);
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(22, 88);
            this.Picbox.Size = new System.Drawing.Size(330, 244);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(652, 51);
            this.label1.Text = "Seleccione el modelo y detalles de su carro:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(407, 226);
            // 
            // labelprecio
            // 
            this.labelprecio.Location = new System.Drawing.Point(406, 307);
            this.labelprecio.Size = new System.Drawing.Size(388, 25);
            this.labelprecio.Text = "El precio del carro solicitado es igual a: ";
            // 
            // combocolor
            // 
            this.combocolor.Location = new System.Drawing.Point(407, 259);
            // 
            // labelmonto
            // 
            this.labelmonto.Location = new System.Drawing.Point(412, 343);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(640, 187);
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // labelCodVeh
            // 
            this.labelCodVeh.Location = new System.Drawing.Point(93, 356);
            // 
            // IdVehiculoL
            // 
            this.IdVehiculoL.Location = new System.Drawing.Point(109, 388);
            // 
            // carro_honda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Name = "carro_honda";
            this.Text = "carro_honda";
            this.Load += new System.EventHandler(this.carro_honda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}