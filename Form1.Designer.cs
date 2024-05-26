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
            titulo.Location = new Point(305, 12);
            titulo.Name = "titulo";
            titulo.Size = new Size(282, 145);
            titulo.SizeMode = PictureBoxSizeMode.StretchImage;
            titulo.TabIndex = 0;
            titulo.TabStop = false;
            titulo.Click += titulo_Click;
            // 
            // ajoloteInicio
            // 
            ajoloteInicio.Image = (Image)resources.GetObject("ajoloteInicio.Image");
            ajoloteInicio.Location = new Point(619, 257);
            ajoloteInicio.Name = "ajoloteInicio";
            ajoloteInicio.Size = new Size(264, 259);
            ajoloteInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            ajoloteInicio.TabIndex = 1;
            ajoloteInicio.TabStop = false;
            ajoloteInicio.Click += pictureBox1_Click;
            // 
            // BtnSuma
            // 
            BtnSuma.AutoSize = true;
            BtnSuma.Location = new Point(305, 228);
            BtnSuma.Name = "BtnSuma";
            BtnSuma.Size = new Size(75, 25);
            BtnSuma.TabIndex = 2;
            BtnSuma.Text = "+";
            BtnSuma.UseVisualStyleBackColor = true;
            BtnSuma.Click += BtnSuma_Click;
            // 
            // BtnResta
            // 
            BtnResta.Location = new Point(443, 228);
            BtnResta.Name = "BtnResta";
            BtnResta.Size = new Size(75, 23);
            BtnResta.TabIndex = 3;
            BtnResta.Text = "-";
            BtnResta.UseVisualStyleBackColor = true;
            BtnResta.Click += BtnResta_Click;
            // 
            // BtnInfo
            // 
            BtnInfo.Location = new Point(375, 284);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(75, 23);
            BtnInfo.TabIndex = 4;
            BtnInfo.Text = "?";
            BtnInfo.UseVisualStyleBackColor = true;
            // 
            // BtnMultiplicacion
            // 
            BtnMultiplicacion.Location = new Point(305, 336);
            BtnMultiplicacion.Name = "BtnMultiplicacion";
            BtnMultiplicacion.Size = new Size(75, 23);
            BtnMultiplicacion.TabIndex = 5;
            BtnMultiplicacion.Text = "x";
            BtnMultiplicacion.UseVisualStyleBackColor = true;
            BtnMultiplicacion.Click += BtnMultiplicacion_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.Location = new Point(443, 336);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(75, 23);
            BtnDivision.TabIndex = 6;
            BtnDivision.Text = "÷";
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += BtnDivision_Click;
            // 
            // Iniciopag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 189, 223);
            ClientSize = new Size(895, 524);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMultiplicacion);
            Controls.Add(BtnInfo);
            Controls.Add(BtnResta);
            Controls.Add(BtnSuma);
            Controls.Add(ajoloteInicio);
            Controls.Add(titulo);
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
