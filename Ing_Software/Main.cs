using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ing_Software
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Properties.Settings.Default.Usuario = "Eder R.C";
            Properties.Settings.Default.Save();
            AbrirFormulario(new Participante.Main());
        }

        public void AbrirFormulario(Form ventana)
        {
            if (pnVentanas.Controls.Count > 0)
                pnVentanas.Controls.RemoveAt(0);

            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;

            pnVentanas.Controls.Add(ventana);
            pnVentanas.Tag = ventana;
            ventana.Show();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(52, 235, 164),
                                                                       Color.FromArgb(52, 203, 237),
                                                                       0F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
            catch
            {
            }
        }
    }
}