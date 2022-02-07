using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace elo
{

    public partial class Form1 : Form
    {

        string dataReceived;
        char[] dataOut;
        int KP_licz = 0, KP_mian = 1, KI_licz = 0, KI_mian = 1;
        short numberOfPoints;
        short[] times = new short[6];
        short[] speeds = new short[6];
        Point offset;
        bool mouseDown, stopCurve;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
            times[0] = 0;
            speeds[0] = 0;
            chart1.ChartAreas[0].BackColor = Color.FromArgb(69, 73, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                if (cBoxStopBits.Text == "0")
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "None");
                else if (cBoxStopBits.Text == "1")
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                else if (cBoxStopBits.Text == "2")
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "Two");
                if (cBoxParityBits.Text == "Brak")
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                else if (cBoxParityBits.Text == "Nieparzystości")
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "Odd");
                else if (cBoxParityBits.Text == "Parzystości")
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "Even");

                serialPort1.Open();
                progressBarConnection.Value = 100;
                buttonPIValues.BackColor = Color.FromArgb(114, 176, 29);
                buttonMonitor.BackColor = Color.FromArgb(114, 176, 29);
                buttonGraph.BackColor = Color.FromArgb(114, 176, 29);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBarConnection.Value = 0;
                buttonPIValues.BackColor = Color.FromArgb(24, 65, 0);
                buttonMonitor.BackColor = Color.FromArgb(24, 65, 0);
                buttonGraph.BackColor = Color.FromArgb(24, 65, 0);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string pomocniczy;
            short number;
            char[] kierunek1 = { 'k', '1', '0', '0', '0', '0' };
            char[] kierunek2 = { 'k', '0', '0', '0', '0', '0' };
            if (serialPort1.IsOpen)
            {
                pomocniczy = textBoxEnterSpeed.Text;
                if (Int16.TryParse(pomocniczy, out number) & pomocniczy.Length >= 1)
                {
                    if (number > 15000)
                    {
                        number = 15000;
                        pomocniczy = number.ToString();
                    }
                    while (pomocniczy.Length < 5)
                        pomocniczy = "0" + pomocniczy;

                    pomocniczy = "s" + pomocniczy;
                    dataOut = pomocniczy.ToCharArray();
                    if (rbKierunek1.Checked)
                        serialPort1.Write(kierunek1, 0, 6);
                    else if (rbKierunek2.Checked)
                        serialPort1.Write(kierunek2, 0, 6);
                    Task.Delay(10);
                    serialPort1.Write(dataOut, 0, 6);

                }
                else if (pomocniczy=="")
                {
                    if (rbKierunek1.Checked)
                        serialPort1.Write(kierunek1, 0, 6);
                    else if (rbKierunek2.Checked)
                        serialPort1.Write(kierunek2, 0, 6);
                }

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                char[] start = { 'e', '0', '0', '0', '0', '0' };
                serialPort1.Write(start, 0, 6);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = "";

            if (serialPort1.IsOpen)
            {
                dataReceived = serialPort1.ReadExisting();
                if (!string.IsNullOrEmpty(dataReceived))
                {
                    if (DsOdbierz("SPEED:", "RPM", ref a))
                    { 
                        textBoxRPM.Text = a;
                        textBox1.Text = a;
                    }
                    if (DsOdbierz("CURRENT:", "AMP", ref a))
                        textBoxCurrent.Text = a + " A";
                    if (DsOdbierz("VOLTAGE:", "VLT", ref a))
                        textBoxVoltage.Text = a + " V";
                    if (DsOdbierz("VALUE:", "SET", ref a))
                        textBoxSpeedSet.Text = a;
                    if (DsOdbierz("TEMP:", "CEL", ref a))
                        textBoxTemp.Text = a + (Char)176 + "C";
                    DsOdbierzInt("KPL:", "PLICZ", ref KP_licz);
                    DsOdbierzInt("KPM:", "PMIAN", ref KP_mian);
                    DsOdbierzInt("KIL:", "ILICZ", ref KI_licz);
                    DsOdbierzInt("KIM:", "IMIAN", ref KI_mian);
                }
                textBoxKP.Text = ((double)KP_licz / (double)KP_mian).ToString("0.000");
                textBoxKI.Text = ((double)KI_licz / (double)KI_mian).ToString("0.0000");
            }

            if (rb2.Checked)
            {
                numberOfPoints = 2;
                tbSpeed3.ReadOnly = true;
                tbSpeed3.BackColor = Color.FromArgb(24, 65, 0);
                tbTime3.ReadOnly = true;
                tbTime3.BackColor = Color.FromArgb(24, 65, 0);
                tbSpeed4.ReadOnly = true;
                tbSpeed4.BackColor = Color.FromArgb(24, 65, 0);
                tbTime4.ReadOnly = true;
                tbTime4.BackColor = Color.FromArgb(24, 65, 0);
                tbSpeed5.ReadOnly = true;
                tbSpeed5.BackColor = Color.FromArgb(24, 65, 0);
                tbTime5.ReadOnly = true;
                tbTime5.BackColor = Color.FromArgb(24, 65, 0);
            }
            else if (rb3.Checked)
            {
                numberOfPoints = 3;
                tbSpeed3.ReadOnly = false;
                tbSpeed3.BackColor = Color.White;
                tbTime3.ReadOnly = false;
                tbTime3.BackColor = Color.White;
                tbSpeed4.ReadOnly = true;
                tbSpeed4.BackColor = Color.FromArgb(24, 65, 0);
                tbTime4.ReadOnly = true;
                tbTime4.BackColor = Color.FromArgb(24, 65, 0);
                tbSpeed5.ReadOnly = true;
                tbSpeed5.BackColor = Color.FromArgb(24, 65, 0);
                tbTime5.ReadOnly = true;
                tbTime5.BackColor = Color.FromArgb(24, 65, 0);
            }
            else if (rb4.Checked)
            {
                numberOfPoints = 4;
                tbSpeed3.ReadOnly = false;
                tbSpeed3.BackColor = Color.White;
                tbTime3.ReadOnly = false;
                tbTime3.BackColor = Color.White;
                tbSpeed4.ReadOnly = false;
                tbSpeed4.BackColor = Color.White;
                tbTime4.ReadOnly = false;
                tbTime4.BackColor = Color.White;
                tbSpeed5.ReadOnly = true;
                tbSpeed5.BackColor = Color.FromArgb(24, 65, 0);
                tbTime5.ReadOnly = true;
                tbTime5.BackColor = Color.FromArgb(24, 65, 0);
            }
            else if (rb5.Checked)
            {
                numberOfPoints = 5;
                tbSpeed3.ReadOnly = false;
                tbSpeed3.BackColor = Color.White;
                tbTime3.ReadOnly = false;
                tbTime3.BackColor = Color.White;
                tbSpeed4.ReadOnly = false;
                tbSpeed4.BackColor = Color.White;
                tbTime4.ReadOnly = false;
                tbTime4.BackColor = Color.White;
                tbSpeed5.ReadOnly = false;
                tbSpeed5.BackColor = Color.White;
                tbTime5.ReadOnly = false;
                tbTime5.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = "f00000".ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                tabControl1.SelectedTab = pivaluesPage;
                dataOut = "v00000".ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
                Task.Delay(20);
                numericUpDownKP.Maximum = (decimal)(Int16.MaxValue / (double)KP_mian);
                numericUpDownKI.Maximum = (decimal)(Int16.MaxValue / (double)KI_mian);
                Task.Delay(10);
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                tabControl1.SelectedTab = monitorPage;
                dataOut = "m00000".ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
                Task.Delay(10);
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = menuPage;
            if (serialPort1.IsOpen)
            {
                Task.Delay(10);
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
        }

        private void monitorPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                tabControl1.SelectedTab = graphPage;
                dataOut = "g00000".ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
                Task.Delay(20);
                chart1.Series.Clear();
                Task.Delay(10);
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
            }
        }

        private void buttonStartGraph_Click(object sender, EventArgs e)
        {
            stopCurve = false;
            char[] kierunek = { 'k', '1', '0', '0', '0', '0' };
            short sh_speed, sh_time;
            var objChart = chart1.ChartAreas[0];
            bool error=false;
            serialPort1.Write(kierunek, 0, 6);
            Task.Delay(10);
            if (numberOfPoints >= 2)
            {

                if (!(Int16.TryParse(tbTime1.Text, out sh_time) & Int16.TryParse(tbSpeed1.Text, out sh_speed)))
                {
                    sh_time = times[0];
                    sh_time += 1000;
                    tbTime1.Text = (sh_time).ToString();
                    sh_speed = speeds[0];
                    tbSpeed1.Text = (sh_speed).ToString();
                }
                times[1] = sh_time;
                speeds[1] = sh_speed;
                if (!(Int16.TryParse(tbTime2.Text, out sh_time) & Int16.TryParse(tbSpeed2.Text, out sh_speed)))
                {
                    sh_time = times[1];
                    sh_time += 1000;
                    tbTime2.Text = (sh_time).ToString();
                    sh_speed = speeds[1];
                    tbSpeed2.Text = (sh_speed).ToString();
                }
                times[2] = sh_time;
                speeds[2] = sh_speed;
                if (numberOfPoints == 2)
                {
                    objChart.AxisX.Minimum = 0;
                    objChart.AxisX.Maximum = times[2] / 1000;
                    DsDrawGraph();
                }
            }
            if (numberOfPoints >= 3)
            {
                if (!(Int16.TryParse(tbTime3.Text, out sh_time) & Int16.TryParse(tbSpeed3.Text, out sh_speed)))
                {
                    sh_time = times[2];
                    sh_time += 1000;
                    tbTime3.Text = (sh_time).ToString();
                    sh_speed = speeds[2];
                    tbSpeed3.Text = (sh_speed).ToString();
                }
                times[3] = sh_time;
                speeds[3] = sh_speed;
                if (numberOfPoints == 3)
                {
                    objChart.AxisX.Minimum = 0;
                    objChart.AxisX.Maximum = times[3] / 1000;
                    DsDrawGraph();
                }

            }
            if (numberOfPoints >= 4)
            {

                if (!(Int16.TryParse(tbTime4.Text, out sh_time) & Int16.TryParse(tbSpeed4.Text, out sh_speed)))
                {
                    sh_time = times[3];
                    sh_time += 1000;
                    tbTime4.Text = (sh_time).ToString();
                    sh_speed = speeds[3];
                    tbSpeed4.Text = (sh_speed).ToString();
                }
                times[4] = sh_time;
                speeds[4] = sh_speed;
                if (numberOfPoints == 4)
                {
                    objChart.AxisX.Minimum = 0;
                    objChart.AxisX.Maximum = times[4] / 1000;
                    DsDrawGraph();
                }
            }
            if (numberOfPoints == 5)
            {
                if (!(Int16.TryParse(tbTime5.Text, out sh_time) & Int16.TryParse(tbSpeed5.Text, out sh_speed)))
                {
                    sh_time = times[4];
                    sh_time += 1000;
                    tbTime5.Text = (sh_time).ToString();
                    sh_speed = speeds[4];
                    tbSpeed5.Text = (sh_speed).ToString();
                }
                times[5] = sh_time;
                speeds[5] = sh_speed;
                if (numberOfPoints == 5)
                {
                    objChart.AxisX.Minimum = 0;
                    objChart.AxisX.Maximum = times[5] / 1000;
                    DsDrawGraph();
                }

            }
            for (int i = 1; i <= numberOfPoints; i++)
            {
                if (times[i] < times[i - 1])
                {
                    MessageBox.Show("Nieprawidłowa wartość czasu w oknie " + i.ToString(), "Błąd wartości", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stopCurve = true;
                    error = true;
                }
            }
            DsExecuteCurve(error);
        }

        private void buttonSendPI_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string pom_KP, pom_KI;
                int kp, ki;
                kp = (int)(numericUpDownKP.Value * KP_mian);
                ki = (int)(numericUpDownKI.Value * KI_mian);
                pom_KP = kp.ToString("00000");
                pom_KI = ki.ToString("00000");
                pom_KP = "p" + pom_KP;
                pom_KI = "i" + pom_KI;

                dataOut = pom_KP.ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
                Task.Delay(20);
                dataOut = pom_KI.ToCharArray();
                serialPort1.Write(dataOut, 0, 6);
                Task.Delay(20);
                dataOut = "c00000".ToCharArray();
                serialPort1.Write(dataOut, 0, 6);

            }
        }

        private void tbTime1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSpeed1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTime2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSpeed2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTime3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSpeed3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTime4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSpeed4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbTime5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSpeed5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonStopGraph_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                char[] stop = { 'd', '0', '0', '0', '0', '0' };
                serialPort1.Write(stop, 0, 6);
                stopCurve = true;
            }
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void menuPage_Click(object sender, EventArgs e)
        {

        }

        private void graphPage_Click(object sender, EventArgs e)
        {

        }

        private void DsWyslijSpeed(string text, int cnt)
        {
            string pomocniczy;
            short number;
            if (serialPort1.IsOpen)
            {
                pomocniczy = text;
                if (Int16.TryParse(pomocniczy, out number) & pomocniczy.Length >= 1)
                {
                    if (number > 15000)
                    {
                        speeds[cnt] = 15000;
                        pomocniczy = "15000";
                        if (cnt == 1)
                            tbSpeed1.Text = pomocniczy;
                        else if (cnt == 2)
                            tbSpeed2.Text = pomocniczy;
                        else if (cnt == 3)
                            tbSpeed3.Text = pomocniczy;
                        else if (cnt == 4)
                            tbSpeed4.Text = pomocniczy;
                        else if (cnt == 5)
                            tbSpeed5.Text = pomocniczy;
                    }

                    else if (pomocniczy == "")
                    {
                        speeds[cnt] = speeds[cnt - 1];
                        pomocniczy = speeds[cnt - 1].ToString();
                        if (cnt == 1)
                            tbSpeed1.Text = pomocniczy;
                        else if (cnt == 2)
                            tbSpeed2.Text = pomocniczy;
                        else if (cnt == 3)
                            tbSpeed3.Text = pomocniczy;
                        else if (cnt == 4)
                            tbSpeed4.Text = pomocniczy;
                        else if (cnt == 5)
                            tbSpeed5.Text = pomocniczy;
                    }
                    else speeds[cnt] = number;
                    while (pomocniczy.Length < 5)
                        pomocniczy = "0" + pomocniczy;

                    pomocniczy = "s" + pomocniczy;
                    dataOut = pomocniczy.ToCharArray();
                    serialPort1.Write(dataOut, 0, 6);

                }
            }
        }
        private bool DsWyslijTime(string text, string prev_text, int cnt)
        {
            short number, prev_number;
            if (serialPort1.IsOpen)
            {
                if (Int16.TryParse(text, out number) & text.Length >= 1 & Int16.TryParse(prev_text, out prev_number) & prev_text.Length >= 1)
                {
                    if (number > prev_number)
                    {
                        text = (number - prev_number).ToString();
                        times[cnt] = number;

                        while (text.Length < 5)
                            text = "0" + text;

                        text = "t" + text;
                        dataOut = text.ToCharArray();
                        serialPort1.Write(dataOut, 0, 6);
                        return true;
                    }

                }
               
            }
            return false;
        }
        private void DsDrawGraph()
        {
            chart1.Series.Clear();
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.LabelStyle.Format = "";
            objChart.AxisY.LabelStyle.Format = "";
            objChart.AxisY.LabelStyle.IsEndLabelVisible = true;


            chart1.Series.Add("RPM");

            chart1.Series["RPM"].ChartType = SeriesChartType.Line;
            chart1.Series["RPM"].Color = Color.FromArgb(114, 176, 29);
            chart1.Series[0].IsVisibleInLegend = false;
            for (int i = 0; i <= numberOfPoints; i++)
            {
                chart1.Series["RPM"].Points.AddXY(times[i] / 1000, speeds[i]);
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].BackColor = Color.FromArgb(69, 73, 85);
            chart1.ChartAreas[0].AxisX.Title = "Czas [s]";
            chart1.ChartAreas[0].AxisY.Title = "Prędkość obrotowa [RPM]";
            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;
        }
        private bool DsOdbierz(string textStart, string textStop, ref string text)
        {
            string a;
            int Pos1;
            int Pos2;

            if (dataReceived.StartsWith(textStart))
            {
                Pos1 = dataReceived.IndexOf(textStart) + textStart.Length;
                Pos2 = dataReceived.IndexOf(textStop) - Pos1;
                if (Pos2 > 0)
                {
                    a = dataReceived.Substring(Pos1, Pos2);
                    text = a;
                    return true;
                }
            }
            return false;
        }
        private void DsOdbierzInt(string textStart, string textStop, ref int number)
        {
            string a;
            int Pos1;
            int Pos2;

            if (dataReceived.StartsWith(textStart))
            {
                Pos1 = dataReceived.IndexOf(textStart) + textStart.Length;
                Pos2 = dataReceived.IndexOf(textStop) - Pos1;
                if (Pos2 > 0)
                {
                    a = dataReceived.Substring(Pos1, Pos2);
                    int.TryParse(a, out number);
                }

            }
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public void DsExecuteCurve(bool error)
        {
            char[] start = { 'e', '0', '0', '0', '0', '0' };

            if (numberOfPoints >= 2 &!stopCurve & !error)
            { 
                    if (DsWyslijTime(tbTime1.Text, times[0].ToString(), 1) & speeds[1] > 0)
                    {
                        Task.Delay(10);
                        DsWyslijSpeed(tbSpeed1.Text, 1);
                        Task.Delay(10);
                        serialPort1.Write(start, 0, 6);
                        wait(times[1] - 20);
                    }
                    else error = true;
            
            if (DsWyslijTime(tbTime2.Text, tbTime1.Text, 2) & error == false & speeds[2] > 0)
                    {
                        Task.Delay(10);
                        DsWyslijSpeed(tbSpeed2.Text, 2);
                        Task.Delay(10);
                        serialPort1.Write(start, 0, 6);
                        wait(times[2] - 20);
                    }
                    else error = true;
            }
            if (numberOfPoints >= 3 & !stopCurve & !error)
                    {
                        if (DsWyslijTime(tbTime3.Text, tbTime2.Text, 3) & error == false & speeds[3] > 0)
                        {
                            Task.Delay(10);
                            DsWyslijSpeed(tbSpeed3.Text, 3);
                            Task.Delay(10);
                            serialPort1.Write(start, 0, 6);
                            wait(times[3] - 20);
                        }
                    }
                    else error = true;
            if (numberOfPoints >= 4 & !stopCurve & !error)
                    {
                if (DsWyslijTime(tbTime4.Text, tbTime3.Text, 3) & error == false & speeds[4] > 0)
                {
                    Task.Delay(10);
                    DsWyslijSpeed(tbSpeed4.Text, 3);
                    Task.Delay(10);
                    serialPort1.Write(start, 0, 6);
                    wait(times[4] - 20);
                }
                else error = true;
            }
            if (numberOfPoints == 5 & !stopCurve & !error)
            { 
                    if (DsWyslijTime(tbTime5.Text, tbTime4.Text, 3) & error == false & speeds[5] > 0)
                    {
                        Task.Delay(10);
                        DsWyslijSpeed(tbSpeed5.Text, 3);
                        Task.Delay(10);
                        serialPort1.Write(start, 0, 6);
                        wait(times[5] - 20);
                    }
            }
        }
    }
}
