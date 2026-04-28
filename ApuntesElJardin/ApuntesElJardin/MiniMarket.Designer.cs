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
            SuspendLayout();
            // 
            // btnNuevoApunte
            // 
            btnNuevoApunte.Font = new Font("Segoe UI", 15F);
            btnNuevoApunte.Location = new Point(72, 147);
            btnNuevoApunte.Margin = new Padding(3, 4, 3, 4);
            btnNuevoApunte.Name = "btnNuevoApunte";
            btnNuevoApunte.Size = new Size(209, 125);
            btnNuevoApunte.TabIndex = 0;
            btnNuevoApunte.Text = "Nuevo Apunte";
            btnNuevoApunte.UseVisualStyleBackColor = true;
            btnNuevoApunte.Click += btnNuevoApunte_Click;
            // 
            // btnVerApuntes
            // 
            btnVerApuntes.Font = new Font("Segoe UI", 15F);
            btnVerApuntes.Location = new Point(406, 147);
            btnVerApuntes.Margin = new Padding(3, 4, 3, 4);
            btnVerApuntes.Name = "btnVerApuntes";
            btnVerApuntes.Size = new Size(209, 125);
            btnVerApuntes.TabIndex = 1;
            btnVerApuntes.Text = "Ver Apuntes";
            btnVerApuntes.UseVisualStyleBackColor = true;
            btnVerApuntes.Click += btnVerApuntes_Click;
            // 
            // MiniMarket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 460);
            Controls.Add(btnVerApuntes);
            Controls.Add(btnNuevoApunte);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MiniMarket";
            Text = "MiniMarket";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoApunte;
        private Button btnVerApuntes;
    }
}
