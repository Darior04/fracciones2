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
    public partial class nivel1Division : Form
    {
        public nivel1Division()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            string valor1 = numero1.Text;
            string valor2 = numero2.Text;
            string valor3 = numero3.Text;
            string valor4 = numero4.Text;

            // Definir los valores esperados
            string[] valoresEsperados = { "4", "5", "15", "8" };

            // Verificar si los valores ingresados son correctos
            if (valor1 == valoresEsperados[0] &&
                valor2 == valoresEsperados[1] &&
                valor3 == valoresEsperados[2] &&
                valor4 == valoresEsperados[3])

            {
                // Mostrar mensaje de felicitación
                MessageBox.Show("¡Felicidades, lo hiciste correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Lo siento, los valores ingresados no son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
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
