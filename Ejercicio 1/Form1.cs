using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            string ItemSelected = comboOpciones.Text;

            switch (ItemSelected)
            {
                case "Suma":
                    var suma = num1 + num2;
                    MessageBox.Show(suma.ToString());
                    break;

                case "Resta":
                    var resta = num1 - num2;
                    MessageBox.Show(resta.ToString());
                    break;

                case "Multiplicación":
                    var multiplicaion = num1 * num2;
                    MessageBox.Show(multiplicaion.ToString());
                    break;

                case "Division":
                    var division = num1 / num2;
                    MessageBox.Show(division.ToString());
                    break;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
