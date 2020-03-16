using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoBBDD.Controles
{
    public partial class BarraDeControl : UserControl
    {
        public BarraDeControl()
        {
            InitializeComponent();
        }

        //Movimiento de la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr a, int b, int c, int d);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void labelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.ParentForm.Handle, 0x112, 0xf012, 0);
        }
    }
}