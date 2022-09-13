using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(txtCapital.Text);
            double interes = double.Parse(txtTasa.Text);
            double tiempo = double.Parse(txtCapital.Text);

            string ItemSelected = comboPeriodo.Text;

            switch (ItemSelected)
            {
                case "Anual":
                    var Anual = capital * interes * tiempo;
                    MessageBox.Show(Anual.ToString());
                    break;

                case "Mensual":
                    var Mensual = capital * interes * tiempo / 12;
                    MessageBox.Show(Mensual.ToString());
                    break;

                case "Diario":
                    var Diario = capital * interes * tiempo / 360;
                    MessageBox.Show(Diario.ToString());
                    break;
            }
        }
    }
}
