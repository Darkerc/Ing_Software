namespace Ing_Software.Controles
{
    partial class CarouselProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.producItem1 = new Ing_Software.Controles.ProducItem();
            this.producItem2 = new Ing_Software.Controles.ProducItem();
            this.producItem4 = new Ing_Software.Controles.ProducItem();
            this.producItem3 = new Ing_Software.Controles.ProducItem();
            this.producItem5 = new Ing_Software.Controles.ProducItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cafeteria edificio K";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.producItem1);
            this.flowLayoutPanel1.Controls.Add(this.producItem2);
            this.flowLayoutPanel1.Controls.Add(this.producItem4);
            this.flowLayoutPanel1.Controls.Add(this.producItem3);
            this.flowLayoutPanel1.Controls.Add(this.producItem5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 238);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // producItem1
            // 
            this.producItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producItem1.Location = new System.Drawing.Point(10, 3);
            this.producItem1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.producItem1.Name = "producItem1";
            this.producItem1.Size = new System.Drawing.Size(205, 205);
            this.producItem1.TabIndex = 0;
            // 
            // producItem2
            // 
            this.producItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producItem2.Location = new System.Drawing.Point(235, 3);
            this.producItem2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.producItem2.Name = "producItem2";
            this.producItem2.Size = new System.Drawing.Size(205, 205);
            this.producItem2.TabIndex = 1;
            // 
            // producItem4
            // 
            this.producItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producItem4.Location = new System.Drawing.Point(460, 3);
            this.producItem4.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.producItem4.Name = "producItem4";
            this.producItem4.Size = new System.Drawing.Size(205, 205);
            this.producItem4.TabIndex = 3;
            // 
            // producItem3
            // 
            this.producItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producItem3.Location = new System.Drawing.Point(685, 3);
            this.producItem3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.producItem3.Name = "producItem3";
            this.producItem3.Size = new System.Drawing.Size(205, 205);
            this.producItem3.TabIndex = 2;
            // 
            // producItem5
            // 
            this.producItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.producItem5.Location = new System.Drawing.Point(910, 3);
            this.producItem5.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.producItem5.Name = "producItem5";
            this.producItem5.Size = new System.Drawing.Size(205, 205);
            this.producItem5.TabIndex = 4;
            // 
            // CarouselProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "CarouselProducts";
            this.Size = new System.Drawing.Size(700, 265);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ProducItem producItem1;
        private ProducItem producItem2;
        private ProducItem producItem4;
        private ProducItem producItem3;
        private ProducItem producItem5;
    }
}
