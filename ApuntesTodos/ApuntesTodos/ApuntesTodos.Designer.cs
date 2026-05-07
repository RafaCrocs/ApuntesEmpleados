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
            Pagado = new DataGridViewButtonColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
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
            btnPagarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)gridApuntes).BeginInit();
            SuspendLayout();
            // 
            // gridApuntes
            // 
            gridApuntes.BackgroundColor = SystemColors.Control;
            gridApuntes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridApuntes.Columns.AddRange(new DataGridViewColumn[] { Pagado, NombreCompleto, IdEmpleado, Trabajo, MiniMarket, Souvenir, Restaurante, Heladeria, Total });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridApuntes.DefaultCellStyle = dataGridViewCellStyle1;
            gridApuntes.Location = new Point(65, 203);
            gridApuntes.Margin = new Padding(3, 4, 3, 4);
            gridApuntes.Name = "gridApuntes";
            gridApuntes.RowHeadersWidth = 51;
            gridApuntes.Size = new Size(1289, 564);
            gridApuntes.TabIndex = 0;
            gridApuntes.CellContentClick += gridApuntes_CellContentClick;
            gridApuntes.CellFormatting += gridApuntes_CellFormatting;
            // 
            // Pagado
            // 
            Pagado.HeaderText = "";
            Pagado.MinimumWidth = 6;
            Pagado.Name = "Pagado";
            Pagado.Text = "Pagado";
            Pagado.UseColumnTextForButtonValue = true;
            Pagado.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.MinimumWidth = 6;
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Visible = false;
            IdEmpleado.Width = 125;
            // 
            // Trabajo
            // 
            Trabajo.DataPropertyName = "Trabajo";
            Trabajo.HeaderText = "De:";
            Trabajo.MinimumWidth = 6;
            Trabajo.Name = "Trabajo";
            Trabajo.Width = 125;
            // 
            // MiniMarket
            // 
            MiniMarket.DataPropertyName = "MiniMarket";
            MiniMarket.HeaderText = "MiniMarket";
            MiniMarket.MinimumWidth = 6;
            MiniMarket.Name = "MiniMarket";
            MiniMarket.Width = 125;
            // 
            // Souvenir
            // 
            Souvenir.DataPropertyName = "Souvenir";
            Souvenir.HeaderText = "Souvenir";
            Souvenir.MinimumWidth = 6;
            Souvenir.Name = "Souvenir";
            Souvenir.Width = 125;
            // 
            // Restaurante
            // 
            Restaurante.DataPropertyName = "Restaurante";
            Restaurante.HeaderText = "Restaurante";
            Restaurante.MinimumWidth = 6;
            Restaurante.Name = "Restaurante";
            Restaurante.Width = 125;
            // 
            // Heladeria
            // 
            Heladeria.DataPropertyName = "Heladeria";
            Heladeria.HeaderText = "Heladeria";
            Heladeria.MinimumWidth = 6;
            Heladeria.Name = "Heladeria";
            Heladeria.Width = 125;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // cmbTrabajo
            // 
            cmbTrabajo.Font = new Font("Segoe UI", 15F);
            cmbTrabajo.FormattingEnabled = true;
            cmbTrabajo.Location = new Point(409, 144);
            cmbTrabajo.Margin = new Padding(3, 4, 3, 4);
            cmbTrabajo.Name = "cmbTrabajo";
            cmbTrabajo.Size = new Size(212, 43);
            cmbTrabajo.TabIndex = 8;
            cmbTrabajo.SelectedIndexChanged += cmbTrabajo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(80, 147);
            label1.Name = "label1";
            label1.Size = new Size(327, 35);
            label1.TabIndex = 7;
            label1.Text = "Buscar por lugar de Trabajo:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(354, 78);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 41);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 15F);
            lblBuscarNombre.Location = new Point(80, 84);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(239, 35);
            lblBuscarNombre.TabIndex = 5;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 255, 128);
            btnActualizar.Location = new Point(1210, 147);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(159, 48);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnPagarTodos
            // 
            btnPagarTodos.BackColor = Color.Goldenrod;
            btnPagarTodos.Location = new Point(1034, 147);
            btnPagarTodos.Margin = new Padding(3, 4, 3, 4);
            btnPagarTodos.Name = "btnPagarTodos";
            btnPagarTodos.Size = new Size(159, 48);
            btnPagarTodos.TabIndex = 10;
            btnPagarTodos.Text = "PAGAR TODOS";
            btnPagarTodos.UseVisualStyleBackColor = false;
            btnPagarTodos.Click += btnPagarTodos_Click;
            // 
            // ApuntesTodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 916);
            Controls.Add(btnPagarTodos);
            Controls.Add(btnActualizar);
            Controls.Add(cmbTrabajo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridApuntes);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnActualizar;
        private DataGridViewButtonColumn Pagado;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn Trabajo;
        private DataGridViewTextBoxColumn MiniMarket;
        private DataGridViewTextBoxColumn Souvenir;
        private DataGridViewTextBoxColumn Restaurante;
        private DataGridViewTextBoxColumn Heladeria;
        private DataGridViewTextBoxColumn Total;
        private Button btnPagarTodos;
    }
}
