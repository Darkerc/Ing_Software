namespace Ing_Software.Participante.Controles
{
    partial class MenuView
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
            this.carouselProducts2 = new Ing_Software.Controles.CarouselProducts();
            this.carouselProducts1 = new Ing_Software.Controles.CarouselProducts();
            this.SuspendLayout();
            // 
            // carouselProducts2
            // 
            this.carouselProducts2.Location = new System.Drawing.Point(12, 322);
            this.carouselProducts2.Name = "carouselProducts2";
            this.carouselProducts2.Size = new System.Drawing.Size(676, 257);
            this.carouselProducts2.TabIndex = 8;
            // 
            // carouselProducts1
            // 
            this.carouselProducts1.Location = new System.Drawing.Point(12, 34);
            this.carouselProducts1.Name = "carouselProducts1";
            this.carouselProducts1.Size = new System.Drawing.Size(676, 257);
            this.carouselProducts1.TabIndex = 7;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 625);
            this.Controls.Add(this.carouselProducts2);
            this.Controls.Add(this.carouselProducts1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private Ing_Software.Controles.CarouselProducts carouselProducts2;
        private Ing_Software.Controles.CarouselProducts carouselProducts1;
    }
}