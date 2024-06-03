namespace fracciones
{
    partial class nivel2resta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel2resta));
            pictureBox1 = new PictureBox();
            btnChecar = new Button();
            btnAtras = new Button();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-9, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(814, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(12, 395);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(114, 43);
            btnChecar.TabIndex = 1;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(57, 30);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // numero1
            // 
            numero1.Location = new Point(393, 133);
            numero1.Name = "numero1";
            numero1.Size = new Size(42, 23);
            numero1.TabIndex = 3;
            // 
            // numero2
            // 
            numero2.Location = new Point(571, 133);
            numero2.Name = "numero2";
            numero2.Size = new Size(39, 23);
            numero2.TabIndex = 4;
            // 
            // numero3
            // 
            numero3.Location = new Point(571, 183);
            numero3.Name = "numero3";
            numero3.Size = new Size(39, 23);
            numero3.TabIndex = 5;
            // 
            // nivel2resta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(pictureBox1);
            Name = "nivel2resta";
            Text = "nivel2resta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnChecar;
        private Button btnAtras;
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
    }
}