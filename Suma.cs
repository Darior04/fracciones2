using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fracciones
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void Suma_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Iniciopag ventana = new Iniciopag();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel1_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel1Suma ventana = new nivel1Suma();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel2_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel2suma ventana = new nivel2suma();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Iniciopag ventana = new Iniciopag();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel3_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel3Suma ventana = new nivel3Suma();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
