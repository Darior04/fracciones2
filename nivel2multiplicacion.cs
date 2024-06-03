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
    public partial class nivel2multiplicacion : Form
    {
        public nivel2multiplicacion()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            string valor1 = numero1.Text;
            string valor2 = numero2.Text;
            string valor3 = numero3.Text;

            // Definir los valores esperados
            string[] valoresEsperados = { "13", "91", "25" };

            // Verificar si los valores ingresados son correctos
            if (valor1 == valoresEsperados[0] &&
                valor2 == valoresEsperados[1] &&
                valor3 == valoresEsperados[2])
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
            multiplicacion ventana = new multiplicacion();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
