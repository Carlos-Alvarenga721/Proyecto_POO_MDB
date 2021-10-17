
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
            // btncomprar
            // 
            this.btncomprar.Size = new System.Drawing.Size(168, 53);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(33, 88);
            this.Picbox.Size = new System.Drawing.Size(324, 212);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // Carro_nissan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 425);
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