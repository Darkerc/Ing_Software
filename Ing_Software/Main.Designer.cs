﻿namespace Ing_Software
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnVentanas = new System.Windows.Forms.Panel();
            this.barraDeControl1 = new ProyectoBBDD.Controles.BarraDeControl();
            this.SuspendLayout();
            // 
            // pnVentanas
            // 
            this.pnVentanas.Location = new System.Drawing.Point(0, 35);
            this.pnVentanas.Name = "pnVentanas";
            this.pnVentanas.Size = new System.Drawing.Size(900, 616);
            this.pnVentanas.TabIndex = 0;
            // 
            // barraDeControl1
            // 
            this.barraDeControl1.AutoSize = true;
            this.barraDeControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraDeControl1.Location = new System.Drawing.Point(0, 0);
            this.barraDeControl1.Margin = new System.Windows.Forms.Padding(0);
            this.barraDeControl1.Name = "barraDeControl1";
            this.barraDeControl1.Size = new System.Drawing.Size(900, 35);
            this.barraDeControl1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.barraDeControl1);
            this.Controls.Add(this.pnVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnVentanas;
        private ProyectoBBDD.Controles.BarraDeControl barraDeControl1;
    }
}

