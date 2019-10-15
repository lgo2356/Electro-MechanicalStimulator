using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;


namespace Electro_MechanicalStimulator
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        Stopwatch stopWatch = new Stopwatch();

        Series series_voltage;
        Series series_pressure;

        SerialPort serialPort = null;

        double volt_value = 0;
        double pressure_value = 0;
        double stopwatch_time = 0;

        List<double> volt_value_arr = new List<double>();
        List<double> pressure_value_arr = new List<double>();
        List<double> time_arr = new List<double>();

        List<double> all_volt_value_arr = new List<double>();
        List<double> all_pressure_value_arr = new List<double>();
        List<double> all_time_arr = new List<double>();

        bool read_thread_state = false;
        bool btn_start_clicked = false;

        int file_number = 0;

        public Form1()
        {
            InitializeComponent();

            // Graph voltage
            graph_voltage.Series.Clear();
            graph_voltage.ChartAreas[0].AxisX.Maximum = 15;
            graph_voltage.ChartAreas[0].AxisX.Minimum = 0;
            graph_voltage.ChartAreas[0].AxisY.Maximum = 15;
            graph_voltage.ChartAreas[0].AxisY.Minimum = -5;

            graph_voltage.ChartAreas[0].AxisX.Interval = 2.0;
            graph_voltage.ChartAreas[0].AxisY.Interval = 2.5;

            graph_voltage.ChartAreas[0].AxisX.Title = "Time(ms)";
            graph_voltage.ChartAreas[0].AxisY.Title = "Voltage(V)";

            graph_voltage.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            graph_voltage.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            graph_voltage.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            graph_voltage.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;

            series_voltage = graph_voltage.Series.Add("voltage");
            series_voltage.ChartType = SeriesChartType.Line;
            series_voltage.Points.AddXY(0, 0);

            // Graph pressure
            graph_pressure.Series.Clear();
            graph_pressure.ChartAreas[0].AxisX.Maximum = 15;
            graph_pressure.ChartAreas[0].AxisX.Minimum = 0;
            graph_pressure.ChartAreas[0].AxisY.Maximum = 300;
            graph_pressure.ChartAreas[0].AxisY.Minimum = 0;

            graph_pressure.ChartAreas[0].AxisX.Interval = 0.5;
            graph_pressure.ChartAreas[0].AxisY.Interval = 50;

            graph_pressure.ChartAreas[0].AxisX.Title = "Time(ms)";
            graph_pressure.ChartAreas[0].AxisY.Title = "Power(%)";

            graph_pressure.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            graph_pressure.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            graph_pressure.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            graph_pressure.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;

            series_pressure = graph_pressure.Series.Add("pressure");
            series_pressure.ChartType = SeriesChartType.Line;
            series_pressure.Points.AddXY(0, 0);

            // Voltage combo box 초기화
            for(double i=0; i<=13.0; i+=0.5)
            {
                combo_volt.Items.Add(String.Format("{0:0.0}", i));
            }

            combo_volt.SelectedItem = "13.0";

            // Voltage frequency 초기화
            nud_volt_feq.Value = 1;

            // Voltage Operating time 초기화
            for(double i=0.5; i<=50.0; i+=0.5)
            {
                combo_volt_op.Items.Add(String.Format("{0:0.0}", i));
            }

            combo_volt_op.SelectedItem = "2.0";

            // Pressure frequency combo box 초기화
            string[] combo_pressure_feq_items_init_arr = new string[] { "2.0", "1.0", "0.5", "0.33", "0.25", "0.2", "0.1", "0.06", "0.05", "0.03" };
            combo_pressure_feq.Items.AddRange(combo_pressure_feq_items_init_arr);
            combo_pressure_feq.SelectedItem = "1.0";

            // Pressure Operating time 초기화
            string[] combo_pressure_op_items_init_arr = new string[] { "50", "100", "200", "300", "400", "500", "600", "700", "800", "900", "1000" };
            combo_pressure_op.Items.AddRange(combo_pressure_op_items_init_arr);
            combo_pressure_op.SelectedItem = "500";
            

            // Voltage x, y 초기화 및 KeyPress 이벤트 적용
            tb_volt_x_min.KeyPress += new KeyPressEventHandler(tb_volt_x_min_KeyPress);
            tb_volt_x_max.KeyPress += new KeyPressEventHandler(tb_volt_x_max_KeyPress);
            tb_volt_y_min.KeyPress += new KeyPressEventHandler(tb_volt_y_min_KeyPress);
            tb_volt_y_max.KeyPress += new KeyPressEventHandler(tb_volt_y_max_KeyPress);

            // Pressure x, y 초기화 및 KeyPress 이벤트 적용
            tb_pressure_x_min.KeyPress += new KeyPressEventHandler(tb_pressure_x_min_KeyPress);
            tb_pressure_x_max.KeyPress += new KeyPressEventHandler(tb_pressure_x_max_KeyPress);
            tb_pressure_y_min.KeyPress += new KeyPressEventHandler(tb_pressure_y_min_KeyPress);
            tb_pressure_y_max.KeyPress += new KeyPressEventHandler(tb_pressure_y_max_KeyPress);

            // 시간 설정 KeyPress 이벤트 적용
            tb_hour.KeyPress += new KeyPressEventHandler(tb_hour_KeyPress);
            tb_minute.KeyPress += new KeyPressEventHandler(tb_minute_KeyPress);
            tb_second.KeyPress += new KeyPressEventHandler(tb_second_KeyPress);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();

            foreach(string port in SerialPort.GetPortNames())
            {
                Console.WriteLine("COM PORT: " + port);
            }

            if(!serialPort.IsOpen)
            {
                serialPort.PortName = "COM3";
                serialPort.BaudRate = 921600;
                serialPort.Open();

                read_thread_state = true;

                Thread animate_thread = new Thread(new ThreadStart(animate));
                animate_thread.IsBackground = true;
                animate_thread.Start();

                timer.Interval = 20;
                timer.Tick += new EventHandler(animate_timer);
                timer.Start();

                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
                btn_start.Enabled = true;
                //btn_stop.Enabled = true;
                btn_save.Enabled = true;
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                read_thread_state = false;

                serialPort.Close();

                time_arr.Clear();
                volt_value_arr.Clear();
                pressure_value_arr.Clear();

                stopWatch.Reset();

                series_voltage.Points.Clear();
                series_voltage.Points.AddXY(0, 0);

                series_pressure.Points.Clear();
                series_pressure.Points.AddXY(0, 0);

                btn_connect.Enabled = true;
                btn_disconnect.Enabled = false;
                btn_start.Enabled = false;
                btn_stop.Enabled = false;
                btn_save.Enabled = false;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Start button clicked.");

            byte[] buffer = new byte[16];
            byte on_off = 0xC0;
            int lower_byte_volt_feq = 0x00;
            double volt_op = 0;
            byte upper_byte_volt_op = 0x00;
            byte lower_byte_volt_op = 0x00;
            int volt_power = 0x00;

            int upper_byte_pressure_feq = 0x00;
            int lower_byte_pressure_feq = 0x00;
            int upper_byte_pressure_op = 0x00;
            int lower_byte_pressure_op = 0x00;

            string combo_volt_text = combo_volt.SelectedItem as String;
            string combo_volt_op_text = combo_volt_op.SelectedItem as String;
            double nud_volt_feq_text = (double)nud_volt_feq.Value;

            if (combo_volt.SelectedIndex < 17)
            {
                volt_power += combo_volt.SelectedIndex;
            }
            else
            {
                volt_power = 0x10;
                volt_power = volt_power + 0x10 * (combo_volt.SelectedIndex - 16);
            }

            // On off check box data value setting
            if (chb_volt.Checked) { on_off += 0x30; }
            if (chb_pressure.Checked) { on_off += 0x0C; }

            // Numeric up down value convert to packet byte
            lower_byte_volt_feq = (int)(((nud_volt_feq_text - 0.5) * 100) + 1);

            // Voltage Operation time 패킷 변환
            volt_op = Convert.ToDouble(combo_volt_op_text) * 2;

            if (volt_op <= 256)
            {
                upper_byte_volt_op = 0x00;
                lower_byte_volt_op = (byte)volt_op;
            }
            else
            {
                upper_byte_volt_op = (byte)volt_op;
                lower_byte_volt_op = 0x00;
            }

            // 압력 주파수 패킷 변환
            int combo_pressure_feq_index = combo_pressure_feq.SelectedIndex;
            if (combo_pressure_feq_index < 8)
            {
                lower_byte_pressure_feq = 0x01 << combo_pressure_feq_index;
            }
            else
            {
                upper_byte_pressure_feq = 0x01 << combo_pressure_feq_index - 8;
            }

            // 압력 Operation time 패킷 변환
            int combo_pressure_op_index = combo_pressure_op.SelectedIndex;
            if (combo_pressure_op_index < 8)
            {
                lower_byte_pressure_op = 0x01 << combo_pressure_op_index;
            }
            else
            {
                upper_byte_pressure_op = 0x01 << combo_pressure_op_index - 8;
            }

            // 압력 Power 패킷 변환
            string pressure_power = tb_pressure_power.Text;
            byte byte_pressure_power = Convert.ToByte(pressure_power);

            // 시간 패킷 변환
            string setting_hour = tb_hour.Text;
            string setting_min = tb_minute.Text;
            string setting_sec = tb_second.Text;

            byte byte_setting_hour = Convert.ToByte(setting_hour);
            byte byte_setting_min = Convert.ToByte(setting_min);
            byte byte_setting_sec = Convert.ToByte(setting_sec);

            buffer[0] = 0xEA;
            buffer[1] = on_off;

            buffer[2] = 0x00;
            buffer[3] = (byte)lower_byte_volt_feq;
            buffer[4] = upper_byte_volt_op;
            buffer[5] = lower_byte_volt_op;
            buffer[6] = (byte)volt_power;

            buffer[7] = (byte)upper_byte_pressure_feq;
            buffer[8] = (byte)lower_byte_pressure_feq;
            buffer[9] = (byte)upper_byte_pressure_op;
            buffer[10] = (byte)lower_byte_pressure_op;
            buffer[11] = byte_pressure_power;

            buffer[12] = byte_setting_hour;
            buffer[13] = byte_setting_min;
            buffer[14] = byte_setting_sec;

            buffer[15] = 0x5A;

            foreach (byte _byte in buffer)
            {
                Console.WriteLine("0x{0:X}", _byte);
            }

            btn_start_clicked = true;

            serialPort.Write(buffer, 0, buffer.Length);

            btn_start.Enabled = false;
            btn_stop.Enabled = true;

            //timer.Interval = 1000;
            timer.Tick += new EventHandler(save_timer);
            timer.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Stop button clicked.");

            byte[] buff =
            {
                0xEA,
                0x00,
                0x00, 0x00, 0x00, 0x00, 0xFF,
                0x00, 0x00, 0x00, 0x00, 0xFF,
                0x00, 0x01, 0x00,
                0x5A
            };

            btn_start_clicked = false;

            serialPort.Write(buff, 0, buff.Length);

            btn_start.Enabled = true;
            btn_stop.Enabled = false;
        }

        private void btn_volt_x_Click(object sender, EventArgs e)
        {
            double x_max = Convert.ToDouble(tb_volt_x_max.Text);
            double x_min = Convert.ToDouble(tb_volt_x_min.Text);
            
            graph_voltage.ChartAreas[0].AxisX.Maximum = x_max;
            graph_voltage.ChartAreas[0].AxisX.Minimum = x_min;
        }

        private void btn_volt_y_Click(object sender, EventArgs e)
        {
            double y_max = Convert.ToDouble(tb_volt_y_max.Text);
            double y_min = Convert.ToDouble(tb_volt_y_min.Text);

            graph_voltage.ChartAreas[0].AxisY.Maximum = y_max;
            graph_voltage.ChartAreas[0].AxisY.Minimum = y_min;
        }

        private void btn_pressure_x_Click(object sender, EventArgs e)
        {
            double x_max = Convert.ToDouble(tb_pressure_x_max.Text);
            double x_min = Convert.ToDouble(tb_pressure_x_min.Text);

            graph_pressure.ChartAreas[0].AxisX.Maximum = x_max;
            graph_pressure.ChartAreas[0].AxisX.Minimum = x_min;
        }

        private void btn_pressure_y_Click(object sender, EventArgs e)
        {
            double y_max = Convert.ToDouble(tb_pressure_y_max.Text);
            double y_min = Convert.ToDouble(tb_pressure_y_min.Text);

            graph_pressure.ChartAreas[0].AxisY.Maximum = y_max;
            graph_pressure.ChartAreas[0].AxisY.Minimum = y_min;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_start_clicked = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.ShowDialog();

            string file_name = saveFileDialog.FileName;
            Console.WriteLine(file_name);

            if (file_name != "")
            {
                using (StreamWriter outputFile = new StreamWriter(new FileStream(file_name, FileMode.Create)))
                {
                    outputFile.WriteLine(" Time(ms)\tVoltage(V)\tPressure(mmHg)");

                    for (int i = 0; i < this.all_time_arr.Count; i++)
                    {
                        outputFile.WriteLine(this.all_time_arr[i] + "\t\t" + this.all_volt_value_arr[i] + "\t\t" + this.all_pressure_value_arr[i]);
                    }
                }
            }
        }

        private void animate_timer(object sender, EventArgs e)
        {
            if(time_arr.Count == volt_value_arr.Count && time_arr.Count == pressure_value_arr.Count)
            {
                for (int i = 0; i < volt_value_arr.Count; i++)
                {
                    series_voltage.Points.AddXY(time_arr[i], volt_value_arr[i]);
                }

                for (int j = 0; j < pressure_value_arr.Count; j++)
                {
                    series_pressure.Points.AddXY(time_arr[j], pressure_value_arr[j]);
                }

                time_arr.Clear();
                volt_value_arr.Clear();
                pressure_value_arr.Clear();

                double volt_xlim_min = graph_voltage.ChartAreas[0].AxisX.Minimum;
                double volt_xlim_max = graph_voltage.ChartAreas[0].AxisX.Maximum;

                double pressure_xlim_min = graph_pressure.ChartAreas[0].AxisX.Minimum;
                double pressure_xlim_max = graph_pressure.ChartAreas[0].AxisX.Maximum;

                // AxisX 간격이 스톱워치 보다 클 때
                if (stopwatch_time >= volt_xlim_max)
                {
                    series_voltage.Points.Clear();
                    graph_voltage.ChartAreas[0].AxisX.Minimum = (volt_xlim_max - volt_xlim_min) + volt_xlim_min;
                    graph_voltage.ChartAreas[0].AxisX.Maximum = (volt_xlim_max - volt_xlim_min) + volt_xlim_max;
                }

                if (stopwatch_time >= pressure_xlim_max)
                {
                    series_pressure.Points.Clear();
                    graph_pressure.ChartAreas[0].AxisX.Minimum = (pressure_xlim_max - pressure_xlim_min) + pressure_xlim_min;
                    graph_pressure.ChartAreas[0].AxisX.Maximum = (pressure_xlim_max - pressure_xlim_min) + pressure_xlim_max;
                }
            } else
            {
                Console.WriteLine("Graph animation error...");

                time_arr.Clear();
                volt_value_arr.Clear();
                pressure_value_arr.Clear();
            }
        }

        private void animate()
        {
            List<int> buff = new List<int>();

            int readData = 0;
            int volt_value_int = 0;
            int volt_value_tenths = 0;
            int pressure_int = 0;
            int pressure_tenths = 0;

            stopWatch.Reset();
            stopWatch.Start();

            while (read_thread_state && serialPort.IsOpen)
            {
                while(readData != 90 && serialPort.IsOpen)
                {
                    try
                    {
                        readData = serialPort.ReadByte();
                    } catch(IOException ioe)
                    {
                        Console.WriteLine("IOException");
                    }

                    stopwatch_time = stopWatch.ElapsedMilliseconds / 1000.0F;

                    buff.Add(readData);
                }
                
                if(buff.Count == 6 && buff[0] == 234 && buff[5] == 90)
                {
                    volt_value_int = buff[1];
                    volt_value_tenths = buff[2];
                    pressure_int = buff[3];
                    pressure_tenths = buff[4];

                    this.volt_value = Convert.ToDouble(volt_value_int.ToString() + "." + volt_value_tenths.ToString());
                    this.pressure_value = Convert.ToDouble(pressure_int.ToString() + "." + pressure_tenths.ToString());

                    // 데이터 배열에 저장
                    time_arr.Add(stopwatch_time);
                    volt_value_arr.Add(this.volt_value);
                    pressure_value_arr.Add(this.pressure_value);

                    //if (btn_start_clicked)
                    //{
                        all_time_arr.Add((int) Math.Round(stopwatch_time * 1000));
                        all_volt_value_arr.Add(this.volt_value);
                        all_pressure_value_arr.Add(this.pressure_value);
                    //}
                }
                
                readData = 0;
                buff.Clear();
            }
        }

        private void save_timer(object sender, EventArgs e)
        {
            if (btn_start_clicked)
            {
                if ((int) Math.Round(stopwatch_time * 1000) % 10000 <= 30)
                {
                    file_number += 1;
                }

                DirectoryInfo di = new DirectoryInfo(Application.StartupPath);

                using (StreamWriter outputFile = new StreamWriter(new FileStream(di + @"\save_file_" + file_number + ".txt", FileMode.Append)))
                {
                    if (this.all_time_arr.Count == this.all_volt_value_arr.Count && this.all_time_arr.Count == this.all_pressure_value_arr.Count)
                    {
                        for (int i = 0; i < this.all_time_arr.Count; i++)
                        {
                            outputFile.WriteLine(this.all_time_arr[i] + "\t\t" + this.all_volt_value_arr[i] + "\t\t" + this.all_pressure_value_arr[i]);
                        }
                    }

                    this.all_time_arr.Clear();
                    this.all_volt_value_arr.Clear();
                    this.all_pressure_value_arr.Clear();
                }
            }
        }

        // Text box voltage x min KeyPress 이벤트 처리
        private void tb_volt_x_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box voltage x max KeyPress 이벤트 처리
        private void tb_volt_x_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box voltage y min KeyPress 이벤트 처리
        private void tb_volt_y_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box voltage y max KeyPress 이벤트 처리
        private void tb_volt_y_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box pressure x min KeyPress 이벤트 처리
        private void tb_pressure_x_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box pressure x max KeyPress 이벤트 처리
        private void tb_pressure_x_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box pressure y min KeyPress 이벤트 처리
        private void tb_pressure_y_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box pressure y max KeyPress 이벤트 처리
        private void tb_pressure_y_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar("-")))
            {
                e.Handled = true;
            }
        }

        // Text box hour KeyPress 이벤트 처리
        private void tb_hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // Text box minute KeyPress 이벤트 처리
        private void tb_minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // Text box second KeyPress 이벤트 처리
        private void tb_second_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
