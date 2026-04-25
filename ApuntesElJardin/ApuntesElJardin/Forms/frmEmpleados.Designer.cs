namespace ApuntesElJardin.Forms
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridEmpleados = new DataGridView();
            Seleccionar = new DataGridViewButtonColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Trabajo = new DataGridViewTextBoxColumn();
            lblBuscarNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cmbTrabajo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gridEmpleados
            // 
            gridEmpleados.BackgroundColor = SystemColors.Control;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.Columns.AddRange(new DataGridViewColumn[] { Seleccionar, IdEmpleado, NombreCompleto, Trabajo });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            gridEmpleados.Location = new Point(42, 172);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.Size = new Size(827, 395);
            gridEmpleados.TabIndex = 0;
            gridEmpleados.CellContentDoubleClick += gridEmpleados_CellContentDoubleClick;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "";
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Width = 35;
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Visible = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.Name = "NombreCompleto";
            // 
            // Trabajo
            // 
            Trabajo.DataPropertyName = "Trabajo";
            Trabajo.HeaderText = "Puesto";
            Trabajo.Name = "Trabajo";
            Trabajo.Width = 200;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(42, 65);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(186, 28);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(234, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 34);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(42, 112);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 3;
            label1.Text = "Buscar por donde Trabaja:";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(282, 112);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(186, 36);
            cmbTrabajo.TabIndex = 4;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 663);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridEmpleados);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridEmpleados;
        private DataGridViewButtonColumn Seleccionar;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Trabajo;
        private Label lblBuscarNombre;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cmbTrabajo;
    }
}