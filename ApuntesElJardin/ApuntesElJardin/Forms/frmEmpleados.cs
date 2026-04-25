using ApunteEmpleados.Entities;
using ApuntesEmpleados.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApuntesElJardin.Forms
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
        public Empleado empleado;

        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Empleado> empleados = new List<Empleado>();

        private void CargarGrid()
        {
            empleados = empleadosBL.Empleados_ObtenerTodos();
            gridEmpleados.DataSource = null;
            gridEmpleados.DataSource = empleados;
        }

        //private void ConfigurarColumnas()
        //{
        //    gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        Name = "IdEmpleado",
        //        HeaderText = "ID Empleado",
        //        DataPropertyName = "IdEmpleado",
        //        Visible = false
        //    });
        //    gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        Name = "NombreCompleto",
        //        HeaderText = "Nombre Completo",
        //        DataPropertyName = "NombreCompleto",
        //        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        //    });
        //    gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        Name = "Trabajo",
        //        HeaderText = "Trabajo",
        //        DataPropertyName = "Trabajo"
        //    });
        //}

        private void CargarCombo()
        {
            cmbTrabajo.DataSource = new List<String> { "", "Souvenir", "Minimarket", "Restaurante" };
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            //ConfigurarColumnas();
            CargarGrid();
            CargarCombo();
        }

        private void gridEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int idEmpleado = (int)gridEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value;
            string nombreEmpleado = (string)gridEmpleados.Rows[e.RowIndex].Cells["NombreCompleto"].Value;
            empleado = new Empleado()
            {
                IdEmpleado = idEmpleado,
                NombreCompleto = nombreEmpleado
            };
            this.DialogResult = DialogResult.OK;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength >= 3)
            {
                var empleadosFiltro = empleados.Where(x => x.NombreCompleto.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                gridEmpleados.DataSource = empleadosFiltro;
            }
            else
            {
                gridEmpleados.DataSource = empleados;
            }
        }

        private void cmbTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajo.Text == "")
            {
                gridEmpleados.DataSource = empleados;
                return;
            }
            else
            {
                var empleadosFiltro = empleados.Where(x => x.Trabajo.ToLower().Contains(cmbTrabajo.Text.ToLower())).ToList();
                gridEmpleados.DataSource = empleadosFiltro;
            }
        }
    }
}
