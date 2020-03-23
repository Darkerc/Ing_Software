namespace Ing_Software.Participante
{
    partial class DatesView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateItem1 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem2 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem3 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem4 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem5 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem6 = new Ing_Software.Participante.Controles.DateItem();
            this.dateItem7 = new Ing_Software.Participante.Controles.DateItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 514);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.dateItem1);
            this.flowLayoutPanel1.Controls.Add(this.dateItem2);
            this.flowLayoutPanel1.Controls.Add(this.dateItem3);
            this.flowLayoutPanel1.Controls.Add(this.dateItem4);
            this.flowLayoutPanel1.Controls.Add(this.dateItem5);
            this.flowLayoutPanel1.Controls.Add(this.dateItem6);
            this.flowLayoutPanel1.Controls.Add(this.dateItem7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 512);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dateItem1
            // 
            this.dateItem1.Location = new System.Drawing.Point(3, 3);
            this.dateItem1.Name = "dateItem1";
            this.dateItem1.Size = new System.Drawing.Size(210, 210);
            this.dateItem1.TabIndex = 0;
            // 
            // dateItem2
            // 
            this.dateItem2.Location = new System.Drawing.Point(219, 3);
            this.dateItem2.Name = "dateItem2";
            this.dateItem2.Size = new System.Drawing.Size(210, 210);
            this.dateItem2.TabIndex = 1;
            // 
            // dateItem3
            // 
            this.dateItem3.Location = new System.Drawing.Point(435, 3);
            this.dateItem3.Name = "dateItem3";
            this.dateItem3.Size = new System.Drawing.Size(210, 210);
            this.dateItem3.TabIndex = 2;
            // 
            // dateItem4
            // 
            this.dateItem4.Location = new System.Drawing.Point(3, 219);
            this.dateItem4.Name = "dateItem4";
            this.dateItem4.Size = new System.Drawing.Size(210, 210);
            this.dateItem4.TabIndex = 3;
            // 
            // dateItem5
            // 
            this.dateItem5.Location = new System.Drawing.Point(219, 219);
            this.dateItem5.Name = "dateItem5";
            this.dateItem5.Size = new System.Drawing.Size(210, 210);
            this.dateItem5.TabIndex = 4;
            // 
            // dateItem6
            // 
            this.dateItem6.Location = new System.Drawing.Point(435, 219);
            this.dateItem6.Name = "dateItem6";
            this.dateItem6.Size = new System.Drawing.Size(210, 210);
            this.dateItem6.TabIndex = 5;
            // 
            // dateItem7
            // 
            this.dateItem7.Location = new System.Drawing.Point(3, 435);
            this.dateItem7.Name = "dateItem7";
            this.dateItem7.Size = new System.Drawing.Size(210, 210);
            this.dateItem7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tus citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ing_Software.Properties.Resources.calendar_line;
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DatesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatesView";
            this.Text = "DatesView";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controles.DateItem dateItem1;
        private Controles.DateItem dateItem2;
        private Controles.DateItem dateItem3;
        private Controles.DateItem dateItem4;
        private Controles.DateItem dateItem5;
        private Controles.DateItem dateItem6;
        private Controles.DateItem dateItem7;
    }
}