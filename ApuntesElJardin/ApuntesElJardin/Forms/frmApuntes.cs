using ApunteEmpleados.Entities;
using ApuntesEmpleados.BL;
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
    public partial class frmApuntes : Form
    {
        public frmApuntes()
        {
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        private List<VerApuntesMiniMarket> apuntesMiniMarket;

        public void CargarGrid()
        {
            apuntesMiniMarket = apuntesBL.ApuntesMiniMarkets();
            gridApuntes.DataSource = apuntesMiniMarket;
        }

        private void CargarCombos()
        {
            cmbTrabajo.DataSource = new List<String> { "", "Souvenir", "Minimarket", "Restaurante" };
        }
        private void frmApuntes_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombos();
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                decimal monto = (decimal)e.Value;
                e.Value = monto.ToString("C2", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                var filtrados = apuntesMiniMarket.FindAll(a => a.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridApuntes.DataSource = filtrados;
            }
            else
            {
                gridApuntes.DataSource = apuntesMiniMarket;
            }
        }

        private void gridApuntes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridApuntes.Columns[e.ColumnIndex].Name == "Pagar")
            {
                int idApunte = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdApunte"].Value);
                if (MessageBox.Show("¿Está seguro que desea pagar este apunte?\n" + gridApuntes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString() + "\nMonto: " + Convert.ToDecimal(gridApuntes.Rows[e.RowIndex].Cells["Monto"].Value).ToString("C2", new System.Globalization.CultureInfo("es-CR")), "Confirmar Pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (apuntesBL.PagarApunte(idApunte))
                    {
                        MessageBox.Show("Apunte pagado correctamente");
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error al pagar el apunte");
                    }
                }
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text == "")
            {
                gridApuntes.DataSource = apuntesMiniMarket;
                return;
            }
            else
            {
                var empleadosFiltro = apuntesMiniMarket.Where(x => x.Trabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                gridApuntes.DataSource = empleadosFiltro;
            }
        }
    }
}
