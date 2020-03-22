namespace Ing_Software.Controles
{
    partial class ProducItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCalorias = new System.Windows.Forms.Label();
            this.lbCosto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCalorias
            // 
            this.lbCalorias.AutoSize = true;
            this.lbCalorias.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalorias.Location = new System.Drawing.Point(56, 141);
            this.lbCalorias.Name = "lbCalorias";
            this.lbCalorias.Size = new System.Drawing.Size(99, 23);
            this.lbCalorias.TabIndex = 1;
            this.lbCalorias.Text = "Calorias: 20";
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbCosto.Location = new System.Drawing.Point(56, 164);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(101, 23);
            this.lbCosto.TabIndex = 2;
            this.lbCosto.Text = "Coste: 200$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ing_Software.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProducItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.lbCalorias);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name = "ProducItem";
            this.Size = new System.Drawing.Size(205, 205);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCalorias;
        private System.Windows.Forms.Label lbCosto;
    }
}
