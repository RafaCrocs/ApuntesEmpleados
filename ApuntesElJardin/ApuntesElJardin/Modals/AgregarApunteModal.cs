using ApunteEmpleados.Entities;
using ApuntesElJardin.Forms;
using ApuntesEmpleados.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Modals
{
    public partial class AgregarApunteModal : Form
    {
        public AgregarApunteModal()
        {
            InitializeComponent();
        }

        private ApuntesBL apuntesBL = new ApuntesBL();
        public Apunte nuevoApunte = new Apunte();

        private void BorrarCampos()
        {
            txtNombre.Text = string.Empty;
            lblIdEmpleado.Text = "";
            txtMonto.Text = string.Empty;
            txtDetalle.Text = string.Empty;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados modal = new frmEmpleados();
            modal.ShowDialog();
            if (modal.DialogResult == DialogResult.OK)
            {
                if (modal.empleado != null)
                {
                    txtNombre.Text = modal.empleado.NombreCompleto;
                    lblIdEmpleado.Text = "Codigo: " + modal.empleado.IdEmpleado.ToString();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nuevoApunte = new Apunte()
            {
                IdApunte = Convert.ToInt32(lblIdEmpleado.Text.Replace("Codigo: ", "")),
                Origen = "MiniMarket",
                IdEmpleado = Convert.ToInt32(lblIdEmpleado.Text.Replace("Codigo: ", "")),
                Monto = decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto) ? monto : 0,
                Detalle = txtDetalle.Text,
            };

            if (apuntesBL.AgregarApunte(nuevoApunte, out string mensaje))
            {
                MessageBox.Show("Apunte agregado correctamente");
                BorrarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el apunte: " + mensaje);
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtMonto.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal monto);
            txtMonto.Text = monto.ToString("C", new CultureInfo("es-CR"));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
