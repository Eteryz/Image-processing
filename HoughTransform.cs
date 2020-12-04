using System;
using System.Drawing;

namespace _2c_Lab4
{
    class HoughTransform
    {
        /// <summary>
        /// The method determines straight lines in the image using the Hough transform. Best used on shapes
        /// </summary>
        /// <param name="bitmap">binary image</param>
        /// <param name="determination_accuracy">number of points selected in Hough space(from 0 and beyond)</param>
        /// <returns>Bitmap</returns>
        public static Bitmap Hough(Bitmap bitmap, int determination_accuracy)
        {
            Bitmap res = (Bitmap)bitmap.Clone();
            int r_max = (int) Math.Sqrt(Math.Pow(bitmap.Width, 2) + Math.Pow(bitmap.Height, 2)) + 1;
            int q_max = 361;
            int[,] arr = new int[r_max,q_max];
            int[,] arrDraw = new int[r_max, q_max];

            //Creating a Hough space. 
            for (int x = 0; x < res.Width; x++)
            {
                for (int y = 0; y < res.Height; y++)
                {
                    if (res.GetPixel(x, y) == Color.FromArgb(0,0,0))
                    {
                        for (int j_q = 0; j_q < q_max; j_q ++)
                        {
                           int i_r =  (int)(x * Math.Cos(j_q * Math.PI / 180 ) + y * Math.Sin(j_q * Math.PI / 180));
                           if(i_r>0)
                            arr[i_r, j_q] ++; //Draw sinusoids using the example of an array (increment the cell where the sinusoid passes)
                        }
                    }
                }
            }

            //Search for local max
            int r = 0, q = 0, curMax = 0;
            for (int k = 0; k <= determination_accuracy; k++)
            {
                for (int i_r = 0; i_r < r_max; i_r++)
                {
                    for (int j_q = 0; j_q < q_max; j_q++)
                    {
                        if (arr[i_r, j_q] > curMax)
                        {
                            curMax = arr[i_r, j_q];
                            r = i_r;
                            q = j_q;
                        }
                    }
                }

                arr[r, q] = 0;
                arrDraw[r, q] = curMax;//The maxima are entered into a separate array
                curMax = 0;

            }

            //Find the parameters x and y in the Cartesian coordinate system
            for (int i_r = 0; i_r < r_max; i_r++)
            {
                for (int j_q = 0; j_q < q_max; j_q++)
                {
                    if (arrDraw[i_r, j_q] != 0)
                    {
                        for (int x = 0; x < res.Width; x++)
                        {
                            int y = (int)((i_r - x * Math.Cos(j_q * Math.PI / 180)) / Math.Sin(j_q * Math.PI / 180));
                            if (y > 0 && y < res.Height)
                            {
                                res.SetPixel(x, y, Color.Red);
                            }
                        }
                        for (int y = 0; y < res.Height; y++)
                        {
                            int x = (int)((i_r - y * Math.Sin(j_q * Math.PI / 180)) / Math.Cos(j_q * Math.PI / 180));
                            if (x > 0 && x < res.Width)
                            {
                                res.SetPixel(x, y, Color.Red);
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
