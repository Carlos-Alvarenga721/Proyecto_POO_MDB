
namespace Proyecto_POO
{
    partial class Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carro));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmarca1
            // 
            this.btnmarca1.Location = new System.Drawing.Point(83, 77);
            this.btnmarca1.Text = "Nissan";
            this.btnmarca1.Click += new System.EventHandler(this.btnmarca1_Click);
            // 
            // btnmarca2
            // 
            this.btnmarca2.Location = new System.Drawing.Point(371, 77);
            this.btnmarca2.Text = "BMW";
            // 
            // btnmarca3
            // 
            this.btnmarca3.Location = new System.Drawing.Point(686, 77);
            this.btnmarca3.Text = "Honda";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(83, 333);
            this.btnregresar.Size = new System.Drawing.Size(293, 43);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(625, 333);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 134);
            this.pictureBox1.Size = new System.Drawing.Size(245, 177);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(328, 134);
            this.pictureBox2.Size = new System.Drawing.Size(250, 177);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(636, 134);
            this.pictureBox3.Size = new System.Drawing.Size(254, 177);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 444);
            this.Name = "Carro";
            this.Text = "Carro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}