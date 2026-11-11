using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Func<double, double, double>> operaciones;
        private Func<double, double, double> operacion;

        public Form1()
        {
            InitializeComponent();

            operaciones = new Dictionary<string, Func<double, double, double>>(){
            { "+", (a, b) => a + b },
            { "-", (a, b) => a - b },
            { "*", (a, b) => a * b },
            { "/", (a, b) => a / b }
            };
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                lblOperacion.Text = rb.Text;
                operacion = operaciones[rb.Text];
            }
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (double.TryParse(txt.Text, out double numero))
            {
                txt.BackColor = Color.White;
            }
            else
            {
                txt.BackColor = Color.LightCoral;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(textBoxOp1.Text, out num1) ||
                !double.TryParse(textBoxOp2.Text, out num2))
            {
                return;
            }

            if (operacion == null)
            {
                return;
            }

            if (lblOperacion.Text == "/" && num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = operacion(num1, num2);

            MessageBox.Show("El resultado es: " + resultado, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }
}
