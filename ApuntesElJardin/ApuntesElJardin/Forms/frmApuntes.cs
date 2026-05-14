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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        private List<VerApuntesMiniMarket> apuntesMiniMarket;

        public void CargarGrid()
        {
            apuntesMiniMarket = apuntesBL.ApuntesMiniMarket();
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
            gridApuntes.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            gridApuntes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            gridApuntes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void gridApuntes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridApuntes.Columns[e.ColumnIndex].Name == "Monto" && e.Value != null)
            {
                decimal monto = (decimal)e.Value;
                e.Value = monto.ToString("C0", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 3)
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
            if(e.RowIndex < 0) return;
            if (gridApuntes.Columns[e.ColumnIndex].Name == "PagarTodo")
            {
                if(MessageBox.Show("¿Está seguro que desea pagar todo el monto pendiente de este empleado?", "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEmpleado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                    if(apuntesBL.PagarTodo(idEmpleado))
                    {
                        MessageBox.Show("Pago realizado con éxito.", "Pago completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al procesar el pago. Por favor, inténtelo de nuevo o contacte al patron.", "Error de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarGrid();
                }
            }
            else if(gridApuntes.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int idEmpleado = Convert.ToInt32(gridApuntes.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                string nombreCompleto = gridApuntes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                frmDetalles detalles = new frmDetalles(idEmpleado, nombreCompleto);
                detalles.ShowDialog();
                CargarGrid();
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
                var filtrados = apuntesMiniMarket.FindAll(a => a.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0); gridApuntes.DataSource = filtrados;
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
