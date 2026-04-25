using ApuntesTodos.BL;
using ApuntesTodos.Entities;

namespace ApuntesTodos
{
    public partial class ApuntesTodos : Form
    {
        public ApuntesTodos()
        {
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        private List<Apuntes> listaApuntes = new List<Apuntes>();

        private void CargarGrid()
        {
            listaApuntes = apuntesBL.Apuntes_ObtenerTodos();
            gridApuntes.DataSource = listaApuntes;
        }
        private void CargarCombos()
        {
            cmbTrabajo.DataSource = new List<String> { "", "Souvenir", "MiniMarket", "Restaurante", "Heladeria" };
        }

        private void ApuntesTodos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombos();
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name != "NombreCompleto" && gridApuntes.Columns[e.ColumnIndex].Name != "Trabajo")
            {
                decimal valor = Convert.ToDecimal(e.Value);
                e.Value = valor.ToString("C", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength >= 3)
            {
                var listaFiltrada = listaApuntes.Where(a => a.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                gridApuntes.DataSource = listaFiltrada;
            }
            else
            {
                gridApuntes.DataSource = listaApuntes;
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text != "")
            {
                var listaFiltrada = listaApuntes.Where(a => a.Trabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                gridApuntes.DataSource = listaFiltrada;
            }
            else
            {
                gridApuntes.DataSource = listaApuntes;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
