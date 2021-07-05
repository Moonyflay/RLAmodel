namespace RLA
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelFrac = new System.Windows.Forms.Panel();
            this.labelStepSize = new System.Windows.Forms.Label();
            this.numericUpDownFracStepSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFracStepNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartSq = new System.Windows.Forms.NumericUpDown();
            this.labelFracStepNum = new System.Windows.Forms.Label();
            this.labelStartSq = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitterBetwAgrFrac = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitterInAgr = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitterPic = new System.Windows.Forms.Splitter();
            this.panelPicBox = new System.Windows.Forms.Panel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеФракталаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзображениеФракталаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelFrac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFracStepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFracStepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartSq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.splitterBetwAgrFrac);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры расчета агрегации и фрактальной размерности";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelFrac);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(331, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 516);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры расчета фрактальной размерности";
            // 
            // panelFrac
            // 
            this.panelFrac.Controls.Add(this.labelStepSize);
            this.panelFrac.Controls.Add(this.numericUpDownFracStepSize);
            this.panelFrac.Controls.Add(this.numericUpDownFracStepNum);
            this.panelFrac.Controls.Add(this.numericUpDownStartSq);
            this.panelFrac.Controls.Add(this.labelFracStepNum);
            this.panelFrac.Controls.Add(this.labelStartSq);
            this.panelFrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrac.Location = new System.Drawing.Point(3, 18);
            this.panelFrac.Name = "panelFrac";
            this.panelFrac.Size = new System.Drawing.Size(567, 495);
            this.panelFrac.TabIndex = 7;
            // 
            // labelStepSize
            // 
            this.labelStepSize.AutoSize = true;
            this.labelStepSize.Location = new System.Drawing.Point(34, 200);
            this.labelStepSize.Name = "labelStepSize";
            this.labelStepSize.Size = new System.Drawing.Size(159, 17);
            this.labelStepSize.TabIndex = 7;
            this.labelStepSize.Text = "Размер шага в клетках";
            // 
            // numericUpDownFracStepSize
            // 
            this.numericUpDownFracStepSize.Location = new System.Drawing.Point(37, 231);
            this.numericUpDownFracStepSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownFracStepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFracStepSize.Name = "numericUpDownFracStepSize";
            this.numericUpDownFracStepSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFracStepSize.TabIndex = 5;
            this.numericUpDownFracStepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFracStepSize.ValueChanged += new System.EventHandler(this.numericUpDownFracStepSize_ValueChanged);
            // 
            // numericUpDownFracStepNum
            // 
            this.numericUpDownFracStepNum.Location = new System.Drawing.Point(37, 154);
            this.numericUpDownFracStepNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownFracStepNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownFracStepNum.Name = "numericUpDownFracStepNum";
            this.numericUpDownFracStepNum.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFracStepNum.TabIndex = 6;
            this.numericUpDownFracStepNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownFracStepNum.ValueChanged += new System.EventHandler(this.numericUpDownFracStepNum_ValueChanged);
            // 
            // numericUpDownStartSq
            // 
            this.numericUpDownStartSq.Location = new System.Drawing.Point(37, 60);
            this.numericUpDownStartSq.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStartSq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartSq.Name = "numericUpDownStartSq";
            this.numericUpDownStartSq.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStartSq.TabIndex = 5;
            this.numericUpDownStartSq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartSq.ValueChanged += new System.EventHandler(this.numericUpDownStartSq_ValueChanged);
            // 
            // labelFracStepNum
            // 
            this.labelFracStepNum.AutoSize = true;
            this.labelFracStepNum.Location = new System.Drawing.Point(34, 98);
            this.labelFracStepNum.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelFracStepNum.Name = "labelFracStepNum";
            this.labelFracStepNum.Size = new System.Drawing.Size(351, 34);
            this.labelFracStepNum.TabIndex = 1;
            this.labelFracStepNum.Text = "Число экспериментальных точек для определения размерности";
            // 
            // labelStartSq
            // 
            this.labelStartSq.AutoSize = true;
            this.labelStartSq.Location = new System.Drawing.Point(34, 9);
            this.labelStartSq.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelStartSq.Name = "labelStartSq";
            this.labelStartSq.Size = new System.Drawing.Size(384, 34);
            this.labelStartSq.TabIndex = 0;
            this.labelStartSq.Text = "Начальное количество клеток, на которое разбивается изображение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 2;
            // 
            // splitterBetwAgrFrac
            // 
            this.splitterBetwAgrFrac.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitterBetwAgrFrac.Location = new System.Drawing.Point(328, 3);
            this.splitterBetwAgrFrac.Name = "splitterBetwAgrFrac";
            this.splitterBetwAgrFrac.Size = new System.Drawing.Size(3, 516);
            this.splitterBetwAgrFrac.TabIndex = 1;
            this.splitterBetwAgrFrac.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitterInAgr);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры расчета агрегации";
            // 
            // splitterInAgr
            // 
            this.splitterInAgr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitterInAgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterInAgr.Location = new System.Drawing.Point(3, 249);
            this.splitterInAgr.Name = "splitterInAgr";
            this.splitterInAgr.Size = new System.Drawing.Size(319, 3);
            this.splitterInAgr.TabIndex = 2;
            this.splitterInAgr.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numericUpDown6);
            this.panel2.Controls.Add(this.numericUpDown5);
            this.panel2.Controls.Add(this.numericUpDown4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 264);
            this.panel2.TabIndex = 1;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "мс",
            "с"});
            this.comboBox5.Location = new System.Drawing.Point(149, 57);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(60, 24);
            this.comboBox5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество временных шагов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Временной шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Процент заполнения поля частицами(%)";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(23, 197);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown6.TabIndex = 3;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(23, 127);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown5.TabIndex = 2;
            this.numericUpDown5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(23, 57);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 1;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 231);
            this.panel1.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "К",
            "ºС"});
            this.comboBox3.Location = new System.Drawing.Point(149, 177);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "мкм",
            "нм"});
            this.comboBox2.Location = new System.Drawing.Point(149, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Па · с",
            "мПа · с"});
            this.comboBox1.Location = new System.Drawing.Point(149, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходный радиус частиц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Динамическая вязкость среды";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(23, 179);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(23, 110);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 39);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Варьирование вероятности слипания";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.splitterPic);
            this.tabPage3.Controls.Add(this.panelPicBox);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(907, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изображение фрактала";
            // 
            // splitterPic
            // 
            this.splitterPic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitterPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterPic.Location = new System.Drawing.Point(705, 0);
            this.splitterPic.Name = "splitterPic";
            this.splitterPic.Size = new System.Drawing.Size(2, 522);
            this.splitterPic.TabIndex = 4;
            this.splitterPic.TabStop = false;
            // 
            // panelPicBox
            // 
            this.panelPicBox.AutoScroll = true;
            this.panelPicBox.Controls.Add(this.pictureBoxMain);
            this.panelPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicBox.Location = new System.Drawing.Point(0, 0);
            this.panelPicBox.Name = "panelPicBox";
            this.panelPicBox.Size = new System.Drawing.Size(707, 522);
            this.panelPicBox.TabIndex = 2;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(700, 520);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelColor);
            this.panel5.Controls.Add(this.buttonColor);
            this.panel5.Controls.Add(this.panelColor);
            this.panel5.Controls.Add(this.buttonStart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(707, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 522);
            this.panel5.TabIndex = 3;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(30, 23);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(110, 17);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Цвет фрактала";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(33, 132);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(126, 53);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Изменить цвет фрактала";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(33, 61);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(126, 48);
            this.panelColor.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(44, 408);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзображениеФракталаToolStripMenuItem,
            this.загрузитьИзображениеФракталаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьИзображениеФракталаToolStripMenuItem
            // 
            this.сохранитьИзображениеФракталаToolStripMenuItem.Name = "сохранитьИзображениеФракталаToolStripMenuItem";
            this.сохранитьИзображениеФракталаToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.сохранитьИзображениеФракталаToolStripMenuItem.Text = "Сохранить изображение фрактала";
            this.сохранитьИзображениеФракталаToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзображениеФракталаToolStripMenuItem_Click);
            // 
            // загрузитьИзображениеФракталаToolStripMenuItem
            // 
            this.загрузитьИзображениеФракталаToolStripMenuItem.Name = "загрузитьИзображениеФракталаToolStripMenuItem";
            this.загрузитьИзображениеФракталаToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.загрузитьИзображениеФракталаToolStripMenuItem.Text = "Загрузить изображение фрактала";
            this.загрузитьИзображениеФракталаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзображениеФракталаToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelFrac.ResumeLayout(false);
            this.panelFrac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFracStepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFracStepNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartSq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelPicBox.ResumeLayout(false);
            this.panelPicBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitterBetwAgrFrac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitterInAgr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеФракталаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеФракталаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFracStepNum;
        private System.Windows.Forms.Label labelStartSq;
        private System.Windows.Forms.NumericUpDown numericUpDownFracStepSize;
        private System.Windows.Forms.Panel panelFrac;
        private System.Windows.Forms.NumericUpDown numericUpDownFracStepNum;
        private System.Windows.Forms.NumericUpDown numericUpDownStartSq;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panelPicBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitterPic;
        private System.Windows.Forms.Label labelStepSize;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelColor;
    }
}

