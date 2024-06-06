namespace fracciones
{
    partial class nivel3Resta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel3Resta));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnChecar = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(350, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(33, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(518, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(34, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(610, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(36, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(666, 146);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(31, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(738, 146);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(50, 23);
            textBox7.TabIndex = 7;
            // 
            // btnChecar
            // 
            btnChecar.Anchor = AnchorStyles.None;
            btnChecar.BackColor = Color.Transparent;
            btnChecar.FlatAppearance.BorderSize = 0;
            btnChecar.FlatStyle = FlatStyle.Flat;
            btnChecar.Image = (Image)resources.GetObject("btnChecar.Image");
            btnChecar.Location = new Point(12, 398);
            btnChecar.Name = "btnChecar";
            btnChecar.Size = new Size(193, 40);
            btnChecar.TabIndex = 10;
            btnChecar.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(-2, -3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(119, 123);
            btnAtras.TabIndex = 11;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // nivel3Resta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "nivel3Resta";
            Text = "nivel3Resta";
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
        private TextBox textBox7;
        private Button btnChecar;
        private Button btnAtras;
    }
}