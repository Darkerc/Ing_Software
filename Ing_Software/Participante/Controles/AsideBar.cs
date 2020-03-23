using Ing_Software.Participante;
using Ing_Software.Participante.Controles;
using System;
using System.Windows.Forms;

namespace Ing_Software.Controles
{
    public partial class AsideBar : UserControl
    {
        private Participante.Main parentForm;

        public AsideBar()
        {
            InitializeComponent();
        }

        public void setParentForm(Participante.Main parentForm)
        {
            this.parentForm = parentForm;
        }

        private void lbMenuDiario_Click(object sender, EventArgs e)
        {
            this.parentForm.AbrirFormulario(new MenuView());
        }

        private void lbControl_Click(object sender, EventArgs e)
        {
            this.parentForm.AbrirFormulario(new ControlView());
        }

        private void lbCalorias_Click(object sender, EventArgs e)
        {
            this.parentForm.AbrirFormulario(new BuyView());
        }

        private void lbCitas_Click(object sender, EventArgs e)
        {
            this.parentForm.AbrirFormulario(new DatesView());
        }
    }
}