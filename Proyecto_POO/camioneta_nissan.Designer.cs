
namespace Proyecto_POO
{
    partial class camioneta_nissan
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
            this.btnsalir.Location = new System.Drawing.Point(677, 413);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(439, 413);
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(117, 415);
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(30, 88);
            this.Picbox.Size = new System.Drawing.Size(341, 235);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Size = new System.Drawing.Size(724, 51);
            this.label1.Text = "Seleccione el modelo y detalles de su camioneta:";
            // 
            // combomodelo
            // 
            this.combomodelo.Size = new System.Drawing.Size(209, 21);
            // 
            // labelprecio
            // 
            this.labelprecio.Size = new System.Drawing.Size(452, 25);
            this.labelprecio.Text = "El precio de la camioneta solicitada es igual a: ";
            // 
            // combocolor
            // 
            this.combocolor.Size = new System.Drawing.Size(209, 21);
            // 
            // labelmonto
            // 
            this.labelmonto.Location = new System.Drawing.Point(406, 338);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(645, 183);
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // labelCodVeh
            // 
            this.labelCodVeh.Location = new System.Drawing.Point(112, 342);
            // 
            // IdVehiculoL
            // 
            this.IdVehiculoL.Location = new System.Drawing.Point(137, 376);
            // 
            // camioneta_nissan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 509);
            this.Name = "camioneta_nissan";
            this.Text = "camioneta_nissan";
            this.Load += new System.EventHandler(this.camioneta_nissan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}