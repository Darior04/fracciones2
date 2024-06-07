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
    public partial class nivel3Resta : Form
    {
        public nivel3Resta()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            Resta ventana = new Resta();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
