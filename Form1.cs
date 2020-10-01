using Ejercicio8.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Ejercicio8 : Form
    {
        public static Random rnd = new Random();
        PictureBox ImageHolder;
        public int t1;
        public int t2;
        public int turno;
        public int[] pares = new int[16];

        public Ejercicio8()
        {
            InitializeComponent();

            GenerarPares();
        }

        public void GenerarPares()
        {
            int i = 0;
            while (i < pares.Length)
            {
                int aux = rnd.Next(9);
                if (aux == 0)
                {
                    aux = 1;
                }

                if (pares.Contains(aux))
                {
                    int contador = 0;
                    for (int j = 0; j < 16; j++)
                    {
                        if (pares[j] == aux)
                        {
                            contador++;
                        }
                    }

                    if (contador == 1)
                    {
                        pares[i] = aux;
                        i++;
                    }
                }
                else
                {
                    pares[i] = aux;
                    i++;
                }
            }
        }

        private void ValidadPares(PictureBox pb, int numPos)
        {
            Graphics p;
            p = pb.CreateGraphics();
            if (pares[numPos] == 8)
                pb.Image = Resources.bey;

            if (pares[numPos] == 1)
                pb.Image = Resources.britney;


            if (pares[numPos] == 2)
                pb.Image = Resources.kp;

            if (pares[numPos] == 3)
                pb.Image = Resources.lg;

            if (pares[numPos] == 4)
                pb.Image = Resources.kylie;

            if (pares[numPos] == 5)
                pb.Image = Resources.donna;

            if (pares[numPos] == 6)
                pb.Image = Resources.rih;

            if (pares[numPos] == 7)
                pb.Image = Resources.xtina;

            if (this.turno == 0)
            {
                this.t1 = pares[numPos];
                ImageHolder = pb;
                turno = 1;
            }
            else
            {
                this.t2 = pares[numPos];
                if (this.t1 == this.t2)
                {
                    //MessageBox.Show("Son iguales");
                }
                else
                {
                    MessageBox.Show("No son iguales");
                    pb.Image = null;
                    ImageHolder.Image = null;
                }
                turno = 0;
            }
        }

        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox1, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox2, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox3, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox4, 3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox5, 4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox6, 5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox7, 6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox8, 7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox9, 8);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox10, 9);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox11, 10);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox12, 11);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox13, 12);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox14, 13);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox15, 14);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ValidadPares(pictureBox16, 15);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio8 Reiniciar = new Ejercicio8();
            Reiniciar.Show();
        }
    }
}
