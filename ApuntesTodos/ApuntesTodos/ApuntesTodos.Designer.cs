namespace ApuntesTodos
{
    partial class ApuntesTodos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridApuntes = new DataGridView();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Trabajo = new DataGridViewTextBoxColumn();
            MiniMarket = new DataGridViewTextBoxColumn();
            Souvenir = new DataGridViewTextBoxColumn();
            Restaurante = new DataGridViewTextBoxColumn();
            Heladeria = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            cmbTrabajo = new ComboBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lblBuscarNombre = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridApuntes).BeginInit();
            SuspendLayout();
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { NombreCompleto, Trabajo, MiniMarket, Souvenir, Restaurante, Heladeria, Total });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(70, 166);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.Size = new Size(1128, 423);
            gridApuntes.TabIndex = 0;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.Name = "NombreCompleto";
            // 
            // Trabajo
            // 
            Trabajo.DataPropertyName = "Trabajo";
            Trabajo.HeaderText = "De:";
            Trabajo.Name = "Trabajo";
            // 
            // MiniMarket
            // 
            MiniMarket.DataPropertyName = "MiniMarket";
            MiniMarket.HeaderText = "MiniMarket";
            MiniMarket.Name = "MiniMarket";
            MiniMarket.Width = 125;
            // 
            // Souvenir
            // 
            Souvenir.DataPropertyName = "Souvenir";
            Souvenir.HeaderText = "Souvenir";
            Souvenir.Name = "Souvenir";
            Souvenir.Width = 125;
            // 
            // Restaurante
            // 
            Restaurante.DataPropertyName = "Restaurante";
            Restaurante.HeaderText = "Restaurante";
            Restaurante.Name = "Restaurante";
            Restaurante.Width = 125;
            // 
            // Heladeria
            // 
            Heladeria.DataPropertyName = "Heladeria";
            Heladeria.HeaderText = "Heladeria";
            Heladeria.Name = "Heladeria";
            Heladeria.Width = 125;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(310, 107);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(186, 36);
            cmbTrabajo.TabIndex = 8;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(70, 110);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 7;
            label1.Text = "Buscar por donde Trabaja:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(262, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 34);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(70, 63);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(186, 28);
            lblBuscarNombre.TabIndex = 5;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1059, 110);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 36);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ApuntesTodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 687);
            Controls.Add(btnActualizar);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Name = "ApuntesTodos";
            Text = "Form1";
            Load += ApuntesTodos_Load;
            ((System.ComponentModel.ISupportInitialize)gridApuntes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridApuntes;
        private ComboBox cmbTrabajo;
        private Label label1;
        private TextBox txtNombre;
        private Label lblBuscarNombre;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Trabajo;
        private DataGridViewTextBoxColumn MiniMarket;
        private DataGridViewTextBoxColumn Souvenir;
        private DataGridViewTextBoxColumn Restaurante;
        private DataGridViewTextBoxColumn Heladeria;
        private DataGridViewTextBoxColumn Total;
        private Button btnActualizar;
    }
}
