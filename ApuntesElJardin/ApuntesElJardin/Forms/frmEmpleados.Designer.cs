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
            btnRegresar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
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
            gridEmpleados.Location = new Point(74, 262);
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
            lblBuscarNombre.Location = new Point(74, 120);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(330, 117);
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
            label1.Location = new Point(74, 182);
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
            cmbTrabajo.Location = new Point(385, 179);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 4;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 12F);
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            btnRegresar.IconColor = Color.Black;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.IconSize = 30;
            btnRegresar.ImageAlign = ContentAlignment.BottomLeft;
            btnRegresar.Location = new Point(31, 25);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(149, 45);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 15F);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.ImageAlign = ContentAlignment.BottomLeft;
            btnNuevo.Location = new Point(896, 212);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 43);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 884);
            Controls.Add(btnNuevo);
            Controls.Add(btnRegresar);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridEmpleados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEmpleados";
            Text = "Colaboradores";
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
        private FontAwesome.Sharp.IconButton btnRegresar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}