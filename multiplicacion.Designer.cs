namespace fracciones
{
    partial class multiplicacion
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
            BtnBack = new Button();
            Nivel1 = new Button();
            Nivel2 = new Button();
            Nivel3 = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(12, 42);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(151, 82);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Inicio";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Nivel1
            // 
            Nivel1.Location = new Point(306, 102);
            Nivel1.Name = "Nivel1";
            Nivel1.Size = new Size(73, 76);
            Nivel1.TabIndex = 1;
            Nivel1.Text = "Nivel 1";
            Nivel1.UseVisualStyleBackColor = true;
            Nivel1.Click += Nivel1_Click;
            // 
            // Nivel2
            // 
            Nivel2.Location = new Point(399, 113);
            Nivel2.Name = "Nivel2";
            Nivel2.Size = new Size(77, 63);
            Nivel2.TabIndex = 2;
            Nivel2.Text = "Nivel 2";
            Nivel2.UseVisualStyleBackColor = true;
            // 
            // Nivel3
            // 
            Nivel3.Location = new Point(510, 120);
            Nivel3.Name = "Nivel3";
            Nivel3.Size = new Size(107, 78);
            Nivel3.TabIndex = 3;
            Nivel3.Text = "Nivel 3";
            Nivel3.UseVisualStyleBackColor = true;
            // 
            // multiplicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(800, 450);
            Controls.Add(Nivel3);
            Controls.Add(Nivel2);
            Controls.Add(Nivel1);
            Controls.Add(BtnBack);
            Name = "multiplicacion";
            Text = "multiplicacion";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button Nivel1;
        private Button Nivel2;
        private Button Nivel3;
    }
}