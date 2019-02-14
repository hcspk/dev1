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
    public partial class Form2 : Form
    {
        int Numb = 0;
        int n;
        public static string lan_read2;
        
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

        int speed = 30;
        int speeds = 30;
        int accel = 100;
        int accels = 100;
        double x_axis = 0;
        double y_axis = 0;
        double z_axis = 0;
        double u_axis = -90;


        public Form2()
        {
            InitializeComponent();

        }

        private void point_list_Load(object sender, EventArgs e)
        {
            //============================================================이 부분부터는 IP통신을 위한
                        
            string c2 = "시작입니다....!!!!!!!!!!!!!";
            Console.WriteLine("String: {0}", c2);
            Robot_Status();


        }
       private void button15_Click(object sender, EventArgs e)
        {
            Robot_Status();
            string sstr =Form1.stat_all;
            Console.WriteLine("gksrnrfgslw" + lan_read2);
           // Sndmsg_Lan("$SetMotorsOn,1");

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

     



        private void Sndmsg_Lan(string msg)                   // LAN을 통해 메세지 송신 후 리드 버퍼.
        {
            byte[] sendmsg = new byte[1024];
            sendmsg = Encoding.Default.GetBytes(msg + "\r\n");
            n = sendmsg.Length;
            Form1.sock.Send(sendmsg, 0, n, SocketFlags.None);
            Thread.Sleep(100);
            
        }

       


        private void Robot_Status()
        {// $GetStatus 송신 -> #GetStatus,Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready, Error/Warning code(4digit)
         //                    #GetStatus,0100000001,0000

        stat_loop:
            Sndmsg_Lan("$Execute,\"Where\"");
            Thread.Sleep(50);
            Console.WriteLine("[!!] !!: " + lan_read2);

            if (lan_read2.Length > 16)
            {

                if (lan_read2.Substring(10, 5) == "WORLD")
                {
                    string world = lan_read2.Substring(20, 9);
                    txtBox_x.Text = world;
                    x_axis = double.Parse(world);
                    Console.WriteLine("x======:" + world);
                     world = lan_read2.Substring(36, 9);
                    txtBox_y.Text = world;
                    y_axis = double.Parse(world);
                    Console.WriteLine("y======:" + world);
                     world = lan_read2.Substring(52, 9);
                    txtBox_z.Text = world;
                    z_axis = double.Parse(world);
                    Console.WriteLine("z======:" + world);
                     world = lan_read2.Substring(68, 9);
                    txtBox_u.Text = world;
                    u_axis = double.Parse(world);
                    Console.WriteLine("u======:" + world);
                    
                }
            }
            if (lan_read2.Length > 8)
            {
                if (lan_read2.Substring(0, 10) == "#GetStatus")
                {
                    stat_teach = lan_read2.Substring(11, 1);
                    stat_auto = lan_read2.Substring(12, 1);
                    stat_warn = lan_read2.Substring(13, 1);
                    stat_serror = lan_read2.Substring(14, 1);
                    stat_safega = lan_read2.Substring(15, 1);
                    stat_estop = lan_read2.Substring(16, 1);
                    stat_error = lan_read2.Substring(17, 1);
                    stat_pause = lan_read2.Substring(18, 1);
                    stat_run = lan_read2.Substring(19, 1);
                    stat_ready = lan_read2.Substring(20, 1);
                    stat_errcode = lan_read2.Substring(22, 4);
                    lan_read2 = "";
                }
            }

            Thread.Sleep(500);
            //goto stat_loop;

        }

        private void btn_teachmode_Click(object sender, EventArgs e)
        {
            Thread RobStat_thread = new Thread(new ThreadStart(delegate () // thread 생성
            {
                Robot_Status();
            }));
            RobStat_thread.Start();
            
        }

        private void btn_ny_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                y_axis = y_axis - 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                y_axis = y_axis - 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                y_axis = y_axis - 10;
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");

        }

        private void btn_py_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                y_axis = y_axis + 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                y_axis = y_axis + 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                y_axis = y_axis + 10;
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
        }

        private void btn_nx_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                x_axis = x_axis - 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                x_axis = x_axis - 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                x_axis = x_axis - 10;
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
        }

        private void btn_px_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                x_axis = x_axis + 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                x_axis = x_axis + 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                x_axis = x_axis + 10;
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
        }

        private void btn_nz_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                z_axis = z_axis - 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                z_axis = z_axis - 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                z_axis = z_axis - 10;
            }
            if (z_axis > 0)
                z_axis = -0.1;

            if (z_axis < -150)
                z_axis = -149.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
        }

        private void btn_pz_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                z_axis = z_axis + 0.1;
            }
            else if (m1_radiobtn.Checked == true)
            {
                z_axis = z_axis + 1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                z_axis = z_axis + 10;
            }
            if (z_axis > 0)
                z_axis = -0.1;

            if (z_axis < -150)
                z_axis = -149.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
        }

        private void btn_nu_Click(object sender, EventArgs e)
        {

        }

        private void btn_pu_Click(object sender, EventArgs e)
        {

        }
    }
}
