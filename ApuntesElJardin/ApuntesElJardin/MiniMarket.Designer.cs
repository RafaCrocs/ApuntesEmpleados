namespace ApuntesElJardin
{
    partial class MiniMarket
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
            btnNuevoApunte = new Button();
            btnVerApuntes = new Button();
            btnNuevoEmpleado = new Button();
            SuspendLayout();
            // 
            // btnNuevoApunte
            // 
            btnNuevoApunte.Font = new Font("Segoe UI", 15F);
            btnNuevoApunte.Location = new Point(85, 168);
            btnNuevoApunte.Name = "btnNuevoApunte";
            btnNuevoApunte.Size = new Size(183, 94);
            btnNuevoApunte.TabIndex = 0;
            btnNuevoApunte.Text = "Nuevo Apunte";
            btnNuevoApunte.UseVisualStyleBackColor = true;
            btnNuevoApunte.Click += btnNuevoApunte_Click;
            // 
            // btnVerApuntes
            // 
            btnVerApuntes.Font = new Font("Segoe UI", 15F);
            btnVerApuntes.Location = new Point(375, 168);
            btnVerApuntes.Name = "btnVerApuntes";
            btnVerApuntes.Size = new Size(183, 94);
            btnVerApuntes.TabIndex = 1;
            btnVerApuntes.Text = "Ver Apuntes";
            btnVerApuntes.UseVisualStyleBackColor = true;
            btnVerApuntes.Click += btnVerApuntes_Click;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.Font = new Font("Segoe UI", 10F);
            btnNuevoEmpleado.Location = new Point(12, 12);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(127, 31);
            btnNuevoEmpleado.TabIndex = 2;
            btnNuevoEmpleado.Text = "Nuevo Empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = true;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // MiniMarket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 424);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(btnVerApuntes);
            Controls.Add(btnNuevoApunte);
            Name = "MiniMarket";
            Text = "MiniMarket";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoApunte;
        private Button btnVerApuntes;
        private Button btnNuevoEmpleado;
    }
}
