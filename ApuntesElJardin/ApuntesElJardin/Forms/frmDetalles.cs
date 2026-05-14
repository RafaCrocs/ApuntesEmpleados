using ApuntesEmpleados.BL;
using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Forms
{
    public partial class frmDetalles : Form
    {
        private int idEmpleado;
        private string nombreCompleto;

        public frmDetalles(int IdEmpleado, string NombreCompleto)
        {
            InitializeComponent();
            idEmpleado = IdEmpleado;
            nombreCompleto = NombreCompleto;
        }

        private DetallesBL detallesBL = new DetallesBL();
        private List<DetallesRestaurante> listaDetalles = new List<DetallesRestaurante>();

        private void CargarGrid()
        {
            listaDetalles = detallesBL.ObtenerDetallesRestaurante(idEmpleado);
            gridDetalles.DataSource = listaDetalles;
        }
        private void frmDetalles_Load(object sender, EventArgs e)
        {
            CargarGrid();
            gridDetalles.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridDetalles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            lblNombre.Text = nombreCompleto;
        }

        private void gridDetalles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridDetalles.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                decimal monto = (decimal)e.Value;
                e.Value = monto.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void gridDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || gridDetalles.Columns[e.ColumnIndex].Name != "Pagar")
            {
                return;
            }
            int idApunte = Convert.ToInt32(gridDetalles.Rows[e.RowIndex].Cells["IdApunte"].Value);
            if (MessageBox.Show("¿Está seguro que desea pagar este apunte?\n" + gridDetalles.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString() + "\nMonto: " + Convert.ToDecimal(gridDetalles.Rows[e.RowIndex].Cells["Monto"].Value).ToString("C0", new System.Globalization.CultureInfo("es-CR")), "Confirmar Pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (detallesBL.PagarApunte(idApunte))
                {
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Error al pagar el apunte");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
