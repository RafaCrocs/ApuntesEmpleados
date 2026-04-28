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
            lblBuscarNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cmbTrabajo = new ComboBox();
            btnNuevoEmpleado = new Button();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gridEmpleados
            // 
            gridEmpleados.BackgroundColor = SystemColors.Control;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            gridEmpleados.Location = new Point(48, 229);
            gridEmpleados.Margin = new Padding(3, 4, 3, 4);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.RowHeadersWidth = 51;
            gridEmpleados.Size = new Size(945, 527);
            gridEmpleados.TabIndex = 0;
            gridEmpleados.CellContentDoubleClick += gridEmpleados_CellContentDoubleClick;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(48, 87);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(304, 84);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 41);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(48, 149);
            label1.Name = "label1";
            label1.Size = new Size(305, 35);
            label1.TabIndex = 3;
            label1.Text = "Buscar por donde Trabaja:";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(359, 146);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 4;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.Font = new Font("Segoe UI", 10F);
            btnNuevoEmpleado.Location = new Point(848, 180);
            btnNuevoEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(145, 41);
            btnNuevoEmpleado.TabIndex = 5;
            btnNuevoEmpleado.Text = "Nuevo Empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = true;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 884);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            WindowState = FormWindowState.Maximized;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridEmpleados;
        private Label lblBuscarNombre;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox cmbTrabajo;
        private Button btnNuevoEmpleado;
    }
}