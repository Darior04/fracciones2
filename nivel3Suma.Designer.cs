namespace fracciones
{
    partial class nivel3Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel3Suma));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnAtras = new Button();
            btnChecar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(485, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(485, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(582, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(48, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(582, 208);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(48, 23);
            textBox6.TabIndex = 6;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(119, 123);
            btnAtras.TabIndex = 9;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnChecar
            // 
            btnChecar.Anchor = AnchorStyles.None;
            btnChecar.BackColor = Color.Transparent;
            btnChecar.FlatAppearance.BorderSize = 0;
            btnChecar.FlatStyle = FlatStyle.Flat;
            btnChecar.Image = (Image)resources.GetObject("btnChecar.Image");
            btnChecar.Location = new Point(0, 398);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(193, 40);
            btnChecar.TabIndex = 11;
            btnChecar.UseVisualStyleBackColor = false;
            // 
            // nivel3Suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChecar);
            Controls.Add(btnAtras);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "nivel3Suma";
            Text = "nivel3Suma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnAtras;
        private Button btnChecar;
    }
}