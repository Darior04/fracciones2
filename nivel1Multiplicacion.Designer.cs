namespace fracciones
{
    partial class nivel1Multiplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel1Multiplicacion));
            pictureBox1 = new PictureBox();
            btnChecar = new Button();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(70, 366);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(94, 26);
            btnChecar.TabIndex = 1;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // numero1
            // 
            numero1.Location = new Point(391, 184);
            numero1.Name = "numero1";
            numero1.Size = new Size(41, 23);
            numero1.TabIndex = 2;
            // 
            // numero2
            // 
            numero2.Location = new Point(450, 129);
            numero2.Name = "numero2";
            numero2.Size = new Size(33, 23);
            numero2.TabIndex = 3;
            // 
            // numero3
            // 
            numero3.Location = new Point(547, 138);
            numero3.Name = "numero3";
            numero3.Size = new Size(39, 23);
            numero3.TabIndex = 4;
            // 
            // nivel1Multiplicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(btnChecar);
            Controls.Add(pictureBox1);
            Name = "nivel1Multiplicacion";
            Text = "nivel1Multiplicacion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnChecar;
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
    }
}