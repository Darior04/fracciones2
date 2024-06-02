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
            pictureBox1.Location = new Point(-5, -7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 612);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // numero1
            // 
            numero1.Location = new Point(249, 204);
            numero1.Margin = new Padding(3, 4, 3, 4);
            numero1.Name = "numero1";
            numero1.Size = new Size(38, 27);
            numero1.TabIndex = 1;
            numero1.TextChanged += textBox1_TextChanged;
            // 
            // numero2
            // 
            numero2.Location = new Point(477, 204);
            numero2.Margin = new Padding(3, 4, 3, 4);
            numero2.Name = "numero2";
            numero2.Size = new Size(37, 27);
            numero2.TabIndex = 2;
            numero2.TextChanged += numero2_TextChanged;
            // 
            // numero3
            // 
            numero3.Location = new Point(604, 215);
            numero3.Margin = new Padding(3, 4, 3, 4);
            numero3.Name = "numero3";
            numero3.Size = new Size(47, 27);
            numero3.TabIndex = 3;
            numero3.TextChanged += numero3_TextChanged;
            // 
            // numero4
            // 
            numero4.Location = new Point(710, 215);
            numero4.Margin = new Padding(3, 4, 3, 4);
            numero4.Name = "numero4";
            numero4.Size = new Size(58, 27);
            numero4.TabIndex = 4;
            numero4.TextChanged += numero4_TextChanged;
            // 
            // numero5
            // 
            numero5.Location = new Point(823, 215);
            numero5.Margin = new Padding(3, 4, 3, 4);
            numero5.Name = "numero5";
            numero5.Size = new Size(65, 27);
            numero5.TabIndex = 5;
            numero5.TextChanged += numero5_TextChanged;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(66, 544);
            btnChecar.Margin = new Padding(3, 4, 3, 4);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(118, 40);
            btnChecar.TabIndex = 6;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(14, 43);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(96, 40);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Volver";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // nivel1Suma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(numero5);
            Controls.Add(numero4);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
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