using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RgbToGrayscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(RgbToGrayscale.Properties.Resources.lena);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    int grayScale = (color.R + color.G + color.B) / 3;

                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    
                    bitmap.SetPixel(i, j, newColor);
                }
            }

            pictureBox2.Image = bitmap;
        }
    }
}
