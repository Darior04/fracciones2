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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resta));
            BtnBack = new Button();
            Nivel1 = new Button();
            Nivel2 = new Button();
            Nivel3 = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Image = (Image)resources.GetObject("BtnBack.Image");
            BtnBack.Location = new Point(33, 77);
            BtnBack.Margin = new Padding(3, 4, 3, 4);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(127, 128);
            BtnBack.TabIndex = 0;
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Nivel1
            // 
            Nivel1.FlatAppearance.BorderSize = 0;
            Nivel1.FlatStyle = FlatStyle.Flat;
            Nivel1.Image = (Image)resources.GetObject("Nivel1.Image");
            Nivel1.Location = new Point(219, 214);
            Nivel1.Margin = new Padding(3, 4, 3, 4);
            Nivel1.Name = "Nivel1";
            Nivel1.Size = new Size(130, 153);
            Nivel1.TabIndex = 1;
            Nivel1.UseVisualStyleBackColor = true;
            Nivel1.Click += Nivel1_Click;
            // 
            // Nivel2
            // 
            Nivel2.FlatAppearance.BorderSize = 0;
            Nivel2.FlatStyle = FlatStyle.Flat;
            Nivel2.Image = (Image)resources.GetObject("Nivel2.Image");
            Nivel2.Location = new Point(397, 211);
            Nivel2.Margin = new Padding(3, 4, 3, 4);
            Nivel2.Name = "Nivel2";
            Nivel2.Size = new Size(129, 159);
            Nivel2.TabIndex = 2;
            Nivel2.UseVisualStyleBackColor = true;
            // 
            // Nivel3
            // 
            Nivel3.FlatAppearance.BorderSize = 0;
            Nivel3.FlatStyle = FlatStyle.Flat;
            Nivel3.Image = (Image)resources.GetObject("Nivel3.Image");
            Nivel3.Location = new Point(563, 214);
            Nivel3.Margin = new Padding(3, 4, 3, 4);
            Nivel3.Name = "Nivel3";
            Nivel3.Size = new Size(131, 153);
            Nivel3.TabIndex = 3;
            Nivel3.UseVisualStyleBackColor = true;
            // 
            // Resta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(914, 600);
            Controls.Add(Nivel3);
            Controls.Add(Nivel2);
            Controls.Add(Nivel1);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 4, 3, 4);
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