namespace fracciones
{
    partial class nivel2suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel2suma));
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            btnAtras = new Button();
            btnChecar = new Button();
            SuspendLayout();
            // 
            // numero1
            // 
            numero1.Location = new Point(384, 201);
            numero1.Name = "numero1";
            numero1.Size = new Size(43, 23);
            numero1.TabIndex = 2;
            // 
            // numero2
            // 
            numero2.Location = new Point(577, 152);
            numero2.Name = "numero2";
            numero2.Size = new Size(36, 23);
            numero2.TabIndex = 3;
            // 
            // numero3
            // 
            numero3.Location = new Point(576, 201);
            numero3.Name = "numero3";
            numero3.Size = new Size(37, 23);
            numero3.TabIndex = 4;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(119, 123);
            btnAtras.TabIndex = 10;
            btnAtras.UseVisualStyleBackColor = false;
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
            btnChecar.TabIndex = 11;
            btnChecar.UseVisualStyleBackColor = false;
            // 
            // nivel2suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChecar);
            Controls.Add(btnAtras);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Name = "nivel2suma";
            Text = "nivel2suma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
        private Button btnAtras;
        private Button btnChecar;
    }
}