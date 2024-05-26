namespace fracciones
{
    partial class nivel1Resta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel1Resta));
            pictureBox1 = new PictureBox();
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            numero4 = new TextBox();
            numero5 = new TextBox();
            btnChecar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(807, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // numero1
            // 
            numero1.Location = new Point(223, 134);
            numero1.Name = "numero1";
            numero1.Size = new Size(35, 23);
            numero1.TabIndex = 1;
            // 
            // numero2
            // 
            numero2.Location = new Point(421, 134);
            numero2.Name = "numero2";
            numero2.Size = new Size(36, 23);
            numero2.TabIndex = 2;
            // 
            // numero3
            // 
            numero3.Location = new Point(530, 134);
            numero3.Name = "numero3";
            numero3.Size = new Size(41, 23);
            numero3.TabIndex = 3;
            // 
            // numero4
            // 
            numero4.Location = new Point(626, 134);
            numero4.Name = "numero4";
            numero4.Size = new Size(45, 23);
            numero4.TabIndex = 4;
            // 
            // numero5
            // 
            numero5.Location = new Point(719, 134);
            numero5.Name = "numero5";
            numero5.Size = new Size(52, 23);
            numero5.TabIndex = 5;
            // 
            // btnChecar
            // 
            btnChecar.Location = new Point(58, 384);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(77, 34);
            btnChecar.TabIndex = 6;
            btnChecar.Text = "Revisar";
            btnChecar.UseVisualStyleBackColor = true;
            btnChecar.Click += btnChecar_Click;
            // 
            // nivel1Resta
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
            Controls.Add(pictureBox1);
            Name = "nivel1Resta";
            Text = "nivel1Resta";
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
    }
}