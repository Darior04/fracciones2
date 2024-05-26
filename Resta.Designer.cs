namespace fracciones
{
    partial class Resta
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
            BtnBack.Location = new Point(27, 55);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(80, 59);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Inicio";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Nivel1
            // 
            Nivel1.Location = new Point(321, 117);
            Nivel1.Name = "Nivel1";
            Nivel1.Size = new Size(61, 75);
            Nivel1.TabIndex = 1;
            Nivel1.Text = "Nivel 1";
            Nivel1.UseVisualStyleBackColor = true;
            Nivel1.Click += Nivel1_Click;
            // 
            // Nivel2
            // 
            Nivel2.Location = new Point(394, 113);
            Nivel2.Name = "Nivel2";
            Nivel2.Size = new Size(61, 75);
            Nivel2.TabIndex = 2;
            Nivel2.Text = "Nivel 2";
            Nivel2.UseVisualStyleBackColor = true;
            // 
            // Nivel3
            // 
            Nivel3.Location = new Point(460, 125);
            Nivel3.Name = "Nivel3";
            Nivel3.Size = new Size(61, 75);
            Nivel3.TabIndex = 3;
            Nivel3.Text = "Nivel 3";
            Nivel3.UseVisualStyleBackColor = true;
            // 
            // Resta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(800, 450);
            Controls.Add(Nivel3);
            Controls.Add(Nivel2);
            Controls.Add(Nivel1);
            Controls.Add(BtnBack);
            Name = "Resta";
            Text = "Resta";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button Nivel1;
        private Button Nivel2;
        private Button Nivel3;
    }
}