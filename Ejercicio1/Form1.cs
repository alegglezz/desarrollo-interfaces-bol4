namespace Ejercicio1
{
    public partial class Form1 : Form //TODO revisar soltar un solo boton del ratón. + LAMBDAS
    {
        public Form1()
        {
            InitializeComponent();
            generarBotones();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

            if (sender.GetType() == typeof(Button))
            {
                x += ((Button)sender).Location.X;
                y += ((Button)sender).Location.Y;
            }

            Text = String.Format("X: {0,5}, Y:{1,5}", x, y);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Pink;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Pink;
            }
            else
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.FromArgb(255, 225, 225, 225);
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.FromArgb(255, 225, 225, 225);
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 225, 225, 225);
                button2.BackColor = Color.FromArgb(255, 225, 225, 225);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Text = "Mouse Tester";
            }
            else
            {
                Text = e.KeyCode.ToString();
            }
        }

        private void generarBotones()
        {
            Button button;

            int text = 1;
            int xpoint = 35;
            int ypoint = 135;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    button = new Button();

                    button.Location = new Point(xpoint, ypoint);
                    button.Name = "btn" + i.ToString();
                    button.Size = new Size(75, 25);
                    button.Text = text.ToString();
                    button.MouseDown += (sender, e) => ((Button)sender).ForeColor = Color.Red;
                    
                    button.MouseUp += (sender, e) =>
                    {
                        ((Button)sender).ForeColor = Color.Black;
                    };
                    button.MouseMove += Form1_MouseMove;

                    Controls.Add(button);

                    xpoint += 80;
                    text++;
                }

                xpoint = 35;
                ypoint += 30;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "EJERCICIO 1", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
