using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Media;

namespace KES_1_for_LAN
{
    public partial class point_list : Form
    {
        int Numb = 0;
        int n;
        string lan_read;

        string MyIP;
        string Ip;
        int Port;
        public static Socket Sock;

        string stat_teach;
        string stat_auto;
        string stat_warn;
        string stat_serror;
        string stat_safega;
        string stat_estop;
        string stat_error;
        string stat_pause;
        string stat_run;
        string stat_ready;
        string stat_errcode; // = "0000";

       

        
        public point_list()
        {
            InitializeComponent();
         //   Ip = ip;
        //    Port = port;
        }

        private void point_list_Load(object sender, EventArgs e)
        {
            //============================================================이 부분부터는 IP통신을 위한
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            MyIP = host.AddressList[0].ToString();
            string c2 = "시작입니다....!!!!!!!!!!!!!";
            Console.WriteLine("String: {0}", c2);
            Console.WriteLine("My IP: " + MyIP);
        }
       private void button15_Click(object sender, EventArgs e)
        {
              
            Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Sock.Connect(Ip, Port);  


        }


        
        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1["No", Numb].Value = Numb;
            Numb += 1;
            
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Numb; i++)
            {
                dataGridView1["Z", i].Value = "1234557";


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            rob_group.Enabled = false;

       
        }



        private void Sndmsg_Lan(string msg)                   // LAN을 통해 메세지 송신 후 리드 버퍼.
        {
            byte[] sendmsg = new byte[1024];
            sendmsg = Encoding.Default.GetBytes(msg + "\r\n");
            n = sendmsg.Length;
            Sock.Send(sendmsg, 0, n, SocketFlags.None);
            Thread.Sleep(100);
            Read_buff();
        }

        void Read_buff()                                      // 수신 메세지를 처리하는 프로시져
        {
            if (Sock.Available != 0)
            {
                byte[] buff = new byte[1024];
                n = Sock.Receive(buff);
                string output = Encoding.ASCII.GetString(buff, 0, n);
                lan_read = output;
                Console.WriteLine("[" + n + "] bytes Received!!: " + output);

                if (lan_read.Substring(0, 10) == "#GetStatus")
                {
                    stat_teach = lan_read.Substring(11, 1);
                    stat_auto = lan_read.Substring(12, 1);
                    stat_warn = lan_read.Substring(13, 1);
                    stat_serror = lan_read.Substring(14, 1);
                    stat_safega = lan_read.Substring(15, 1);
                    stat_estop = lan_read.Substring(16, 1);
                    stat_error = lan_read.Substring(17, 1);
                    stat_pause = lan_read.Substring(18, 1);
                    stat_run = lan_read.Substring(19, 1);
                    stat_ready = lan_read.Substring(20, 1);
                    stat_errcode = lan_read.Substring(22, 4);
                    lan_read = "";

                }
            }

        }



        private void Robot_Status()
        {// $GetStatus 송신 -> #GetStatus,Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready, Error/Warning code(4digit)
            //                    #GetStatus,0100000001,0000
            Sndmsg_Lan("$GetStatus");
            Read_buff();

            Console.WriteLine("[!!] !!: " + lan_read);
            if (lan_read.Substring(0, 10) == "#GetStatus")
            {
                stat_teach = lan_read.Substring(11, 1);
                stat_auto = lan_read.Substring(12, 1);
                stat_warn = lan_read.Substring(13, 1);
                stat_serror = lan_read.Substring(14, 1);
                stat_safega = lan_read.Substring(15, 1);
                stat_estop = lan_read.Substring(16, 1);
                stat_error = lan_read.Substring(17, 1);
                stat_pause = lan_read.Substring(18, 1);
                stat_run = lan_read.Substring(19, 1);
                stat_ready = lan_read.Substring(20, 1);
                stat_errcode = lan_read.Substring(22, 4);
                lan_read = "";

            }
            else
            {
                MessageBox.Show("Robot의 상태 조회에 실패하였습니다. ");
            }
            Console.WriteLine(stat_teach + stat_auto + stat_warn + stat_serror + stat_safega + stat_estop + stat_error + stat_pause + stat_run + stat_ready + stat_errcode);

        }

 

    }
}
