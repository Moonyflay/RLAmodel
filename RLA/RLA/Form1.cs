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
        static double particle_percent =1;
        static double timestep = 0.1;
        static double [] probability = { 1, 1, 1, 1 };
   
        static Bitmap bmp;

        static int max_in_row =50;
        static byte cell_size =2;

        static string mask = "Fractal";
        static string folder_name;
        



        public FormMain()
        {
            InitializeComponent();
            comboBoxDelta.SelectedIndex = 0;
            comboBoxDiff.SelectedIndex = 0;
            comboBoxRadius.SelectedIndex = 0;
            comboBoxTemp.SelectedIndex = 0;
            comboBoxTimestep.SelectedIndex = 0;
            comboBoxVisc.SelectedIndex = 0;
            labelDir.Text = $"Результаты будут сохранены в: {Environment.SpecialFolder.Personal}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Param_Set();
            if (Param_Check() == false)
            {
                double dis = displacement;
                if (checkBoxStokes.Checked == true) dis = Math.Sqrt(2 * (1.3806 * Math.Pow(10, -23) * temp / (6 * Math.PI * visc * radius)) * timestep);
                if (checkBoxES.Checked == true && checkBoxStokes.Checked == false) dis = Math.Sqrt(2 * diff_coeff * timestep);
                textBoxAlert.Text += $"{DateTime.Now}: Значение среднеквадратичного сдвига {dis} м меньше диаметра частицы {2 * radius} м. Увеличте временной шаг для проведения расчетов." + Environment.NewLine;
                
                if(particle_percent/100*max_in_row*max_in_row < 1)
                    textBoxAlert.Text += $"{DateTime.Now}: На поле не будут генерироваться частицы. Увеличте процент заполнения поля частицами для проведения расчетов." + Environment.NewLine;
                return;
            }
            if (String.IsNullOrWhiteSpace(folder_name) == true && tableLayoutPanelProb.RowCount > 2)
            { 
                textBoxAlert.Text += $"{DateTime.Now}: Необходимо выбрать директорию для сохранения изображений" + Environment.NewLine;
                return;
            }
            for (int i = 0; i < tableLayoutPanelProb.RowCount - 1; i++)
            {
                Probability_Set(i+1); 
                Map map;

                if (checkBoxStokes.Checked == true) map = new Map(radius, timestep, probability, max_in_row, particle_percent, visc, temp);
                else if (checkBoxES.Checked == true) map = new Map(radius, timestep, probability, max_in_row, particle_percent, diff_coeff);
                else map = new Map(displacement, radius, probability, max_in_row, particle_percent);

                Cluster cluster = new Cluster(max_in_row / 2, max_in_row / 2, ref map);
                Map.Start_Spawn();

                while (Cluster.Max_X - Cluster.Min_X < max_in_row * final_size / 100.0 && Cluster.Max_Y - Cluster.Min_Y < max_in_row * final_size / 100)
                {
                    MoveP(ref map);
                }
                Delete_Particles(ref map);
                Draw(ref map);
                if (tableLayoutPanelProb.RowCount > 2) 
                {
                    string pic_name;
                    if (radioButtonProb.Checked == true)
                    {
                        pic_name ="\\" + mask + $" {probability[0]} {probability[1]} {probability[2]} {probability[3]}";
                    }
                    else pic_name = "\\" + mask + $"{i+1}";

                             pictureBoxMain.Image.Save(folder_name + pic_name + ".BMP", System.Drawing.Imaging.ImageFormat.Bmp);
                    
                }
            }

        }
       
        private void buttonFractal_Click(object sender, EventArgs e)
        {

            Rectangle rect = new Rectangle(0, 0, pictureBoxMain.Image.Width, pictureBoxMain.Image.Height);
            System.Drawing.Imaging.PixelFormat format = pictureBoxMain.Image.PixelFormat;

            bmp = new Bitmap(pictureBoxMain.Image);
            FractalDim.Fractal_Image = bmp.Clone(rect, format);
            FractalDim.Fractal_Color = panelColor.BackColor;

            textBoxAlert.Text += Environment.NewLine + $"Размерность фрактала: {Math.Round(FractalDimension.FractalDim.Dimenshion(),3)}";
            pictureBoxMain.Image.Dispose();

            rect = new Rectangle(0, 0, FractalDim.Fractal_Image.Width, FractalDim.Fractal_Image.Height);
            pictureBoxMain.Image = FractalDim.Fractal_Image.Clone(rect, FractalDim.Fractal_Image.PixelFormat);
            bmp?.Dispose();
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
                            g.FillRectangle(new SolidBrush(panelColor.BackColor), rect);
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

            Probability_Set(1);
        }
        void Probability_Set(int row_num)
        {
            for (int i = 0; i < 4; i++)
            {
                NumericUpDown num = tableLayoutPanelProb.Controls[row_num * 5 + i + 1] as NumericUpDown;
                probability[i] = (double)num.Value;
            }
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
                bmp?.Dispose();
               bmp = new Bitmap(openFileDialog.FileName);
            }
            pictureBoxMain.Image?.Dispose(); 
            pictureBoxMain.Image = bmp;
        }

        private void Pick_Directory(object sender, EventArgs e) 
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Выберите папку для сохранения изображений";
            // folder.RootFolder = Environment.SpecialFolder.Personal;
           
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                folder_name = folder.SelectedPath;
                labelDir.Text = $"Результаты будут сохранены в: {folder_name}";
            }
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //if (pictureBoxMain.Image == null) { MessageBox.Show("Изображение фрактала отсутствует"); return; }
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
            if
                (pictureBoxMain.Image != null && pictureBoxMain.PointToClient(Cursor.Position).X <= pictureBoxMain.Image.Width && 
                  pictureBoxMain.PointToClient(Cursor.Position).Y <= pictureBoxMain.Image.Height)
                using (Bitmap bmp2 = new Bitmap(pictureBoxMain.Image))
                    panelColor.BackColor = bmp2.GetPixel(pictureBoxMain.PointToClient(Cursor.Position).X, pictureBoxMain.PointToClient(Cursor.Position).Y);
            
        }
        private void ColorPick(object sender, EventArgs e)
        {
            pictureBoxMain.Click -= ColorPick;
            pictureBoxMain.MouseMove -= ChangeColorOnMove;
            pictureBoxMain.Cursor = Cursors.Default;
            buttonColor.Text = "Изменить цвет фрактала";
        }
        private void panelBlack_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.Black;
            if (pictureBoxMain.Cursor == Cursors.Cross) buttonColor_Click(sender, e);
        }
        private void panelRed_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.Red;
            if (pictureBoxMain.Cursor == Cursors.Cross) buttonColor_Click(sender, e);
        }
        private void panelBlue_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.Blue;
            if (pictureBoxMain.Cursor == Cursors.Cross) buttonColor_Click(sender, e);
        }

        private void panelGreen_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Color.Green;
            if (pictureBoxMain.Cursor == Cursors.Cross) buttonColor_Click(sender, e);
        }

        private void checkBoxES_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDelta.Enabled = !numericUpDownDelta.Enabled;
            comboBoxDelta.Enabled = !comboBoxDelta.Enabled;
            checkBoxStokes.Enabled = !checkBoxStokes.Enabled;
            numericUpDownDiff.Enabled = !numericUpDownDiff.Enabled;
            comboBoxDiff.Enabled = !comboBoxDiff.Enabled;
            numericUpDownTimestep.Enabled = !numericUpDownTimestep.Enabled;
            comboBoxTimestep.Enabled = !comboBoxTimestep.Enabled;

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
            labelPartNumber.Text = $"Итого частиц на поле: {Math.Truncate(max_in_row * max_in_row * particle_percent / 100)}";
            labelVacNumber.Text = $"Итого клеток: {max_in_row * max_in_row }";
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
            labelPartNumber.Text = $"Итого частиц на поле: {Math.Truncate(max_in_row* max_in_row*particle_percent/100)}";
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            panelMaskChoice.Enabled = true;
            textBoxMask.Enabled = true;
            buttonDirPick.Enabled = true;
            labelDir.Enabled = true;

            tableLayoutPanelProb.RowCount++;
            Label lab = new Label();
            lab.Text = $"{tableLayoutPanelProb.RowCount-1}";
            lab.Font = new Font(lab.Font.FontFamily ,10);
            lab.Dock = DockStyle.Fill;
            tableLayoutPanelProb.Controls.Add(lab, 0, tableLayoutPanelProb.RowCount - 1);
            for (int i = 1; i < 5; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Maximum = 1;
                num.Minimum = 0.001M;
                num.DecimalPlaces = 3;
                num.Value = 1;
                num.Increment = 0.001M; 
                tableLayoutPanelProb.Controls.Add(num,i,tableLayoutPanelProb.RowCount-1);
                num.Dock = DockStyle.Fill;
            }
            Button but = new Button();
            but.Text = "Удалить";
            but.Click += DeleteProb_Click;
            tableLayoutPanelProb.Controls.Add(but, 5, tableLayoutPanelProb.RowCount - 1);

        }
        private void DeleteProb_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            int index = tableLayoutPanelProb.Controls.GetChildIndex(but);
            int row = tableLayoutPanelProb.GetRow(but);
            for (int i = 0; i < 6; i++)
                tableLayoutPanelProb.Controls.RemoveAt(index - i);
            for (int i = 0; i < tableLayoutPanelProb.RowCount - row - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tableLayoutPanelProb.SetRow(tableLayoutPanelProb.Controls[index - j + i * 6], tableLayoutPanelProb.GetRow(tableLayoutPanelProb.Controls[index - j + i * 6]) - 1);
                    if (j == 5) { tableLayoutPanelProb.Controls[index - j + i * 6].Text = $"{i+row}"; }
                }
            }
            tableLayoutPanelProb.RowCount--;
            if (tableLayoutPanelProb.RowCount < 3)
            {
                panelMaskChoice.Enabled = false;
                textBoxMask.Enabled = false;
                buttonDirPick.Enabled = false;
                labelDir.Enabled = false;
            }
           
        }

        private void textBoxMask_TextChanged(object sender, EventArgs e)
        {
            mask = textBoxMask.Text;
        }
    }
}
