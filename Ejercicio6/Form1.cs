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

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        private List<string> imagenes = new List<string>();
        private int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog carpeta = new FolderBrowserDialog())
                {
                    carpeta.Description = "Selecciona una carpeta de imágenes";

                    if (carpeta.ShowDialog() == DialogResult.OK)
                    {
                        string ruta = carpeta.SelectedPath;
                        lblDirectorio.Text = "Directorio actual: " + ruta;

                        foreach (Control control in panelImgs.Controls)
                        {
                            if (control is PictureBox pb)
                            {
                                pb.Image?.Dispose();
                            }

                            control.Dispose();
                        }

                        panelImgs.Controls.Clear();
                        imagenes.Clear();
                        indice = 0;
                        pbImg.Image?.Dispose();
                        pbImg.Image = null;

                        string[] archivos = Directory.GetFiles(ruta);

                        foreach (string archivo in archivos)
                        {
                            string extension = Path.GetExtension(archivo).ToLower();

                            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                            {
                                PictureBox pb = new PictureBox();

                                pb.Size = new Size(80, 80);
                                pb.SizeMode = PictureBoxSizeMode.Zoom;
                                pb.Margin = new Padding(10);
                                pb.BorderStyle = BorderStyle.FixedSingle;
                                pb.Tag = archivo;
                                pb.Click += Miniatura_Click;

                                using (Image imagen = Image.FromFile(archivo))
                                {
                                    pb.Image = new Bitmap(imagen);
                                }

                                imagenes.Add(archivo);
                                panelImgs.Controls.Add(pb);
                            }
                        }

                        if (imagenes.Count > 0)
                        {
                            indice = 0;
                            MostrarImagen();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la carpeta: " + ex.Message);
            }
        }

        private void MostrarImagen()
        {
            if (imagenes.Count > 0)
            {
                pbImg.Image?.Dispose();

                using (Image imagen = Image.FromFile(imagenes[indice]))
                {
                    pbImg.Image = new Bitmap(imagen);
                }

                this.Text = "Visor de imágenes: " + Path.GetFileName(imagenes[indice]);

                MostrarDatos();
            }
        }

        public void MostrarDatos()
        {
            if (imagenes.Count > 0)
            {
                string ruta = imagenes[indice];

                FileInfo archivo = new FileInfo(ruta);

                double tamaño = archivo.Length / 1024.0;
                string unidad = " KB";

                if (tamaño >= 1024)
                {
                    tamaño = tamaño / 1024;
                    unidad = " MB";
                }

                using (Image imagen = Image.FromFile(ruta))
                {
                    lblDatos.Text = "Nombre: " + Path.GetFileName(ruta) + "\nTamaño: " + tamaño.ToString("0.00") + unidad + "\nResolución: " + imagen.Width + " x " + imagen.Height + " píxeles";
                }
            }
            else
            {
                lblDatos.Text = "";
            }
        }

        private void Retroceso()
        {
            if (imagenes.Count > 0)
            {
                indice--;

                if (indice < 0)
                {
                    indice = imagenes.Count - 1;
                }

                MostrarImagen();
            }
        }

        private void Avance()
        {
            if (imagenes.Count > 0)
            {
                indice++;

                if (indice >= imagenes.Count)
                {
                    indice = 0;
                }

                MostrarImagen();
            }
        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            Avance();
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            Retroceso();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Retroceso();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Avance();
            }
        }

        private void Miniatura_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string ruta = pb.Tag.ToString();
            indice = imagenes.IndexOf(ruta);
            MostrarImagen();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "CERRAR PROGRAMA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
