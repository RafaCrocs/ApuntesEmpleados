namespace ApuntesTodos
{
    partial class frmDetalles
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
            gridDetalles = new DataGridView();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            lblNombre = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // gridDetalles
            // 
            gridDetalles.BackgroundColor = SystemColors.Control;
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Columns.AddRange(new DataGridViewColumn[] { IdApunte, NombreCompleto, Origen, Monto, Detalle, Fecha });
            gridDetalles.Font = new Font("Segoe UI", 14F);
            gridDetalles.Location = new Point(125, 216);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.Size = new Size(1155, 536);
            gridDetalles.TabIndex = 0;
            gridDetalles.CellFormatting += gridDetalles_CellFormatting;
            // 
            // IdApunte
            // 
            IdApunte.DataPropertyName = "IdApunte";
            IdApunte.HeaderText = "IdApunte";
            IdApunte.Name = "IdApunte";
            IdApunte.Visible = false;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.Name = "NombreCompleto";
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.Width = 200;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Detalle
            // 
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            Detalle.Width = 300;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(207, 161);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(186, 36);
            cmbTrabajo.TabIndex = 10;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(125, 164);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 9;
            label1.Text = "Origen:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaption;
            lblNombre.Font = new Font("Segoe UI", 20F);
            lblNombre.Location = new Point(65, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 37);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Detalles de ";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1401, 444);
            label2.TabIndex = 12;
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 797);
            Controls.Add(lblNombre);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(gridDetalles);
            Controls.Add(label2);
            Name = "frmDetalles";
            Text = "frmDetalles";
            Load += frmDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)gridDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridDetalles;
        private ComboBox cmbTrabajo;
        private Label label1;
        private DataGridViewTextBoxColumn IdApunte;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Fecha;
        private Label lblNombre;
        private Label label2;
    }
}