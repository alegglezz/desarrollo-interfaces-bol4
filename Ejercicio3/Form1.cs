namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {
            // Creamos el cuadro de diálogo para seleccionar archivos.
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Title = "Seleccionar imagen";
            // Mostramos los archivos JPG, JPEG y PNG
            abrirImagen.Filter = "Imágenes|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";
            abrirImagen.Multiselect = false;

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                Form2 f = new Form2(abrirImagen.FileName);

                if (f.imagenValida)
                {
                    if (ckbModal.Checked)
                    {
                        f.ShowDialog();
                    }
                    else
                    {
                        f.Show();
                    }
                }
                else
                {
                    f.Dispose();
                }
            }

            abrirImagen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int segundos = 0;
        private int minutos = 0;

        private void timerTitulo_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos % 60 == 0)
            {
                minutos++;
                segundos = 0;
            }

            this.Text = "Visor de imágenes " + minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        private void ckbModal_CheckedChanged(object sender, EventArgs e)
        {
            ckbModal.ForeColor = ckbModal.Checked ? Color.Red : Color.Black;
        }
    }
}