namespace ProyectoBBDD.Controles
{
    partial class BarraDeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarraDeControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconoBarraPrincipal = new System.Windows.Forms.PictureBox();
            this.lbCabecera = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoBarraPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.iconoBarraPrincipal);
            this.panel1.Controls.Add(this.lbCabecera);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 35);
            this.panel1.TabIndex = 2;
            // 
            // iconoBarraPrincipal
            // 
            this.iconoBarraPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.iconoBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconoBarraPrincipal.Image = global::Ing_Software.Properties.Resources.store_local_shop_building_512;
            this.iconoBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.iconoBarraPrincipal.Name = "iconoBarraPrincipal";
            this.iconoBarraPrincipal.Size = new System.Drawing.Size(30, 35);
            this.iconoBarraPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoBarraPrincipal.TabIndex = 3;
            this.iconoBarraPrincipal.TabStop = false;
            // 
            // lbCabecera
            // 
            this.lbCabecera.BackColor = System.Drawing.Color.Transparent;
            this.lbCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCabecera.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecera.ForeColor = System.Drawing.Color.Black;
            this.lbCabecera.Location = new System.Drawing.Point(0, 0);
            this.lbCabecera.Name = "lbCabecera";
            this.lbCabecera.Size = new System.Drawing.Size(688, 35);
            this.lbCabecera.TabIndex = 4;
            this.lbCabecera.Text = "Texto de ejemplo\r\n";
            this.lbCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCabecera_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(688, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(5);
            this.btnMinimizar.Size = new System.Drawing.Size(51, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(739, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(51, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BarraDeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "BarraDeControl";
            this.Size = new System.Drawing.Size(790, 35);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoBarraPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconoBarraPrincipal;
        private System.Windows.Forms.Label lbCabecera;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}
