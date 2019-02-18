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
        string teach_act;

        string stat_all;
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

        int counter = 0;
        Thread countThread = null;
        bool stop = false;
        public Form2()
        {
            InitializeComponent();
            
            btnState.MouseDown += BtnState_MouseDown;
            btnState.MouseUp += BtnState_MouseUp;

        }
        private void BtnState_MouseUp(object sender, MouseEventArgs e)
        {
            stop = true;
            countThread.Join();
            MessageBox.Show(counter.ToString());
        }
        
        private void BtnState_MouseDown(object sender, MouseEventArgs e)
        {
            stop = false;
            counter = 0;
            countThread = new Thread(() =>
            {
                while (!stop)
                {
                    counter++;

                    Thread.Sleep(100);

                }
            });
            countThread.Start();
        }
        
        private void point_list_Load(object sender, EventArgs e)
        {
            //============================================================이 부분부터는 IP통신을 위한
                        
            string c2 = "시작입니다....!!!!!!!!!!!!!";
            Console.WriteLine("String: {0}", c2);
            //Robot_Status();

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
       private void button15_Click(object sender, EventArgs e)
        {
            //Robot_Status();
            //string sstr =Form1.stat_all;
            Console.WriteLine("gksrnrfgslw" + lan_read2);
           // Sndmsg_Lan("$SetMotorsOn,1");

        }
        
        
        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1["No", Numb].Value = Numb;
            Numb += 1;
            
        }

        private void btn_teach_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            Console.WriteLine("i : " + i);
            //i = i - 1;
            dataGridView1.Rows.Add(0,i,"p"+i, x_axis.ToString(), y_axis.ToString(), z_axis.ToString(), u_axis.ToString());
            
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            int j = dataGridView1.RowCount;
            for (int i = 0; i < j - 1; i++)
            {
                dataGridView1["Z", i].Value = txtBox_z_fix.Text;
                
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

       private void Stat_Pannel()
        {

        stat_pan_loop:

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

            Thread.Sleep(400);
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
            goto stat_pan_loop;

        }


        private void Robot_Status()
        {// $GetStatus 송신 -> #GetStatus,Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready, Error/Warning code(4digit)
         //                    #GetStatus,0100000001,0000

        stat_loop:
            Sndmsg_Lan("$Execute,\"Where\"");
            //Thread.Sleep(50);
            Console.WriteLine("[!!] !!: " + lan_read2);

            if (lan_read2.Length > 16)
            {

                if (lan_read2.Substring(10, 5) == "WORLD")
                {
                    string world = lan_read2.Substring(20, 9);
                    
                    x_axis = double.Parse(world);
                    Console.WriteLine("x======:" + world);
                     world = lan_read2.Substring(36, 9);
                    
                    y_axis = double.Parse(world);
                    Console.WriteLine("y======:" + world);
                     world = lan_read2.Substring(52, 9);
                    
                    z_axis = double.Parse(world);
                    Console.WriteLine("z======:" + world);
                     world = lan_read2.Substring(68, 9);
                    
                    u_axis = double.Parse(world);
                    Console.WriteLine("u======:" + world);

                    if (this.txtBox_x.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            txtBox_x.Text = string.Format("{0:#0.000}", x_axis);
                            txtBox_y.Text = string.Format("{0:#0.000}", y_axis);
                            txtBox_z.Text = string.Format("{0:#0.000}", z_axis);
                            txtBox_u.Text = string.Format("{0:#0.000}", u_axis);
                        }));
                    }
                    else
                    {
                        txtBox_x.Text = string.Format("{0:#0.000}", x_axis);
                        txtBox_y.Text = string.Format("{0:#0.000}", y_axis);
                        txtBox_z.Text = string.Format("{0:#0.000}", z_axis);
                        txtBox_u.Text = string.Format("{0:#0.000}", u_axis);
                    }
                                       
                }
            }
            if (lan_read2.Length > 8)
            {
                if (lan_read2.Substring(0, 10) == "#GetStatus")
                {
                    stat_all = lan_read2;
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
                    lan_read2 = "";
                }
                
            }
            Thread.Sleep(100);
            goto stat_loop;

        }

        private void btn_teachmode_Click(object sender, EventArgs e)
        {
            Thread RobStat_thread = new Thread(new ThreadStart(delegate () // thread 생성
            {
                Robot_Status();
            }));
            RobStat_thread.Start();

            Thread Stat_pannel_thread = new Thread(new ThreadStart(delegate () // thread 생성
            {
                Stat_Pannel();
            }));
            Stat_pannel_thread.Start();

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
            else if(usr_radiobtn.Checked == true)
            {
                y_axis = y_axis - double.Parse(user_pitch_txt.Text);
            }

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();

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
            else if (usr_radiobtn.Checked == true)
            {
                y_axis = y_axis + double.Parse(user_pitch_txt.Text);
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
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
            else if (usr_radiobtn.Checked == true)
            {
                x_axis = x_axis - double.Parse(user_pitch_txt.Text);
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
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
            else if (usr_radiobtn.Checked == true)
            {
                x_axis = x_axis + double.Parse(user_pitch_txt.Text);
            }
            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Sndmsg_Lan("$execute, \"Move xy(311,255,-20,-85)\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
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
            else if (usr_radiobtn.Checked == true)
            {
                z_axis = z_axis - double.Parse(user_pitch_txt.Text);
            }
            if (z_axis > 0)
                z_axis = -0.1;

            if (z_axis < -150)
                z_axis = -149.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
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
            else if (usr_radiobtn.Checked == true)
            {
                z_axis = z_axis + double.Parse(user_pitch_txt.Text);
            }
            if (z_axis > 0)
                z_axis = -0.1;

            if (z_axis < -150)
                z_axis = -149.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
        }

        private void btn_nu_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                u_axis = u_axis - 0.01;
            }
            else if (m1_radiobtn.Checked == true)
            {
                u_axis = u_axis - 0.1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                u_axis = u_axis - 1;
            }
            else if (usr_radiobtn.Checked == true)
            {
                u_axis = u_axis - (double.Parse(user_pitch_txt.Text) / 10);
            }
            if (u_axis > 360)
                u_axis = 359.9;

            if (u_axis < -360)
                u_axis = -359.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
        }

        private void btn_pu_Click(object sender, EventArgs e)
        {
            if (m01_radiobtn.Checked == true)
            {
                u_axis = u_axis + 0.01;
            }
            else if (m1_radiobtn.Checked == true)
            {
                u_axis = u_axis + 0.1;
            }
            else if (m10_radiobtn.Checked == true)
            {
                u_axis = u_axis + 1;
            }
            else if (usr_radiobtn.Checked == true)
            {
                u_axis = u_axis + (double.Parse(user_pitch_txt.Text) / 10);
            }

            if (u_axis > 360)
                u_axis = 359.9;

            if (u_axis < -360)
                u_axis = -359.9;

            Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
            //Robot_Status();
        }

        private void btn_MtrOn_Click(object sender, EventArgs e)
        {
            Sndmsg_Lan("$SetMotorsOn,1");
            
        }

        private void btn_MtrOff_Click(object sender, EventArgs e)
        {
            Sndmsg_Lan("$SetMotorsOff,1");
        }

        private void btn_ErrRst_Click(object sender, EventArgs e)
        {
            Sndmsg_Lan("$Reset");
        }
    }
}
