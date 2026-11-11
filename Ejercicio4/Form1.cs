namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            ActualizarToolTip();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Trim() != "" && !lsMulti.Items.Contains(txtBox.Text.Trim()))
            {
                lsMulti.Items.Add(txtBox.Text.Trim());
                ActualizarEtiquetas();
            }
        }

        private void rbLista1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                btnQuitar.Text = "Quitar de 1";
            }
        }

        private void rbLista2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLista2.Checked)
            {
                btnQuitar.Text = "Quitar de 2";
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                for (int i = lsMulti.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lsMulti.Items.RemoveAt(lsMulti.SelectedIndices[i]);
                    ActualizarEtiquetas();
                }
            }
            else if (rbLista2.Checked)
            {
                lsUnica.Items.Remove(lsUnica.SelectedItem);
            }

            ActualizarToolTip();
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if (rbTraspaso12.Checked)
            {
                for (int i = 0; i < lsMulti.SelectedIndices.Count; i++)
                {
                    lsUnica.Items.Add(lsMulti.SelectedItems[i]);
                }

                for (int i = lsMulti.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lsMulti.Items.RemoveAt(lsMulti.SelectedIndices[i]);
                    ActualizarEtiquetas();
                }
            }
            else if (rbTraspaso21.Checked)
            {
                if (lsUnica.SelectedItem != null)
                {
                    lsMulti.Items.Add(lsUnica.SelectedItem);
                    lsUnica.Items.Remove(lsUnica.SelectedItem);
                    ActualizarEtiquetas();
                }
            }

            ActualizarToolTip();
        }

        private void rbTraspaso12_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraspaso12.Checked)
            {
                btnTraspasar.Text = "Traspaso 1-2";
            }
        }

        private void rbTraspaso21_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraspaso21.Checked)
            {
                btnTraspasar.Text = "Traspaso 2-1";
            }
        }

        private void ActualizarEtiquetas()
        {
            lblElementosLista1.Text = "ELEMENTOS LISTA 1:   " + lsMulti.Items.Count;

            int indicesSeleccionados = 0;

            foreach (int indice in lsMulti.SelectedIndices)
            {
                indicesSeleccionados++;
            }

            lblIndicesLista1.Text = "ÍNDICES SELECCIONADOS LISTA 1:   " + indicesSeleccionados;
        }

        private void lsMulti_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEtiquetas();
        }

        private static string titulo = "EJERCICIO 4";
        private int posicion = titulo.Length - 1;
        private bool icono = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = titulo.Substring(posicion);
            posicion--;

            if (icono)
            {
                this.Icon = Properties.Resources.hello_kitty;
            }
            else
            {
                this.Icon = Properties.Resources.hello_kitty2;
            }

            if (posicion < 0)
            {
                posicion = titulo.Length - 1;
            }

            icono = !icono;
        }

        public void ActualizarToolTip()
        {
            int contadorLsUnica = lsUnica.Items.Count;
            string mensajeToolTip = "ELEMENTOS LISTA 2: " + contadorLsUnica.ToString();
            toolTipLista.SetToolTip(lsUnica, mensajeToolTip);
        }
    }
}