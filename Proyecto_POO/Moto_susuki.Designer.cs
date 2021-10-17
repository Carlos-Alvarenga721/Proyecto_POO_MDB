
namespace Proyecto_POO
{
    partial class Moto_susuki
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
            // btnsolicitar
            // 
            this.btnsolicitar.Location = new System.Drawing.Point(623, 110);
            this.btnsolicitar.Click += new System.EventHandler(this.btnsolicitar_Click);
            // 
            // Moto_susuki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 417);
            this.Name = "Moto_susuki";
            this.Text = "Moto_susuki";
            this.Load += new System.EventHandler(this.Moto_susuki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}