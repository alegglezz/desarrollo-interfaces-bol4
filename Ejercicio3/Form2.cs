using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public bool imagenValida = false;

        public Form2(string rutaImagen)
        {
            InitializeComponent();

            try
            {
                this.Text = Path.GetFileName(rutaImagen);

                pbxImg.Image = Image.FromFile(rutaImagen);
                imagenValida = true;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is OutOfMemoryException || ex is FileNotFoundException || ex is UnauthorizedAccessException || ex is IOException || ex is System.Runtime.InteropServices.ExternalException)
            {
                imagenValida = false;

                MessageBox.Show("No se ha podido cargar la imagen: \n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajustarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbxImg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noAjustarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbxImg.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
