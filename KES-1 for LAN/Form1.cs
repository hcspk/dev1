using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Media;
using System.IO;

/// <summary>
/// ////////////////////
/// </summary>
namespace KES_1_for_LAN
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string Text);
        DateTime startCalcTime = DateTime.Now;
       
        //========================== UI가 사용하는 변수들 
        int Target = 0;               // 목표값
        int Current = 0;              // 현재 값
        double ActTime = 0;           // 전동이 가동되는 시간(초)
        double NGTime = 0;            // 불량을 판단하는 기준시간(초)
        int NGPoint = 0;              // 불량 갯수
        double TimeSpen = 0;          // 시작후 경과된 시간(초)
        int tar_val = 0;              // For progress bar(target-current)
        double curr_val = 0;          // For progress bar
        string task = "norm";         // 전체 흐름에 사용
        string rob_stat = "";         // status pannel
        string ecmd = "";             // 로봇에 보낼 명령어($으로 시작)
        string ecmd_str = "";         // 로봇에 보낼 명령문($으로 시작)

        //========================== 이 부분부터는 IP통신을 위한 변수
        string MyIP;                  // PC의 IP
        string ip;                    // 로봇의 IP             
        int port;                     // 로봇의 PORT
        public static Socket sock;    // 소캣통신용 소캣
        byte[] buff = new byte[8192]; // 바이트형 수신데이터
        string strReceive;            // 처리전 수신데이터
        int n = 0;                    // 통신 데이터 비트수
        string sock_stat = "normal";  // 소켓의 상태
        string any_stat;              // anytime_run,read 가 가동 or 중지를 하기 위해
        string lan_read;              // 수신데이터 from LAN 
        //========================== 이 부분은 상태조회 및 상태를 나타내는 변수
        string stat_all = "";         // 상태조회 정보 총집합
        string stat_teach = "";       // 상태조회 정보_티치모드
        string stat_auto = "";        // 상태조회 정보_자동
        string stat_warn = "";        // 상태조회 정보_월닝
        string stat_serror = "";      // 상태조회 정보_S에러
        string stat_safega = "";      // 상태조회 정보_세이프트가드 온
        string stat_estop = "";       // 상태조회 정보_이머진시스톱
        string stat_error = "";       // 상태조회 정보_에러발생
        string stat_pause = "";       // 상태조회 정보_일시정지
        string stat_run = "";         // 상태조회 정보_런
        string stat_ready = "";       // 상태조회 정보_레디
        string stat_errcode = "";     // 상태조회 정보_에러코드 = "0000";
        //=========================== 로봇에 명령하기 위한 변수
        string speed = "30";
        string speeds = "30";
        string accel = "30";
        string accels = "30";
        string x_axis = "510.20";
        string y_axis = "-195.62";
        string z_axis = "";
        string u_axis = "";



        public Form1()
        {
            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Target_txt.Text = Target.ToString();
            Current_txt.Text = Current.ToString();
            Time_txt.Text = string.Format("{0:#0.0}", ActTime);
            NGTime_txt.Text = string.Format("{0:#0.0}", NGTime);
            NGPoint_txt.Text = NGPoint.ToString();
            TimeSpen_txt.Text = string.Format("{0:#0.0}", TimeSpen);
            label_conn.Visible = false;
            progressBar1.Value = 0;
            label_conn.Visible = true;
            label_conn.Image = KES_1_for_LAN.Properties.Resources.disconnect;

            //============================================================이 부분부터는 IP통신을 위한
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            MyIP = host.AddressList[0].ToString();
            string c2 = "시작입니다....!!!!!!!!!!!!!";
            Console.WriteLine("String: {0}", c2);
            Console.WriteLine("My IP: " + MyIP);
            listBox.Items.Insert(0, " 이 컴퓨터의 IP 주소 : " + MyIP);
            textBox1.Text = DateTime.Now.ToLongTimeString();//<<--- 시간표시기

            lbl_led_auto.BackColor = Color.Empty;
            lbl_led_ready.BackColor = Color.Empty;
            lbl_led_run.BackColor = Color.Empty;
            lbl_led_paused.BackColor = Color.Empty;
            lbl_led_warning.BackColor = Color.Empty;
            lbl_led_serror.BackColor = Color.Empty;
            lbl_led_safty.BackColor = Color.Empty;
            lbl_led_estop.BackColor = Color.Empty;
            lbl_led_error.BackColor = Color.Empty;

        }
        private void init_load(int intval)
        {
            
            lbl_led_auto.BackColor = Color.Empty;
            lbl_led_ready.BackColor = Color.Empty;
            lbl_led_run.BackColor = Color.Empty;
            lbl_led_paused.BackColor = Color.Empty;
            lbl_led_warning.BackColor = Color.Empty;
            lbl_led_serror.BackColor = Color.Empty;
            lbl_led_safty.BackColor = Color.Empty;
            lbl_led_estop.BackColor = Color.Empty;
            lbl_led_error.BackColor = Color.Empty;
            
            lbl_led_auto.BackColor = Color.GreenYellow;
            Thread.Sleep(intval);
            lbl_led_auto.BackColor = Color.Empty;
            lbl_led_ready.BackColor = Color.GreenYellow;
            Thread.Sleep(intval);
            lbl_led_ready.BackColor = Color.Empty;
            lbl_led_run.BackColor = Color.GreenYellow;
            Thread.Sleep(intval);
            lbl_led_run.BackColor = Color.Empty;
            lbl_led_paused.BackColor = Color.Yellow;
            Thread.Sleep(intval);
            lbl_led_paused.BackColor = Color.Empty;
            lbl_led_warning.BackColor = Color.Red;
            Thread.Sleep(intval);
            lbl_led_warning.BackColor = Color.Empty;
            lbl_led_serror.BackColor = Color.Red;
            Thread.Sleep(intval);
            lbl_led_serror.BackColor = Color.Empty;
            lbl_led_safty.BackColor = Color.Yellow;
            Thread.Sleep(intval);
            lbl_led_safty.BackColor = Color.Empty;
            lbl_led_estop.BackColor = Color.Red;
            Thread.Sleep(intval);
            lbl_led_estop.BackColor = Color.Empty;
            lbl_led_error.BackColor = Color.Red;
            Thread.Sleep(intval);
            lbl_led_error.BackColor = Color.Empty;

            Thread Status_thread = new Thread(new ThreadStart(delegate () // 전체 작업용 thread2 생성
            {
                Robot_Status(500);               // 숫자는 인터벌.
            }));
            Status_thread.Start();               // thread 실행하여 병렬작업 시작  

        }


        private void ComPort_btn_Click(object sender, EventArgs e) // LAN 포트 연결 / 해제
        {
            ip = IP_txt1.Text;
            port = int.Parse(textBox2.Text);
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            
            Thread anytime_thread = new Thread(new ThreadStart(delegate() // thread 생성
            {
                anytime_run(1000);                         // ms단위. <<- 콘넥션되면 anytime_run이 항상 가동됨.
            }));
            Thread anyread_thread = new Thread(new ThreadStart(delegate() // thread 생성
            {
                read_buff();
                //anytime_read(1000);                        // ms단위. <<- 콘넥션되면 anytime_read이 항상 가동됨.
            }));
            
            if (ComPort_btn.Text == "Connect")
            {
                sock_stat = "normal";
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sock.Connect(ip, port);                // 로봇에 연결
                    Console.WriteLine("Connect to: " + ip + " , Port: " + port);
                    anytime_thread.Start();
                    anyread_thread.Start();
                    any_stat = "run";
                                        
                    int login_try = 0;                     //  로그인을 시도한다.
                login_try_loop:
                    Sendmsg_Lan("$Login");                 //<<------ 로그인 ID -> if Success : #Login,0
                    Console.WriteLine(lan_read);
                    if (lan_read == "#Login,0\r\n")        //  "$Login" 에 대한 응답(\r\n 은 종료문자) 
                    {
                        Console.WriteLine("Login Success !!!" + DateTime.Now.ToLongTimeString());
                        ComPort_btn.Text = "Disconnect";
                        ComPort_btn.BackColor = Color.WhiteSmoke;
                        label_conn.Image = KES_1_for_LAN.Properties.Resources.connected;

                        Thread initload_thread = new Thread(new ThreadStart(delegate () // 전체 작업용 thread2 생성
                        {   init_load(50);               // 숫자는 인터벌.
                        }));
                        initload_thread.Start();          // thread 실행하여 병렬작업 시작
                    }
                    else if (login_try < 5)
                    {
                        login_try += 1;
                        Thread.Sleep(1000);
                        goto login_try_loop;
                    }
                    else
                    {
                        sock.Disconnect(false);
                        MessageBox.Show("Login에 실패 했습니다. 확인하여 주시기 바랍니다.");
                    }
                }
                catch
                {
                    MessageBox.Show("Scoket OPEN에 실패했습니다. IP 또는 Port를 확인해 주세요");
                }
            }
            else
            {
                sock_stat = "closing";
                label_conn.Image = KES_1_for_LAN.Properties.Resources.disconnect;
                any_stat = "stop";
                ecmd = "$Logout";
                Sendmsg_Lan(ecmd);
                Thread.Sleep(100);

                if (sock.Connected == true)
                {
                    Console.WriteLine("sock.Connected == true");
                    anytime_thread.Interrupt();
                    anytime_thread.Abort();
                    sock.Disconnect(false);
                }
                else if (sock.Connected == false)
                {
                    Console.WriteLine("sock.Connected == false");
                }
                else
                {
                    Console.WriteLine("sock.Connected == i dont know");
                }
                Thread.Sleep(500);
                
                label_tx.BackColor = Color.White;
                label_rx.BackColor = Color.White;
                label_ex.BackColor = Color.White;
                label_wx.BackColor = Color.White;
                ComPort_btn.BackColor = Color.White;
                ComPort_btn.Text = "Connect";
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {   //=====================================================  숨겨진 문자송신 버튼! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Sendmsg_Lan(textBox3.Text);

        }
        
        private void Start_btn_Click_1(object sender, EventArgs e)            // <<=- 시작버튼 클릭시 시작한다.
        {
            task = "norm";
            TimeSpen = 0;
            Target = int.Parse(Target_txt.Text);
            NGTime = double.Parse(NGTime_txt.Text);
            NGPoint = 0;
            NGPoint_txt.Text = NGPoint.ToString();
                       
            if (Target == 0 || NGTime == 0)
            {
                MessageBox.Show("설정이 완료되지 않았습니다. 목표 포인트와 불량기준을 입력해 주세요.");
            }
            else
            {
                Start_btn.Enabled = false;
                Thread Spent_thread = new Thread(new ThreadStart(delegate() // 작동시간 체크용 thread 생성
                {   SpentimeCalc(6000000);              // 최대 작업 시간을 넣자.
                }));
                Spent_thread.Start();                   // thread 실행하여 병렬작업 시작

                Thread Oper_thread = new Thread(new ThreadStart(delegate() // 전체 작업용 thread2 생성
                {   Operation_Task(1000);               // 숫자는 의미 없다.
                }));
                Oper_thread.Start();                    // thread 실행하여 병렬작업 시작
            }
            pictureBox1.Image = KES_1_for_LAN.Properties.Resources.home_pos3;
        }

        private void Pause_btn_Click_1(object sender, EventArgs e)
        {
            ecmd = "$Pause";
            Sendmsg_Lan(ecmd);    
            send_N_check(5);
            
            if (task == "com_fail")
            {
                rob_stat = "stop";
            }
            else
            {
                insert_listbox1("일시정지 중 입니다.");
                rob_stat = "pause";
            }
        }

        private void Cont_btn_Click_1(object sender, EventArgs e)// <<=- 일시정지 해제 버튼 클릭시 시작한다.
        {
            ecmd = "$Continue";
            Sendmsg_Lan(ecmd);    
            send_N_check(5);

            if (task == "com_fail")
            {
                rob_stat = "stop";
            }
            else
            {
                insert_listbox1("일시정지가 해제되어 연속으로 작업합니다.");
                rob_stat = "norm";
            }
        }


        private void Stop_btn_Click_1(object sender, EventArgs e)// <<=- 작업 중지 버튼 클릭시 시작한다.
        {
            ecmd = "$Abort";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            Start_btn.Enabled = true;
            if (task == "com_fail")
            {
                rob_stat = "stop";
            }
            else
            {
                insert_listbox1("작업을 모두 중지하고 그자리에 멈춥니다. 제자리로 복귀하려면 재설정을 눌러주세요");
                rob_stat = "stop";
            }
            
        }


        private void Reset_btn_Click_1(object sender, EventArgs e)// <<=- 재설정 버튼 클릭시 시작한다.
        {
            if (MessageBox.Show("모든 설정이 초기화되며 로봇이 HOME 으로 이동합니다. \n\r 초기화하지 않으려면 아니오(N)를 눌러 주세요!!", "설정 초기화 및 로봇 HOME 복귀", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Target = 0; Current = 0; ActTime = 0; NGTime = 0; NGPoint = 0; TimeSpen = 0; progressBar1.Value = 0;
                Target_txt.Text = Target.ToString();
                Current_txt.Text = Current.ToString();
                Time_txt.Text = string.Format("{0:#0.0}", ActTime);
                NGTime_txt.Text = string.Format("{0:#0.0}", NGTime);
                NGPoint_txt.Text = NGPoint.ToString();
                TimeSpen_txt.Text = string.Format("{0:#0.0}", TimeSpen);
                strReceive = "0";
            }
            ecmd = "$Stop";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            Thread.Sleep(50);
                        
            ecmd = "$Abort";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            Thread.Sleep(50);
            Start_btn.Enabled = true;

            ecmd = "$Reset";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            Thread.Sleep(50);

            if (task == "com_fail")
            {
                rob_stat = "stop";
            }
            else
            {
                insert_listbox1("로봇이 홈으로 복귀합니다.");
                rob_stat = "stop";
            }


        }
        //*************************************************************************************************************************
        //*************************************************** 프로시져형 **********************************************************
        //*************************************************************************************************************************

        void anytime_run(int interv) //  코넥팅 되면 항상 가동되어 송수신 표시한다.
        {
        any_loop:
            this.Invoke(new Action(() =>
            {
                textBox1.Text = DateTime.Now.ToLongTimeString();//<<--- 시간표시기
            }));
            
            ComPort_btn.BackColor = Color.YellowGreen;
            
            label_tx.BackColor = Color.LawnGreen;
            label_rx.BackColor = Color.White;
            label_ex.BackColor = Color.White;
            label_wx.BackColor = Color.White;
            Thread.Sleep(interv / 4);
            label_tx.BackColor = Color.White;
            label_rx.BackColor = Color.LawnGreen;
            label_ex.BackColor = Color.White;
            label_wx.BackColor = Color.White;
            Thread.Sleep(interv / 4);

            label_tx.BackColor = Color.White;
            label_rx.BackColor = Color.White;
            label_ex.BackColor = Color.LawnGreen;
            label_wx.BackColor = Color.White;
            Thread.Sleep(interv / 4);
            label_tx.BackColor = Color.White;
            label_rx.BackColor = Color.White;
            label_ex.BackColor = Color.White;
            label_wx.BackColor = Color.LawnGreen;
            Thread.Sleep(interv / 4);

            if (any_stat == "run")
            {
                goto any_loop;
            }
        }

        private void Sendmsg_Lan(string msg)                   // LAN을 통해 메세지 송신 후 리드 버퍼.
        {
            byte[] sendmsg = new byte[1024];
            sendmsg = Encoding.Default.GetBytes(msg + "\r\n");
            n = sendmsg.Length;
            sock.Send(sendmsg, 0, n, SocketFlags.None);
            Thread.Sleep(100);

        }

        void read_buff()                                      // 수신 메세지를 처리하는 프로시져
        {
          read_loop:
            if (sock.Available != 0)
           {
                byte[] buff = new byte[1024];
                n = sock.Receive(buff);
                string output = Encoding.ASCII.GetString(buff, 0, n);
                lan_read = output;
                //Console.WriteLine("[" + n + "] bytes Received!!: " + output);
                if (lan_read.Length > 10) 
                {
                    if (lan_read.Substring(0, 10) == "#GetStatus")
                    {
                        //Console.WriteLine("Robot: " + lan_read);
                        stat_all = lan_read;
                        lan_read = "";
                        //if (stat_all != (string)listBox_cmd.Items[1])   <<----- 숙제....
                        {
                            this.Invoke(new Action(() =>
                            {
                                listBox_cmd.Items.Insert(0, "Robot : " + output + "  [" + n + "Bytes]");
                            }));
                        }
                    }
                    else
                    {
                        Console.WriteLine("[" + n + "] bytes Received!!: " + output);
                    }
                }
                else
                {
                    Console.WriteLine("[" + n + "] bytes Received!!: " + output);
                }
            }
            if (sock_stat == "normal")
            { goto read_loop; }
            Console.WriteLine("read_buff()종료");
        }

       

        private void Robot_Status(int interval)
        {// $GetStatus 송신 -> #GetStatus,Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready, Error/Warning code(4digit)
         //                    #GetStatus,0100000001,0000
           stat_loop:
            Sendmsg_Lan("$GetStatus");
           // read_buff();
           // Console.WriteLine("[!!] !!: " + stat_all);
            if (stat_all.Length > 24)
            {
                if (stat_all.Substring(0, 10) == "#GetStatus" && stat_all.Length > 11)
                {
                    stat_teach = stat_all.Substring(12, 1);
                    stat_auto = stat_all.Substring(13, 1);
                    stat_warn = stat_all.Substring(14, 1);
                    stat_serror = stat_all.Substring(15, 1);
                    stat_safega = stat_all.Substring(16, 1);
                    stat_estop = stat_all.Substring(17, 1);
                    stat_error = stat_all.Substring(18, 1);
                    stat_pause = stat_all.Substring(19, 1);
                    stat_run = stat_all.Substring(20, 1);
                    stat_ready = stat_all.Substring(21, 1);
                    stat_errcode = stat_all.Substring(22, 5);
                    stat_all = "";

                    if (stat_error == "1")
                        rob_stat = "error";
                    if (stat_estop == "1")
                        rob_stat = "estop";
                    if (stat_safega == "1")
                        rob_stat = "sstop";
                    if (stat_run == "1")
                        rob_stat = "norm";
                }
            }
            stat_all = "";
            if (stat_auto == "1")
                lbl_led_auto.BackColor = Color.GreenYellow;
            else
                lbl_led_auto.BackColor = Color.Empty;

            if (stat_ready == "1")
                lbl_led_ready.BackColor = Color.GreenYellow;
            else
                lbl_led_ready.BackColor = Color.Empty;

            if (stat_run == "1")
                lbl_led_run.BackColor = Color.GreenYellow;
            else
                lbl_led_run.BackColor = Color.Empty;

            if (stat_pause == "1")
                lbl_led_paused.BackColor = Color.Yellow;
            else
                lbl_led_paused.BackColor = Color.Empty;

            if (stat_warn == "1")
                lbl_led_warning.BackColor = Color.Red;
            else
                lbl_led_warning.BackColor = Color.Empty;

            if (stat_serror == "1")
                lbl_led_serror.BackColor = Color.Red;
            else
                lbl_led_serror.BackColor = Color.Empty;

            if (stat_safega == "1")
                lbl_led_safty.BackColor = Color.Yellow;
            else
                lbl_led_safty.BackColor = Color.Empty;

            if (stat_estop == "1")
                lbl_led_estop.BackColor = Color.Red;
            else
                lbl_led_estop.BackColor = Color.Empty;

            if (stat_error == "1")
                lbl_led_error.BackColor = Color.Red;
            else
                lbl_led_error.BackColor = Color.Empty;
            
            Thread.Sleep(interval - 100);
            lbl_led_auto.BackColor = Color.Empty;
            lbl_led_ready.BackColor = Color.Empty;
            lbl_led_run.BackColor = Color.Empty;
            lbl_led_paused.BackColor = Color.Empty;
            lbl_led_warning.BackColor = Color.Empty;
            lbl_led_serror.BackColor = Color.Empty;
            lbl_led_safty.BackColor = Color.Empty;
            lbl_led_estop.BackColor = Color.Empty;
            lbl_led_error.BackColor = Color.Empty;
            Thread.Sleep(100);
            if (any_stat == "run")
            {
                goto stat_loop;
            }
        }

        private void nego() //------------------------------------------ 텔넷통신시 네고 프로시져가 필요하다
        {
            if (buff[0] == 255)
            {
                if ((buff[1] == 254) && (buff[2] == 37))
                {
                    listBox.Items.Insert(0, "Server: DON'T AUTHENTICATION.");
                    Console.WriteLine("Server: DON'T AUTHENTICATION.");
                    byte[] Send_byte = new byte[3]; // 3개 바이트를 생성
                    Send_byte[0] = 255;
                    Send_byte[1] = 251;
                    Send_byte[2] = 24;
                    sock.Send(Send_byte, 0, 3, SocketFlags.None);
                    listBox.Items.Insert(0, "Client: WILL Echo.");
                    Console.WriteLine("Client: WILL Echo.");
                }
                if ((buff[1] == 253) && (buff[2] == 24))
                {
                    listBox.Items.Insert(0, "Server: DO Terminal Type.");
                    Console.WriteLine("Server: DO Terminal Type.");
                    byte[] Send_byte = new byte[11]; // 11개 바이트를 생성
                    Send_byte[0] = 255;
                    Send_byte[1] = 250;
                    Send_byte[2] = 24;
                    Send_byte[3] = 0;
                    Send_byte[4] = Convert.ToByte('v');
                    Send_byte[5] = Convert.ToByte('t');
                    Send_byte[6] = Convert.ToByte('1');
                    Send_byte[7] = Convert.ToByte('0');
                    Send_byte[8] = Convert.ToByte('0');
                    Send_byte[9] = 255;
                    Send_byte[10] = 240;
                    sock.Send(Send_byte, 0, 11, SocketFlags.None);
                    listBox.Items.Insert(0, "Client: SB Terminal Type 'VT100' SE.");
                    Console.WriteLine("Client: SB Terminal Type 'VT100' SE.");
                }
                if ((buff[1] == 251) && (buff[2] == 1))
                {
                    listBox.Items.Insert(0, "Server: Server: WILL Echo.");
                    Console.WriteLine("Server: WILL Echo.");
                    byte[] Send_byte = new byte[3]; // 3개 바이트를 생성
                    Send_byte[0] = 255;
                    Send_byte[1] = 253; ;
                    Send_byte[2] = 1;
                    sock.Send(Send_byte, 0, 3, SocketFlags.None);
                    listBox.Items.Insert(0, "Client: DO Echo.");
                    Console.WriteLine("Client: Do Echo.");
                }
            }

        }

        private void insert_listbox1(string insert_msg)
        {
            this.Invoke(new Action(() =>
            {
                listBox.Items.Insert(0, insert_msg);
            }));
        }
        private void insert_listbox_cmd(string insert_msg)
        {
            this.Invoke(new Action(() =>
            {
                listBox_cmd.Items.Insert(0, insert_msg);
            }));
        }

        private void send_N_check(int cnt)
        {
            int trycnt = 0;
        send_again:
            if (lan_read == ("#" + ecmd.Substring(1, ecmd.Length - 1) + ",0\r\n"))                 //  "$Abort" 에 대한 응답(\r\n 은 종료문자) 
            {
                Console.WriteLine("lan_read = true ");
                return;
            }
            else if (trycnt < cnt)
            {
                trycnt++;
                Console.WriteLine("lan_read = true " + trycnt);
                goto send_again;
            }
            else
            {
                task = "com_fail";
                Console.WriteLine("send_N_check() 에서 통신 실패 " + ecmd);
            }
        }

        private void Start_Condition()
        {
            int try_start = 0;
            while (stat_auto != "1" || stat_ready != "1" || stat_serror == "1" || stat_safega == "1" || stat_estop == "1" || stat_error == "1" || stat_pause == "1" || stat_run == "1")
            {
                string err_msg = "";
                if (stat_auto != "1")
                    err_msg = err_msg + "시스템이 Auto 상태가 아닙니다. 정지 후 다시 시도해 주세요! \r\n";

                if (stat_ready != "1")
                    err_msg = err_msg + "시스템이 Ready 상태가 아닙니다. 정지 후 다시 시도해 주세요! \r\n ";

                if (stat_serror == "1")
                    err_msg = err_msg + "시스템에 약간의 에러(S-Error)가 있습니다. 에러요인을 제거해 주세요! \r\n ";

                if (stat_safega == "1")
                    err_msg = err_msg + "안전센서 작동중! 도어 또는 에어리어 센서를 확인해 주세요! \r\n ";

                if (stat_estop == "1")
                    err_msg = err_msg + "시스템의 비상정지가 작동중입니다. 해제 후 다시 시도해 주세요! \r\n ";

                if (stat_error == "1")
                    err_msg = err_msg + "시스템에 에러(Error)가 있습니다. 에러요인을 제거해 주세요! \r\n ";

                if (stat_pause == "1")
                    err_msg = err_msg + "시스템이 일시정지 중 입니다. 일시정지를  해제해 주세요! \r\n ";

                if (stat_run == "1")
                    err_msg = err_msg + "시스템이 이미 가동 중입니다. 정지 후 다시 시도해 주세요! \r\n ";

                if (MessageBox.Show(err_msg + "시스템 가동을 중지 하시겠습니까? \r\n (재시도를 원하시면 아니오를 눌러 주세요!)", "시스템 시작 조건 위반", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    task = "stop";
                    MessageBox.Show("메세지박스에 의한 스톱 task = stop" + try_start);
                    break;
                }

                if (try_start > 10)
                {
                    task = "stop";
                    MessageBox.Show("task = stop" + try_start);
                    break;
                }
                try_start++;
                Thread.Sleep(500);
            }
        }

        private void Operation_Task(int opc)                 // 전체 작업 진행하는 쓰레드
        {
            
            insert_listbox1(" KES-1 이 작업을 시작합니다. " + Target + "포인트");
            insert_listbox1(" 로봇을 초기화 하고 있습니다. ");
            startCalcTime = DateTime.Now;

            ecmd = "$Stop";
            Sendmsg_Lan(ecmd);          // $Stop 송신 -> 수신확인
            send_N_check(5);            // 재시도 횟수 넣어준다.
            Thread.Sleep(50);

            ecmd = "$Abort";
            Sendmsg_Lan(ecmd);          // $Abort 송신 -> 수신확인
            send_N_check(5);            // 재시도 횟수 넣어준다.
            Thread.Sleep(50);

            ecmd = "$Reset";
            Sendmsg_Lan(ecmd);          // $Reset 송신 -> 수신확인
            send_N_check(5);            // 재시도 횟수 넣어준다.
            Thread.Sleep(50);
                        
            string rob_start = "pass";
            Start_Condition();

            
            Console.WriteLine("Operation_Task 쓰레드가 시작되었습니다. :" + task);
            //==================================================================================================================================//
            // =======================>>>>>>>>>>   기동조건이 만족하여 실제 기동을 시작하자.  ==================================================//

            // ****  엡손에 데이터 날리기.
            x_axis = "263";               // 매 작업마다 x축 좌표를 넣어 준다(실 좌표값 * 100).
            ecmd = "$SetMemIOWord";
            ecmd_str = ",11" + x_axis;    // x 좌표를 11번 mem IO 에 넣어 준다.
            Sendmsg_Lan (ecmd+ecmd_str);

            y_axis = "133";               // 매 작업마다 y축 좌표를 넣어 준다(실 좌표값 * 100).
            ecmd = "$SetMemIOWord";
            ecmd_str = ",12" + y_axis;    // y 좌표를 12번 mem IO 에 넣어 준다.
            Sendmsg_Lan(ecmd + ecmd_str);

            z_axis = "-23";               // 매 작업마다 z축 좌표를 넣어 준다(실 좌표값 * 100).
            ecmd = "$SetMemIOWord";
            ecmd_str = ",13" + z_axis;    // z 좌표를 13번 mem IO 에 넣어 준다.
            Sendmsg_Lan(ecmd + ecmd_str);

            u_axis = "-86";               // 매 작업마다 theta 좌표를 넣어 준다(실 좌표값 * 100).
            ecmd = "$SetMemIOWord";
            ecmd_str = ",14" + z_axis;    // theta 좌표를 14번 mem IO 에 넣어 준다.
            Sendmsg_Lan(ecmd + ecmd_str);

            ecmd = "$SetMemIO";
            ecmd_str = ",16,0";           // x 좌표의 값이 '-' 면 mem IOdml 16번 bit를 on(1)하자.
            Sendmsg_Lan(ecmd + ecmd_str);

            ecmd = "$SetMemIO";
            ecmd_str = ",17,0";           // y 좌표의 값이 '-' 면 mem IOdml 17번 bit를 on(1)하자.
            Sendmsg_Lan(ecmd + ecmd_str);

            ecmd = "$SetMemIO";
            ecmd_str = ",18,0";           // z 좌표의 값이 '-' 면 mem IOdml 18번 bit를 on(1)하자.
            Sendmsg_Lan(ecmd + ecmd_str); // z 좌표는 항상 '-' 이다. 

            ecmd = "$SetMemIO";
            ecmd_str = ",19,0";           // theta 좌표의 값이 '-' 면 mem IOdml 19번 bit를 on(1)하자.
            Sendmsg_Lan(ecmd + ecmd_str);

            ecmd = "$GetIO,6";             // 6번 bit는 나사공급 OK ,,  (로봇의 hard wiring 된 입력의 상태조회.). 
            Sendmsg_Lan(ecmd);             // #GetIO,1  응답이 이와 같이 0,1로 옴.,
            // ** -->>   #GetIO,1 로 응답되면 다음으로 넘어가고 #GetIO,0 으로 응답되면 다시 시도 하거나 다른 시도~~~

            ecmd = "$GetIO,7";             // 7번 bit는 나사흡착 OK ,,  (로봇의 hard wiring 된 입력의 상태조회.). 
            Sendmsg_Lan(ecmd);             // #GetIO,1  응답이 이와 같이 0,1로 옴.,
            // ** -->>   #GetIO,1 로 응답되면 다음으로 넘어가고 #GetIO,0 으로 응답되면 다시 시도 하거나 다른 시도~~~

            ecmd = "$GetIO,17";             // 17번 bit는 드라이버 토크발생 ,,  (로봇의 hard wiring 된 입력의 상태조회.). 
            Sendmsg_Lan(ecmd);             // #GetIO,1  응답이 이와 같이 0,1로 옴.,
            // ** -->>   #GetIO,1 로 응답되면 다음으로 넘어가고 #GetIO,0 으로 응답되면 다시 시도 하거나, 대기 하거나, 다른 시도~~~

            ecmd = "$SetIO";               
            ecmd_str = ",6,1";             // 6번 bit는 나사흡착하라, 1->0 바꾸면 나사흡착 꺼라. (로봇의 hard wiring 된 출력의 설정.)
            Sendmsg_Lan(ecmd+ecmd_str);

            ecmd = "$SetIO";
            ecmd_str = ",10,1";            // 10번 bit는 전동 드라이버 ON , 300 ~ 500ms 후에 끄자.. (로봇의 hard wiring 된 출력의 설정.)
            Sendmsg_Lan(ecmd + ecmd_str);

            ecmd = "$SetIO";
            ecmd_str = ",11,1";            // 11번 bit는 전동 드라이버 OFF , 300 ~ 500ms 후에 끄자.. (로봇의 hard wiring 된 출력의 설정.)
            Sendmsg_Lan(ecmd + ecmd_str);












            /*  *** 이 아래 부분 주석으로 된 부분은 지우지 말기... 나중에 참고하애 함...
            ecmd = "$SetMotorsOn,1";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$SetMotorsOn, 1");

            ecmd = "$Execute,\"Power Low\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Power High\"");

            speed = "10";
            ecmd = "$Execute,\"Speed " + speed + "\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Speed " + speed + "\"");

            ecmd = "$Execute,\"Jump Home1\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Jump Home1\"");

            ecmd = "$Execute,\"Jump P0\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Jump P0\"");

            speed = "30";
            ecmd = "$Execute,\"Speed " + speed + "\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Speed " + speed + "\"");

            ecmd = "$Execute,\"Jump Home1\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Jump Home1\"");

            ecmd = "$Execute,\"Jump P0\"";
            Sendmsg_Lan(ecmd);
            send_N_check(5);
            insert_listbox_cmd("$Execute,\"Jump P0\"");
                                                    
            Start_btn.Enabled = true;
            #########################################################################################################################################
                        //============================================================================ 불량 시간을 로봇에 전송하는 부분
                        double NGTimeX = NGTime * 10;
                        //   SPort.Write("out " + NGTimeX + "\r\n");

                    wait_int80:
                        if (strReceive == "INT8" || task != "norm")
                        {
                        }
                        else
                        {
                            Console.WriteLine("INT80 기다리는 중");
                            Thread.Sleep(100);
                            goto wait_int80;
                        }

                        tar_val = Target - Current + 1;

                        //====================================================== 이 부분부터 반복을 시작하면서 작업을 시키는 루프
                        while (Current <= Target && task != "stop")  //rob_act == "norm") 
                        {
                            //   SPort.Write("out " + Current + "\r\n");
                            Console.WriteLine("out " + Current);
                            Thread.Sleep(100);
                            //   SPort.Write("bit9 1" + "\r\n");          // ##번 포인트를 실하기 위해 로봇은 오타케로 가라!!.

                            curr_val = (Current - (Target - tar_val)); // 프로그래스바 계산을 위해, 이렇게 나눠서 계산해야 하더라,
                            curr_val = curr_val / tar_val;           // 프로그래스바 계산을 위해, 이렇게 나눠서 계산해야 하더라,
                            curr_val = curr_val * 100;               // 프로그래스바 계산을 위해, 이렇게 나눠서 계산해야 하더라,
                            int pr_val = Convert.ToInt32(curr_val);
                            pictureBox1.Image = KES_1_for_LAN.Properties.Resources.supp_pos3;

                        wait_int31:                                  // 드라이버 가동 시그널 1번째 기다림. ~~  
                            if (strReceive == "INT3")                // INT3 = 드라이버를 ON 하였다는 신호
                            {
                                strReceive = "INT";
                                //   SPort.Write("bit9 0" + "\r\n");
                            }
                            else
                            {
                                if (task != "stop") //rob_act == "norm")
                                {
                                    Console.WriteLine("INT3-1 기다리는 중");
                                    Thread.Sleep(50);
                                    goto wait_int31;
                                }
                            }
                            Current_txt.Text = Current.ToString();
                            pictureBox1.Image = KES_1_for_LAN.Properties.Resources.mid_pos3;

                        wait_int32:                                 // 드라이버 가동 시그널 2번째 기다림. ~~  
                            Thread actt_thread = new Thread(new ThreadStart(delegate() // 체결시간 체크 thread 생성
                            {
                                ActtimeCalc(10);                    // 불량판정 초단위 ....<<- INT4가 입력되면 체결시간 멈춤.
                            }));
                            if (strReceive == "INT3")               // INT3 = 드라이버를 ON 하였다는 신호
                            {
                                actt_thread.Start();                // thread 실행하여 작업 시작
                            }
                            else
                            {
                                if (task != "stop") //rob_act == "norm")
                                {
                                    Console.WriteLine("INT3-2 기다리는 중");
                                    Thread.Sleep(100);
                                    goto wait_int32;
                                }
                            }
                            pictureBox1.Image = KES_1_for_LAN.Properties.Resources.act_pos3;

                            if (Current == Target)
                            {
                                //   SPort.Write("bit11 1" + "\r\n");
                            }


                        wait_int8:
                            if (strReceive == "INT8" || strReceive == "INT2") // INT8 = 1포인트 작업을 완료, INT2 = 불량 발생 하였다는 신호
                            {
                                if (strReceive == "INT8")
                                {
                                    Current += 1;
                                    Console.WriteLine("Operation_Task// " + Current + " 번 포인트 완료");
                                }
                                if (strReceive == "INT2")
                                {
                                    NGPoint += 1;
                                    NGPoint_txt.Text = NGPoint.ToString();
                                    listBox.Items.Insert(0, " #### NG Point: " + Current);
                                    Console.WriteLine("NG Point: " + Current);
                                    MessageBox.Show("NG Point: " + Current + "// 뷸량나사를 제거한 후 재시작버튼을 눌러 주세요!");
                                }

                            }
                            else
                            {
                                if (task != "stop") //rob_act == "norm")
                                {
                                    Console.WriteLine("INT8(ok) or INT2(ng) 기다리는 중");
                                    Thread.Sleep(200);
                                    goto wait_int8;
                                }
                            }
                            pictureBox1.Image = KES_1_for_LAN.Properties.Resources.mid_pos3;
                            actt_thread.Interrupt();                 // actt_thread 쓰레드 강제종료(2018 11 07)
                            actt_thread.Abort();                     // actt_thread 쓰레드 강제종료(2018 11 07)
                            strReceive = "INT";
                            progressBar1.Value = pr_val;
                        }
                        // <<<<<<<<===============------------------------------- 이 부분까지가 루프(while)를 형성하였다.

                        rob_stat = "finish";
                        task = "stop";
                        // SPort.Write("bit11 1" + "\r\n");

                        int try_in9 = 0;
                    wait_in9:
                        //   SPort.Write("in1?" + "\r\n");
                        Thread.Sleep(200);
                        string data = strReceive;

                        label2.Text = data;
                        if (data == "0")
                        {
                            Console.WriteLine("data " + data + " Robot at HOME1");
                        }
                        else if (rob_start == "fail")
                        {
                        }
                        else
                        {
                            Console.WriteLine("IN9 기다리는 중");
                            Thread.Sleep(200);
                            try_in9 += 1;
                            if (try_in9 < 301)
                            {
                                goto wait_in9;
                            }

                        }
                        //   SPort.Write("bit11 0" + "\r\n");
                        pictureBox1.Image = KES_1_for_LAN.Properties.Resources.home_pos3;


                        if (Current == 10000)
                        {
                            if (rob_start == "fail")
                            {
                                MessageBox.Show("로봇이 Ready 상태가 아니어서 작업을 시작하지 못하였습니다. Reset을 눌러주세요. ");
                            }
                            else
                            {
                                listBox.Items.Insert(0, " 로봇이 기동되지 않아 작업을 종료합니다.!! Error Code: Z007");
                                MessageBox.Show("로봇이 기동되지 않아 작업을 종료합니다.!! Error Code: Z007");
                            }
                        }
                        else if (try_in9 > 299)
                        {
                            listBox.Items.Insert(0, " 작업을 종료하였으나 로봇이 홈으로 복귀하지 못하였습니다.!! Error Code: Z008");
                            MessageBox.Show("작업을 종료하였으나 로봇이 홈으로 복귀하지 못하였습니다. RESET를 눌러 모든설정 재설정을 실행 하시기 바랍니다.");
                        }
                        else
                        {
                            listBox.Items.Insert(0, " 작업을 종료하였습니다.!! 불량포인트: " + NGPoint + "개");
                            MessageBox.Show("작업을 종료하였습니다.!! 불량포인트: " + NGPoint + "개");
                        }
                        Start_btn.Enabled = true;
                        Current_txt.Text = 0.ToString();
             ###########################################################################################################################################
                         */


        }










        private void SpentimeCalc(int aaa)                  // 동작 시간 계산하는 프로시져.
        {
            Console.WriteLine("SpentimeCalc 쓰레드가 시작되었습니다.");
            while (TimeSpen < aaa + 0.01 && task != "stop")
            {
                if (this.TimeSpen_txt.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        TimeSpen_txt.Text = string.Format("{0:#0.0}", TimeSpen);
                    }));
                }
                else
                {
                    TimeSpen_txt.Text = string.Format("{0:#0.0}", TimeSpen);
                }
                Thread.Sleep(1000);
                TimeSpen += 1;
            }
            this.Invoke(new Action(() =>
            {
                label1.Text = (DateTime.Now - startCalcTime).TotalSeconds + "초";
            }));
        }

        private void ActtimeCalc(int bbb)                   // 체결시간 계산하는 프로시져.
        {
            ActTime = 0;
            while (strReceive != "INT4" && ActTime < bbb && task == "norm") // INT4 = 로봇에서 전동 토크가 발생 하였다는 신호
            {
                ActTime += 0.05;
                Thread.Sleep(50);
                Time_txt.Text = ActTime.ToString();
            }

        }

        private void Status_Pannel(int ccc)                         //상태를 모니터링 하여 화면에 표현
        {
            while (task != "stop")
            {
                if (rob_stat == "norm")
                {
                    label_stat.Text = "작    업    중";
                    label_stat.ForeColor = Color.SeaGreen;
                    label_bar.BackColor = Color.LawnGreen;
                    label_bar2.BackColor = Color.LawnGreen;
                    Thread.Sleep(500);
                }
                if (rob_stat == "error")
                {
                    string stmsg = listBox.Items[0].ToString();
                    if (stmsg != " Robot Error 발생. 해제를 기다립니다. ")
                    {
                        listBox.Items.Insert(0, " Robot Error 발생. 해제를 기다립니다. ");
                    }
                    label_stat.Text = "Robot Error 발생";
                    label_stat.ForeColor = Color.Red;
                    label_bar.BackColor = Color.Red;
                    label_bar2.BackColor = Color.Red;
                    Thread.Sleep(300);
                    //listBox.BackColor = Color.Red;
                    Thread.Sleep(200);
                }
                if (rob_stat == "e_stop")
                {
                   string stmsg = listBox.Items[0].ToString();
                    if (stmsg != " Emergency Stop 발생. 해제를 기다립니다. ")
                    {
                        listBox.Items.Insert(0, " Emergency Stop 발생. 해제를 기다립니다. ");
                    }
                    label_stat.Text = "Emergency Stop 발생";
                    label_stat.ForeColor = Color.Red;
                    label_bar.BackColor = Color.Red;
                    label_bar2.BackColor = Color.Red;
                    Thread.Sleep(300);
                    //listBox.BackColor = Color.Red; 
                    Thread.Sleep(200);
                }
                if (rob_stat == "s_stop")
                {
                   string stmsg = listBox.Items[0].ToString();
                    if (stmsg != " Safty Guard 열림. 해제를 기다립니다. ")
                    {
                        listBox.Items.Insert(0, " Safty Guard 열림. 해제를 기다립니다. ");
                    }
                    label_stat.Text = "Safty Guard 열림";
                    label_stat.ForeColor = Color.Gold;
                    label_bar.BackColor = Color.Yellow;
                    label_bar2.BackColor = Color.Yellow;
                    Thread.Sleep(300);
                    //listBox.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                if (rob_stat == "pause")
                {
                    string stmsg = listBox.Items[0].ToString();
                    if (stmsg != " 사용자에 의해 일시정지 되었습니다. ")
                    {
                        listBox.Items.Insert(0, " 사용자에 의해 일시정지 되었습니다. ");
                    }
                    label_stat.Text = "작업중 일시정지";
                    label_stat.ForeColor = Color.Gold;
                    label_bar.BackColor = Color.Yellow;
                    label_bar2.BackColor = Color.Yellow;
                    Thread.Sleep(300);
                    //listBox.BackColor = Color.Yellow;
                    Thread.Sleep(200);
                }
                label_stat.Text = "";
                listBox.BackColor = Color.DarkGray;
                label_bar.BackColor = Color.DarkSlateGray;
                label_bar2.BackColor = Color.DarkSlateGray;
                Thread.Sleep(500);
            }
            label_stat.Text = "대    기    중";
            label_stat.ForeColor = Color.Black;
            label_stat.BackColor = Color.White;

        }

        private void button1_Click_1(object sender, EventArgs e)
        { //=============================================================== Teach Pendent Open Btn

            point_list frm2 = new point_list(ip, port);
            frm2.Show();


   


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ecmd = "$SetMotorsOn,1";
            Sendmsg_Lan(ecmd);
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ecmd = "$SetMotorsOff,1";
            Sendmsg_Lan(ecmd);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ecmd = "$Execute,\"Jump xy(300,200,-10,-90)\"";
            Sendmsg_Lan(ecmd);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ecmd = "$Abort";
            Sendmsg_Lan(ecmd);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ecmd = "$Execute,\"Jump home1\"";
            Sendmsg_Lan(ecmd);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ecmd = "$Execute,\"Jump p0\"";
            Sendmsg_Lan(ecmd);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sendmsg_Lan(textBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sendmsg_Lan(textBox5.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ecmd = "$Execute,\"Speed " + speed + "\"";
            Sendmsg_Lan(ecmd);
            
            //Sendmsg_Lan(textBox6.Text);
        }
    }
}
