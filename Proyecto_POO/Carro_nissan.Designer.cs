
namespace Proyecto_POO
{
    partial class Carro_nissan
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
            this.btnsalir.Size = new System.Drawing.Size(148, 53);
            // 
            // btnregresar
            // 
            this.btnregresar.Size = new System.Drawing.Size(151, 53);
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnvender
            // 
            this.btnvender.Size = new System.Drawing.Size(168, 53);
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(33, 88);
            this.Picbox.Size = new System.Drawing.Size(324, 212);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(652, 51);
            this.label1.Text = "Seleccione el modelo y detalles de su carro:";
            // 
            // labelprecio
            // 
            this.labelprecio.Size = new System.Drawing.Size(388, 25);
            this.labelprecio.Text = "El precio del carro solicitado es igual a: ";
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // Carro_nissan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 489);
            this.Name = "Carro_nissan";
            this.Text = "Carro_nissan";
            this.Load += new System.EventHandler(this.Carro_nissan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}