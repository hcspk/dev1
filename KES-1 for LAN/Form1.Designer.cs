namespace KES_1_for_LAN
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_bar2 = new System.Windows.Forms.Label();
            this.label_bar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label_stat = new System.Windows.Forms.Label();
            this.TimeSpen_txt = new System.Windows.Forms.TextBox();
            this.NGPoint_txt = new System.Windows.Forms.TextBox();
            this.NGTime_txt = new System.Windows.Forms.TextBox();
            this.Time_txt = new System.Windows.Forms.TextBox();
            this.Current_txt = new System.Windows.Forms.TextBox();
            this.Target_txt = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IP_txt1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_conn = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Cont_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.ComPort_btn = new System.Windows.Forms.Button();
            this.label_tx = new System.Windows.Forms.Label();
            this.label_rx = new System.Windows.Forms.Label();
            this.label_ex = new System.Windows.Forms.Label();
            this.label_wx = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_led_sa = new System.Windows.Forms.Label();
            this.lbl_led_es = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_led_auto = new System.Windows.Forms.Label();
            this.lbl_led_ready = new System.Windows.Forms.Label();
            this.lbl_led_run = new System.Windows.Forms.Label();
            this.lbl_led_paused = new System.Windows.Forms.Label();
            this.lbl_led_warning = new System.Windows.Forms.Label();
            this.lbl_led_serror = new System.Windows.Forms.Label();
            this.lbl_led_safty = new System.Windows.Forms.Label();
            this.lbl_led_estop = new System.Windows.Forms.Label();
            this.lbl_led_error = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnExcelimport = new System.Windows.Forms.Button();
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_pause = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.start_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bar2
            // 
            this.label_bar2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_bar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bar2.Location = new System.Drawing.Point(29, 186);
            this.label_bar2.Name = "label_bar2";
            this.label_bar2.Size = new System.Drawing.Size(1097, 20);
            this.label_bar2.TabIndex = 54;
            // 
            // label_bar
            // 
            this.label_bar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_bar.Location = new System.Drawing.Point(29, 751);
            this.label_bar.Name = "label_bar";
            this.label_bar.Size = new System.Drawing.Size(1097, 20);
            this.label_bar.TabIndex = 55;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(29, 726);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1097, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 46;
            this.progressBar1.Value = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(1069, 874);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = ":";
            // 
            // label_stat
            // 
            this.label_stat.BackColor = System.Drawing.Color.White;
            this.label_stat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_stat.Font = new System.Drawing.Font("굴림", 18F);
            this.label_stat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_stat.Location = new System.Drawing.Point(289, 1);
            this.label_stat.Name = "label_stat";
            this.label_stat.Size = new System.Drawing.Size(863, 50);
            this.label_stat.TabIndex = 44;
            this.label_stat.Text = "대    기    중";
            this.label_stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeSpen_txt
            // 
            this.TimeSpen_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TimeSpen_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeSpen_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TimeSpen_txt.Location = new System.Drawing.Point(966, 100);
            this.TimeSpen_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeSpen_txt.Name = "TimeSpen_txt";
            this.TimeSpen_txt.Size = new System.Drawing.Size(161, 79);
            this.TimeSpen_txt.TabIndex = 40;
            this.TimeSpen_txt.Text = "0.12";
            this.TimeSpen_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NGPoint_txt
            // 
            this.NGPoint_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NGPoint_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NGPoint_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NGPoint_txt.Location = new System.Drawing.Point(500, 100);
            this.NGPoint_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NGPoint_txt.Name = "NGPoint_txt";
            this.NGPoint_txt.Size = new System.Drawing.Size(154, 79);
            this.NGPoint_txt.TabIndex = 39;
            this.NGPoint_txt.Text = "0.12";
            this.NGPoint_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NGTime_txt
            // 
            this.NGTime_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NGTime_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NGTime_txt.ForeColor = System.Drawing.Color.DarkRed;
            this.NGTime_txt.Location = new System.Drawing.Point(809, 100);
            this.NGTime_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NGTime_txt.Name = "NGTime_txt";
            this.NGTime_txt.Size = new System.Drawing.Size(158, 79);
            this.NGTime_txt.TabIndex = 41;
            this.NGTime_txt.Text = "0.12";
            this.NGTime_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Time_txt
            // 
            this.Time_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Time_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Time_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Time_txt.Location = new System.Drawing.Point(653, 100);
            this.Time_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Time_txt.Name = "Time_txt";
            this.Time_txt.Size = new System.Drawing.Size(157, 79);
            this.Time_txt.TabIndex = 43;
            this.Time_txt.Text = "0.12";
            this.Time_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Current_txt
            // 
            this.Current_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Current_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Current_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Current_txt.Location = new System.Drawing.Point(340, 100);
            this.Current_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Current_txt.Name = "Current_txt";
            this.Current_txt.Size = new System.Drawing.Size(160, 79);
            this.Current_txt.TabIndex = 42;
            this.Current_txt.Text = "0.12";
            this.Current_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Target_txt
            // 
            this.Target_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Target_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Target_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Target_txt.Location = new System.Drawing.Point(183, 100);
            this.Target_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Target_txt.Name = "Target_txt";
            this.Target_txt.Size = new System.Drawing.Size(158, 79);
            this.Target_txt.TabIndex = 38;
            this.Target_txt.Text = "7.89";
            this.Target_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.DarkGray;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox.FormattingEnabled = true;
            this.listBox.IntegralHeight = false;
            this.listBox.ItemHeight = 31;
            this.listBox.Items.AddRange(new object[] {
            " 나사체결 로봇 시스템입니다.",
            " 종료 포인트: 마지막  조립 포인트 입력(좌표 로딩시 최대값 입력됨).",
            " 현재 포인트: 현재 조립 중인 포인트.",
            "   (시작하려는 포인트를 넣을 경우 그 포인트부터 시작.)",
            " 불량 포인트: 불량이 발생한 포인트의 갯수. ",
            " 불량 기준: 최소 조립시간임.  0.1초 단위로 입력.",
            " 체결 시간: 직전 포인트의 나사 조립시 걸린 시간. ",
            " 경과 시간: 작업이 시작된 후 경과된 시간."});
            this.listBox.Location = new System.Drawing.Point(29, 208);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(1033, 516);
            this.listBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(810, 52);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label6.Size = new System.Drawing.Size(158, 47);
            this.label6.TabIndex = 28;
            this.label6.Text = "불량기준(초)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(968, 52);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label8.Size = new System.Drawing.Size(158, 47);
            this.label8.TabIndex = 27;
            this.label8.Text = "경과시간(초)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(652, 52);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label7.Size = new System.Drawing.Size(158, 47);
            this.label7.TabIndex = 26;
            this.label7.Text = "체결시간(초)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(499, 52);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label5.Size = new System.Drawing.Size(153, 47);
            this.label5.TabIndex = 31;
            this.label5.Text = "불량 포인트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(341, 52);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label4.Size = new System.Drawing.Size(158, 47);
            this.label4.TabIndex = 30;
            this.label4.Text = "현재 포인트";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(183, 52);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label3.Size = new System.Drawing.Size(158, 47);
            this.label3.TabIndex = 29;
            this.label3.Text = "종료 포인트";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(1087, 876);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 21);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "5000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IP_txt1
            // 
            this.IP_txt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IP_txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP_txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IP_txt1.Location = new System.Drawing.Point(946, 876);
            this.IP_txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IP_txt1.Name = "IP_txt1";
            this.IP_txt1.Size = new System.Drawing.Size(120, 21);
            this.IP_txt1.TabIndex = 58;
            this.IP_txt1.Text = "192.168.0.1";
            this.IP_txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(0, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(319, 50);
            this.label14.TabIndex = 48;
            // 
            // label_conn
            // 
            this.label_conn.BackColor = System.Drawing.Color.White;
            this.label_conn.Image = global::KES_1_for_LAN.Properties.Resources.disconnect;
            this.label_conn.Location = new System.Drawing.Point(946, 775);
            this.label_conn.Name = "label_conn";
            this.label_conn.Size = new System.Drawing.Size(179, 70);
            this.label_conn.TabIndex = 47;
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Reset_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Reset_btn.FlatAppearance.BorderSize = 0;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset_btn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reset_btn.Location = new System.Drawing.Point(655, 774);
            this.Reset_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Reset_btn.Size = new System.Drawing.Size(149, 100);
            this.Reset_btn.TabIndex = 33;
            this.Reset_btn.Text = "재설정/홈";
            this.Reset_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reset_btn.UseVisualStyleBackColor = false;
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stop_btn.FlatAppearance.BorderSize = 0;
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_btn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stop_btn.Location = new System.Drawing.Point(498, 774);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Stop_btn.Size = new System.Drawing.Size(149, 100);
            this.Stop_btn.TabIndex = 32;
            this.Stop_btn.Text = "작 업 종 료";
            this.Stop_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stop_btn.UseVisualStyleBackColor = false;
            // 
            // Cont_btn
            // 
            this.Cont_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Cont_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cont_btn.FlatAppearance.BorderSize = 0;
            this.Cont_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cont_btn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cont_btn.Location = new System.Drawing.Point(342, 774);
            this.Cont_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cont_btn.Name = "Cont_btn";
            this.Cont_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Cont_btn.Size = new System.Drawing.Size(149, 100);
            this.Cont_btn.TabIndex = 34;
            this.Cont_btn.Text = "재  시  작";
            this.Cont_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cont_btn.UseVisualStyleBackColor = false;
            // 
            // Pause_btn
            // 
            this.Pause_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Pause_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pause_btn.FlatAppearance.BorderSize = 0;
            this.Pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause_btn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pause_btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Pause_btn.Location = new System.Drawing.Point(185, 774);
            this.Pause_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Pause_btn.Size = new System.Drawing.Size(149, 100);
            this.Pause_btn.TabIndex = 36;
            this.Pause_btn.Text = "일 시 정 지";
            this.Pause_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pause_btn.UseVisualStyleBackColor = false;
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Start_btn.FlatAppearance.BorderSize = 0;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_btn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Start_btn.Location = new System.Drawing.Point(29, 774);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Start_btn.Size = new System.Drawing.Size(149, 100);
            this.Start_btn.TabIndex = 35;
            this.Start_btn.Text = "작 업 시 작";
            this.Start_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Start_btn.UseVisualStyleBackColor = false;
            // 
            // ComPort_btn
            // 
            this.ComPort_btn.BackColor = System.Drawing.Color.White;
            this.ComPort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComPort_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComPort_btn.Location = new System.Drawing.Point(945, 841);
            this.ComPort_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComPort_btn.Name = "ComPort_btn";
            this.ComPort_btn.Size = new System.Drawing.Size(182, 31);
            this.ComPort_btn.TabIndex = 20;
            this.ComPort_btn.Text = "Connect";
            this.ComPort_btn.UseVisualStyleBackColor = false;
            // 
            // label_tx
            // 
            this.label_tx.BackColor = System.Drawing.Color.White;
            this.label_tx.Location = new System.Drawing.Point(946, 776);
            this.label_tx.Name = "label_tx";
            this.label_tx.Size = new System.Drawing.Size(45, 5);
            this.label_tx.TabIndex = 60;
            // 
            // label_rx
            // 
            this.label_rx.BackColor = System.Drawing.Color.White;
            this.label_rx.Location = new System.Drawing.Point(991, 776);
            this.label_rx.Name = "label_rx";
            this.label_rx.Size = new System.Drawing.Size(45, 5);
            this.label_rx.TabIndex = 61;
            // 
            // label_ex
            // 
            this.label_ex.BackColor = System.Drawing.Color.White;
            this.label_ex.Location = new System.Drawing.Point(1035, 776);
            this.label_ex.Name = "label_ex";
            this.label_ex.Size = new System.Drawing.Size(45, 5);
            this.label_ex.TabIndex = 60;
            // 
            // label_wx
            // 
            this.label_wx.BackColor = System.Drawing.Color.White;
            this.label_wx.Location = new System.Drawing.Point(1080, 776);
            this.label_wx.Name = "label_wx";
            this.label_wx.Size = new System.Drawing.Size(46, 5);
            this.label_wx.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Location = new System.Drawing.Point(1065, 209);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label10.Size = new System.Drawing.Size(59, 52);
            this.label10.TabIndex = 64;
            this.label10.Text = "Auto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label12.Location = new System.Drawing.Point(1065, 439);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label12.Size = new System.Drawing.Size(59, 52);
            this.label12.TabIndex = 64;
            this.label12.Text = "Warning";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label18.Location = new System.Drawing.Point(1065, 496);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label18.Size = new System.Drawing.Size(59, 52);
            this.label18.TabIndex = 64;
            this.label18.Text = "SError";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_led_sa
            // 
            this.lbl_led_sa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_led_sa.Location = new System.Drawing.Point(1065, 554);
            this.lbl_led_sa.Name = "lbl_led_sa";
            this.lbl_led_sa.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_led_sa.Size = new System.Drawing.Size(59, 52);
            this.lbl_led_sa.TabIndex = 64;
            this.lbl_led_sa.Text = "Safty";
            this.lbl_led_sa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_led_es
            // 
            this.lbl_led_es.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_led_es.Location = new System.Drawing.Point(1065, 611);
            this.lbl_led_es.Name = "lbl_led_es";
            this.lbl_led_es.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_led_es.Size = new System.Drawing.Size(59, 52);
            this.lbl_led_es.TabIndex = 64;
            this.lbl_led_es.Text = "EStop";
            this.lbl_led_es.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label21.Location = new System.Drawing.Point(1065, 669);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label21.Size = new System.Drawing.Size(59, 52);
            this.label21.TabIndex = 64;
            this.label21.Text = "Error";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label22.Location = new System.Drawing.Point(1065, 381);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label22.Size = new System.Drawing.Size(59, 52);
            this.label22.TabIndex = 64;
            this.label22.Text = "Paused";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label23.Location = new System.Drawing.Point(1065, 324);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label23.Size = new System.Drawing.Size(59, 52);
            this.label23.TabIndex = 64;
            this.label23.Text = "Run";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label24.Location = new System.Drawing.Point(1065, 266);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label24.Size = new System.Drawing.Size(59, 52);
            this.label24.TabIndex = 64;
            this.label24.Text = "Ready";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_led_auto
            // 
            this.lbl_led_auto.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_led_auto.Location = new System.Drawing.Point(1073, 215);
            this.lbl_led_auto.Name = "lbl_led_auto";
            this.lbl_led_auto.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_auto.TabIndex = 65;
            // 
            // lbl_led_ready
            // 
            this.lbl_led_ready.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_led_ready.Location = new System.Drawing.Point(1073, 272);
            this.lbl_led_ready.Name = "lbl_led_ready";
            this.lbl_led_ready.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_ready.TabIndex = 65;
            // 
            // lbl_led_run
            // 
            this.lbl_led_run.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_led_run.Location = new System.Drawing.Point(1073, 330);
            this.lbl_led_run.Name = "lbl_led_run";
            this.lbl_led_run.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_run.TabIndex = 65;
            // 
            // lbl_led_paused
            // 
            this.lbl_led_paused.BackColor = System.Drawing.Color.Yellow;
            this.lbl_led_paused.Location = new System.Drawing.Point(1073, 388);
            this.lbl_led_paused.Name = "lbl_led_paused";
            this.lbl_led_paused.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_paused.TabIndex = 65;
            // 
            // lbl_led_warning
            // 
            this.lbl_led_warning.BackColor = System.Drawing.Color.Yellow;
            this.lbl_led_warning.Location = new System.Drawing.Point(1073, 445);
            this.lbl_led_warning.Name = "lbl_led_warning";
            this.lbl_led_warning.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_warning.TabIndex = 65;
            // 
            // lbl_led_serror
            // 
            this.lbl_led_serror.BackColor = System.Drawing.Color.Red;
            this.lbl_led_serror.Location = new System.Drawing.Point(1073, 502);
            this.lbl_led_serror.Name = "lbl_led_serror";
            this.lbl_led_serror.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_serror.TabIndex = 65;
            // 
            // lbl_led_safty
            // 
            this.lbl_led_safty.BackColor = System.Drawing.Color.Yellow;
            this.lbl_led_safty.Location = new System.Drawing.Point(1073, 560);
            this.lbl_led_safty.Name = "lbl_led_safty";
            this.lbl_led_safty.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_safty.TabIndex = 65;
            // 
            // lbl_led_estop
            // 
            this.lbl_led_estop.BackColor = System.Drawing.Color.Red;
            this.lbl_led_estop.Location = new System.Drawing.Point(1073, 618);
            this.lbl_led_estop.Name = "lbl_led_estop";
            this.lbl_led_estop.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_estop.TabIndex = 65;
            // 
            // lbl_led_error
            // 
            this.lbl_led_error.BackColor = System.Drawing.Color.Red;
            this.lbl_led_error.Location = new System.Drawing.Point(1073, 675);
            this.lbl_led_error.Name = "lbl_led_error";
            this.lbl_led_error.Size = new System.Drawing.Size(43, 20);
            this.lbl_led_error.TabIndex = 65;
            // 
            // btnForm2
            // 
            this.btnForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForm2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForm2.Location = new System.Drawing.Point(809, 826);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(131, 48);
            this.btnForm2.TabIndex = 78;
            this.btnForm2.Text = "좌표관리";
            this.btnForm2.UseVisualStyleBackColor = false;
            // 
            // btnExcelimport
            // 
            this.btnExcelimport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelimport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExcelimport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcelimport.Location = new System.Drawing.Point(809, 774);
            this.btnExcelimport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelimport.Name = "btnExcelimport";
            this.btnExcelimport.Size = new System.Drawing.Size(131, 48);
            this.btnExcelimport.TabIndex = 79;
            this.btnExcelimport.Text = "좌표불러오기";
            this.btnExcelimport.UseVisualStyleBackColor = false;
            // 
            // dgrData
            // 
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(43, 504);
            this.dgrData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrData.Name = "dgrData";
            this.dgrData.RowTemplate.Height = 27;
            this.dgrData.Size = new System.Drawing.Size(240, 150);
            this.dgrData.TabIndex = 80;
            this.dgrData.Visible = false;
            // 
            // lbl_start
            // 
            this.lbl_start.BackColor = System.Drawing.Color.GreenYellow;
            this.lbl_start.Location = new System.Drawing.Point(43, 789);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(119, 19);
            this.lbl_start.TabIndex = 81;
            // 
            // lbl_pause
            // 
            this.lbl_pause.BackColor = System.Drawing.Color.Yellow;
            this.lbl_pause.Location = new System.Drawing.Point(200, 789);
            this.lbl_pause.Name = "lbl_pause";
            this.lbl_pause.Size = new System.Drawing.Size(119, 19);
            this.lbl_pause.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(358, 789);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(514, 789);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(671, 789);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 865);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 82;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_txt
            // 
            this.start_txt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.start_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_txt.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start_txt.Location = new System.Drawing.Point(26, 100);
            this.start_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start_txt.Name = "start_txt";
            this.start_txt.Size = new System.Drawing.Size(158, 79);
            this.start_txt.TabIndex = 84;
            this.start_txt.Text = "1";
            this.start_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 83;
            this.label1.Text = "시작 포인트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1152, 901);
            this.Controls.Add(this.start_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComPort_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_pause);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgrData);
            this.Controls.Add(this.btnExcelimport);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lbl_led_error);
            this.Controls.Add(this.lbl_led_estop);
            this.Controls.Add(this.lbl_led_safty);
            this.Controls.Add(this.lbl_led_serror);
            this.Controls.Add(this.lbl_led_warning);
            this.Controls.Add(this.lbl_led_paused);
            this.Controls.Add(this.lbl_led_run);
            this.Controls.Add(this.lbl_led_ready);
            this.Controls.Add(this.lbl_led_auto);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbl_led_es);
            this.Controls.Add(this.lbl_led_sa);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_wx);
            this.Controls.Add(this.label_rx);
            this.Controls.Add(this.label_ex);
            this.Controls.Add(this.label_tx);
            this.Controls.Add(this.IP_txt1);
            this.Controls.Add(this.label_bar2);
            this.Controls.Add(this.label_bar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_conn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_stat);
            this.Controls.Add(this.TimeSpen_txt);
            this.Controls.Add(this.NGPoint_txt);
            this.Controls.Add(this.NGTime_txt);
            this.Controls.Add(this.Time_txt);
            this.Controls.Add(this.Current_txt);
            this.Controls.Add(this.Target_txt);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Cont_btn);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_bar2;
        private System.Windows.Forms.Label label_bar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_conn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_stat;
        private System.Windows.Forms.TextBox TimeSpen_txt;
        private System.Windows.Forms.TextBox NGPoint_txt;
        private System.Windows.Forms.TextBox NGTime_txt;
        private System.Windows.Forms.TextBox Time_txt;
        private System.Windows.Forms.TextBox Current_txt;
        private System.Windows.Forms.TextBox Target_txt;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Cont_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ComPort_btn;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox IP_txt1;
        private System.Windows.Forms.Label label_tx;
        private System.Windows.Forms.Label label_rx;
        private System.Windows.Forms.Label label_ex;
        private System.Windows.Forms.Label label_wx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_led_sa;
        private System.Windows.Forms.Label lbl_led_es;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_led_auto;
        private System.Windows.Forms.Label lbl_led_ready;
        private System.Windows.Forms.Label lbl_led_run;
        private System.Windows.Forms.Label lbl_led_paused;
        private System.Windows.Forms.Label lbl_led_warning;
        private System.Windows.Forms.Label lbl_led_serror;
        private System.Windows.Forms.Label lbl_led_safty;
        private System.Windows.Forms.Label lbl_led_estop;
        private System.Windows.Forms.Label lbl_led_error;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnExcelimport;
        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_pause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox start_txt;
        private System.Windows.Forms.Label label1;
    }
}

