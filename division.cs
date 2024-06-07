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
    public partial class division : Form
    {
        public division()
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
            nivel1Division ventana = new nivel1Division();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel2_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel2division ventana = new nivel2division();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel3_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel3division ventana = new nivel3division();

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
