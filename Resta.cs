﻿using System;
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
    public partial class Resta : Form
    {
        public Resta()
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
            nivel1Resta ventana = new nivel1Resta();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }

        private void Nivel2_Click(object sender, EventArgs e)
        {
            // formulario que quieres mostrar
            nivel2resta ventana = new nivel2resta();

            // Mostrar el nuevo formulario
            ventana.Show();

            // Cerrar el formulario actual
            this.Hide();
        }
    }
}
