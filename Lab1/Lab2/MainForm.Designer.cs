namespace Lab2
{
    partial class MainForm
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.uniformDistributionTabPage = new System.Windows.Forms.TabPage();
            this.uniformBNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uniformANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uniformMagicButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paramAErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gaussDistributionTabPage = new System.Windows.Forms.TabPage();
            this.gaussQNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussMNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gaussMagicButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exponentialDistributionTabPage = new System.Windows.Forms.TabPage();
            this.expLnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.expMagicButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gammaDistributiontabPage = new System.Windows.Forms.TabPage();
            this.gammaLNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaNNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaMagicButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.triangleDistributionTabPage = new System.Windows.Forms.TabPage();
            this.triangleMinRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleMaxRadioButton = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.triangleBNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.triangleANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.trinagleMagicButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.simpsonDistributionTabPage = new System.Windows.Forms.TabPage();
            this.simpsonBNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.simpsonANumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.simpsonMagicbutton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.uniformDistributionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniformBNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformANumericUpDown)).BeginInit();
            this.gaussDistributionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussQNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussMNumericUpDown)).BeginInit();
            this.exponentialDistributionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expLnumericUpDown)).BeginInit();
            this.gammaDistributiontabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaLNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNNumericUpDown)).BeginInit();
            this.triangleDistributionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleANumericUpDown)).BeginInit();
            this.simpsonDistributionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonBNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonANumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(663, 290);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(343, 122);
            this.resultTextBox.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 400);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.uniformDistributionTabPage);
            this.tabControl.Controls.Add(this.gaussDistributionTabPage);
            this.tabControl.Controls.Add(this.exponentialDistributionTabPage);
            this.tabControl.Controls.Add(this.gammaDistributiontabPage);
            this.tabControl.Controls.Add(this.triangleDistributionTabPage);
            this.tabControl.Controls.Add(this.simpsonDistributionTabPage);
            this.tabControl.Location = new System.Drawing.Point(659, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 276);
            this.tabControl.TabIndex = 5;
            // 
            // uniformDistributionTabPage
            // 
            this.uniformDistributionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.uniformDistributionTabPage.Controls.Add(this.uniformBNumericUpDown);
            this.uniformDistributionTabPage.Controls.Add(this.uniformANumericUpDown);
            this.uniformDistributionTabPage.Controls.Add(this.uniformMagicButton);
            this.uniformDistributionTabPage.Controls.Add(this.label4);
            this.uniformDistributionTabPage.Controls.Add(this.label2);
            this.uniformDistributionTabPage.Controls.Add(this.label3);
            this.uniformDistributionTabPage.Controls.Add(this.paramAErrorLabel);
            this.uniformDistributionTabPage.Controls.Add(this.label1);
            this.uniformDistributionTabPage.Location = new System.Drawing.Point(4, 40);
            this.uniformDistributionTabPage.Name = "uniformDistributionTabPage";
            this.uniformDistributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uniformDistributionTabPage.Size = new System.Drawing.Size(342, 232);
            this.uniformDistributionTabPage.TabIndex = 0;
            this.uniformDistributionTabPage.Text = "Равномерное";
            // 
            // uniformBNumericUpDown
            // 
            this.uniformBNumericUpDown.Location = new System.Drawing.Point(119, 67);
            this.uniformBNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uniformBNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.uniformBNumericUpDown.Name = "uniformBNumericUpDown";
            this.uniformBNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.uniformBNumericUpDown.TabIndex = 17;
            this.uniformBNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uniformANumericUpDown
            // 
            this.uniformANumericUpDown.Location = new System.Drawing.Point(119, 15);
            this.uniformANumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uniformANumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.uniformANumericUpDown.Name = "uniformANumericUpDown";
            this.uniformANumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.uniformANumericUpDown.TabIndex = 16;
            // 
            // uniformMagicButton
            // 
            this.uniformMagicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniformMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uniformMagicButton.Location = new System.Drawing.Point(107, 197);
            this.uniformMagicButton.Name = "uniformMagicButton";
            this.uniformMagicButton.Size = new System.Drawing.Size(151, 32);
            this.uniformMagicButton.TabIndex = 15;
            this.uniformMagicButton.Text = "Magic";
            this.uniformMagicButton.UseVisualStyleBackColor = false;
            this.uniformMagicButton.Click += new System.EventHandler(this.uniformMagicButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "paramBErrorLabel";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Параметр \'B\'";
            // 
            // paramAErrorLabel
            // 
            this.paramAErrorLabel.AutoSize = true;
            this.paramAErrorLabel.Location = new System.Drawing.Point(116, 38);
            this.paramAErrorLabel.Name = "paramAErrorLabel";
            this.paramAErrorLabel.Size = new System.Drawing.Size(91, 13);
            this.paramAErrorLabel.TabIndex = 10;
            this.paramAErrorLabel.Text = "paramAErrorLabel";
            this.paramAErrorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Параметр \'А\'";
            // 
            // gaussDistributionTabPage
            // 
            this.gaussDistributionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.gaussDistributionTabPage.Controls.Add(this.gaussQNumericUpDown);
            this.gaussDistributionTabPage.Controls.Add(this.gaussMNumericUpDown);
            this.gaussDistributionTabPage.Controls.Add(this.gaussMagicButton);
            this.gaussDistributionTabPage.Controls.Add(this.label5);
            this.gaussDistributionTabPage.Controls.Add(this.label6);
            this.gaussDistributionTabPage.Controls.Add(this.label7);
            this.gaussDistributionTabPage.Controls.Add(this.label8);
            this.gaussDistributionTabPage.Location = new System.Drawing.Point(4, 40);
            this.gaussDistributionTabPage.Name = "gaussDistributionTabPage";
            this.gaussDistributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gaussDistributionTabPage.Size = new System.Drawing.Size(342, 232);
            this.gaussDistributionTabPage.TabIndex = 1;
            this.gaussDistributionTabPage.Text = "Гаусса";
            // 
            // gaussQNumericUpDown
            // 
            this.gaussQNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gaussQNumericUpDown.Location = new System.Drawing.Point(119, 64);
            this.gaussQNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaussQNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gaussQNumericUpDown.Name = "gaussQNumericUpDown";
            this.gaussQNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.gaussQNumericUpDown.TabIndex = 24;
            this.gaussQNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gaussMNumericUpDown
            // 
            this.gaussMNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gaussMNumericUpDown.Location = new System.Drawing.Point(119, 12);
            this.gaussMNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gaussMNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.gaussMNumericUpDown.Name = "gaussMNumericUpDown";
            this.gaussMNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.gaussMNumericUpDown.TabIndex = 23;
            this.gaussMNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gaussMagicButton
            // 
            this.gaussMagicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gaussMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gaussMagicButton.Location = new System.Drawing.Point(107, 194);
            this.gaussMagicButton.Name = "gaussMagicButton";
            this.gaussMagicButton.Size = new System.Drawing.Size(151, 32);
            this.gaussMagicButton.TabIndex = 22;
            this.gaussMagicButton.Text = "Magic";
            this.gaussMagicButton.UseVisualStyleBackColor = false;
            this.gaussMagicButton.Click += new System.EventHandler(this.gaussMagicButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "paramBErrorLabel";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Параметр \'Q\'";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Параметр \'M\'";
            // 
            // exponentialDistributionTabPage
            // 
            this.exponentialDistributionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.exponentialDistributionTabPage.Controls.Add(this.expLnumericUpDown);
            this.exponentialDistributionTabPage.Controls.Add(this.expMagicButton);
            this.exponentialDistributionTabPage.Controls.Add(this.label9);
            this.exponentialDistributionTabPage.Controls.Add(this.label10);
            this.exponentialDistributionTabPage.Location = new System.Drawing.Point(4, 22);
            this.exponentialDistributionTabPage.Name = "exponentialDistributionTabPage";
            this.exponentialDistributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exponentialDistributionTabPage.Size = new System.Drawing.Size(342, 235);
            this.exponentialDistributionTabPage.TabIndex = 2;
            this.exponentialDistributionTabPage.Text = "Экспоненциальное";
            // 
            // expLnumericUpDown
            // 
            this.expLnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.expLnumericUpDown.Location = new System.Drawing.Point(119, 12);
            this.expLnumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.expLnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expLnumericUpDown.Name = "expLnumericUpDown";
            this.expLnumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.expLnumericUpDown.TabIndex = 27;
            this.expLnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // expMagicButton
            // 
            this.expMagicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expMagicButton.Location = new System.Drawing.Point(107, 194);
            this.expMagicButton.Name = "expMagicButton";
            this.expMagicButton.Size = new System.Drawing.Size(151, 32);
            this.expMagicButton.TabIndex = 26;
            this.expMagicButton.Text = "Magic";
            this.expMagicButton.UseVisualStyleBackColor = false;
            this.expMagicButton.Click += new System.EventHandler(this.expMagicButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Параметр \'L\'";
            // 
            // gammaDistributiontabPage
            // 
            this.gammaDistributiontabPage.BackColor = System.Drawing.SystemColors.Control;
            this.gammaDistributiontabPage.Controls.Add(this.gammaLNumericUpDown);
            this.gammaDistributiontabPage.Controls.Add(this.gammaNNumericUpDown);
            this.gammaDistributiontabPage.Controls.Add(this.gammaMagicButton);
            this.gammaDistributiontabPage.Controls.Add(this.label11);
            this.gammaDistributiontabPage.Controls.Add(this.label12);
            this.gammaDistributiontabPage.Controls.Add(this.label13);
            this.gammaDistributiontabPage.Controls.Add(this.label14);
            this.gammaDistributiontabPage.Location = new System.Drawing.Point(4, 40);
            this.gammaDistributiontabPage.Name = "gammaDistributiontabPage";
            this.gammaDistributiontabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gammaDistributiontabPage.Size = new System.Drawing.Size(342, 232);
            this.gammaDistributiontabPage.TabIndex = 3;
            this.gammaDistributiontabPage.Text = "Гамма";
            // 
            // gammaLNumericUpDown
            // 
            this.gammaLNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.gammaLNumericUpDown.Location = new System.Drawing.Point(119, 64);
            this.gammaLNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gammaLNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gammaLNumericUpDown.Name = "gammaLNumericUpDown";
            this.gammaLNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.gammaLNumericUpDown.TabIndex = 31;
            this.gammaLNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gammaNNumericUpDown
            // 
            this.gammaNNumericUpDown.Location = new System.Drawing.Point(119, 12);
            this.gammaNNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.gammaNNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gammaNNumericUpDown.Name = "gammaNNumericUpDown";
            this.gammaNNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.gammaNNumericUpDown.TabIndex = 30;
            this.gammaNNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gammaMagicButton
            // 
            this.gammaMagicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gammaMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gammaMagicButton.Location = new System.Drawing.Point(107, 194);
            this.gammaMagicButton.Name = "gammaMagicButton";
            this.gammaMagicButton.Size = new System.Drawing.Size(151, 32);
            this.gammaMagicButton.TabIndex = 29;
            this.gammaMagicButton.Text = "Magic";
            this.gammaMagicButton.UseVisualStyleBackColor = false;
            this.gammaMagicButton.Click += new System.EventHandler(this.gammaMagicButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "paramBErrorLabel";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Параметр \'L\'";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Параметр \'N\'";
            // 
            // triangleDistributionTabPage
            // 
            this.triangleDistributionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.triangleDistributionTabPage.Controls.Add(this.triangleMinRadioButton);
            this.triangleDistributionTabPage.Controls.Add(this.triangleMaxRadioButton);
            this.triangleDistributionTabPage.Controls.Add(this.label18);
            this.triangleDistributionTabPage.Controls.Add(this.triangleBNumericUpDown);
            this.triangleDistributionTabPage.Controls.Add(this.triangleANumericUpDown);
            this.triangleDistributionTabPage.Controls.Add(this.trinagleMagicButton);
            this.triangleDistributionTabPage.Controls.Add(this.label15);
            this.triangleDistributionTabPage.Controls.Add(this.label16);
            this.triangleDistributionTabPage.Controls.Add(this.label17);
            this.triangleDistributionTabPage.Location = new System.Drawing.Point(4, 40);
            this.triangleDistributionTabPage.Name = "triangleDistributionTabPage";
            this.triangleDistributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.triangleDistributionTabPage.Size = new System.Drawing.Size(342, 232);
            this.triangleDistributionTabPage.TabIndex = 4;
            this.triangleDistributionTabPage.Text = "Треугольное";
            // 
            // triangleMinRadioButton
            // 
            this.triangleMinRadioButton.AutoSize = true;
            this.triangleMinRadioButton.Location = new System.Drawing.Point(119, 122);
            this.triangleMinRadioButton.Name = "triangleMinRadioButton";
            this.triangleMinRadioButton.Size = new System.Drawing.Size(96, 17);
            this.triangleMinRadioButton.TabIndex = 26;
            this.triangleMinRadioButton.Text = "Минимальное";
            this.triangleMinRadioButton.UseVisualStyleBackColor = true;
            // 
            // triangleMaxRadioButton
            // 
            this.triangleMaxRadioButton.AutoSize = true;
            this.triangleMaxRadioButton.Checked = true;
            this.triangleMaxRadioButton.Location = new System.Drawing.Point(10, 122);
            this.triangleMaxRadioButton.Name = "triangleMaxRadioButton";
            this.triangleMaxRadioButton.Size = new System.Drawing.Size(102, 17);
            this.triangleMaxRadioButton.TabIndex = 25;
            this.triangleMaxRadioButton.TabStop = true;
            this.triangleMaxRadioButton.Text = "Максимальное";
            this.triangleMaxRadioButton.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(6, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "Параметр \'A\'";
            // 
            // triangleBNumericUpDown
            // 
            this.triangleBNumericUpDown.Location = new System.Drawing.Point(119, 62);
            this.triangleBNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.triangleBNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.triangleBNumericUpDown.Name = "triangleBNumericUpDown";
            this.triangleBNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.triangleBNumericUpDown.TabIndex = 23;
            this.triangleBNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // triangleANumericUpDown
            // 
            this.triangleANumericUpDown.Location = new System.Drawing.Point(119, 10);
            this.triangleANumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.triangleANumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.triangleANumericUpDown.Name = "triangleANumericUpDown";
            this.triangleANumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.triangleANumericUpDown.TabIndex = 22;
            // 
            // trinagleMagicButton
            // 
            this.trinagleMagicButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trinagleMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trinagleMagicButton.Location = new System.Drawing.Point(107, 192);
            this.trinagleMagicButton.Name = "trinagleMagicButton";
            this.trinagleMagicButton.Size = new System.Drawing.Size(151, 32);
            this.trinagleMagicButton.TabIndex = 21;
            this.trinagleMagicButton.Text = "Magic";
            this.trinagleMagicButton.UseVisualStyleBackColor = false;
            this.trinagleMagicButton.Click += new System.EventHandler(this.trinagleMagicButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "paramBErrorLabel";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Параметр \'B\'";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "label17";
            this.label17.Visible = false;
            // 
            // simpsonDistributionTabPage
            // 
            this.simpsonDistributionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.simpsonDistributionTabPage.Controls.Add(this.simpsonBNumericUpDown);
            this.simpsonDistributionTabPage.Controls.Add(this.simpsonANumericUpDown);
            this.simpsonDistributionTabPage.Controls.Add(this.simpsonMagicbutton);
            this.simpsonDistributionTabPage.Controls.Add(this.label19);
            this.simpsonDistributionTabPage.Controls.Add(this.label20);
            this.simpsonDistributionTabPage.Controls.Add(this.label21);
            this.simpsonDistributionTabPage.Controls.Add(this.label22);
            this.simpsonDistributionTabPage.Location = new System.Drawing.Point(4, 40);
            this.simpsonDistributionTabPage.Name = "simpsonDistributionTabPage";
            this.simpsonDistributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.simpsonDistributionTabPage.Size = new System.Drawing.Size(342, 232);
            this.simpsonDistributionTabPage.TabIndex = 5;
            this.simpsonDistributionTabPage.Text = "Симпсона";
            // 
            // simpsonBNumericUpDown
            // 
            this.simpsonBNumericUpDown.Location = new System.Drawing.Point(119, 64);
            this.simpsonBNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.simpsonBNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.simpsonBNumericUpDown.Name = "simpsonBNumericUpDown";
            this.simpsonBNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.simpsonBNumericUpDown.TabIndex = 24;
            this.simpsonBNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // simpsonANumericUpDown
            // 
            this.simpsonANumericUpDown.Location = new System.Drawing.Point(119, 12);
            this.simpsonANumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.simpsonANumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.simpsonANumericUpDown.Name = "simpsonANumericUpDown";
            this.simpsonANumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.simpsonANumericUpDown.TabIndex = 23;
            // 
            // simpsonMagicbutton
            // 
            this.simpsonMagicbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simpsonMagicbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpsonMagicbutton.Location = new System.Drawing.Point(107, 194);
            this.simpsonMagicbutton.Name = "simpsonMagicbutton";
            this.simpsonMagicbutton.Size = new System.Drawing.Size(151, 32);
            this.simpsonMagicbutton.TabIndex = 22;
            this.simpsonMagicbutton.Text = "Magic";
            this.simpsonMagicbutton.UseVisualStyleBackColor = false;
            this.simpsonMagicbutton.Click += new System.EventHandler(this.simpsonMagicbutton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(116, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "paramBErrorLabel";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Параметр \'B\'";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "label21";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(6, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "Параметр \'А\'";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 423);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.uniformDistributionTabPage.ResumeLayout(false);
            this.uniformDistributionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniformBNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniformANumericUpDown)).EndInit();
            this.gaussDistributionTabPage.ResumeLayout(false);
            this.gaussDistributionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussQNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussMNumericUpDown)).EndInit();
            this.exponentialDistributionTabPage.ResumeLayout(false);
            this.exponentialDistributionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expLnumericUpDown)).EndInit();
            this.gammaDistributiontabPage.ResumeLayout(false);
            this.gammaDistributiontabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaLNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNNumericUpDown)).EndInit();
            this.triangleDistributionTabPage.ResumeLayout(false);
            this.triangleDistributionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleANumericUpDown)).EndInit();
            this.simpsonDistributionTabPage.ResumeLayout(false);
            this.simpsonDistributionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonBNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonANumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage uniformDistributionTabPage;
        private System.Windows.Forms.TabPage gaussDistributionTabPage;
        private System.Windows.Forms.TabPage exponentialDistributionTabPage;
        private System.Windows.Forms.TabPage gammaDistributiontabPage;
        private System.Windows.Forms.TabPage triangleDistributionTabPage;
        private System.Windows.Forms.TabPage simpsonDistributionTabPage;
        private System.Windows.Forms.Label paramAErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uniformBNumericUpDown;
        private System.Windows.Forms.NumericUpDown uniformANumericUpDown;
        private System.Windows.Forms.Button uniformMagicButton;
        private System.Windows.Forms.NumericUpDown gaussQNumericUpDown;
        private System.Windows.Forms.NumericUpDown gaussMNumericUpDown;
        private System.Windows.Forms.Button gaussMagicButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown expLnumericUpDown;
        private System.Windows.Forms.Button expMagicButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown gammaLNumericUpDown;
        private System.Windows.Forms.NumericUpDown gammaNNumericUpDown;
        private System.Windows.Forms.Button gammaMagicButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown triangleBNumericUpDown;
        private System.Windows.Forms.NumericUpDown triangleANumericUpDown;
        private System.Windows.Forms.Button trinagleMagicButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton triangleMinRadioButton;
        private System.Windows.Forms.RadioButton triangleMaxRadioButton;
        private System.Windows.Forms.NumericUpDown simpsonBNumericUpDown;
        private System.Windows.Forms.NumericUpDown simpsonANumericUpDown;
        private System.Windows.Forms.Button simpsonMagicbutton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

