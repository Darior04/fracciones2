namespace fracciones
{
    partial class nivel1Division
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel1Division));
            pictureBox1 = new PictureBox();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            numero4 = new TextBox();
            btnChecar = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(815, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // numero1
            // 
            numero1.Location = new Point(361, 222);
            numero1.Name = "numero1";
            numero1.Size = new Size(44, 23);
            numero1.TabIndex = 2;
            // 
            // numero2
            // 
            numero2.Location = new Point(423, 170);
            numero2.Name = "numero2";
            numero2.Size = new Size(36, 23);
            numero2.TabIndex = 3;
            // 
            // numero3
            // 
            numero3.Location = new Point(521, 170);
            numero3.Name = "numero3";
            numero3.Size = new Size(47, 23);
            numero3.TabIndex = 4;
            // 
            // numero4
            // 
            numero4.Location = new Point(521, 222);
            numero4.Name = "numero4";
            numero4.Size = new Size(50, 23);
            numero4.TabIndex = 5;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(34, 391);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(75, 31);
            btnChecar.TabIndex = 6;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(34, 96);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(76, 46);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Volver";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // nivel1Division
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(numero4);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(pictureBox1);
            Name = "nivel1Division";
            Text = "nivel1Division";
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
        private Button btnChecar;
        private Button btnAtras;
    }
}