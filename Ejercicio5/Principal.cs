using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Principal : Form
    {
        private Agenda agenda = null;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn;
            int x = 140;
            int y = 150;

            for (int i = 1; i <= 12; i++)
            {
                btn = new Button();

                if (i == 10)
                {
                    btn.Text = "*";
                }
                else if (i == 11)
                {
                    btn.Text = "0";
                }
                else if (i == 12)
                {
                    btn.Text = "#";
                }
                else
                {
                    btn.Text = i.ToString();
                }

                btn.Name = "btn" + btn.Text;
                btn.Location = new Point(x, y);
                btn.Size = new Size(50, 50);

                // No entiendo por qué con un nuevo botón si puedo y sin él no funciona
                Button boton = btn;
                bool pulsado = false;
                boton.Click += (senderClick, eClick) =>
                {
                    textBoxTelefono.Text += boton.Text;
                    boton.ForeColor = Color.Pink;
                    pulsado = true;
                };
                boton.MouseEnter += (senderMouseEnter, eMouseEnter) =>
                {
                    if (!pulsado)
                    {
                        boton.ForeColor = Color.Blue;
                    }
                };
                boton.MouseLeave += (senderMouseLeave, eMouseLeave) =>
                {
                    if (!pulsado)
                    {
                        boton.ForeColor = Color.Black;
                    }
                };

                x += 70;

                if (i % 3 == 0)
                {
                    x = 140;
                    y += 70;
                }

                Controls.Add(btn);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '*' || e.KeyChar == '#')
            {
                textBoxTelefono.Text += e.KeyChar;
            }
            else
            {
                textBoxTelefono.Text += "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '*' && e.KeyChar != '#' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Reset()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.ForeColor = Color.Black;
                }

                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String texto = "Este programa crea botones en tiempo de ejecución.\nAutora: Alejandra González Graña.";
            MessageBox.Show(texto, "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxTelefono.Text == "" || textBoxTelefono.Text.Length <= 3 || textBoxTelefono.Text.Length >= 15)
            {
                MessageBox.Show("Introduce un número de teléfono válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GrabarNumero secundario = new GrabarNumero();

            TextBox nombre = null;
            Button aceptar = null;

            foreach (Control control in secundario.Controls)
            {
                if (control is TextBox)
                {
                    nombre = (TextBox)control;
                }

                if (control is Button)
                {
                    aceptar = (Button)control;
                }
            }

            aceptar.Click += (senderClick, eClicK) =>
            {
                if (nombre.Text != "" && textBoxTelefono.Text != "")
                {
                    using (StreamWriter s = new StreamWriter("contactos.txt", true))
                    {
                        s.WriteLine(nombre.Text + ":" + textBoxTelefono.Text);
                    }

                    secundario.Close();
                }
            };

            secundario.ShowDialog();

            labelNombre.Text = nombre.Text;
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agenda != null && agenda.IsDisposed)
            {
                return;
            }

            agenda = new Agenda();

            TextBox visor = null;

            foreach (Control control in agenda.Controls)
            {
                if (control is TextBox)
                {
                    visor = (TextBox)control;
                }
            }

            if (File.Exists("contactos.txt"))
            {
                string[] lineas = File.ReadAllLines("contactos.txt");

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(':');

                    if (datos.Length == 2)
                    {
                        visor.Text += datos[0].PadRight(20) + datos[1] + Environment.NewLine;
                    }
                }
            }

            agenda.FormClosed += (senderClosed, eClosed) =>
            {
                agenda = null;
            };

            agenda.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
