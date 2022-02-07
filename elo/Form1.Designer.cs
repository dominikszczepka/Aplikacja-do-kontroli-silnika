namespace elo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenCon = new System.Windows.Forms.Button();
            this.buttonCloseCon = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.textBoxEnterSpeed = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxRPM = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonMotorOn = new System.Windows.Forms.Button();
            this.buttonMotorOff = new System.Windows.Forms.Button();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVoltage = new System.Windows.Forms.TextBox();
            this.textBoxSpeedSet = new System.Windows.Forms.TextBox();
            this.rbKierunek1 = new System.Windows.Forms.RadioButton();
            this.rbKierunek2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.buttonSendPI = new System.Windows.Forms.Button();
            this.numericUpDownKP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKI = new System.Windows.Forms.NumericUpDown();
            this.buttonPIDef = new System.Windows.Forms.Button();
            this.buttonPIValues = new System.Windows.Forms.Button();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuPage = new System.Windows.Forms.TabPage();
            this.monitorPage = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pivaluesPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxKI = new System.Windows.Forms.TextBox();
            this.textBoxKP = new System.Windows.Forms.TextBox();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.buttonStopGraph = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStartGraph = new System.Windows.Forms.Button();
            this.tbTime2 = new System.Windows.Forms.TextBox();
            this.tbSpeed2 = new System.Windows.Forms.TextBox();
            this.tbSpeed1 = new System.Windows.Forms.TextBox();
            this.tbTime1 = new System.Windows.Forms.TextBox();
            this.tbSpeed5 = new System.Windows.Forms.TextBox();
            this.tbTime5 = new System.Windows.Forms.TextBox();
            this.tbSpeed4 = new System.Windows.Forms.TextBox();
            this.tbTime4 = new System.Windows.Forms.TextBox();
            this.tbSpeed3 = new System.Windows.Forms.TextBox();
            this.tbTime3 = new System.Windows.Forms.TextBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKI)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuPage.SuspendLayout();
            this.monitorPage.SuspendLayout();
            this.pivaluesPage.SuspendLayout();
            this.graphPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(180, 58);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(178, 28);
            this.cBoxComPort.TabIndex = 0;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1843200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(180, 92);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(178, 28);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "19200";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cBoxDataBits.Location = new System.Drawing.Point(180, 126);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(178, 28);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cBoxStopBits.Location = new System.Drawing.Point(180, 162);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(178, 28);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "1";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "Brak",
            "Nieparzystości",
            "Parzystości"});
            this.cBoxParityBits.Location = new System.Drawing.Point(180, 196);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(178, 28);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "Nieparzystości";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LuzSans-Book", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuzSans-Book", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szybkość transmisji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LuzSans-Book", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Długość słowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LuzSans-Book", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(31, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liczba bitów stopu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LuzSans-Book", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(32, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bit kontrolny";
            // 
            // buttonOpenCon
            // 
            this.buttonOpenCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonOpenCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCon.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.buttonOpenCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonOpenCon.Location = new System.Drawing.Point(46, 251);
            this.buttonOpenCon.Name = "buttonOpenCon";
            this.buttonOpenCon.Size = new System.Drawing.Size(109, 83);
            this.buttonOpenCon.TabIndex = 10;
            this.buttonOpenCon.Text = "Nawiąż połączenie";
            this.buttonOpenCon.UseVisualStyleBackColor = false;
            this.buttonOpenCon.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCloseCon
            // 
            this.buttonCloseCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonCloseCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseCon.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.buttonCloseCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonCloseCon.Location = new System.Drawing.Point(241, 251);
            this.buttonCloseCon.Name = "buttonCloseCon";
            this.buttonCloseCon.Size = new System.Drawing.Size(109, 83);
            this.buttonCloseCon.TabIndex = 11;
            this.buttonCloseCon.Text = "Zamknij połączenie";
            this.buttonCloseCon.UseVisualStyleBackColor = false;
            this.buttonCloseCon.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSend.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.ButtonSend.Location = new System.Drawing.Point(210, 131);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(130, 38);
            this.ButtonSend.TabIndex = 12;
            this.ButtonSend.Text = "Wyślij";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.Send_Click);
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.BackColor = System.Drawing.Color.OrangeRed;
            this.progressBarConnection.ForeColor = System.Drawing.Color.OrangeRed;
            this.progressBarConnection.Location = new System.Drawing.Point(47, 362);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(303, 30);
            this.progressBarConnection.TabIndex = 13;
            // 
            // textBoxEnterSpeed
            // 
            this.textBoxEnterSpeed.BackColor = System.Drawing.Color.White;
            this.textBoxEnterSpeed.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxEnterSpeed.Location = new System.Drawing.Point(210, 93);
            this.textBoxEnterSpeed.MaxLength = 5;
            this.textBoxEnterSpeed.Name = "textBoxEnterSpeed";
            this.textBoxEnterSpeed.Size = new System.Drawing.Size(130, 32);
            this.textBoxEnterSpeed.TabIndex = 16;
            this.textBoxEnterSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxRPM
            // 
            this.textBoxRPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxRPM.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxRPM.ForeColor = System.Drawing.Color.White;
            this.textBoxRPM.Location = new System.Drawing.Point(34, 118);
            this.textBoxRPM.Name = "textBoxRPM";
            this.textBoxRPM.ReadOnly = true;
            this.textBoxRPM.Size = new System.Drawing.Size(141, 32);
            this.textBoxRPM.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonMotorOn
            // 
            this.buttonMotorOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonMotorOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotorOn.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.buttonMotorOn.Location = new System.Drawing.Point(35, 372);
            this.buttonMotorOn.Name = "buttonMotorOn";
            this.buttonMotorOn.Size = new System.Drawing.Size(131, 70);
            this.buttonMotorOn.TabIndex = 20;
            this.buttonMotorOn.Text = "Załącz silnik";
            this.buttonMotorOn.UseVisualStyleBackColor = false;
            this.buttonMotorOn.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMotorOff
            // 
            this.buttonMotorOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonMotorOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMotorOff.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.buttonMotorOff.Location = new System.Drawing.Point(224, 372);
            this.buttonMotorOff.Name = "buttonMotorOff";
            this.buttonMotorOff.Size = new System.Drawing.Size(131, 70);
            this.buttonMotorOff.TabIndex = 21;
            this.buttonMotorOff.Text = "Wyłącz silnik";
            this.buttonMotorOff.UseVisualStyleBackColor = false;
            this.buttonMotorOff.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxCurrent.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxCurrent.ForeColor = System.Drawing.Color.White;
            this.textBoxCurrent.Location = new System.Drawing.Point(35, 184);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.ReadOnly = true;
            this.textBoxCurrent.Size = new System.Drawing.Size(140, 32);
            this.textBoxCurrent.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "RPM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Prąd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Napięcie";
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxVoltage.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxVoltage.ForeColor = System.Drawing.Color.White;
            this.textBoxVoltage.Location = new System.Drawing.Point(35, 248);
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.ReadOnly = true;
            this.textBoxVoltage.Size = new System.Drawing.Size(140, 32);
            this.textBoxVoltage.TabIndex = 28;
            // 
            // textBoxSpeedSet
            // 
            this.textBoxSpeedSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxSpeedSet.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxSpeedSet.ForeColor = System.Drawing.Color.White;
            this.textBoxSpeedSet.Location = new System.Drawing.Point(34, 54);
            this.textBoxSpeedSet.Name = "textBoxSpeedSet";
            this.textBoxSpeedSet.ReadOnly = true;
            this.textBoxSpeedSet.Size = new System.Drawing.Size(141, 32);
            this.textBoxSpeedSet.TabIndex = 29;
            // 
            // rbKierunek1
            // 
            this.rbKierunek1.AutoSize = true;
            this.rbKierunek1.Checked = true;
            this.rbKierunek1.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.rbKierunek1.ForeColor = System.Drawing.Color.White;
            this.rbKierunek1.Location = new System.Drawing.Point(210, 175);
            this.rbKierunek1.Name = "rbKierunek1";
            this.rbKierunek1.Size = new System.Drawing.Size(146, 30);
            this.rbKierunek1.TabIndex = 32;
            this.rbKierunek1.TabStop = true;
            this.rbKierunek1.Text = "Obroty Prawe";
            this.rbKierunek1.UseVisualStyleBackColor = true;
            // 
            // rbKierunek2
            // 
            this.rbKierunek2.AutoSize = true;
            this.rbKierunek2.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.rbKierunek2.ForeColor = System.Drawing.Color.White;
            this.rbKierunek2.Location = new System.Drawing.Point(210, 211);
            this.rbKierunek2.Name = "rbKierunek2";
            this.rbKierunek2.Size = new System.Drawing.Size(137, 30);
            this.rbKierunek2.TabIndex = 33;
            this.rbKierunek2.TabStop = true;
            this.rbKierunek2.Text = "Obroty Lewe";
            this.rbKierunek2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 34;
            this.label9.Text = "Temperatura";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxTemp.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBoxTemp.ForeColor = System.Drawing.Color.White;
            this.textBoxTemp.Location = new System.Drawing.Point(34, 316);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(141, 32);
            this.textBoxTemp.TabIndex = 35;
            // 
            // buttonSendPI
            // 
            this.buttonSendPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonSendPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendPI.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.buttonSendPI.Location = new System.Drawing.Point(43, 190);
            this.buttonSendPI.Name = "buttonSendPI";
            this.buttonSendPI.Size = new System.Drawing.Size(143, 42);
            this.buttonSendPI.TabIndex = 38;
            this.buttonSendPI.Text = "Zatwierdź nastawy";
            this.buttonSendPI.UseVisualStyleBackColor = false;
            this.buttonSendPI.Click += new System.EventHandler(this.buttonSendPI_Click);
            // 
            // numericUpDownKP
            // 
            this.numericUpDownKP.BackColor = System.Drawing.Color.White;
            this.numericUpDownKP.DecimalPlaces = 3;
            this.numericUpDownKP.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.numericUpDownKP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKP.Location = new System.Drawing.Point(154, 81);
            this.numericUpDownKP.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            196608});
            this.numericUpDownKP.Name = "numericUpDownKP";
            this.numericUpDownKP.Size = new System.Drawing.Size(130, 36);
            this.numericUpDownKP.TabIndex = 43;
            this.numericUpDownKP.Value = new decimal(new int[] {
            604,
            0,
            0,
            196608});
            // 
            // numericUpDownKI
            // 
            this.numericUpDownKI.BackColor = System.Drawing.Color.White;
            this.numericUpDownKI.DecimalPlaces = 4;
            this.numericUpDownKI.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.numericUpDownKI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownKI.Location = new System.Drawing.Point(154, 127);
            this.numericUpDownKI.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            262144});
            this.numericUpDownKI.Name = "numericUpDownKI";
            this.numericUpDownKI.Size = new System.Drawing.Size(130, 36);
            this.numericUpDownKI.TabIndex = 44;
            this.numericUpDownKI.Value = new decimal(new int[] {
            314,
            0,
            0,
            262144});
            // 
            // buttonPIDef
            // 
            this.buttonPIDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonPIDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPIDef.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.buttonPIDef.Location = new System.Drawing.Point(204, 190);
            this.buttonPIDef.Name = "buttonPIDef";
            this.buttonPIDef.Size = new System.Drawing.Size(143, 42);
            this.buttonPIDef.TabIndex = 45;
            this.buttonPIDef.Text = "Domyślne";
            this.buttonPIDef.UseVisualStyleBackColor = false;
            this.buttonPIDef.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPIValues
            // 
            this.buttonPIValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.buttonPIValues.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonPIValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPIValues.Font = new System.Drawing.Font("LuzSans-Book", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonPIValues.Location = new System.Drawing.Point(377, 182);
            this.buttonPIValues.Name = "buttonPIValues";
            this.buttonPIValues.Size = new System.Drawing.Size(98, 80);
            this.buttonPIValues.TabIndex = 46;
            this.buttonPIValues.Text = "Nastawy PI";
            this.buttonPIValues.UseVisualStyleBackColor = false;
            this.buttonPIValues.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.buttonMonitor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonitor.Font = new System.Drawing.Font("LuzSans-Book", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonMonitor.Location = new System.Drawing.Point(377, 96);
            this.buttonMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(100, 77);
            this.buttonMonitor.TabIndex = 48;
            this.buttonMonitor.Text = "Monitor";
            this.buttonMonitor.UseVisualStyleBackColor = false;
            this.buttonMonitor.Click += new System.EventHandler(this.Monitor_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.menuPage);
            this.tabControl1.Controls.Add(this.monitorPage);
            this.tabControl1.Controls.Add(this.pivaluesPage);
            this.tabControl1.Controls.Add(this.graphPage);
            this.tabControl1.Location = new System.Drawing.Point(-22, -30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 610);
            this.tabControl1.TabIndex = 49;
            // 
            // menuPage
            // 
            this.menuPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.menuPage.Controls.Add(this.buttonCloseCon);
            this.menuPage.Controls.Add(this.cBoxComPort);
            this.menuPage.Controls.Add(this.buttonOpenCon);
            this.menuPage.Controls.Add(this.label3);
            this.menuPage.Controls.Add(this.label2);
            this.menuPage.Controls.Add(this.progressBarConnection);
            this.menuPage.Controls.Add(this.label4);
            this.menuPage.Controls.Add(this.cBoxBaudRate);
            this.menuPage.Controls.Add(this.label1);
            this.menuPage.Controls.Add(this.label5);
            this.menuPage.Controls.Add(this.cBoxDataBits);
            this.menuPage.Controls.Add(this.cBoxParityBits);
            this.menuPage.Controls.Add(this.cBoxStopBits);
            this.menuPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(125)))), ((int)(((byte)(32)))));
            this.menuPage.Location = new System.Drawing.Point(4, 22);
            this.menuPage.Name = "menuPage";
            this.menuPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuPage.Size = new System.Drawing.Size(374, 584);
            this.menuPage.TabIndex = 0;
            this.menuPage.Text = "tabPage1";
            this.menuPage.Click += new System.EventHandler(this.menuPage_Click);
            // 
            // monitorPage
            // 
            this.monitorPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.monitorPage.Controls.Add(this.label19);
            this.monitorPage.Controls.Add(this.label18);
            this.monitorPage.Controls.Add(this.buttonMotorOn);
            this.monitorPage.Controls.Add(this.ButtonSend);
            this.monitorPage.Controls.Add(this.textBoxEnterSpeed);
            this.monitorPage.Controls.Add(this.textBoxRPM);
            this.monitorPage.Controls.Add(this.buttonMotorOff);
            this.monitorPage.Controls.Add(this.textBoxCurrent);
            this.monitorPage.Controls.Add(this.label6);
            this.monitorPage.Controls.Add(this.label7);
            this.monitorPage.Controls.Add(this.textBoxTemp);
            this.monitorPage.Controls.Add(this.label8);
            this.monitorPage.Controls.Add(this.label9);
            this.monitorPage.Controls.Add(this.textBoxVoltage);
            this.monitorPage.Controls.Add(this.rbKierunek2);
            this.monitorPage.Controls.Add(this.textBoxSpeedSet);
            this.monitorPage.Controls.Add(this.rbKierunek1);
            this.monitorPage.Location = new System.Drawing.Point(4, 22);
            this.monitorPage.Name = "monitorPage";
            this.monitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorPage.Size = new System.Drawing.Size(374, 584);
            this.monitorPage.TabIndex = 1;
            this.monitorPage.Text = "tabPage2";
            this.monitorPage.Click += new System.EventHandler(this.monitorPage_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(180, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(194, 26);
            this.label19.TabIndex = 38;
            this.label19.Text = "Zadaj prędkość [RPM]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(30, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 26);
            this.label18.TabIndex = 37;
            this.label18.Text = "Zadana prędkość [RPM]";
            // 
            // pivaluesPage
            // 
            this.pivaluesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.pivaluesPage.Controls.Add(this.label10);
            this.pivaluesPage.Controls.Add(this.label11);
            this.pivaluesPage.Controls.Add(this.label22);
            this.pivaluesPage.Controls.Add(this.label23);
            this.pivaluesPage.Controls.Add(this.label21);
            this.pivaluesPage.Controls.Add(this.label20);
            this.pivaluesPage.Controls.Add(this.textBoxKI);
            this.pivaluesPage.Controls.Add(this.textBoxKP);
            this.pivaluesPage.Controls.Add(this.numericUpDownKP);
            this.pivaluesPage.Controls.Add(this.buttonSendPI);
            this.pivaluesPage.Controls.Add(this.buttonPIDef);
            this.pivaluesPage.Controls.Add(this.numericUpDownKI);
            this.pivaluesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.pivaluesPage.Location = new System.Drawing.Point(4, 22);
            this.pivaluesPage.Name = "pivaluesPage";
            this.pivaluesPage.Size = new System.Drawing.Size(374, 584);
            this.pivaluesPage.TabIndex = 2;
            this.pivaluesPage.Text = "tabPage1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(106, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 26);
            this.label10.TabIndex = 52;
            this.label10.Text = "KP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(106, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "KI";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(106, 307);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 26);
            this.label22.TabIndex = 50;
            this.label22.Text = "KP";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(106, 355);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 26);
            this.label23.TabIndex = 51;
            this.label23.Text = "KI";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(101, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 29);
            this.label21.TabIndex = 49;
            this.label21.Text = "Aktualna Wartość";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(106, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 29);
            this.label20.TabIndex = 48;
            this.label20.Text = "Zadaj Wartość";
            // 
            // textBoxKI
            // 
            this.textBoxKI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxKI.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.textBoxKI.ForeColor = System.Drawing.Color.White;
            this.textBoxKI.Location = new System.Drawing.Point(154, 350);
            this.textBoxKI.Name = "textBoxKI";
            this.textBoxKI.ReadOnly = true;
            this.textBoxKI.Size = new System.Drawing.Size(130, 36);
            this.textBoxKI.TabIndex = 47;
            // 
            // textBoxKP
            // 
            this.textBoxKP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBoxKP.Font = new System.Drawing.Font("LuzSans-Book", 16.25F);
            this.textBoxKP.ForeColor = System.Drawing.Color.White;
            this.textBoxKP.Location = new System.Drawing.Point(154, 302);
            this.textBoxKP.Name = "textBoxKP";
            this.textBoxKP.ReadOnly = true;
            this.textBoxKP.Size = new System.Drawing.Size(130, 36);
            this.textBoxKP.TabIndex = 46;
            // 
            // graphPage
            // 
            this.graphPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.graphPage.Controls.Add(this.buttonStopGraph);
            this.graphPage.Controls.Add(this.label17);
            this.graphPage.Controls.Add(this.textBox1);
            this.graphPage.Controls.Add(this.label16);
            this.graphPage.Controls.Add(this.label15);
            this.graphPage.Controls.Add(this.label12);
            this.graphPage.Controls.Add(this.label14);
            this.graphPage.Controls.Add(this.label13);
            this.graphPage.Controls.Add(this.chart1);
            this.graphPage.Controls.Add(this.buttonStartGraph);
            this.graphPage.Controls.Add(this.tbTime2);
            this.graphPage.Controls.Add(this.tbSpeed2);
            this.graphPage.Controls.Add(this.tbSpeed1);
            this.graphPage.Controls.Add(this.tbTime1);
            this.graphPage.Controls.Add(this.tbSpeed5);
            this.graphPage.Controls.Add(this.tbTime5);
            this.graphPage.Controls.Add(this.tbSpeed4);
            this.graphPage.Controls.Add(this.tbTime4);
            this.graphPage.Controls.Add(this.tbSpeed3);
            this.graphPage.Controls.Add(this.tbTime3);
            this.graphPage.Controls.Add(this.rb5);
            this.graphPage.Controls.Add(this.rb4);
            this.graphPage.Controls.Add(this.rb3);
            this.graphPage.Controls.Add(this.rb2);
            this.graphPage.Location = new System.Drawing.Point(4, 22);
            this.graphPage.Name = "graphPage";
            this.graphPage.Size = new System.Drawing.Size(374, 584);
            this.graphPage.TabIndex = 3;
            this.graphPage.Text = "tabPage1";
            this.graphPage.Click += new System.EventHandler(this.graphPage_Click);
            // 
            // buttonStopGraph
            // 
            this.buttonStopGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonStopGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopGraph.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.buttonStopGraph.Location = new System.Drawing.Point(243, 204);
            this.buttonStopGraph.Name = "buttonStopGraph";
            this.buttonStopGraph.Size = new System.Drawing.Size(114, 36);
            this.buttonStopGraph.TabIndex = 70;
            this.buttonStopGraph.Text = "Stop";
            this.buttonStopGraph.UseVisualStyleBackColor = false;
            this.buttonStopGraph.Click += new System.EventHandler(this.buttonStopGraph_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(38, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 69;
            this.label17.Text = "RPM";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(21, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(82, 32);
            this.textBox1.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 23);
            this.label16.TabIndex = 51;
            this.label16.Text = " wykresu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(25, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 23);
            this.label15.TabIndex = 67;
            this.label15.Text = " punktów";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 23);
            this.label12.TabIndex = 66;
            this.label12.Text = "Liczba";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(274, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 65;
            this.label14.Text = "RPM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("LuzSans-Book", 12.25F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(128, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 23);
            this.label13.TabIndex = 64;
            this.label13.Text = "Czas [ms]";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 241);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(359, 211);
            this.chart1.TabIndex = 63;
            this.chart1.Text = "chart1";
            // 
            // buttonStartGraph
            // 
            this.buttonStartGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonStartGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGraph.Font = new System.Drawing.Font("LuzSans-Book", 14.25F);
            this.buttonStartGraph.Location = new System.Drawing.Point(110, 204);
            this.buttonStartGraph.Name = "buttonStartGraph";
            this.buttonStartGraph.Size = new System.Drawing.Size(114, 36);
            this.buttonStartGraph.TabIndex = 61;
            this.buttonStartGraph.Text = "Start";
            this.buttonStartGraph.UseVisualStyleBackColor = false;
            this.buttonStartGraph.Click += new System.EventHandler(this.buttonStartGraph_Click);
            // 
            // tbTime2
            // 
            this.tbTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTime2.Location = new System.Drawing.Point(109, 92);
            this.tbTime2.MaxLength = 5;
            this.tbTime2.Name = "tbTime2";
            this.tbTime2.Size = new System.Drawing.Size(114, 29);
            this.tbTime2.TabIndex = 59;
            this.tbTime2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime2_KeyPress);
            // 
            // tbSpeed2
            // 
            this.tbSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbSpeed2.Location = new System.Drawing.Point(242, 92);
            this.tbSpeed2.MaxLength = 5;
            this.tbSpeed2.Name = "tbSpeed2";
            this.tbSpeed2.Size = new System.Drawing.Size(114, 29);
            this.tbSpeed2.TabIndex = 58;
            this.tbSpeed2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed2_KeyPress);
            // 
            // tbSpeed1
            // 
            this.tbSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbSpeed1.Location = new System.Drawing.Point(242, 66);
            this.tbSpeed1.MaxLength = 5;
            this.tbSpeed1.Name = "tbSpeed1";
            this.tbSpeed1.Size = new System.Drawing.Size(114, 29);
            this.tbSpeed1.TabIndex = 57;
            this.tbSpeed1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed1_KeyPress);
            // 
            // tbTime1
            // 
            this.tbTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTime1.Location = new System.Drawing.Point(109, 66);
            this.tbTime1.MaxLength = 5;
            this.tbTime1.Name = "tbTime1";
            this.tbTime1.Size = new System.Drawing.Size(114, 29);
            this.tbTime1.TabIndex = 56;
            this.tbTime1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime1_KeyPress);
            // 
            // tbSpeed5
            // 
            this.tbSpeed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbSpeed5.Location = new System.Drawing.Point(242, 170);
            this.tbSpeed5.MaxLength = 5;
            this.tbSpeed5.Name = "tbSpeed5";
            this.tbSpeed5.Size = new System.Drawing.Size(114, 29);
            this.tbSpeed5.TabIndex = 55;
            this.tbSpeed5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed5_KeyPress);
            // 
            // tbTime5
            // 
            this.tbTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTime5.Location = new System.Drawing.Point(109, 170);
            this.tbTime5.MaxLength = 5;
            this.tbTime5.Name = "tbTime5";
            this.tbTime5.Size = new System.Drawing.Size(114, 29);
            this.tbTime5.TabIndex = 54;
            this.tbTime5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime5_KeyPress);
            // 
            // tbSpeed4
            // 
            this.tbSpeed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbSpeed4.Location = new System.Drawing.Point(242, 144);
            this.tbSpeed4.MaxLength = 5;
            this.tbSpeed4.Name = "tbSpeed4";
            this.tbSpeed4.Size = new System.Drawing.Size(114, 29);
            this.tbSpeed4.TabIndex = 53;
            this.tbSpeed4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed4_KeyPress);
            // 
            // tbTime4
            // 
            this.tbTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTime4.Location = new System.Drawing.Point(109, 144);
            this.tbTime4.MaxLength = 5;
            this.tbTime4.Name = "tbTime4";
            this.tbTime4.Size = new System.Drawing.Size(114, 29);
            this.tbTime4.TabIndex = 52;
            this.tbTime4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime4_KeyPress);
            // 
            // tbSpeed3
            // 
            this.tbSpeed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbSpeed3.Location = new System.Drawing.Point(242, 118);
            this.tbSpeed3.MaxLength = 5;
            this.tbSpeed3.Name = "tbSpeed3";
            this.tbSpeed3.Size = new System.Drawing.Size(114, 29);
            this.tbSpeed3.TabIndex = 51;
            this.tbSpeed3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed3_KeyPress);
            // 
            // tbTime3
            // 
            this.tbTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTime3.Location = new System.Drawing.Point(109, 118);
            this.tbTime3.MaxLength = 5;
            this.tbTime3.Name = "tbTime3";
            this.tbTime3.Size = new System.Drawing.Size(114, 29);
            this.tbTime3.TabIndex = 6;
            this.tbTime3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime3_KeyPress);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rb5.ForeColor = System.Drawing.Color.White;
            this.rb5.Location = new System.Drawing.Point(42, 162);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(36, 24);
            this.rb5.TabIndex = 5;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rb4.ForeColor = System.Drawing.Color.White;
            this.rb4.Location = new System.Drawing.Point(42, 136);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(36, 24);
            this.rb4.TabIndex = 4;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rb3.ForeColor = System.Drawing.Color.White;
            this.rb3.Location = new System.Drawing.Point(42, 110);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(36, 24);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rb2.ForeColor = System.Drawing.Color.White;
            this.rb2.Location = new System.Drawing.Point(42, 87);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(36, 24);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("LuzSans-Book", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.Location = new System.Drawing.Point(377, 10);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 80);
            this.buttonMenu.TabIndex = 49;
            this.buttonMenu.Text = "Połączenie";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(65)))), ((int)(((byte)(0)))));
            this.buttonGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.buttonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph.Font = new System.Drawing.Font("LuzSans-Book", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonGraph.Location = new System.Drawing.Point(377, 268);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(98, 80);
            this.buttonGraph.TabIndex = 50;
            this.buttonGraph.Text = "Wykres";
            this.buttonGraph.UseVisualStyleBackColor = false;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(176)))), ((int)(((byte)(29)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("LuzSans-Book", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(377, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 80);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(489, 446);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonMonitor);
            this.Controls.Add(this.buttonPIValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKI)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuPage.ResumeLayout(false);
            this.menuPage.PerformLayout();
            this.monitorPage.ResumeLayout(false);
            this.monitorPage.PerformLayout();
            this.pivaluesPage.ResumeLayout(false);
            this.pivaluesPage.PerformLayout();
            this.graphPage.ResumeLayout(false);
            this.graphPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOpenCon;
        private System.Windows.Forms.Button buttonCloseCon;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.TextBox textBoxEnterSpeed;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.TextBox textBoxRPM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMotorOn;
        private System.Windows.Forms.Button buttonMotorOff;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVoltage;
        private System.Windows.Forms.TextBox textBoxSpeedSet;
        private System.Windows.Forms.RadioButton rbKierunek1;
        private System.Windows.Forms.RadioButton rbKierunek2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Button buttonSendPI;
        private System.Windows.Forms.NumericUpDown numericUpDownKP;
        private System.Windows.Forms.NumericUpDown numericUpDownKI;
        private System.Windows.Forms.Button buttonPIDef;
        private System.Windows.Forms.Button buttonPIValues;
        private System.Windows.Forms.Button buttonMonitor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage monitorPage;
        private System.Windows.Forms.TabPage menuPage;
        private System.Windows.Forms.TabPage pivaluesPage;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.TextBox textBoxKI;
        private System.Windows.Forms.TextBox textBoxKP;
        private System.Windows.Forms.TabPage graphPage;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.TextBox tbTime2;
        private System.Windows.Forms.TextBox tbSpeed2;
        private System.Windows.Forms.TextBox tbSpeed1;
        private System.Windows.Forms.TextBox tbTime1;
        private System.Windows.Forms.TextBox tbSpeed5;
        private System.Windows.Forms.TextBox tbTime5;
        private System.Windows.Forms.TextBox tbSpeed4;
        private System.Windows.Forms.TextBox tbTime4;
        private System.Windows.Forms.TextBox tbSpeed3;
        private System.Windows.Forms.TextBox tbTime3;
        private System.Windows.Forms.Button buttonStartGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStopGraph;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

