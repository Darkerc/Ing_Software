using Ing_Software.Participante.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ing_Software.Participante
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AbrirFormulario(new BuyView());
            //Console.WriteLine(Properties.Settings.Default.Usuario);
        }

        public void AbrirFormulario(Form ventana)
        {
            if (pnViews.Controls.Count > 0)
                pnViews.Controls.RemoveAt(0);

            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;

            pnViews.Controls.Add(ventana);
            pnViews.Tag = ventana;
            ventana.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ModalWarning warning = new ModalWarning();
            warning.ShowDialog();
        }
    }
}