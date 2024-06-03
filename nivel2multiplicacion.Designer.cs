namespace fracciones
{
    partial class nivel2multiplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel2multiplicacion));
            pictureBox1 = new PictureBox();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            btnChecar = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // numero1
            // 
            numero1.Location = new Point(399, 139);
            numero1.Name = "numero1";
            numero1.Size = new Size(28, 23);
            numero1.TabIndex = 1;
            // 
            // numero2
            // 
            numero2.Location = new Point(574, 129);
            numero2.Name = "numero2";
            numero2.Size = new Size(31, 23);
            numero2.TabIndex = 2;
            // 
            // numero3
            // 
            numero3.Location = new Point(574, 181);
            numero3.Name = "numero3";
            numero3.Size = new Size(31, 23);
            numero3.TabIndex = 3;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(12, 395);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(55, 34);
            btnChecar.TabIndex = 4;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(70, 29);
            btnAtras.TabIndex = 5;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // nivel2multiplicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(pictureBox1);
            Name = "nivel2multiplicacion";
            Text = "nivel2multiplicacion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
        private Button btnChecar;
        private Button btnAtras;
    }
}