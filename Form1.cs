using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2c_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap bitmap;

        private void buttunOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bitmap = new Bitmap(ofd.FileName);
                    pictureBox1.Image = bitmap;
                    MessageBox.Show("To work with an image, click on it, \n and then select the desired actions by clicking on the buttons");
                }
                catch
                {
                   MessageBox.Show("The selected file cannot be opened\nThe file must be with the extension: .bmp .png .jpg",
                       "Exception",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
       
        private void buttonNoise_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            trackBar1.Enabled = buttonNoise.Enabled = false;
            pictureBox4.Image = FiltersForImage.AddSpeckleNoise(bitmap, trackBar1.Value);
            trackBar1.Enabled = buttonNoise.Enabled = true;
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonGray.Enabled = false;
            pictureBox2.Image = FiltersForImage.GrayFilter(bitmap);
            buttonGray.Enabled = true;
        }

        private void buttonContrastSaw_Click(object sender, EventArgs e)
        {
            if(bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonContrastSaw.Enabled = false;
            pictureBox3.Image = FiltersForImage.СontrastScaling(bitmap, trackBar2.Value);
            buttonContrastSaw.Enabled = true;
        }

        private void buttonDefiningBoundaries_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                    "If there is no image, then upload it by clicking the <open image>",
                    "Error: no image selected",
                    MessageBoxButtons.OK
                    );
                return;
            }
            buttonDefiningBoundaries.Enabled = false;
            int[,] mask = new[,] {
                { 0, -1, 0 },
                { -1, 4, -1 },
                { 0, -1, 0 } };
            pictureBox3.Image = FiltersForImage.Convolution(bitmap, mask);
            buttonDefiningBoundaries.Enabled = true;
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonBrightness.Enabled = false;
            pictureBox4.Image = FiltersForImage.ImageBrightness(bitmap, trackBar3.Value);
            buttonBrightness.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)pictureBox4.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           toolTip1.SetToolTip(trackBar1, "Set the value using the slider(range: from 0 to 100)\n and then press the button <add noise>!");
           toolTip2.SetToolTip(trackBar2, "Set the value using the slider(range: from 0 to 20)\n and then press the button <contrast (saw)>!");
           toolTip3.SetToolTip(trackBar3, "Set the value using the slider(default is 0, right + values, left - values, range: from -100 to 100)\n" +
               " and then press the button <brightness>!");
           toolTip4.SetToolTip(trackBar4, "Set the value using the slider(range: from 0 to 500"+ 
               "\nRegulates the number of local max found in the Hough space");
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonContrast.Enabled = false;
            int [,] kernel = new int[,]
                              {{0, -1, 0},
                              {-1, 5, -1},
                              {0, -1, 0}};
            pictureBox3.Image = FiltersForImage.Convolution(bitmap, kernel);
            buttonContrast.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            bitmap = (Bitmap)pictureBox1.Image;
        }

        private void buttonReflection_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonReflection.Enabled = false;
            pictureBox4.Image = FiltersForImage.MirrorReflection(bitmap);
            buttonReflection.Enabled = true;
        }

        private void buttonHough_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonHough.Enabled = false;
            Bitmap bmp = FiltersForImage.bynaryImage(bitmap);
            pictureBox4.Image = HoughTransform.Hough(bmp,trackBar4.Value);
            buttonHough.Enabled = true;
        }

        private void buttonBinaryImage_Click(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                MessageBox.Show("Select an image to work with.(By clicking on it)\n " +
                   "If there is no image, then upload it by clicking the <open image>",
                   "Error: no image selected",
                   MessageBoxButtons.OK
                   );
                return;
            }
            buttonBinaryImage.Enabled = false;
            pictureBox2.Image =  FiltersForImage.bynaryImage(bitmap);
            buttonBinaryImage.Enabled = true;
        }
    }
}