namespace Electro_MechanicalStimulator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chb_volt = new System.Windows.Forms.CheckBox();
            this.graph_voltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_pressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_voltage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_volt_op = new System.Windows.Forms.ComboBox();
            this.combo_volt = new System.Windows.Forms.ComboBox();
            this.nud_volt_feq = new System.Windows.Forms.NumericUpDown();
            this.chb_pressure = new System.Windows.Forms.CheckBox();
            this.label_pressure = new System.Windows.Forms.Label();
            this.label_pressure_feq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pressure_power = new System.Windows.Forms.TextBox();
            this.combo_pressure_feq = new System.Windows.Forms.ComboBox();
            this.combo_pressure_op = new System.Windows.Forms.ComboBox();
            this.label_volt_x = new System.Windows.Forms.Label();
            this.label_volt_y = new System.Windows.Forms.Label();
            this.label_pressure_x = new System.Windows.Forms.Label();
            this.label_pressure_y = new System.Windows.Forms.Label();
            this.tb_volt_y_min = new System.Windows.Forms.TextBox();
            this.tb_volt_y_max = new System.Windows.Forms.TextBox();
            this.tb_volt_x_max = new System.Windows.Forms.TextBox();
            this.tb_volt_x_min = new System.Windows.Forms.TextBox();
            this.tb_pressure_x_min = new System.Windows.Forms.TextBox();
            this.tb_pressure_x_max = new System.Windows.Forms.TextBox();
            this.tb_pressure_y_max = new System.Windows.Forms.TextBox();
            this.tb_pressure_y_min = new System.Windows.Forms.TextBox();
            this.btn_volt_x = new System.Windows.Forms.Button();
            this.btn_volt_y = new System.Windows.Forms.Button();
            this.btn_pressure_x = new System.Windows.Forms.Button();
            this.btn_pressure_y = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_hour = new System.Windows.Forms.TextBox();
            this.tb_minute = new System.Windows.Forms.TextBox();
            this.tb_second = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph_voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_pressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volt_feq)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Location = new System.Drawing.Point(93, 12);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(89, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(188, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(269, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(350, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chb_volt
            // 
            this.chb_volt.AutoSize = true;
            this.chb_volt.Location = new System.Drawing.Point(16, 82);
            this.chb_volt.Name = "chb_volt";
            this.chb_volt.Size = new System.Drawing.Size(48, 16);
            this.chb_volt.TabIndex = 5;
            this.chb_volt.Text = "전압";
            this.chb_volt.UseVisualStyleBackColor = true;
            // 
            // graph_voltage
            // 
            chartArea19.Name = "ChartArea1";
            this.graph_voltage.ChartAreas.Add(chartArea19);
            this.graph_voltage.Location = new System.Drawing.Point(262, 68);
            this.graph_voltage.Name = "graph_voltage";
            series19.ChartArea = "ChartArea1";
            series19.Name = "Series1";
            this.graph_voltage.Series.Add(series19);
            this.graph_voltage.Size = new System.Drawing.Size(1253, 324);
            this.graph_voltage.TabIndex = 6;
            this.graph_voltage.Text = "chart1";
            // 
            // graph_pressure
            // 
            chartArea20.Name = "ChartArea1";
            this.graph_pressure.ChartAreas.Add(chartArea20);
            this.graph_pressure.Location = new System.Drawing.Point(262, 406);
            this.graph_pressure.Name = "graph_pressure";
            series20.ChartArea = "ChartArea1";
            series20.Name = "Series1";
            this.graph_pressure.Series.Add(series20);
            this.graph_pressure.Size = new System.Drawing.Size(1253, 324);
            this.graph_pressure.TabIndex = 7;
            this.graph_pressure.Text = "chart2";
            // 
            // label_voltage
            // 
            this.label_voltage.AutoSize = true;
            this.label_voltage.Font = new System.Drawing.Font("굴림", 10F);
            this.label_voltage.Location = new System.Drawing.Point(16, 112);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(85, 14);
            this.label_voltage.TabIndex = 8;
            this.label_voltage.Text = "Voltage (V):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frequency (Hz):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operation Time (ms):";
            // 
            // combo_volt_op
            // 
            this.combo_volt_op.FormattingEnabled = true;
            this.combo_volt_op.Location = new System.Drawing.Point(168, 166);
            this.combo_volt_op.Name = "combo_volt_op";
            this.combo_volt_op.Size = new System.Drawing.Size(67, 20);
            this.combo_volt_op.TabIndex = 11;
            // 
            // combo_volt
            // 
            this.combo_volt.FormattingEnabled = true;
            this.combo_volt.Location = new System.Drawing.Point(168, 110);
            this.combo_volt.Name = "combo_volt";
            this.combo_volt.Size = new System.Drawing.Size(67, 20);
            this.combo_volt.TabIndex = 12;
            // 
            // nud_volt_feq
            // 
            this.nud_volt_feq.DecimalPlaces = 2;
            this.nud_volt_feq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_volt_feq.Location = new System.Drawing.Point(168, 139);
            this.nud_volt_feq.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            65536});
            this.nud_volt_feq.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_volt_feq.Name = "nud_volt_feq";
            this.nud_volt_feq.Size = new System.Drawing.Size(67, 21);
            this.nud_volt_feq.TabIndex = 15;
            this.nud_volt_feq.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // chb_pressure
            // 
            this.chb_pressure.AutoSize = true;
            this.chb_pressure.Location = new System.Drawing.Point(16, 416);
            this.chb_pressure.Name = "chb_pressure";
            this.chb_pressure.Size = new System.Drawing.Size(48, 16);
            this.chb_pressure.TabIndex = 16;
            this.chb_pressure.Text = "압력";
            this.chb_pressure.UseVisualStyleBackColor = true;
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Font = new System.Drawing.Font("굴림", 10F);
            this.label_pressure.Location = new System.Drawing.Point(16, 445);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(121, 14);
            this.label_pressure.TabIndex = 17;
            this.label_pressure.Text = "Power(duty) (%):";
            // 
            // label_pressure_feq
            // 
            this.label_pressure_feq.AutoSize = true;
            this.label_pressure_feq.Font = new System.Drawing.Font("굴림", 10F);
            this.label_pressure_feq.Location = new System.Drawing.Point(16, 476);
            this.label_pressure_feq.Name = "label_pressure_feq";
            this.label_pressure_feq.Size = new System.Drawing.Size(115, 14);
            this.label_pressure_feq.TabIndex = 18;
            this.label_pressure_feq.Text = "Frequency (Hz):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(15, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Operation Time (ms):";
            // 
            // tb_pressure_power
            // 
            this.tb_pressure_power.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_pressure_power.Location = new System.Drawing.Point(168, 440);
            this.tb_pressure_power.Name = "tb_pressure_power";
            this.tb_pressure_power.Size = new System.Drawing.Size(67, 21);
            this.tb_pressure_power.TabIndex = 20;
            this.tb_pressure_power.Text = "100";
            // 
            // combo_pressure_feq
            // 
            this.combo_pressure_feq.FormattingEnabled = true;
            this.combo_pressure_feq.Location = new System.Drawing.Point(168, 472);
            this.combo_pressure_feq.Name = "combo_pressure_feq";
            this.combo_pressure_feq.Size = new System.Drawing.Size(67, 20);
            this.combo_pressure_feq.TabIndex = 21;
            // 
            // combo_pressure_op
            // 
            this.combo_pressure_op.FormattingEnabled = true;
            this.combo_pressure_op.Location = new System.Drawing.Point(168, 504);
            this.combo_pressure_op.Name = "combo_pressure_op";
            this.combo_pressure_op.Size = new System.Drawing.Size(67, 20);
            this.combo_pressure_op.TabIndex = 22;
            // 
            // label_volt_x
            // 
            this.label_volt_x.AutoSize = true;
            this.label_volt_x.Font = new System.Drawing.Font("굴림", 10F);
            this.label_volt_x.Location = new System.Drawing.Point(16, 217);
            this.label_volt_x.Name = "label_volt_x";
            this.label_volt_x.Size = new System.Drawing.Size(21, 14);
            this.label_volt_x.TabIndex = 23;
            this.label_volt_x.Text = "x:";
            // 
            // label_volt_y
            // 
            this.label_volt_y.AutoSize = true;
            this.label_volt_y.Font = new System.Drawing.Font("굴림", 10F);
            this.label_volt_y.Location = new System.Drawing.Point(17, 246);
            this.label_volt_y.Name = "label_volt_y";
            this.label_volt_y.Size = new System.Drawing.Size(20, 14);
            this.label_volt_y.TabIndex = 24;
            this.label_volt_y.Text = "y:";
            // 
            // label_pressure_x
            // 
            this.label_pressure_x.AutoSize = true;
            this.label_pressure_x.Font = new System.Drawing.Font("굴림", 10F);
            this.label_pressure_x.Location = new System.Drawing.Point(17, 566);
            this.label_pressure_x.Name = "label_pressure_x";
            this.label_pressure_x.Size = new System.Drawing.Size(21, 14);
            this.label_pressure_x.TabIndex = 25;
            this.label_pressure_x.Text = "x:";
            // 
            // label_pressure_y
            // 
            this.label_pressure_y.AutoSize = true;
            this.label_pressure_y.Font = new System.Drawing.Font("굴림", 10F);
            this.label_pressure_y.Location = new System.Drawing.Point(18, 596);
            this.label_pressure_y.Name = "label_pressure_y";
            this.label_pressure_y.Size = new System.Drawing.Size(20, 14);
            this.label_pressure_y.TabIndex = 26;
            this.label_pressure_y.Text = "y:";
            // 
            // tb_volt_y_min
            // 
            this.tb_volt_y_min.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_volt_y_min.Location = new System.Drawing.Point(43, 244);
            this.tb_volt_y_min.Name = "tb_volt_y_min";
            this.tb_volt_y_min.Size = new System.Drawing.Size(48, 21);
            this.tb_volt_y_min.TabIndex = 27;
            this.tb_volt_y_min.Text = "-5";
            // 
            // tb_volt_y_max
            // 
            this.tb_volt_y_max.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_volt_y_max.Location = new System.Drawing.Point(101, 244);
            this.tb_volt_y_max.Name = "tb_volt_y_max";
            this.tb_volt_y_max.Size = new System.Drawing.Size(48, 21);
            this.tb_volt_y_max.TabIndex = 28;
            this.tb_volt_y_max.Text = "15";
            // 
            // tb_volt_x_max
            // 
            this.tb_volt_x_max.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_volt_x_max.Location = new System.Drawing.Point(101, 215);
            this.tb_volt_x_max.Name = "tb_volt_x_max";
            this.tb_volt_x_max.Size = new System.Drawing.Size(48, 21);
            this.tb_volt_x_max.TabIndex = 29;
            this.tb_volt_x_max.Text = "15";
            // 
            // tb_volt_x_min
            // 
            this.tb_volt_x_min.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_volt_x_min.Location = new System.Drawing.Point(43, 215);
            this.tb_volt_x_min.Name = "tb_volt_x_min";
            this.tb_volt_x_min.Size = new System.Drawing.Size(48, 21);
            this.tb_volt_x_min.TabIndex = 30;
            this.tb_volt_x_min.Text = "0";
            // 
            // tb_pressure_x_min
            // 
            this.tb_pressure_x_min.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_pressure_x_min.Location = new System.Drawing.Point(43, 564);
            this.tb_pressure_x_min.Name = "tb_pressure_x_min";
            this.tb_pressure_x_min.Size = new System.Drawing.Size(48, 21);
            this.tb_pressure_x_min.TabIndex = 31;
            this.tb_pressure_x_min.Text = "0";
            // 
            // tb_pressure_x_max
            // 
            this.tb_pressure_x_max.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_pressure_x_max.Location = new System.Drawing.Point(101, 564);
            this.tb_pressure_x_max.Name = "tb_pressure_x_max";
            this.tb_pressure_x_max.Size = new System.Drawing.Size(48, 21);
            this.tb_pressure_x_max.TabIndex = 32;
            this.tb_pressure_x_max.Text = "15";
            // 
            // tb_pressure_y_max
            // 
            this.tb_pressure_y_max.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_pressure_y_max.Location = new System.Drawing.Point(101, 594);
            this.tb_pressure_y_max.Name = "tb_pressure_y_max";
            this.tb_pressure_y_max.Size = new System.Drawing.Size(48, 21);
            this.tb_pressure_y_max.TabIndex = 33;
            this.tb_pressure_y_max.Text = "300";
            // 
            // tb_pressure_y_min
            // 
            this.tb_pressure_y_min.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_pressure_y_min.Location = new System.Drawing.Point(43, 594);
            this.tb_pressure_y_min.Name = "tb_pressure_y_min";
            this.tb_pressure_y_min.Size = new System.Drawing.Size(48, 21);
            this.tb_pressure_y_min.TabIndex = 34;
            this.tb_pressure_y_min.Text = "0";
            // 
            // btn_volt_x
            // 
            this.btn_volt_x.Location = new System.Drawing.Point(160, 213);
            this.btn_volt_x.Name = "btn_volt_x";
            this.btn_volt_x.Size = new System.Drawing.Size(75, 23);
            this.btn_volt_x.TabIndex = 35;
            this.btn_volt_x.Text = "Set";
            this.btn_volt_x.UseVisualStyleBackColor = true;
            this.btn_volt_x.Click += new System.EventHandler(this.btn_volt_x_Click);
            // 
            // btn_volt_y
            // 
            this.btn_volt_y.Location = new System.Drawing.Point(160, 244);
            this.btn_volt_y.Name = "btn_volt_y";
            this.btn_volt_y.Size = new System.Drawing.Size(75, 23);
            this.btn_volt_y.TabIndex = 36;
            this.btn_volt_y.Text = "Set";
            this.btn_volt_y.UseVisualStyleBackColor = true;
            this.btn_volt_y.Click += new System.EventHandler(this.btn_volt_y_Click);
            // 
            // btn_pressure_x
            // 
            this.btn_pressure_x.Location = new System.Drawing.Point(160, 562);
            this.btn_pressure_x.Name = "btn_pressure_x";
            this.btn_pressure_x.Size = new System.Drawing.Size(75, 23);
            this.btn_pressure_x.TabIndex = 37;
            this.btn_pressure_x.Text = "Set";
            this.btn_pressure_x.UseVisualStyleBackColor = true;
            this.btn_pressure_x.Click += new System.EventHandler(this.btn_pressure_x_Click);
            // 
            // btn_pressure_y
            // 
            this.btn_pressure_y.Location = new System.Drawing.Point(160, 594);
            this.btn_pressure_y.Name = "btn_pressure_y";
            this.btn_pressure_y.Size = new System.Drawing.Size(75, 23);
            this.btn_pressure_y.TabIndex = 38;
            this.btn_pressure_y.Text = "Set";
            this.btn_pressure_y.UseVisualStyleBackColor = true;
            this.btn_pressure_y.Click += new System.EventHandler(this.btn_pressure_y_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8F);
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 11);
            this.label3.TabIndex = 39;
            this.label3.Text = "MIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8F);
            this.label4.Location = new System.Drawing.Point(110, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 11);
            this.label4.TabIndex = 40;
            this.label4.Text = "MAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8F);
            this.label6.Location = new System.Drawing.Point(110, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 11);
            this.label6.TabIndex = 42;
            this.label6.Text = "MAX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8F);
            this.label7.Location = new System.Drawing.Point(55, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 11);
            this.label7.TabIndex = 41;
            this.label7.Text = "MIN";
            // 
            // tb_hour
            // 
            this.tb_hour.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_hour.Location = new System.Drawing.Point(38, 717);
            this.tb_hour.Name = "tb_hour";
            this.tb_hour.Size = new System.Drawing.Size(36, 21);
            this.tb_hour.TabIndex = 43;
            this.tb_hour.Text = "0";
            // 
            // tb_minute
            // 
            this.tb_minute.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_minute.Location = new System.Drawing.Point(113, 717);
            this.tb_minute.Name = "tb_minute";
            this.tb_minute.Size = new System.Drawing.Size(36, 21);
            this.tb_minute.TabIndex = 44;
            this.tb_minute.Text = "1";
            // 
            // tb_second
            // 
            this.tb_second.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_second.Location = new System.Drawing.Point(193, 717);
            this.tb_second.Name = "tb_second";
            this.tb_second.Size = new System.Drawing.Size(36, 21);
            this.tb_second.TabIndex = 45;
            this.tb_second.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 720);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "시:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 720);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "분:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 720);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "초:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 750);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_second);
            this.Controls.Add(this.tb_minute);
            this.Controls.Add(this.tb_hour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pressure_y);
            this.Controls.Add(this.btn_pressure_x);
            this.Controls.Add(this.btn_volt_y);
            this.Controls.Add(this.btn_volt_x);
            this.Controls.Add(this.tb_pressure_y_min);
            this.Controls.Add(this.tb_pressure_y_max);
            this.Controls.Add(this.tb_pressure_x_max);
            this.Controls.Add(this.tb_pressure_x_min);
            this.Controls.Add(this.tb_volt_x_min);
            this.Controls.Add(this.tb_volt_x_max);
            this.Controls.Add(this.tb_volt_y_max);
            this.Controls.Add(this.tb_volt_y_min);
            this.Controls.Add(this.label_pressure_y);
            this.Controls.Add(this.label_pressure_x);
            this.Controls.Add(this.label_volt_y);
            this.Controls.Add(this.label_volt_x);
            this.Controls.Add(this.combo_pressure_op);
            this.Controls.Add(this.combo_pressure_feq);
            this.Controls.Add(this.tb_pressure_power);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_pressure_feq);
            this.Controls.Add(this.label_pressure);
            this.Controls.Add(this.chb_pressure);
            this.Controls.Add(this.nud_volt_feq);
            this.Controls.Add(this.combo_volt);
            this.Controls.Add(this.combo_volt_op);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_voltage);
            this.Controls.Add(this.graph_pressure);
            this.Controls.Add(this.graph_voltage);
            this.Controls.Add(this.chb_volt);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph_voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_pressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volt_feq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox chb_volt;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_voltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_pressure;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_volt_op;
        private System.Windows.Forms.ComboBox combo_volt;
        private System.Windows.Forms.NumericUpDown nud_volt_feq;
        private System.Windows.Forms.CheckBox chb_pressure;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.Label label_pressure_feq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pressure_power;
        private System.Windows.Forms.ComboBox combo_pressure_feq;
        private System.Windows.Forms.ComboBox combo_pressure_op;
        private System.Windows.Forms.Label label_volt_x;
        private System.Windows.Forms.Label label_volt_y;
        private System.Windows.Forms.Label label_pressure_x;
        private System.Windows.Forms.Label label_pressure_y;
        private System.Windows.Forms.TextBox tb_volt_y_min;
        private System.Windows.Forms.TextBox tb_volt_y_max;
        private System.Windows.Forms.TextBox tb_volt_x_max;
        private System.Windows.Forms.TextBox tb_volt_x_min;
        private System.Windows.Forms.TextBox tb_pressure_x_min;
        private System.Windows.Forms.TextBox tb_pressure_x_max;
        private System.Windows.Forms.TextBox tb_pressure_y_max;
        private System.Windows.Forms.TextBox tb_pressure_y_min;
        private System.Windows.Forms.Button btn_volt_x;
        private System.Windows.Forms.Button btn_volt_y;
        private System.Windows.Forms.Button btn_pressure_x;
        private System.Windows.Forms.Button btn_pressure_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_hour;
        private System.Windows.Forms.TextBox tb_minute;
        private System.Windows.Forms.TextBox tb_second;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

