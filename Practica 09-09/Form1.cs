﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_09_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este es mi primer formulario");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            MessageBox.Show(mensaje);
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ItemSelected = comboOpcion.Text;
            MessageBox.Show(ItemSelected);
        }
    }
}
