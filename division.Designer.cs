namespace fracciones
{
    partial class division
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(division));
            Nivel1 = new Button();
            Nivel2 = new Button();
            Nivel3 = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // Nivel1
            // 
            Nivel1.FlatAppearance.BorderSize = 0;
            Nivel1.FlatStyle = FlatStyle.Flat;
            Nivel1.Image = (Image)resources.GetObject("Nivel1.Image");
            Nivel1.Location = new Point(204, 128);
            Nivel1.Name = "Nivel1";
            Nivel1.Size = new Size(145, 162);
            Nivel1.TabIndex = 1;
            Nivel1.UseVisualStyleBackColor = true;
            Nivel1.Click += Nivel1_Click;
            // 
            // Nivel2
            // 
            Nivel2.FlatAppearance.BorderSize = 0;
            Nivel2.FlatStyle = FlatStyle.Flat;
            Nivel2.Image = (Image)resources.GetObject("Nivel2.Image");
            Nivel2.Location = new Point(355, 128);
            Nivel2.Name = "Nivel2";
            Nivel2.Size = new Size(132, 162);
            Nivel2.TabIndex = 2;
            Nivel2.UseVisualStyleBackColor = true;
            Nivel2.Click += Nivel2_Click;
            // 
            // Nivel3
            // 
            Nivel3.FlatAppearance.BorderSize = 0;
            Nivel3.FlatStyle = FlatStyle.Flat;
            Nivel3.Image = (Image)resources.GetObject("Nivel3.Image");
            Nivel3.Location = new Point(493, 128);
            Nivel3.Name = "Nivel3";
            Nivel3.Size = new Size(144, 162);
            Nivel3.TabIndex = 3;
            Nivel3.UseVisualStyleBackColor = true;
            Nivel3.Click += Nivel3_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(119, 123);
            btnAtras.TabIndex = 12;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // division
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(Nivel3);
            Controls.Add(Nivel2);
            Controls.Add(Nivel1);
            Name = "division";
            Text = "division";
            ResumeLayout(false);
        }

        #endregion
        private Button Nivel1;
        private Button Nivel2;
        private Button Nivel3;
        private Button btnAtras;
    }
}