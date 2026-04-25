using ApuntesElJardin.Forms;
using ApuntesElJardin.Modals;

namespace ApuntesElJardin
{
    public partial class MiniMarket : Form
    {
        public MiniMarket()
        {
            InitializeComponent();
        }

        private void btnNuevoApunte_Click(object sender, EventArgs e)
        {
            AgregarApunteModal modal = new AgregarApunteModal();
            modal.Show();
        }

        private void btnVerApuntes_Click(object sender, EventArgs e)
        {
            frmApuntes frmApuntes = new frmApuntes();
            frmApuntes.Show();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleadoModal modal = new AgregarEmpleadoModal();
            modal.Show();
        }
    }
}
