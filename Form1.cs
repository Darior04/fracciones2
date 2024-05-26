namespace fracciones
{
    public partial class Iniciopag : Form
    {
        public Iniciopag()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Suma ventana = new Suma();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Resta ventana = new Resta();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            multiplicacion ventana = new multiplicacion();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            division ventana = new division();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
