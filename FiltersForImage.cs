using System;
using System.Drawing;

namespace _2c_Lab4
{
    class FiltersForImage
    {
        /// <summary>
        /// Converting a color image to grayscale.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns>Bitmap</returns>
        public static Bitmap GrayFilter(Bitmap bitmap)
        {
            Bitmap result = (Bitmap)bitmap.Clone();
            Color color;
            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    color = result.GetPixel(x, y);
                    byte r = color.R,
                         g = color.G,
                         b = color.B;
                    byte averageSample = (byte)((r + g + b) / 3);
                    result.SetPixel(x, y, Color.FromArgb(color.A, averageSample, averageSample, averageSample));
                }
            }
            return result;
        }

        /// <summary>
        /// Sawtooth Contrasting Scaling.
        /// </summary>
        /// <param name="bitmap">Grayscale image</param>
        /// <param name="number_peaks">The number of peaks of the "saw" set by the user</param>
        /// <returns>Bitmap</returns>
        public static Bitmap СontrastScaling(Bitmap bitmap, int number_peaks)
        {
            Bitmap result = (Bitmap)bitmap.Clone();
            Color currentColorPixel;
            if (number_peaks != 0)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    for (int y = 0; y < result.Height; y++)
                    {
                        currentColorPixel = result.GetPixel(x, y);
                        byte channelValueR = currentColorPixel.R;
                        double colorValueRange = (255 / number_peaks);
                        byte dl = (byte)(Math.Floor(channelValueR / colorValueRange) * colorValueRange);
                        //we translate the color value into the range for the peak of the saw
                        byte newValueChannel = (byte)((channelValueR - dl) * number_peaks);//sawtooth converted color
                        result.SetPixel(x, y, Color.FromArgb(currentColorPixel.A, newValueChannel, newValueChannel, newValueChannel));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Filter for superimposing noise Gaussian.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="dispersion">The intensity of the noise that the user enters.</param>
        /// <returns>Bitmap</returns>
        public static Bitmap AddSpeckleNoise(Bitmap bitmap, float dispersion)
        {
            Bitmap res = (Bitmap)bitmap.Clone();
            Random rnd = new Random();
            Color color, new_color;
            var deviation = Math.Sqrt(dispersion/100);
            for (int x = 0; x < res.Width; x++)
            {
                for (int y = 0; y < res.Height; y++)
                {
                    color = res.GetPixel(x, y);
                    double noise = (rnd.NextDouble() - 0.5f) * 2 * deviation;
                    int r = (int)(color.R + noise * color.R), 
                        g = (int)(color.G + noise * color.G), 
                        b = (int)(color.B + noise * color.B);
                    new_color = ValidatingValue(r, g, b);
                    res.SetPixel(x,y,new_color);
                }
            }
            return res;
        }

        /// <summary>
        /// Checking RGB channel values ​​in the range from 0 to 255.
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns>Color</returns>
        private static Color ValidatingValue(int r, int g, int b)
        {
            int r1 = r > 255 ? 255 : r < 0 ? 0 : r;
            int g1 = g > 255 ? 255 : g < 0 ? 0 : g;
            int b1 = b > 255 ? 255 : b < 0 ? 0 : b;
            return Color.FromArgb(r1, g1, b1);
        }

        /// <summary>
        /// Function works with image brightness.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="brightnessValue">If the values ​​are positive, then the image becomes lighter, otherwise it is darker</param>
        /// <returns>Bitmap</returns>
        public static Bitmap ImageBrightness(Bitmap bitmap, int brightnessValue)
        {
            Bitmap result = (Bitmap)bitmap.Clone();
            Color color, new_color;
            byte lengthTrackBar = 100;//valid range of values ​​that the user can enter
            brightnessValue = 255 / lengthTrackBar * brightnessValue;//we convert from a 100 point scale to 255
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    color = result.GetPixel(x, y);
                    int newRChannelValue = color.R + brightnessValue * 128 / 100;
                    int newGChannelValue = color.G + brightnessValue * 128 / 100;
                    int newBChannelValue = color.B + brightnessValue * 128 / 100;
                    new_color = ValidatingValue(newRChannelValue, newGChannelValue, newBChannelValue);
                    result.SetPixel(x, y, new_color);
                }
            }
            return result;
        }

        /// <summary>
        /// Method implements mask filtering.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="matrix_mask">Сonvolution kernel</param>
        /// <returns>Bitmap</returns>
        public static Bitmap Convolution(Bitmap bitmap, int[,] matrix_mask)
        {
            Bitmap result = (Bitmap)bitmap.Clone();
            Bitmap bmp = (Bitmap)bitmap.Clone();
            byte n = 1;//The number of "layers" included in the pixel environment
            Color color, new_color;
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    int r = 0, g = 0, b = 0;
                    for (int i = 0; i <= n + 1; i++)
                        for (int j = 0; j <= n + 1; j++)
                        {
                            int a = x + i - 1, d = y + j - 1;
                            if (x == 0|| y == 0 || x == result.Width - 1 || y == result.Height - 1)//It needs to be redone, because it works for a very long time
                            {   
                                Point point = Check(result.Height,result.Width,x,y);
                                a = point.X;
                                d = point.Y;
                            }
                            color = bmp.GetPixel(a,d);
                            r += matrix_mask[i, j] * color.R;
                            g += matrix_mask[i, j] * color.G;
                            b += matrix_mask[i, j] * color.B;
                        }
                    new_color = ValidatingValue(r, g, b);
                    result.SetPixel(x, y, new_color);
                }
            }
            return result;
        }

        /// <summary>
        /// Boundary pixel check method. 
        /// Used in mask filtration.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="x">the x coordinate of the current pixel of the original image</param>
        /// <param name="y">the y coordinate of the current pixel of the original image</param>
        /// <returns></returns>
        private static Point Check(int height,int width, int x ,int y)
        {
            Point point = new Point();
            if (x < 0 && y < 0)
            {
                point.X = 1;
                point.Y = 1;
                return point;
            }
            else if (x < 0)
            {
                point.X = 1;
                return point;
            }
            else if (y < 0)
            {
               point.Y = 1;
                return point;
            }

            if (x == width && y == height)
            {
                point.X = width - 2;
                point.Y = height - 2;
                return point;
            }
            else if (x == width)
            {
                point.X = width - 2;
                return point;
            }
            else if (y == height)
            {
                point.Y = height - 2;
                return point;
            }
            else
                return point;
        }

        /// <summary>
        /// Create mirror image.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns>Bitmap</returns>
        public static Bitmap MirrorReflection(Bitmap bitmap)
        {
            Bitmap result = (Bitmap)bitmap.Clone();
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    result.SetPixel(result.Width - x - 1, y, color);
                }
            }
            return result;
        }

        /// <summary>
        /// Image binarization.
        /// Creating a black and white image.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns>Bitmap(black and white image)</returns>
        public static Bitmap bynaryImage(Bitmap bitmap)
        {
            Color clr;
            Bitmap bmp = (Bitmap)bitmap.Clone();
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    clr = bmp.GetPixel(x, y);
                    if (clr.R < 120) bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return bmp;
        }
    }
}
