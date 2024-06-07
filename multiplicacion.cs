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
    public partial class multiplicacion : Form
    {
        public multiplicacion()
        {
            InitializeComponent();
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
            nivel1Multiplicacion ventana = new nivel1Multiplicacion();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel2_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel2multiplicacion ventana = new nivel2multiplicacion();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel3_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel3multiplicacion ventana = new nivel3multiplicacion();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Iniciopag ventana = new Iniciopag();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
