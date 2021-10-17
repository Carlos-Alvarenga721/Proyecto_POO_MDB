
namespace Proyecto_POO
{
    partial class Camioneta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camioneta));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmarca1
            // 
            this.btnmarca1.Location = new System.Drawing.Point(74, 87);
            this.btnmarca1.Text = "Nissan";
            // 
            // btnmarca2
            // 
            this.btnmarca2.Location = new System.Drawing.Point(377, 87);
            this.btnmarca2.Text = "Ford";
            this.btnmarca2.Click += new System.EventHandler(this.btnmarca2_Click);
            // 
            // btnmarca3
            // 
            this.btnmarca3.Location = new System.Drawing.Point(684, 87);
            this.btnmarca3.Text = "Chevrolet";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(74, 345);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(625, 345);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 148);
            this.pictureBox1.Size = new System.Drawing.Size(254, 174);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 148);
            this.pictureBox2.Size = new System.Drawing.Size(256, 174);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(651, 148);
            this.pictureBox3.Size = new System.Drawing.Size(243, 174);
            // 
            // Camioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 429);
            this.Name = "Camioneta";
            this.Text = "Camioneta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}