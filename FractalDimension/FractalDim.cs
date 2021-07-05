using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace FractalDimension
{
    public static class FractalDim
    {

        // a = F^(-1) * b 
        // ln(N) = D * ln(1/length) + const, где - число квадратов, содержащих фрактал, а length - длина стороны квадрата (разрешение)
        // Dimension (D) = a[1] - тангенс наклона прямой
        // 10 100 100 = 1,29081652
        // 9 100 100 =  1,26962306
        // 9 100 200 =  1,23880202
        // 10 100 200 = 1,20148566
        // 20 50 100 =  1.68239269
        // 5 200 100 =  1.87607837
        // 10 200 200 = 1.50709
        // 20 100 100 = 1.3961984
        // 10 200 50  = 1.5235720
        static int step_num = 10;
        static int step_size = 100;
        static int start_sq = 1000;
        static Color frac_color = Color.Black;  // Цвет фрактала
        static Bitmap bmp;
        static double [] true_squares; // ln(N)
        static double[] resolution; // ln(1/length)

        public static int Step_Number
        {
            get { return step_num; }
            set { if (value > 0) step_num = value; }
        }
        public static int Step_Size
        {
            get { return step_size; }
            set { if (value > 0) step_size = value; }
        }
        public static int Start_Number_of_Squares
        {
            get { return start_sq; }
            set { if (value > 0) start_sq = value; }
        }
        public static Bitmap Fractal_Image
        {
            get { return bmp; }
            set 
            { 
                if (value != null) 
                { 
                    if (bmp != null) bmp.Dispose();
                    Rectangle rect = new Rectangle(0, 0, value.Width, value.Height);
                    System.Drawing.Imaging.PixelFormat format = value.PixelFormat;
                    bmp = value.Clone(rect, format);
                   
                }
            }
        }
        public static Color Fractal_Color
        {
            get { return frac_color; }
            set { if (value != null) frac_color = value; }
        }



        public static double Dimenshion() 
        {
            
            if (bmp == null) { MessageBox.Show("Изображение фрактала отсутствует"); return 0.0; }
            Picture_Analisis();
            double[,] F = new double [2,2];
            F[0, 0] = 1 + step_num; 
            double[] b = new double[2];
            for (int i = 0; i < resolution.Length; i++)
            {
                F[1, 0] += resolution[i];
                F[0, 1] += resolution[i];
                F[1, 1] += resolution[i]*resolution[i];
                b[0] += true_squares[i];
                b[1] += true_squares[i] * resolution[i];
            }
            return Linear_regression(F, b); 
        }
        static void Picture_Analisis()
        {
            if (bmp == null) return;
            true_squares = new double[step_num + 1];
            resolution = new double[step_num + 1];
            int sq_size_stand;
            int sq_size_hor;
            int sq_size_ver;
            int sq_num = start_sq;
            int N;
            int bytes;
            int ost_hor;
            int ost_ver;
            Rectangle rect;
            Bitmap _bmp;

            int add_k;
            switch (bmp.PixelFormat)
            {
                case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                    { add_k = 3; break; }
                default: { add_k = 4; break; }
            }

            for (int i = 0; i <= step_num; i++)
            {
                N = 0;
                sq_num += step_size * i;
                sq_size_stand = (int)Truncate(Sqrt(bmp.Width * bmp.Height / sq_num));
                ost_hor = -1; // остаток пикселей, которые не захватит сетка заданного размера
                ost_ver = -1;
                if (bmp.Width % sq_size_stand > 0) ost_hor += bmp.Width % sq_size_stand;
                if (bmp.Height % sq_size_stand > 0) ost_ver += bmp.Height % sq_size_stand;

                for (int v = 0; v < Truncate((double)bmp.Height / sq_size_stand) ; v++)
                {
                    if (v + 1 >= Truncate((double)bmp.Height / sq_size_stand)) sq_size_hor = sq_size_stand + ost_hor;
                    else sq_size_hor = sq_size_stand;
                    for (int h = 0; h < Truncate((double)bmp.Width / sq_size_stand); h++)
                    {
                        // последние ряд и колонка имеет увеличенные клетки, чтобы захватить остаток пикселей
                         if (h +1 >= Truncate((double)bmp.Width / sq_size_stand)) sq_size_ver = sq_size_stand + ost_ver;
                        else sq_size_ver = sq_size_stand;

                        rect = new Rectangle(h * sq_size_stand, v * sq_size_stand, sq_size_hor, sq_size_ver);
                        _bmp = bmp.Clone(rect,bmp.PixelFormat);
                        System.Drawing.Imaging.BitmapData bmpData = _bmp.LockBits(new Rectangle(0,0,_bmp.Width, _bmp.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, _bmp.PixelFormat);
                        IntPtr ptr = bmpData.Scan0;
                        bytes = Abs(bmpData.Stride) * _bmp.Height;
                        byte[] rgbValues = new byte[bytes];
                        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                        for (int k = 2; k < rgbValues.Length; k += add_k)

                        {
                            // проверка совпадения цвета пикселя и цвета фрактала
                            // разница не равна 0, т.к. цвет фрактала может немного варьироваться (например на JPG изображениях)
                            if
                           (Abs((int)frac_color.B - (int)rgbValues[k - 2]) < 20 &&
                            Abs((int)frac_color.G - (int)rgbValues[k - 1]) < 20 &&
                            Abs((int)frac_color.R - (int)rgbValues[k]) < 20)
                            {

                                //if (i == step_num)
                                //{
                                //    for (int pp = 2; pp < rgbValues.Length; pp += add_k)
                                //    {
                                //        rgbValues[pp - 2] = 255;
                                //        rgbValues[pp - 1] = 0;
                                //        rgbValues[pp] = 0;
                                //        //rgbValues[k + 1] = 100;

                                //        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
                                //    }
                                //}

                                N += sq_size_hor*sq_size_ver/(sq_size_stand*sq_size_stand) ;
                                break;
                            }
                        }
                        _bmp.UnlockBits(bmpData);
                        _bmp.Dispose();
                  
                    }
                }

                true_squares[i] = Log(N);
                resolution[i] = - Log(Sqrt(bmp.Width * bmp.Height / sq_num));

            }

        }
        static double Linear_regression(double[,] F, double[] b)
        {
            F = Invert_Matrix(F);
            double[] a = new double[2];
            a = Multiply_Matrix(F, b);
            return a[1];
        }
        static private double[,] Invert_Matrix(double [,] F) // обращение матрицы 2х2
        {
            if (F.GetUpperBound(0) != F.GetUpperBound(1)) throw new Exception("Матрица, полученная методом Invert_Matrix, не является квадратной");
            double[,] F_inv = {{1, 0}, {0, 1}};
            double def = F[0, 0] * F[1, 1] - F[0, 1] * F[1, 0]; // определитель
            if (def == 0) throw new Exception("Определитель матрицы, полученной методом Invert_Matrix, равен 0");

            for (int i = 0; i < 2; i++) // Обращение методом Гаусса 
            {
                double a  = F[i, i];
                for (int j = 0; j < 2; j++)
                {
                    F[i, j] /= a;
                    F_inv[i, j] /= a;                
                }
                for (int k = 0; k < 2; k++)
                {
                    a = F[k, i];
                    if (k != i)
                        for (int j = 0; j < 2; j++)
                        {
                            
                            F[k, j] -= a*F[i,j];
                            F_inv[k, j] -= a * F_inv[i, j];
                        }
                }
            }

            return F_inv;
        }
        static private double[] Multiply_Matrix(double[,] F, double[] b) // Умножение матрицы 2x2 на вектор 2x1
        {
            double[] a = {0, 0};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i] += F[i, j] * b[j];
                }
            }
            return a;
        }
    }
}
