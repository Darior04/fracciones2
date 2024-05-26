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
    public partial class nivel1Suma : Form
    {
        public nivel1Suma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            string valor1 = numero1.Text;
            string valor2 = numero2.Text;
            string valor3 = numero3.Text;
            string valor4 = numero4.Text;
            string valor5 = numero5.Text;

            // Definir los valores esperados
            string[] valoresEsperados = { "3", "2", "15", "8", "23" };

            // Verificar si los valores ingresados son correctos
            if (valor1 == valoresEsperados[0] &&
                valor2 == valoresEsperados[1] &&
                valor3 == valoresEsperados[2] &&
                valor4 == valoresEsperados[3] &&
                valor5 == valoresEsperados[4])
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
    }
}