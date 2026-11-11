namespace Ejercicio2  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el formulario?", "EJERCICIO 2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            bool valido1 = int.TryParse(txtBoxRojo.Text, out int txb1);
            bool valido2 = int.TryParse(txtBoxVerde.Text, out int txb2);
            bool valido3 = int.TryParse(txtBoxAzul.Text, out int txb3);

            if (!valido1 || !valido2 || !valido3 || txb1 < 0 || txb1 > 255 || txb2 < 0 || txb2 > 255 || txb3 < 0 || txb3 > 255)
            {
                lblErrorColor.Text = "Los valores introducidos no son válidos para RGB (0-255)";
            }
            else
            {
                lblErrorColor.Text = "";

                this.BackColor = Color.FromArgb(txb1, txb2, txb3);
            }
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            String path = txtBoxPath.Text;

            if (!String.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                try
                {
                    picBoxImagen.Image = Image.FromFile(path); 
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("El archivo no es una imagen válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("No se encontró el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("La ruta no es válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("El archivo no es una imagen válida.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró la ruta especificada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxColor_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }

        private void textBoxPath_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnIntroducir;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).Name == txtBoxPath.Name)
                    {
                        txtBoxPath.Text = "";
                    }
                    else
                    {
                        ((TextBox)control).Text = "0";
                    }
                }
            }

            this.BackColor = SystemColors.Control;
            picBoxImagen.Image = null;
        }

        private void Buttons_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Pink;
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Control;
        }
    }
}
