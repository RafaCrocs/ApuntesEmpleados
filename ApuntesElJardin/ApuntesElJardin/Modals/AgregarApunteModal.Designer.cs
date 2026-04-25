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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(55, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(321, 34);
            txtNombre.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 15F);
            lblEmpleado.Location = new Point(55, 90);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(104, 28);
            lblEmpleado.TabIndex = 1;
            lblEmpleado.Text = "Empelado:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 15F);
            lblMonto.Location = new Point(55, 174);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(76, 28);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(55, 256);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Detalle";
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Font = new Font("Segoe UI", 15F);
            btnBuscarEmpleado.Location = new Point(395, 116);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(131, 36);
            btnBuscarEmpleado.TabIndex = 4;
            btnBuscarEmpleado.Text = "BUSCAR";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += btnBuscarEmpleado_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 15F);
            txtMonto.Location = new Point(55, 205);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(208, 34);
            txtMonto.TabIndex = 5;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // txtDetalle
            // 
            txtDetalle.Font = new Font("Segoe UI", 15F);
            txtDetalle.Location = new Point(55, 289);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(321, 34);
            txtDetalle.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15F);
            btnAceptar.Location = new Point(132, 384);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 36);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.Location = new Point(312, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.Location = new Point(55, 153);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(0, 15);
            lblIdEmpleado.TabIndex = 9;
            // 
            // AgregarApunteModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 522);
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
    }
}