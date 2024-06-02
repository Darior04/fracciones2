namespace fracciones
{
    partial class Iniciopag
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciopag));
            titulo = new PictureBox();
            ajoloteInicio = new PictureBox();
            BtnSuma = new Button();
            BtnResta = new Button();
            BtnInfo = new Button();
            BtnMultiplicacion = new Button();
            BtnDivision = new Button();
            ((System.ComponentModel.ISupportInitialize)titulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ajoloteInicio).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Image = (Image)resources.GetObject("titulo.Image");
            titulo.Location = new Point(349, 16);
            titulo.Margin = new Padding(3, 4, 3, 4);
            titulo.Name = "titulo";
            titulo.Size = new Size(322, 193);
            titulo.SizeMode = PictureBoxSizeMode.StretchImage;
            titulo.TabIndex = 0;
            titulo.TabStop = false;
            titulo.Click += titulo_Click;
            // 
            // ajoloteInicio
            // 
            ajoloteInicio.Image = (Image)resources.GetObject("ajoloteInicio.Image");
            ajoloteInicio.Location = new Point(707, 343);
            ajoloteInicio.Margin = new Padding(3, 4, 3, 4);
            ajoloteInicio.Name = "ajoloteInicio";
            ajoloteInicio.Size = new Size(302, 345);
            ajoloteInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            ajoloteInicio.TabIndex = 1;
            ajoloteInicio.TabStop = false;
            ajoloteInicio.Click += pictureBox1_Click;
            // 
            // BtnSuma
            // 
            BtnSuma.AutoSize = true;
            BtnSuma.FlatAppearance.BorderSize = 0;
            BtnSuma.FlatStyle = FlatStyle.Flat;
            BtnSuma.Image = (Image)resources.GetObject("BtnSuma.Image");
            BtnSuma.Location = new Point(304, 242);
            BtnSuma.Margin = new Padding(3, 4, 3, 4);
            BtnSuma.Name = "BtnSuma";
            BtnSuma.Size = new Size(133, 131);
            BtnSuma.TabIndex = 2;
            BtnSuma.UseVisualStyleBackColor = true;
            BtnSuma.Click += BtnSuma_Click;
            // 
            // BtnResta
            // 
            BtnResta.FlatAppearance.BorderSize = 0;
            BtnResta.FlatStyle = FlatStyle.Flat;
            BtnResta.Image = (Image)resources.GetObject("BtnResta.Image");
            BtnResta.Location = new Point(571, 242);
            BtnResta.Margin = new Padding(3, 4, 3, 4);
            BtnResta.Name = "BtnResta";
            BtnResta.Size = new Size(130, 131);
            BtnResta.TabIndex = 3;
            BtnResta.UseVisualStyleBackColor = true;
            BtnResta.Click += BtnResta_Click;
            // 
            // BtnInfo
            // 
            BtnInfo.FlatAppearance.BorderSize = 0;
            BtnInfo.FlatStyle = FlatStyle.Flat;
            BtnInfo.Image = (Image)resources.GetObject("BtnInfo.Image");
            BtnInfo.Location = new Point(432, 381);
            BtnInfo.Margin = new Padding(3, 4, 3, 4);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(133, 127);
            BtnInfo.TabIndex = 4;
            BtnInfo.UseVisualStyleBackColor = true;
            // 
            // BtnMultiplicacion
            // 
            BtnMultiplicacion.FlatAppearance.BorderSize = 0;
            BtnMultiplicacion.FlatStyle = FlatStyle.Flat;
            BtnMultiplicacion.Image = (Image)resources.GetObject("BtnMultiplicacion.Image");
            BtnMultiplicacion.Location = new Point(304, 510);
            BtnMultiplicacion.Margin = new Padding(3, 4, 3, 4);
            BtnMultiplicacion.Name = "BtnMultiplicacion";
            BtnMultiplicacion.Size = new Size(133, 129);
            BtnMultiplicacion.TabIndex = 5;
            BtnMultiplicacion.UseVisualStyleBackColor = true;
            BtnMultiplicacion.Click += BtnMultiplicacion_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.FlatAppearance.BorderSize = 0;
            BtnDivision.FlatStyle = FlatStyle.Flat;
            BtnDivision.Image = (Image)resources.GetObject("BtnDivision.Image");
            BtnDivision.Location = new Point(571, 510);
            BtnDivision.Margin = new Padding(3, 4, 3, 4);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(130, 129);
            BtnDivision.TabIndex = 6;
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += BtnDivision_Click;
            // 
            // Iniciopag
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(1123, 799);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMultiplicacion);
            Controls.Add(BtnInfo);
            Controls.Add(BtnResta);
            Controls.Add(BtnSuma);
            Controls.Add(ajoloteInicio);
            Controls.Add(titulo);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1141, 846);
            MinimumSize = new Size(1141, 846);
            Name = "Iniciopag";
            Text = "inicio";
            ((System.ComponentModel.ISupportInitialize)titulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ajoloteInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox titulo;
        private PictureBox ajoloteInicio;
        private Button BtnSuma;
        private Button BtnResta;
        private Button BtnInfo;
        private Button BtnMultiplicacion;
        private Button BtnDivision;
    }
}
