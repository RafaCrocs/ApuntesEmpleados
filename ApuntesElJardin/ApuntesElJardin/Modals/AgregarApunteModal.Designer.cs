namespace ApuntesElJardin.Modals
{
    partial class AgregarApunteModal
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
            txtNombre = new TextBox();
            lblEmpleado = new Label();
            lblMonto = new Label();
            label3 = new Label();
            btnBuscarEmpleado = new Button();
            txtMonto = new TextBox();
            txtDetalle = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblIdEmpleado = new Label();
            lblCantidad = new Label();
            btnLimpiar = new Button();
            lblCadaUno = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.ForeColor = SystemColors.MenuText;
            txtNombre.Location = new Point(63, 146);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(580, 41);
            txtNombre.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 15F);
            lblEmpleado.Location = new Point(63, 98);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(143, 35);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Empelados:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 15F);
            lblMonto.Location = new Point(62, 227);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(94, 35);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(62, 336);
            label3.Name = "label3";
            label3.Size = new Size(92, 35);
            label3.TabIndex = 3;
            label3.Text = "Detalle";
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Font = new Font("Segoe UI", 15F);
            btnBuscarEmpleado.Location = new Point(493, 85);
            btnBuscarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(150, 48);
            btnBuscarEmpleado.TabIndex = 4;
            btnBuscarEmpleado.Text = "BUSCAR";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += btnBuscarEmpleado_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 15F);
            txtMonto.Location = new Point(62, 268);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(237, 41);
            txtMonto.TabIndex = 5;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // txtDetalle
            // 
            txtDetalle.Font = new Font("Segoe UI", 15F);
            txtDetalle.Location = new Point(62, 380);
            txtDetalle.Margin = new Padding(3, 4, 3, 4);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(455, 41);
            txtDetalle.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15F);
            btnAceptar.Location = new Point(150, 469);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 48);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.Location = new Point(356, 469);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 48);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.Location = new Point(62, 195);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(0, 20);
            lblIdEmpleado.TabIndex = 9;
            lblIdEmpleado.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(65, 191);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.Location = new Point(530, 191);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 32);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCadaUno
            // 
            lblCadaUno.AutoSize = true;
            lblCadaUno.Enabled = false;
            lblCadaUno.Font = new Font("Segoe UI", 15F);
            lblCadaUno.Location = new Point(328, 268);
            lblCadaUno.Name = "lblCadaUno";
            lblCadaUno.Size = new Size(0, 35);
            lblCadaUno.TabIndex = 12;
            // 
            // AgregarApunteModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 587);
            Controls.Add(lblCadaUno);
            Controls.Add(btnLimpiar);
            Controls.Add(lblCantidad);
            Controls.Add(lblIdEmpleado);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(txtMonto);
            Controls.Add(btnBuscarEmpleado);
            Controls.Add(label3);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpleado);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarApunteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarApunteModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblEmpleado;
        private Label lblMonto;
        private Label label3;
        private Button btnBuscarEmpleado;
        private TextBox txtMonto;
        private TextBox txtDetalle;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblIdEmpleado;
        private Label lblCantidad;
        private Button btnLimpiar;
        private Label lblCadaUno;
    }
}