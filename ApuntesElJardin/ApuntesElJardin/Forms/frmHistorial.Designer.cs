namespace ApuntesElJardin.Forms
{
    partial class frmHistorial
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
            gridHistorial = new DataGridView();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            IdPago = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            SePagoEn = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridHistorial).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 20F);
            txtNombre.Location = new Point(362, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 43);
            txtNombre.TabIndex = 20;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 20F);
            lblBuscarNombre.Location = new Point(90, 39);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(252, 37);
            lblBuscarNombre.TabIndex = 19;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // gridHistorial
            // 
            gridHistorial.BackgroundColor = SystemColors.Control;
            gridHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHistorial.Columns.AddRange(new DataGridViewColumn[] { IdPago, NombreCompleto, Monto, Detalle, SePagoEn, Fecha });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            gridHistorial.Location = new Point(93, 182);
            gridHistorial.Name = "gridHistorial";
            gridHistorial.RowHeadersWidth = 51;
            gridHistorial.Size = new Size(1285, 589);
            gridHistorial.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(93, 112);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 21;
            label1.Text = "Buscar por Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 20F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(362, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 43);
            dateTimePicker1.TabIndex = 22;
            // 
            // IdPago
            // 
            IdPago.DataPropertyName = "IdPago";
            IdPago.HeaderText = "IdApunte";
            IdPago.MinimumWidth = 6;
            IdPago.Name = "IdPago";
            IdPago.Visible = false;
            IdPago.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 300;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 150;
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            // 
            // SePagoEn
            // 
            SePagoEn.DataPropertyName = "SePagoEn";
            SePagoEn.HeaderText = "Se Pago En:";
            SePagoEn.Name = "SePagoEn";
            SePagoEn.Width = 150;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 200;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 811);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridHistorial);
            Name = "frmHistorial";
            Text = "frmHistorial";
            Load += frmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)gridHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridView gridHistorial;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn SePagoEn;
        private DataGridViewTextBoxColumn Fecha;
    }
}