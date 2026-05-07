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
            gridApuntes.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridApuntes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridApuntes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name != "NombreCompleto" && gridApuntes.Columns[e.ColumnIndex].Name != "Trabajo" && gridApuntes.Columns[e.ColumnIndex].Name != "Pagado" && gridApuntes.Columns[e.ColumnIndex].Name != "Detalles")
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

        private void gridApuntes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                return;
            }
            if (gridApuntes.Columns[e.ColumnIndex].Name == "Pagado")
            {
                int idSelecionado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                if (apuntesBL.Eliminar_Apuntes_Empleado(idSelecionado))
                {
                    MessageBox.Show("Apuntes eliminados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Algo malio sal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnPagarTodos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere pagar todos los apuntes existentes?", "Pagar Todos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(apuntesBL.Pagar_Todos())
                {
                    MessageBox.Show("Apuntes eliminados correctamente", "Apuntes Pagados", MessageBoxButtons.OK);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("No se pudieron eliminar los apuntes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
