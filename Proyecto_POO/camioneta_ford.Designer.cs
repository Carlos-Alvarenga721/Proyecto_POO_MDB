
namespace Proyecto_POO
{
    partial class camioneta_ford
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
            this.btnsalir.Location = new System.Drawing.Point(613, 337);
            this.btnsalir.Size = new System.Drawing.Size(145, 54);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(380, 337);
            this.btnregresar.Size = new System.Drawing.Size(153, 54);
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btncomprar
            // 
            this.btncomprar.Location = new System.Drawing.Point(106, 337);
            this.btncomprar.Size = new System.Drawing.Size(168, 56);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(33, 88);
            this.Picbox.Size = new System.Drawing.Size(320, 221);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // camioneta_ford
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "camioneta_ford";
            this.Text = "camioneta_ford";
            this.Load += new System.EventHandler(this.camioneta_ford_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}