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
        public static Random sluchai = new Random();
        
        static double radius = 50 * Math.Pow(10, -9); //+
        static double visc = 0.001;
        static double temp = 273;
        static double displacement;
        static double diff_coeff;
        
        static double final_size = 50;
        static double particle_percent = 1;
        static double timestep = 0.1;
        static double [] probability = { 1, 1, 1, 1 };
   
        static Bitmap bmp;

        static int max_in_row =50;
        static byte cell_size =2;
        static int startsq;
        static int fracstep;
        static int fracstep_num;
        static int endsq;
        static bool stop = false;

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
            comboBoxDelta.SelectedIndex = 0;
            comboBoxDiff.SelectedIndex = 0;
            comboBoxRadius.SelectedIndex = 0;
            comboBoxTemp.SelectedIndex = 0;
            comboBoxTimestep.SelectedIndex = 0;
            comboBoxVisc.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Param_Set();
            if (Param_Check() == false)
            {
                double dis = displacement;
                if (checkBoxStokes.Checked == true) dis = Math.Sqrt(2 * (1.3806 * Math.Pow(10, -23) * temp / (6 * Math.PI * visc * radius)) * timestep);
                if (checkBoxES.Checked == true && checkBoxStokes.Checked == false) dis = Math.Sqrt(2 * diff_coeff * timestep);
                textBoxAlert.Text += $"{DateTime.Now}: Значение среднеквадратичного сдвига {dis} м меньше диаметра частицы {2 * radius} м. Увеличте временной шаг для проведения расчетов."+ Environment.NewLine;
                return;
            }
            Map map = new Map(radius, timestep, probability, max_in_row, particle_percent, visc, temp);
            Cluster cluster = new Cluster(max_in_row / 2, max_in_row / 2,ref map);
            Map.Start_Spawn();
            //Draw(ref map);
            while (Cluster.Max_X - Cluster.Min_X < max_in_row * final_size/100.0  && Cluster.Max_Y - Cluster.Min_Y < max_in_row * final_size / 100)
            { 
                MoveP(ref map);
                
            }
            Delete_Particles(ref map);
            Draw(ref map);




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
            bmp = new Bitmap(cell_size * max_in_row, cell_size * max_in_row, System.Drawing.Imaging.PixelFormat.Format32bppRgb); 
            using(Graphics g = Graphics.FromImage(bmp))
            {
                Rectangle rect;
                for (int i = 0; i < max_in_row ; i++)
                {
                    for (int j = 0; j < max_in_row; j++)
                    {
                        rect = new Rectangle(i * cell_size, j * cell_size, cell_size, cell_size);
                        if (map[i, j].Taken == true)
                        {
                            g.FillRectangle(new SolidBrush(Color.Black), rect);
                        }
                        else g.FillRectangle(new SolidBrush(Color.White), rect);
                    }
                }

               
                pictureBoxMain.Image = bmp;
                if (checkBoxCrop.Checked == true)
                {
                    
                    Rectangle cut_rect = new Rectangle((Cluster.Min_X-1)* cell_size, (Cluster.Min_Y-1) * cell_size, (Cluster.Max_X - Cluster.Min_X + 4)*cell_size, (Cluster.Max_Y - Cluster.Min_Y + 4)*cell_size);
                    using (Bitmap cutbmp = new Bitmap(pictureBoxMain.Image))
                    {
                        pictureBoxMain.Image.Dispose();
                        pictureBoxMain.Image = cutbmp.Clone(cut_rect, pictureBoxMain.Image.PixelFormat);
                    }

                }
                
                pictureBoxMain.Refresh();
            }
        }
        

        public void MoveP(ref Map map)
        {
            for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_row; j++)
                {
                    if (map[i, j].particle.Count > 0) map[i, j].particle[0].Move(ref map);
                   
                }
            for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_row; j++)
                {
                    if (map[i, j].particle.Count > 0 && map[i, j].particle[0].To_Delete == true)
                    {
                        map[i, j].particle[0] = null;
                        map[i, j].particle.RemoveAt(0);
                        Map.Single_Spawn();

                    }
                }
                    for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_row; j++)
                {
                    if (map[i, j].particle.Count > 0 && map[i, j].particle[0].moved != false)
                    {
                         map[i, j].particle[0].moved = false;
                    }
                }

        }
        void Delete_Particles(ref Map map) 
        {
            for (int i = 0; i < max_in_row; i++)
                for (int j = 0; j < max_in_row; j++)
                {
                    if (map[i, j].particle.Count > 0)
                    {
                        map[i, j].particle[0] = null;
                        map[i, j].particle.RemoveAt(0);
                    }
                }
        }

        void Param_Set()
        {
            radius = (double) numericUpDownRadius.Value;
            if (comboBoxRadius.SelectedIndex == 0) radius *= Math.Pow(10, -6);
            else radius *= Math.Pow(10, -9);

            displacement = (double)numericUpDownDelta.Value;
            if(comboBoxDelta.SelectedIndex == 0) displacement *= Math.Pow(10, -6);
            else displacement *= Math.Pow(10, -9);

            diff_coeff = (double)numericUpDownDiff.Value;
            switch (comboBoxDiff.SelectedIndex)
            {
                case 0: { diff_coeff *= Math.Pow(10, -10); break; }
                case 1: { diff_coeff *= Math.Pow(10, -11); break; }
                default: { diff_coeff *= Math.Pow(10, -12); break; }
            }

            temp = (double)numericUpDownTemp.Value;
            if (comboBoxTemp.SelectedIndex == 1) temp += 273.15;

            visc = (double)numericUpDownVisc.Value;
            if (comboBoxVisc.SelectedIndex == 1) visc *= Math.Pow(10, -3);

            timestep = (double)numericUpDownTimestep.Value;
            if (comboBoxTimestep.SelectedIndex == 0) timestep *= Math.Pow(10, -3);
            
            //particle_percent = (double)numericUpDownPercent.Value;
            //cell_size = (byte)numericCellSize.Value;
            //max_in_row = (int)numericUpDownCellNum.Value;
            //final_size = (double)numericUpDownFinalSize.Value;
        }
        bool Param_Check() 
        {
            if (checkBoxStokes.Checked == true &&
                Math.Sqrt(2 * (1.3806 * Math.Pow(10, -23) * temp / (6 * Math.PI * visc * radius)) * timestep) / (2 * radius) < 1) 
                return false;
            if (checkBoxES.Checked == true && checkBoxStokes.Checked == false && Math.Sqrt(2 * diff_coeff * timestep) / (2 * radius) < 1) return false;
            if (checkBoxES.Checked == false && displacement / (2 * radius) < 1) return false;
            return true;
        }

        private void сохранитьИзображениеФракталаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if ( pictureBoxMain.Image == null)
            {
                MessageBox.Show("Ошибка: изображение отсутствует"); 
                return;
            }
            bmp?.Dispose();
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

        private void checkBoxES_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDelta.Enabled = !numericUpDownDelta.Enabled;
            comboBoxDelta.Enabled = !comboBoxDelta.Enabled;
            checkBoxStokes.Enabled = !checkBoxStokes.Enabled;
            numericUpDownDiff.Enabled = !numericUpDownDiff.Enabled;
            comboBoxDiff.Enabled = !comboBoxDiff.Enabled;
            if (checkBoxES.Checked == false) checkBoxStokes.Checked = false;
        }
        private void checkBoxStokes_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiff.Enabled = !numericUpDownDiff.Enabled;
            comboBoxDiff.Enabled = !comboBoxDiff.Enabled;
            numericUpDownTemp.Enabled = !numericUpDownTemp.Enabled;
            numericUpDownVisc.Enabled = !numericUpDownVisc.Enabled;
            comboBoxTemp.Enabled = !comboBoxTemp.Enabled;
            comboBoxVisc.Enabled = !comboBoxVisc.Enabled;
        }

        private void numericCellSize_ValueChanged(object sender, EventArgs e)
        {
            cell_size = (byte)numericCellSize.Value;
            labelImageSizeText_Change();
        }

        private void numericUpDownCellNum_ValueChanged(object sender, EventArgs e)
        {
            max_in_row = (int) numericUpDownCellNum.Value;
            labelImageSizeText_Change();
        }

        private void checkBoxCrop_CheckedChanged(object sender, EventArgs e)
        {
            labelImageSizeText_Change();
        }
        
        private void numericUpDownFinalSize_ValueChanged(object sender, EventArgs e)
        {
            final_size = (double) numericUpDownFinalSize.Value;
            labelImageSizeText_Change();
        }
        private void labelImageSizeText_Change()
        {
            if (checkBoxCrop.Checked == true)
                labelImageSize.Text = $"Примерный размер конечного изображения: {cell_size * (Math.Ceiling(max_in_row * final_size / 100) + 2)} х {cell_size * (Math.Ceiling(max_in_row * final_size / 100) + 2)}";
            else labelImageSize.Text = $"Размер конечного изображения: {cell_size * max_in_row} х {cell_size * max_in_row}";
        }

        private void numericUpDownPercent_ValueChanged(object sender, EventArgs e)
        {
            particle_percent = (double)numericUpDownPercent.Value;
        }
    }
}
