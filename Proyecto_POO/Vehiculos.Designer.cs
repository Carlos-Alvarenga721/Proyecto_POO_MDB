
namespace Proyecto_POO
{
    partial class Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos));
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmoto = new System.Windows.Forms.Button();
            this.btncarro = new System.Windows.Forms.Button();
            this.btncamioneta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Yellow;
            this.btnsalir.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnsalir.Location = new System.Drawing.Point(632, 326);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(141, 54);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmoto
            // 
            this.btnmoto.BackColor = System.Drawing.Color.Yellow;
            this.btnmoto.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btnmoto.Location = new System.Drawing.Point(328, 77);
            this.btnmoto.Name = "btnmoto";
            this.btnmoto.Size = new System.Drawing.Size(197, 50);
            this.btnmoto.TabIndex = 2;
            this.btnmoto.Text = "Motocicleta";
            this.btnmoto.UseVisualStyleBackColor = false;
            this.btnmoto.Click += new System.EventHandler(this.btnmoto_Click);
            // 
            // btncarro
            // 
            this.btncarro.BackColor = System.Drawing.Color.Yellow;
            this.btncarro.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btncarro.Location = new System.Drawing.Point(58, 77);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(140, 50);
            this.btncarro.TabIndex = 3;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = false;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // btncamioneta
            // 
            this.btncamioneta.BackColor = System.Drawing.Color.Yellow;
            this.btncamioneta.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.btncamioneta.Location = new System.Drawing.Point(632, 77);
            this.btncamioneta.Name = "btncamioneta";
            this.btncamioneta.Size = new System.Drawing.Size(174, 49);
            this.btncamioneta.TabIndex = 4;
            this.btncamioneta.Text = "Camioneta";
            this.btncamioneta.UseVisualStyleBackColor = false;
            this.btncamioneta.Click += new System.EventHandler(this.btncamioneta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(218, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione el tipo de vehiculo:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(318, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncamioneta);
            this.Controls.Add(this.btncarro);
            this.Controls.Add(this.btnmoto);
            this.Controls.Add(this.btnsalir);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmoto;
        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Button btncamioneta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}