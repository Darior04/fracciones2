namespace fracciones
{
    partial class nivel1Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel1Suma));
            pictureBox1 = new PictureBox();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            numero4 = new TextBox();
            numero5 = new TextBox();
            btnChecar = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // numero1
            // 
            numero1.Location = new Point(218, 153);
            numero1.Name = "numero1";
            numero1.Size = new Size(34, 23);
            numero1.TabIndex = 1;
            numero1.TextChanged += textBox1_TextChanged;
            // 
            // numero2
            // 
            numero2.Location = new Point(417, 153);
            numero2.Name = "numero2";
            numero2.Size = new Size(33, 23);
            numero2.TabIndex = 2;
            numero2.TextChanged += numero2_TextChanged;
            // 
            // numero3
            // 
            numero3.Location = new Point(528, 161);
            numero3.Name = "numero3";
            numero3.Size = new Size(42, 23);
            numero3.TabIndex = 3;
            numero3.TextChanged += numero3_TextChanged;
            // 
            // numero4
            // 
            numero4.Location = new Point(621, 161);
            numero4.Name = "numero4";
            numero4.Size = new Size(51, 23);
            numero4.TabIndex = 4;
            numero4.TextChanged += numero4_TextChanged;
            // 
            // numero5
            // 
            numero5.Location = new Point(720, 161);
            numero5.Name = "numero5";
            numero5.Size = new Size(57, 23);
            numero5.TabIndex = 5;
            numero5.TextChanged += numero5_TextChanged;
            // 
            // btnChecar
            // 
            btnChecar.Anchor = AnchorStyles.None;
            btnChecar.BackColor = Color.Transparent;
            btnChecar.BackgroundImage = (Image)resources.GetObject("btnChecar.BackgroundImage");
            btnChecar.FlatAppearance.BorderSize = 0;
            btnChecar.FlatStyle = FlatStyle.Flat;
            btnChecar.Image = (Image)resources.GetObject("btnChecar.Image");
            btnChecar.Location = new Point(-4, 398);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(193, 40);
            btnChecar.TabIndex = 6;
            btnChecar.UseVisualStyleBackColor = false;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(-4, -5);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(129, 132);
            btnAtras.TabIndex = 7;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // nivel1Suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChecar);
            Controls.Add(numero5);
            Controls.Add(numero4);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox1);
            Name = "nivel1Suma";
            Text = "nivel1Suma";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
        private TextBox numero4;
        private TextBox numero5;
        private Button btnChecar;
        private Button btnAtras;
    }
}