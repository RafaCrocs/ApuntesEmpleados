namespace ApuntesElJardin.Forms
{
    partial class frmApuntes
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
            txtNombre = new TextBox();
            lblBuscarNombre = new Label();
            gridApuntes = new DataGridView();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            Pagar = new DataGridViewButtonColumn();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Trabajo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridApuntes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(313, 116);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 41);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(68, 116);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 6;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { Pagar, IdApunte, NombreCompleto, Trabajo, Monto, Origen, Detalle, Fecha });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(72, 261);
            gridApuntes.Margin = new Padding(3, 4, 3, 4);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.RowHeadersWidth = 51;
            gridApuntes.Size = new Size(1469, 657);
            gridApuntes.TabIndex = 5;
            gridApuntes.CellContentClick += gridApuntes_CellContentClick;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(383, 191);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 9;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(72, 194);
            label1.Name = "label1";
            label1.Size = new Size(305, 35);
            label1.TabIndex = 8;
            label1.Text = "Buscar por donde Trabaja:";
            // 
            // Pagar
            // 
            Pagar.HeaderText = "";
            Pagar.MinimumWidth = 6;
            Pagar.Name = "Pagar";
            Pagar.Resizable = DataGridViewTriState.True;
            Pagar.SortMode = DataGridViewColumnSortMode.Automatic;
            Pagar.Text = "Pagar";
            Pagar.UseColumnTextForButtonValue = true;
            Pagar.Width = 125;
            // 
            // IdApunte
            // 
            IdApunte.DataPropertyName = "IdApunte";
            IdApunte.HeaderText = "IdApunte";
            IdApunte.MinimumWidth = 6;
            IdApunte.Name = "IdApunte";
            IdApunte.Visible = false;
            IdApunte.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 300;
            // 
            // Trabajo
            // 
            Trabajo.DataPropertyName = "Trabajo";
            Trabajo.HeaderText = "Trabajo";
            Trabajo.MinimumWidth = 6;
            Trabajo.Name = "Trabajo";
            Trabajo.Visible = false;
            Trabajo.Width = 125;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 150;
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 6;
            Origen.Name = "Origen";
            Origen.Width = 125;
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 200;
            // 
            // frmApuntes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 1055);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmApuntes";
            Text = "frmApuntes";
            WindowState = FormWindowState.Maximized;
            Load += frmApuntes_Load;
            ((System.ComponentModel.ISupportInitialize)gridApuntes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridApuntes;
        private ComboBox cmbTrabajo;
        private Label label1;
        private DataGridViewButtonColumn Pagar;
        private DataGridViewTextBoxColumn IdApunte;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Trabajo;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Fecha;
    }
}