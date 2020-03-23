namespace Ing_Software.Participante
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCalorias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnViews = new System.Windows.Forms.Panel();
            this.bcPrincipal = new Ing_Software.Controles.AsideBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ing_Software.Properties.Resources._107831;
            this.pictureBox1.Location = new System.Drawing.Point(662, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lbCalorias
            // 
            this.lbCalorias.AutoSize = true;
            this.lbCalorias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalorias.Location = new System.Drawing.Point(3, 9);
            this.lbCalorias.Name = "lbCalorias";
            this.lbCalorias.Size = new System.Drawing.Size(148, 22);
            this.lbCalorias.TabIndex = 10;
            this.lbCalorias.Text = "Tus calorias : 80";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCalorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 45);
            this.panel1.TabIndex = 12;
            // 
            // pnViews
            // 
            this.pnViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnViews.Location = new System.Drawing.Point(300, 45);
            this.pnViews.Name = "pnViews";
            this.pnViews.Size = new System.Drawing.Size(700, 625);
            this.pnViews.TabIndex = 13;
            // 
            // bcPrincipal
            // 
            this.bcPrincipal.BackColor = System.Drawing.SystemColors.Desktop;
            this.bcPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.bcPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.bcPrincipal.Name = "bcPrincipal";
            this.bcPrincipal.Size = new System.Drawing.Size(300, 670);
            this.bcPrincipal.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnViews);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Ing_Software.Controles.AsideBar bcPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCalorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnViews;
    }
}