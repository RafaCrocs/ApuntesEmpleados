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
            Pagar = new DataGridViewButtonColumn();
            IdApunte = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
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
            txtNombre.Location = new Point(254, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 34);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(62, 128);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(186, 28);
            lblBuscarNombre.TabIndex = 6;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { Pagar, IdApunte, NombreCompleto, Monto, Origen, Detalle, Fecha });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(63, 196);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.Size = new Size(1285, 493);
            gridApuntes.TabIndex = 5;
            gridApuntes.CellContentClick += gridApuntes_CellContentClick;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // Pagar
            // 
            Pagar.HeaderText = "";
            Pagar.Name = "Pagar";
            Pagar.Resizable = DataGridViewTriState.True;
            Pagar.SortMode = DataGridViewColumnSortMode.Automatic;
            Pagar.Text = "Pagar";
            Pagar.UseColumnTextForButtonValue = true;
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
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 300;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.Width = 150;
            // 
            // Origen
            // 
            Origen.DataPropertyName = "Origen";
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.Name = "Detalle";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.Width = 200;
            // 
            // frmApuntes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 791);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Name = "frmApuntes";
            Text = "frmApuntes";
            Load += frmApuntes_Load;
            ((System.ComponentModel.ISupportInitialize)gridApuntes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridApuntes;
        private DataGridViewButtonColumn Pagar;
        private DataGridViewTextBoxColumn IdApunte;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Fecha;
    }
}