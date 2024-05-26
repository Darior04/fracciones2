namespace fracciones
{
    partial class Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma));
            pictureBox1 = new PictureBox();
            BtnBack = new Button();
            Nivel1 = new Button();
            Nivel2 = new Button();
            Nivel3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(24, 65);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 27);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Inicio";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Nivel1
            // 
            Nivel1.Location = new Point(231, 130);
            Nivel1.Name = "Nivel1";
            Nivel1.Size = new Size(61, 75);
            Nivel1.TabIndex = 2;
            Nivel1.Text = "Nivel 1";
            Nivel1.UseVisualStyleBackColor = true;
            Nivel1.Click += Nivel1_Click;
            // 
            // Nivel2
            // 
            Nivel2.Location = new Point(322, 130);
            Nivel2.Name = "Nivel2";
            Nivel2.Size = new Size(61, 75);
            Nivel2.TabIndex = 3;
            Nivel2.Text = "Nivel 2";
            Nivel2.UseVisualStyleBackColor = true;
            // 
            // Nivel3
            // 
            Nivel3.Location = new Point(415, 130);
            Nivel3.Name = "Nivel3";
            Nivel3.Size = new Size(61, 75);
            Nivel3.TabIndex = 4;
            Nivel3.Text = "Nivel 3";
            Nivel3.UseVisualStyleBackColor = true;
            // 
            // Suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(800, 450);
            Controls.Add(Nivel3);
            Controls.Add(Nivel2);
            Controls.Add(Nivel1);
            Controls.Add(BtnBack);
            Controls.Add(pictureBox1);
            Name = "Suma";
            Text = "Suma";
            Load += Suma_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnBack;
        private Button Nivel1;
        private Button Nivel2;
        private Button Nivel3;
    }
}