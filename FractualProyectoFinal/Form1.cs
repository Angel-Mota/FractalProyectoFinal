using System;

namespace FractualProyectoFinal
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           DrawMandelbrot();
        }
        private void DrawMandelbrot()
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            bmp = new Bitmap(width, height);
            for (int xc = 0; xc < width; xc++)
            {
                for (int yc = 0; yc < height; yc++)
                {
                    double nReal = (xc - width / 3d) * 4d / (width * 7d);
                    double nImaginario = (yc - height / -1d) * 4d / (height * 7d);
                    double x = 0;
                    double y = 0;
                    int iteraciones = 0;

                    while (iteraciones < 5000 && (x * x + y * y) < 4)
                    {
                        double xtemp = (x * x) - (y * y) + nReal;
                        y = 2d * x * y + nImaginario;
                        x = xtemp;
                        iteraciones++;

                    }

                    if (iteraciones >= 0 && iteraciones < 750)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(4 * iteraciones % 255, iteraciones % 3 * 30, 50));
                    }

                    else if (iteraciones >= 750 && iteraciones < 1500)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(100, iteraciones * 3 % 50, iteraciones % 255));
                    }

                    else if (iteraciones >= 1500 && iteraciones < 2250)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(iteraciones * 4 % 255, iteraciones % 247, iteraciones % 237));
                    }

                    else if (iteraciones >= 2250 && iteraciones < 3000)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(iteraciones % 255, 77, 0));
                    }

                    else if (iteraciones >= 3000 && iteraciones < 3750)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(255, iteraciones % 2 * 255, 3 * iteraciones % 255));
                    }

                    else if (iteraciones >= 3750 && iteraciones < 4500)
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(4 * iteraciones % 255, iteraciones % 3 * 30, 50));
                    }

                    else
                    {
                        bmp.SetPixel(xc, yc, Color.FromArgb(iteraciones % 18, iteraciones % 37, iteraciones % 177));
                    }
                }

            }
            pictureBox1.Image = bmp;
        }
    }
}