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
            numero1 = new TextBox();
            numero2 = new TextBox();
            numero3 = new TextBox();
            btnChecar = new Button();
            btnAtras = new Button();
            SuspendLayout();
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
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(119, 123);
            btnAtras.TabIndex = 12;
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // nivel2resta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnChecar);
            Controls.Add(numero3);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Name = "nivel2resta";
            Text = "nivel2resta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox numero1;
        private TextBox numero2;
        private TextBox numero3;
        private Button btnChecar;
        private Button btnAtras;
    }
}