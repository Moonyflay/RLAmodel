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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAgr = new System.Windows.Forms.GroupBox();
            this.splitterInAgr = new System.Windows.Forms.Splitter();
            this.panelAgBot = new System.Windows.Forms.Panel();
            this.numericUpDownFinalSize = new System.Windows.Forms.NumericUpDown();
            this.labelFinalSize = new System.Windows.Forms.Label();
            this.checkBoxCrop = new System.Windows.Forms.CheckBox();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.numericUpDownCellNum = new System.Windows.Forms.NumericUpDown();
            this.labelCellNum = new System.Windows.Forms.Label();
            this.numericCellSize = new System.Windows.Forms.NumericUpDown();
            this.labelCellSize = new System.Windows.Forms.Label();
            this.comboBoxTimestep = new System.Windows.Forms.ComboBox();
            this.labelTimestep = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.numericUpDownPercent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimestep = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStokes = new System.Windows.Forms.Panel();
            this.checkBoxStokes = new System.Windows.Forms.CheckBox();
            this.comboBoxVisc = new System.Windows.Forms.ComboBox();
            this.numericUpDownVisc = new System.Windows.Forms.NumericUpDown();
            this.labelVisc = new System.Windows.Forms.Label();
            this.numericUpDownTemp = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.panelES = new System.Windows.Forms.Panel();
            this.checkBoxES = new System.Windows.Forms.CheckBox();
            this.comboBoxDiff = new System.Windows.Forms.ComboBox();
            this.labelDiff = new System.Windows.Forms.Label();
            this.numericUpDownDiff = new System.Windows.Forms.NumericUpDown();
            this.panelRadius = new System.Windows.Forms.Panel();
            this.comboBoxRadius = new System.Windows.Forms.ComboBox();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDelta = new System.Windows.Forms.ComboBox();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.numericUpDownDelta = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPicBox = new System.Windows.Forms.Panel();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelAlert = new System.Windows.Forms.Panel();
            this.textBoxAlert = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеФракталаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзображениеФракталаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAgr.SuspendLayout();
            this.panelAgBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimestep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelStokes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).BeginInit();
            this.panelES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiff)).BeginInit();
            this.panelRadius.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelta)).BeginInit();
            this.panelPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelAlert.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 971);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBoxAgr);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 942);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры расчета агрегации";
            // 
            // groupBoxAgr
            // 
            this.groupBoxAgr.Controls.Add(this.splitterInAgr);
            this.groupBoxAgr.Controls.Add(this.panelAgBot);
            this.groupBoxAgr.Controls.Add(this.panel1);
            this.groupBoxAgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAgr.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAgr.Name = "groupBoxAgr";
            this.groupBoxAgr.Size = new System.Drawing.Size(530, 936);
            this.groupBoxAgr.TabIndex = 0;
            this.groupBoxAgr.TabStop = false;
            this.groupBoxAgr.Text = "Параметры расчета агрегации";
            // 
            // splitterInAgr
            // 
            this.splitterInAgr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitterInAgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterInAgr.Location = new System.Drawing.Point(3, 388);
            this.splitterInAgr.Name = "splitterInAgr";
            this.splitterInAgr.Size = new System.Drawing.Size(524, 3);
            this.splitterInAgr.TabIndex = 2;
            this.splitterInAgr.TabStop = false;
            // 
            // panelAgBot
            // 
            this.panelAgBot.Controls.Add(this.numericUpDownFinalSize);
            this.panelAgBot.Controls.Add(this.labelFinalSize);
            this.panelAgBot.Controls.Add(this.checkBoxCrop);
            this.panelAgBot.Controls.Add(this.labelImageSize);
            this.panelAgBot.Controls.Add(this.numericUpDownCellNum);
            this.panelAgBot.Controls.Add(this.labelCellNum);
            this.panelAgBot.Controls.Add(this.numericCellSize);
            this.panelAgBot.Controls.Add(this.labelCellSize);
            this.panelAgBot.Controls.Add(this.comboBoxTimestep);
            this.panelAgBot.Controls.Add(this.labelTimestep);
            this.panelAgBot.Controls.Add(this.labelPercent);
            this.panelAgBot.Controls.Add(this.numericUpDownPercent);
            this.panelAgBot.Controls.Add(this.numericUpDownTimestep);
            this.panelAgBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgBot.Location = new System.Drawing.Point(3, 388);
            this.panelAgBot.Name = "panelAgBot";
            this.panelAgBot.Size = new System.Drawing.Size(524, 545);
            this.panelAgBot.TabIndex = 1;
            // 
            // numericUpDownFinalSize
            // 
            this.numericUpDownFinalSize.Location = new System.Drawing.Point(10, 373);
            this.numericUpDownFinalSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFinalSize.Name = "numericUpDownFinalSize";
            this.numericUpDownFinalSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFinalSize.TabIndex = 16;
            this.numericUpDownFinalSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownFinalSize.ValueChanged += new System.EventHandler(this.numericUpDownFinalSize_ValueChanged);
            // 
            // labelFinalSize
            // 
            this.labelFinalSize.AutoSize = true;
            this.labelFinalSize.Location = new System.Drawing.Point(7, 335);
            this.labelFinalSize.Name = "labelFinalSize";
            this.labelFinalSize.Size = new System.Drawing.Size(401, 17);
            this.labelFinalSize.TabIndex = 15;
            this.labelFinalSize.Text = "Конечный размер фрактала (в % от ширины изображения)";
            // 
            // checkBoxCrop
            // 
            this.checkBoxCrop.AutoSize = true;
            this.checkBoxCrop.Location = new System.Drawing.Point(10, 426);
            this.checkBoxCrop.Name = "checkBoxCrop";
            this.checkBoxCrop.Size = new System.Drawing.Size(425, 21);
            this.checkBoxCrop.TabIndex = 14;
            this.checkBoxCrop.Text = "Обрезать полученное изображение до размеров фрактала";
            this.checkBoxCrop.UseVisualStyleBackColor = true;
            this.checkBoxCrop.CheckedChanged += new System.EventHandler(this.checkBoxCrop_CheckedChanged);
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Location = new System.Drawing.Point(10, 477);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(291, 17);
            this.labelImageSize.TabIndex = 13;
            this.labelImageSize.Text = "Размер конечного изображения: 100 х 100";
            // 
            // numericUpDownCellNum
            // 
            this.numericUpDownCellNum.Location = new System.Drawing.Point(10, 293);
            this.numericUpDownCellNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCellNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCellNum.Name = "numericUpDownCellNum";
            this.numericUpDownCellNum.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCellNum.TabIndex = 12;
            this.numericUpDownCellNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCellNum.ValueChanged += new System.EventHandler(this.numericUpDownCellNum_ValueChanged);
            // 
            // labelCellNum
            // 
            this.labelCellNum.AutoSize = true;
            this.labelCellNum.Location = new System.Drawing.Point(7, 259);
            this.labelCellNum.Name = "labelCellNum";
            this.labelCellNum.Size = new System.Drawing.Size(181, 17);
            this.labelCellNum.TabIndex = 11;
            this.labelCellNum.Text = "Количество клеток в ряду";
            // 
            // numericCellSize
            // 
            this.numericCellSize.Location = new System.Drawing.Point(10, 216);
            this.numericCellSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericCellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCellSize.Name = "numericCellSize";
            this.numericCellSize.Size = new System.Drawing.Size(120, 22);
            this.numericCellSize.TabIndex = 10;
            this.numericCellSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCellSize.ValueChanged += new System.EventHandler(this.numericCellSize_ValueChanged);
            // 
            // labelCellSize
            // 
            this.labelCellSize.AutoSize = true;
            this.labelCellSize.Location = new System.Drawing.Point(7, 181);
            this.labelCellSize.Name = "labelCellSize";
            this.labelCellSize.Size = new System.Drawing.Size(191, 17);
            this.labelCellSize.TabIndex = 9;
            this.labelCellSize.Text = "Размер клетки (в пикселях)";
            // 
            // comboBoxTimestep
            // 
            this.comboBoxTimestep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimestep.FormattingEnabled = true;
            this.comboBoxTimestep.Items.AddRange(new object[] {
            "мс",
            "с"});
            this.comboBoxTimestep.Location = new System.Drawing.Point(149, 58);
            this.comboBoxTimestep.Name = "comboBoxTimestep";
            this.comboBoxTimestep.Size = new System.Drawing.Size(60, 24);
            this.comboBoxTimestep.TabIndex = 8;
            // 
            // labelTimestep
            // 
            this.labelTimestep.AutoSize = true;
            this.labelTimestep.Location = new System.Drawing.Point(10, 25);
            this.labelTimestep.Name = "labelTimestep";
            this.labelTimestep.Size = new System.Drawing.Size(110, 17);
            this.labelTimestep.TabIndex = 5;
            this.labelTimestep.Text = "Временной шаг";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(7, 100);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(285, 17);
            this.labelPercent.TabIndex = 4;
            this.labelPercent.Text = "Процент заполнения поля частицами (%)";
            // 
            // numericUpDownPercent
            // 
            this.numericUpDownPercent.Location = new System.Drawing.Point(10, 130);
            this.numericUpDownPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownPercent.Name = "numericUpDownPercent";
            this.numericUpDownPercent.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPercent.TabIndex = 3;
            this.numericUpDownPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPercent.ValueChanged += new System.EventHandler(this.numericUpDownPercent_ValueChanged);
            // 
            // numericUpDownTimestep
            // 
            this.numericUpDownTimestep.Location = new System.Drawing.Point(10, 59);
            this.numericUpDownTimestep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimestep.Name = "numericUpDownTimestep";
            this.numericUpDownTimestep.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTimestep.TabIndex = 1;
            this.numericUpDownTimestep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelStokes);
            this.panel1.Controls.Add(this.panelES);
            this.panel1.Controls.Add(this.panelRadius);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 370);
            this.panel1.TabIndex = 0;
            // 
            // panelStokes
            // 
            this.panelStokes.Controls.Add(this.checkBoxStokes);
            this.panelStokes.Controls.Add(this.comboBoxVisc);
            this.panelStokes.Controls.Add(this.numericUpDownVisc);
            this.panelStokes.Controls.Add(this.labelVisc);
            this.panelStokes.Controls.Add(this.numericUpDownTemp);
            this.panelStokes.Controls.Add(this.comboBoxTemp);
            this.panelStokes.Controls.Add(this.labelTemp);
            this.panelStokes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStokes.Location = new System.Drawing.Point(0, 186);
            this.panelStokes.Name = "panelStokes";
            this.panelStokes.Size = new System.Drawing.Size(524, 184);
            this.panelStokes.TabIndex = 12;
            // 
            // checkBoxStokes
            // 
            this.checkBoxStokes.AutoEllipsis = true;
            this.checkBoxStokes.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxStokes.Enabled = false;
            this.checkBoxStokes.Location = new System.Drawing.Point(13, 62);
            this.checkBoxStokes.Name = "checkBoxStokes";
            this.checkBoxStokes.Size = new System.Drawing.Size(221, 67);
            this.checkBoxStokes.TabIndex = 11;
            this.checkBoxStokes.Text = "Рассчитать коэффициент диффузии, используя закон Стокса";
            this.toolTip1.SetToolTip(this.checkBoxStokes, "D = kb·T/(6π·η·r)\r\nD - коэффициент диффузии; \r\nkb - константа Больцмана;\r\nT - абс" +
        "олютная температура;\r\nη - динамическая вязкость;\r\nr - радиус частицы.");
            this.checkBoxStokes.UseVisualStyleBackColor = false;
            this.checkBoxStokes.CheckedChanged += new System.EventHandler(this.checkBoxStokes_CheckedChanged);
            // 
            // comboBoxVisc
            // 
            this.comboBoxVisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisc.Enabled = false;
            this.comboBoxVisc.FormattingEnabled = true;
            this.comboBoxVisc.Items.AddRange(new object[] {
            "Па · с",
            "мПа · с"});
            this.comboBoxVisc.Location = new System.Drawing.Point(388, 127);
            this.comboBoxVisc.Name = "comboBoxVisc";
            this.comboBoxVisc.Size = new System.Drawing.Size(60, 24);
            this.comboBoxVisc.TabIndex = 6;
            // 
            // numericUpDownVisc
            // 
            this.numericUpDownVisc.Enabled = false;
            this.numericUpDownVisc.Location = new System.Drawing.Point(250, 129);
            this.numericUpDownVisc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVisc.Name = "numericUpDownVisc";
            this.numericUpDownVisc.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVisc.TabIndex = 0;
            this.numericUpDownVisc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelVisc
            // 
            this.labelVisc.AutoSize = true;
            this.labelVisc.Location = new System.Drawing.Point(247, 98);
            this.labelVisc.Name = "labelVisc";
            this.labelVisc.Size = new System.Drawing.Size(213, 17);
            this.labelVisc.TabIndex = 3;
            this.labelVisc.Text = "Динамическая вязкость среды";
            // 
            // numericUpDownTemp
            // 
            this.numericUpDownTemp.Enabled = false;
            this.numericUpDownTemp.Location = new System.Drawing.Point(250, 49);
            this.numericUpDownTemp.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownTemp.Name = "numericUpDownTemp";
            this.numericUpDownTemp.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTemp.TabIndex = 2;
            this.numericUpDownTemp.Value = new decimal(new int[] {
            273,
            0,
            0,
            0});
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemp.Enabled = false;
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Items.AddRange(new object[] {
            "К",
            "ºС"});
            this.comboBoxTemp.Location = new System.Drawing.Point(388, 47);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(60, 24);
            this.comboBoxTemp.TabIndex = 8;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(247, 18);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(96, 17);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.Text = "Температура";
            // 
            // panelES
            // 
            this.panelES.Controls.Add(this.checkBoxES);
            this.panelES.Controls.Add(this.comboBoxDiff);
            this.panelES.Controls.Add(this.labelDiff);
            this.panelES.Controls.Add(this.numericUpDownDiff);
            this.panelES.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelES.Location = new System.Drawing.Point(0, 93);
            this.panelES.Name = "panelES";
            this.panelES.Size = new System.Drawing.Size(524, 93);
            this.panelES.TabIndex = 18;
            // 
            // checkBoxES
            // 
            this.checkBoxES.Location = new System.Drawing.Point(13, 13);
            this.checkBoxES.Name = "checkBoxES";
            this.checkBoxES.Size = new System.Drawing.Size(221, 71);
            this.checkBoxES.TabIndex = 9;
            this.checkBoxES.Text = "Рассчитать сдвиг частицы через уравнение Эйнштейна-Смолуховского";
            this.toolTip1.SetToolTip(this.checkBoxES, "Δ² = 2Dτ\r\nΔ - среднеквадратичный сдвиг;\r\nD - коэффициент диффузии;\r\nτ - временной" +
        " шаг.");
            this.checkBoxES.UseVisualStyleBackColor = false;
            this.checkBoxES.CheckedChanged += new System.EventHandler(this.checkBoxES_CheckedChanged);
            // 
            // comboBoxDiff
            // 
            this.comboBoxDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiff.Enabled = false;
            this.comboBoxDiff.FormattingEnabled = true;
            this.comboBoxDiff.Items.AddRange(new object[] {
            "10^(-10) м²/с",
            "10^(-11) м²/с",
            "10^(-12) м²/с"});
            this.comboBoxDiff.Location = new System.Drawing.Point(388, 51);
            this.comboBoxDiff.Name = "comboBoxDiff";
            this.comboBoxDiff.Size = new System.Drawing.Size(60, 24);
            this.comboBoxDiff.TabIndex = 17;
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(247, 19);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(173, 17);
            this.labelDiff.TabIndex = 14;
            this.labelDiff.Text = "Коэффициент диффузии";
            // 
            // numericUpDownDiff
            // 
            this.numericUpDownDiff.Enabled = false;
            this.numericUpDownDiff.Location = new System.Drawing.Point(250, 51);
            this.numericUpDownDiff.Name = "numericUpDownDiff";
            this.numericUpDownDiff.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDiff.TabIndex = 15;
            // 
            // panelRadius
            // 
            this.panelRadius.Controls.Add(this.comboBoxRadius);
            this.panelRadius.Controls.Add(this.numericUpDownRadius);
            this.panelRadius.Controls.Add(this.comboBoxDelta);
            this.panelRadius.Controls.Add(this.labelDelta);
            this.panelRadius.Controls.Add(this.labelRadius);
            this.panelRadius.Controls.Add(this.numericUpDownDelta);
            this.panelRadius.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRadius.Location = new System.Drawing.Point(0, 0);
            this.panelRadius.Name = "panelRadius";
            this.panelRadius.Size = new System.Drawing.Size(524, 93);
            this.panelRadius.TabIndex = 19;
            // 
            // comboBoxRadius
            // 
            this.comboBoxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRadius.FormattingEnabled = true;
            this.comboBoxRadius.Items.AddRange(new object[] {
            "мкм",
            "нм"});
            this.comboBoxRadius.Location = new System.Drawing.Point(149, 48);
            this.comboBoxRadius.Name = "comboBoxRadius";
            this.comboBoxRadius.Size = new System.Drawing.Size(60, 24);
            this.comboBoxRadius.TabIndex = 7;
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(10, 48);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRadius.TabIndex = 1;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxDelta
            // 
            this.comboBoxDelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelta.FormattingEnabled = true;
            this.comboBoxDelta.Items.AddRange(new object[] {
            "мкм",
            "нм"});
            this.comboBoxDelta.Location = new System.Drawing.Point(388, 48);
            this.comboBoxDelta.Name = "comboBoxDelta";
            this.comboBoxDelta.Size = new System.Drawing.Size(60, 24);
            this.comboBoxDelta.TabIndex = 16;
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Location = new System.Drawing.Point(247, 15);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(251, 17);
            this.labelDelta.TabIndex = 10;
            this.labelDelta.Text = "Среднеквадратичный сдвиг частицы";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(7, 15);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(173, 17);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Исходный радиус частиц";
            // 
            // numericUpDownDelta
            // 
            this.numericUpDownDelta.Location = new System.Drawing.Point(250, 48);
            this.numericUpDownDelta.Name = "numericUpDownDelta";
            this.numericUpDownDelta.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDelta.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(536, 942);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вероятность слипания";
            // 
            // panelPicBox
            // 
            this.panelPicBox.AutoScroll = true;
            this.panelPicBox.Controls.Add(this.pictureBoxMain);
            this.panelPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicBox.Location = new System.Drawing.Point(544, 28);
            this.panelPicBox.Name = "panelPicBox";
            this.panelPicBox.Size = new System.Drawing.Size(1124, 971);
            this.panelPicBox.TabIndex = 2;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1124, 969);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelAlert);
            this.panelButtons.Controls.Add(this.labelColor);
            this.panelButtons.Controls.Add(this.buttonColor);
            this.panelButtons.Controls.Add(this.panelColor);
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(544, 809);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1124, 190);
            this.panelButtons.TabIndex = 3;
            // 
            // panelAlert
            // 
            this.panelAlert.AutoScroll = true;
            this.panelAlert.Controls.Add(this.textBoxAlert);
            this.panelAlert.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAlert.Location = new System.Drawing.Point(0, 0);
            this.panelAlert.Name = "panelAlert";
            this.panelAlert.Size = new System.Drawing.Size(466, 190);
            this.panelAlert.TabIndex = 6;
            // 
            // textBoxAlert
            // 
            this.textBoxAlert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAlert.Location = new System.Drawing.Point(0, 0);
            this.textBoxAlert.Multiline = true;
            this.textBoxAlert.Name = "textBoxAlert";
            this.textBoxAlert.ReadOnly = true;
            this.textBoxAlert.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAlert.Size = new System.Drawing.Size(466, 190);
            this.textBoxAlert.TabIndex = 5;
            this.textBoxAlert.TabStop = false;
            this.textBoxAlert.WordWrap = false;
            // 
            // labelColor
            // 
            this.labelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(761, 30);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(110, 17);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Цвет фрактала";
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonColor.Location = new System.Drawing.Point(764, 125);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(126, 53);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Изменить цвет фрактала";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(764, 63);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(126, 48);
            this.panelColor.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(967, 114);
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
            this.menuStrip1.Size = new System.Drawing.Size(1668, 28);
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
            this.ClientSize = new System.Drawing.Size(1668, 999);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelPicBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAgr.ResumeLayout(false);
            this.panelAgBot.ResumeLayout(false);
            this.panelAgBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCellNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimestep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelStokes.ResumeLayout(false);
            this.panelStokes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).EndInit();
            this.panelES.ResumeLayout(false);
            this.panelES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiff)).EndInit();
            this.panelRadius.ResumeLayout(false);
            this.panelRadius.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelta)).EndInit();
            this.panelPicBox.ResumeLayout(false);
            this.panelPicBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelAlert.ResumeLayout(false);
            this.panelAlert.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAgr;
        private System.Windows.Forms.Splitter splitterInAgr;
        private System.Windows.Forms.Panel panelAgBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеФракталаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеФракталаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTimestep;
        private System.Windows.Forms.Label labelTimestep;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NumericUpDown numericUpDownTimestep;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.ComboBox comboBoxRadius;
        private System.Windows.Forms.ComboBox comboBoxVisc;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelVisc;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownVisc;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panelPicBox;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.NumericUpDown numericUpDownFinalSize;
        private System.Windows.Forms.Label labelFinalSize;
        private System.Windows.Forms.CheckBox checkBoxCrop;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.NumericUpDown numericUpDownCellNum;
        private System.Windows.Forms.Label labelCellNum;
        private System.Windows.Forms.NumericUpDown numericCellSize;
        private System.Windows.Forms.Label labelCellSize;
        private System.Windows.Forms.NumericUpDown numericUpDownPercent;
        private System.Windows.Forms.CheckBox checkBoxES;
        private System.Windows.Forms.Panel panelStokes;
        private System.Windows.Forms.CheckBox checkBoxStokes;
        private System.Windows.Forms.Panel panelES;
        private System.Windows.Forms.ComboBox comboBoxDiff;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.NumericUpDown numericUpDownDiff;
        private System.Windows.Forms.Panel panelRadius;
        private System.Windows.Forms.ComboBox comboBoxDelta;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.NumericUpDown numericUpDownDelta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelAlert;
        private System.Windows.Forms.TextBox textBoxAlert;
    }
}

