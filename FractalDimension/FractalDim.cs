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
        
        static Color frac_color = Color.Black;  // Цвет фрактала
        static Bitmap bmp;
        static double [] true_squares = new double[14]; // ln(N)
        readonly static byte[] resolution = new byte[14]; // length
        

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

        static FractalDim() 
        {
            for (byte i = 0; i < resolution.Length; i++)
            {
                resolution[i] = (byte)((i + 2) * 2); // От 4 до 30 пикселей с шагом 2
            }
        }

        public static double Dimenshion() 
        {
            
            if (bmp == null) { MessageBox.Show("Изображение фрактала отсутствует"); return 0.0; }
            Picture_Analisis();

            byte step_num = (byte) resolution.Length;
            for (int i = 0; i < resolution.Length; i++)
                if (true_squares[i] <= 0) step_num--; // Поправка для небольших изображений. 
            //Если изображение разбивается меньше, чем на 25 квадратов, точка пропускается

            double[,] F = new double [2,2];
            F[0, 0] = step_num; 
            double[] b = new double[2];
            for (int i = 0; i < step_num; i++)
            {
                F[1, 0] += -Log(resolution[i]);
                F[0, 1] += -Log(resolution[i]);
                F[1, 1] += Log(resolution[i])*Log(resolution[i]);
                b[0] += true_squares[i];
                b[1] += true_squares[i] *(-Log(resolution[i]));
            }
            return Linear_regression(F, b); 
        }
        static void Picture_Analisis()
        {
            if (bmp == null) return;
            if (bmp.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb || bmp.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppRgb) ARGB_to_RGB();
           // MessageBox.Show($"{bmp.PixelFormat}");
           
            byte sq_size_hor;
            byte sq_size_ver;
            float N;
            int bytes;
            sbyte ost_hor;
            sbyte ost_ver;
            Rectangle rect;
            Bitmap _bmp;

            int add_k;
            switch (bmp.PixelFormat)
            {
                case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                    { add_k = 3; break; }
                default: { add_k = 4; break; }
            }

            for (int i = 0; i < resolution.Length; i++)
            {
                N = 0;
                // Поправка для небольших изображений. 
                //Если изображение разбивается меньше, чем на 25 квадратов, точка пропускается
                if (bmp.Width * bmp.Height / (resolution[i]*resolution[i]) < 25) { true_squares[i] = 0; continue;}
                
                ost_hor = 0; // остаток пикселей, которые не захватит сетка заданного размера
                ost_ver = 0;
                if (bmp.Width % resolution[i] > 0) ost_hor += (sbyte)( bmp.Width % resolution[i]);
                if (bmp.Height % resolution[i] > 0) ost_ver +=(sbyte) (bmp.Height % resolution[i]);

                for (int v = 0; v < bmp.Height / resolution[i]; v++)
                {
                    // последние ряд и колонка имеет увеличенные клетки, чтобы захватить остаток пикселей
                    if (v + 1 >= bmp.Height / resolution[i]) sq_size_hor = (byte)(resolution[i] + ost_hor);
                    else sq_size_hor = resolution[i];
                    for (int h = 0; h < bmp.Width / resolution[i]; h++)
                    {
                        // последние ряд и колонка имеет увеличенные клетки, чтобы захватить остаток пикселей
                        if (h + 1 >= bmp.Width / resolution[i]) sq_size_ver = (byte)(resolution[i] + ost_ver);
                        else sq_size_ver = resolution[i];

                        rect = new Rectangle(h * resolution[i], v * resolution[i], sq_size_hor, sq_size_ver);
                        _bmp = bmp.Clone(rect, bmp.PixelFormat);
                        System.Drawing.Imaging.BitmapData bmpData = _bmp.LockBits(new Rectangle(0, 0, _bmp.Width, _bmp.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, _bmp.PixelFormat);
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
                                N += (float) sq_size_hor * sq_size_ver / (resolution[i] * resolution[i]);
                                //N++;
                                break;
                            }
                        }
                        _bmp.UnlockBits(bmpData);
                        _bmp.Dispose();

                    }
                }

                true_squares[i] = Log(N);
                

            }

        }
        static void ARGB_to_RGB() // Предполагается, что альфа-канал не используется 
        {
            if (bmp == null) return;
            if (bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppArgb && bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppRgb)
                throw new Exception("У изображения, преобразуемого методом ARGB_to_RGB(), формат пикселя должн быть 32bpp");
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            using (Bitmap bmp2 = bmp.Clone(rect,System.Drawing.Imaging.PixelFormat.Format24bppRgb))
            {
                bmp.Dispose();
                bmp = bmp2.Clone(rect, bmp2.PixelFormat);
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
