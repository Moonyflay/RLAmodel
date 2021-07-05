using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractalDimension;

namespace RLA
{
    public partial class FormMain : Form
    {
        static Bitmap bmp;
        static double visc = 0.001;
        static double temp = 273;
        static double radius = 1.25 * Math.Pow(10,-9) ;
        static double percent = 10;
        static double timestep = 10;
        static double timestep_num;
        static double [] probability = { 1, 1, 1, 1 };
    static int startsq;
        static int fracstep;
        static int fracstep_num;
        static int endsq;

        static int EndSq
        {
            get { return endsq; }
            set { 
                if(endsq > startsq) endsq = value;
                //else endsq = startsq;
                }
        }
       
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Map map = new Map(radius, timestep, probability, visc, temp);
            Map.Start_Spawn(new Random());
            Draw(ref map);
            for (int i = 0; i < 100000; i++)
            { 
                Move(ref map); 
                Draw(ref map); 
            }



            // Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            // System.Drawing.Imaging.PixelFormat format = bmp.PixelFormat;

            // FractalDim.Fractal_Image =  bmp.Clone(rect, format);
            //FractalDim.Fractal_Color = panelColor.BackColor;

            // MessageBox.Show($"Размерность фрактала: {FractalDimension.FractalDim.Dimenshion()}");
            // pictureBoxMain.Image.Dispose();

            //  rect = new Rectangle(0, 0, FractalDim.Fractal_Image.Width, FractalDim.Fractal_Image.Height);
            //pictureBoxMain.Image = FractalDim.Fractal_Image.Clone(rect, FractalDim.Fractal_Image.PixelFormat);
        }
        public void Draw(ref Map map)
        {
            bmp?.Dispose();
            pictureBoxMain.Image?.Dispose();
            bmp = new Bitmap(Map.c_width * Map.max_in_row, Map.c_height * Map.max_in_col, System.Drawing.Imaging.PixelFormat.Format32bppRgb); 
            using(Graphics g = Graphics.FromImage(bmp))
            {
                Rectangle rect;
                for (int i = 0; i < Map.max_in_row ; i++)
                {
                    for (int j = 0; j < Map.max_in_col; j++)
                    {
                        rect = new Rectangle(i * Map.c_width, j * Map.c_height, Map.c_width, Map.c_width);
                        if (map[i, j].Taken == true)
                        {
                            g.FillRectangle(new SolidBrush(map[i, j].Cell_Color), rect);
                        }
                        else g.FillRectangle(new SolidBrush(Color.White), rect);
                    }
                }
                pictureBoxMain.Image = bmp;
                pictureBoxMain.Refresh();
            }
        }
        public static void Move(ref Map map)
        {
            for (int i = 0; i < Map.max_in_row; i++)
                for (int j = 0; j < Map.max_in_col; j++)
                {
                    map[i, j].particle?.Move(ref map);
                }
            for (int i = 0; i < Map.max_in_row; i++)
                for (int j = 0; j < Map.max_in_col; j++)
                {
                    if (map[i, j].particle != null && map[i, j].particle.moved != false)
                    {
                        if (map[i, j].particle.agg != null) map[i, j].particle.agg.Moved = false;
                        else map[i, j].particle.moved = false; 
                    }
                }

        }

        private void сохранитьИзображениеФракталаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (/*bmp*/ pictureBoxMain.Image == null)
            {
                MessageBox.Show("Ошибка: изображение отсутствует"); 
                return;
            }
            bmp = new Bitmap(pictureBoxMain.Image);
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "BMP Files(*.BMP)|*.BMP|JPG Files(*.JPG)|*.JPG|JPEG Files(*.JPEG)|*.JPEG|PNG files (*.PNG)|*.PNG|All files (*.*)|*.*";  
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            bmp.Save(myStream, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case 4:
                            bmp.Save(myStream, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        default:
                            bmp.Save(myStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                    }
                            myStream.Close();
                }
            }
        }

        private void загрузитьИзображениеФракталаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP Files(*.BMP)|*.BMP|JPG Files(*.JPG)|*.JPG|JPEG Files(*.JPEG)|*.JPEG|PNG files (*.PNG)|*.PNG|Image Files (*.JPG;*.PNG;*.JPEG;*.PNG)|*.JPG;*.PNG;*.JPEG;*.PNG";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Dispose();
               bmp = new Bitmap(openFileDialog.FileName);
            }
            pictureBoxMain.Image?.Dispose(); 
            pictureBoxMain.Image = bmp;
        }

  
        private void numericUpDownStartSq_ValueChanged(object sender, EventArgs e)
        {
            startsq = (int)numericUpDownStartSq.Value;
        }

        private void numericUpDownFracStepNum_ValueChanged(object sender, EventArgs e)
        {
            fracstep_num = (int)numericUpDownFracStepNum.Value;
        }

        private void numericUpDownFracStepSize_ValueChanged(object sender, EventArgs e)
        {
            fracstep = (int)numericUpDownFracStepSize.Value;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image == null) { MessageBox.Show("Изображение фрактала отсутствует"); return; }
            if (pictureBoxMain.Cursor != Cursors.Cross)
            {
                pictureBoxMain.Click += ColorPick;
                pictureBoxMain.MouseMove += ChangeColorOnMove;
                pictureBoxMain.Cursor = Cursors.Cross;
                buttonColor.Text = "Отменить выбор цвета";
            }
            else 
            {
                pictureBoxMain.Click -= ColorPick;
                pictureBoxMain.MouseMove -= ChangeColorOnMove;
                pictureBoxMain.Cursor = Cursors.Default;
                buttonColor.Text = "Изменить цвет фрактала";
            }
        }
        private void ChangeColorOnMove(object sender, EventArgs e)
        {
            panelColor.BackColor = bmp.GetPixel(pictureBoxMain.PointToClient(Cursor.Position).X, pictureBoxMain.PointToClient(Cursor.Position).Y);
        }
        private void ColorPick(object sender, EventArgs e)
        {
            pictureBoxMain.Click -= ColorPick;
            pictureBoxMain.MouseMove -= ChangeColorOnMove;
            pictureBoxMain.Cursor = Cursors.Default;
            buttonColor.Text = "Изменить цвет фрактала";
        }
    }
}
