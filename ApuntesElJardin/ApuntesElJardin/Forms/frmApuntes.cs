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
        private List<VerApuntesMiniMarket> apuntesMiniMarkets;

        public void CargarGrid()
        {
            apuntesMiniMarkets = apuntesBL.ApuntesMiniMarkets();
            gridApuntes.DataSource = apuntesMiniMarkets;
        }

        private void frmApuntes_Load(object sender, EventArgs e)
        {
            CargarGrid();
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
                var filtrados = apuntesMiniMarkets.FindAll(a => a.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridApuntes.DataSource = filtrados;
            }
            else
            {
                gridApuntes.DataSource = apuntesMiniMarkets;
            }
        }

        private void gridApuntes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && gridApuntes.Columns[e.ColumnIndex].Name == "Pagar")
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
    }
}
