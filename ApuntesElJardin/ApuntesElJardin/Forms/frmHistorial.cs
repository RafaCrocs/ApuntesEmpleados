using ApuntesEmpleados.BL;
using ApuntesEmpleados.DAL.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Forms
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private HistorialBL historialBL = new HistorialBL();
        private List<Historial> listaHistorial;

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            CagarGrid();
        }

        private void CagarGrid()
        {
            listaHistorial = historialBL.Historial_ObtenerTodos();
            gridHistorial.DataSource = null;
            gridHistorial.DataSource = listaHistorial;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 3)
            {
                var filtrados = listaHistorial.FindAll(a => a.NombreCompleto.IndexOf(txtNombre.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridHistorial.DataSource = filtrados;
            }
            else
            {
                gridHistorial.DataSource = listaHistorial;
            }
        }
    }
}
