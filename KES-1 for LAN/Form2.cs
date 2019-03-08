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
using System.Runtime.InteropServices;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace KES_1_for_LAN
{
    public partial class Form2 : Form
    {
        int Numb = 0;
        int n;
        int row_index;
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
            
            //btnState.MouseDown += BtnState_MouseDown;
            //btnState.MouseUp += BtnState_MouseUp;

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
            
            lbl_led_auto.BackColor = Color.Empty;
            lbl_led_ready.BackColor = Color.Empty;
            lbl_led_run.BackColor = Color.Empty;
            lbl_led_paused.BackColor = Color.Empty;
            lbl_led_warning.BackColor = Color.Empty;
            lbl_led_serror.BackColor = Color.Empty;
            lbl_led_safty.BackColor = Color.Empty;
            lbl_led_estop.BackColor = Color.Empty;
            lbl_led_error.BackColor = Color.Empty;

           // grpBox_PoChk.Enabled = false;
            grpBox_Pos.Enabled = false;
            grpBox_RobMov.Enabled = false;
                       

        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            
            Excel.Application xlApp = null;
            Excel.Workbook xlWorkbook = null;
            Excel.Worksheet xlWorksheet = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel File 97~2003 (*.xls)|*.xls|Excel File (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //dataGridView1.Columns.Clear();
                    //DataTable dt = new DataTable();
                    xlApp = new Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
                    xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
                    Excel.Range range = xlWorksheet.UsedRange;
                    object[,] data = (object[,])range.Value;

                    for (int r = 2; r < range.Rows.Count; r++)
                    {
                        //dataGridView1.Rows.Add();
                        dataGridView1.Rows.Add(data[r, 1], data[r, 2], data[r, 3], data[r, 4].ToString(), data[r, 5].ToString(), data[r, 6].ToString(), data[r, 7].ToString());
                        //for (int c = 0; c < range.Columns.Count; c++)
                        //{
                        //    dt.Columns.Add();
                        //    dt.Rows[r][c] = data[r+1, c+1];
                       // }
                    }
                    xlWorkbook.Close(true);
                    xlApp.Quit();
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    ReleaseExcelObject(xlWorksheet);
                    ReleaseExcelObject(xlWorkbook);
                    ReleaseExcelObject(xlApp);
                }
            }                                     
           
        }

        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
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

        private void btn_z_edit_Click(object sender, EventArgs e)
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
            if (teach_act == "teach")
                goto stat_pan_loop;

        }


        private void Robot_Status()
        {// $GetStatus 송신 -> #GetStatus,Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready, Error/Warning code(4digit)
         //                    #GetStatus,0100000001,0000

        stat_loop:
            Sndmsg_Lan("$Execute,\"Where\"");
            //Thread.Sleep(50);
            //Console.WriteLine("[!!] !!: " + lan_read2);

            if (lan_read2.Length > 77)
            {

                if (lan_read2.Substring(10, 5) == "WORLD")
                {
                    string world = lan_read2.Substring(20, 9);
                    
                    x_axis = double.Parse(world);
                    //Console.WriteLine("x======:" + world);
                     world = lan_read2.Substring(36, 9);
                    
                    y_axis = double.Parse(world);
                    //Console.WriteLine("y======:" + world);
                     world = lan_read2.Substring(52, 9);
                    
                    z_axis = double.Parse(world);
                    //Console.WriteLine("z======:" + world);
                     world = lan_read2.Substring(68, 9);
                    
                    u_axis = double.Parse(world);
                    //Console.WriteLine("u======:" + world);

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
            if( teach_act == "teach")
                goto stat_loop;

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
                    teach_act = "Start_cond_Fail";
                    MessageBox.Show("메세지박스에 의한 스톱 task = stop" + try_start);
                    break;
                }

                if (try_start > 10)
                {
                    teach_act = "Start_cond_Fail";
                    MessageBox.Show("task = Start_cond_Fail" + try_start);
                    break;
                }
                try_start++;
                Thread.Sleep(500);
            }
        }


        private void btn_teachmode_Click(object sender, EventArgs e)
        {
            if (teach_act == "teach")
            {
                grpBox_PoChk.Enabled = false;
                grpBox_Pos.Enabled = false;
                grpBox_RobMov.Enabled = false;
                teach_act = "frmclose";
            }
            else
            {
                teach_act = "teach";
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

                grpBox_PoChk.Enabled = true;
                grpBox_Pos.Enabled = true;
                grpBox_RobMov.Enabled = true;
            }

        }

        private void btn_ny_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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
                else if (usr_radiobtn.Checked == true)
                {
                    y_axis = y_axis - double.Parse(user_pitch_txt.Text);
                }

                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_py_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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
                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_nx_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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
                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_px_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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
                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_nz_Click(object sender, EventArgs e)
        {

            Start_Condition();
            if (teach_act == "teach")
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

                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_pz_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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

                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_nu_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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

                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
        }

        private void btn_pu_Click(object sender, EventArgs e)
        {
            Start_Condition();
            if (teach_act == "teach")
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

                //Console.WriteLine("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                Sndmsg_Lan("$execute,\"Move xy(" + x_axis + ", " + y_axis + ", " + z_axis + ", " + u_axis + ")\"");
                //Robot_Status();
            }
            else
            {
                MessageBox.Show("명령을 수행할 수 없습니다." + teach_act);
            }
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

        private void btn_FrmColse_Click(object sender, EventArgs e)
        {
            teach_act = "frmclose";
            Thread.Sleep(500);

            this.Dispose();

        }

        private void chkBox_pwr_CheckedChanged(object sender, EventArgs e)
        {

            if (chkBox_pwr.Checked == true)
            {
                Sndmsg_Lan("$execute,\"power high\"");
                
            }
            else
            {
                Sndmsg_Lan("$execute,\"power low\"");
               
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBox_StartPos.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                row_index = int.Parse(txtBox_StartPos.Text);
                if (int.Parse(txtBox_StartPos.Text) >= int.Parse(txtBox_StopPos.Text))
                    txtBox_StopPos.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {
            }

        }

        private void btn_jump_Click(object sender, EventArgs e)
        {
            //Sndmsg_Lan("$SetMotorsOn,1");
            //Thread.Sleep(100);
            int pnt = int.Parse(txtBox_StartPos.Text) - 1;
            double x_val = double.Parse(dataGridView1.Rows[pnt].Cells[3].Value.ToString());
            double y_val = double.Parse(dataGridView1.Rows[pnt].Cells[4].Value.ToString());
            double z_val = double.Parse(dataGridView1.Rows[pnt].Cells[5].Value.ToString());
            double u_val = double.Parse(dataGridView1.Rows[pnt].Cells[6].Value.ToString());

            string ecmd = "$execute,\"Jump xy(" + x_val + "," + y_val + "," + z_val + "," + u_val + ")\"";
            Sndmsg_Lan(ecmd);
            //MessageBox.Show(x_val + "   " + y_val + "   " + z_val + "   " + u_val);

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            int pnt = int.Parse(txtBox_StartPos.Text) - 1;
            double x_val = double.Parse(dataGridView1.Rows[pnt].Cells[3].Value.ToString());
            double y_val = double.Parse(dataGridView1.Rows[pnt].Cells[4].Value.ToString());
            double z_val = double.Parse(dataGridView1.Rows[pnt].Cells[5].Value.ToString());
            double u_val = double.Parse(dataGridView1.Rows[pnt].Cells[6].Value.ToString());

            string ecmd = "$execute,\"Move xy(" + x_val + "," + y_val + "," + z_val + "," + u_val + ")\"";
            Sndmsg_Lan(ecmd);

        }

        private void txtBox_Speed_TextChanged(object sender, EventArgs e)
        {
            speed = int.Parse(txtBox_Speed.Text);
            accel = speed;
            Sndmsg_Lan("$execute,\"Speed " + speed + "\"");
            Sndmsg_Lan("$execute,\"Accel " + accel + "\"");

            if (double.Parse(txtBox_Speed.Text) > 60)
            {
                txtBox_Speed.ForeColor = Color.Red;
            }
            else
            {
                txtBox_Speed.ForeColor = Color.Black;
            }

        }

        private void btn_moveAll_Click(object sender, EventArgs e)
        {
            Thread MoveAll_thread = new Thread(new ThreadStart(delegate () // thread 생성
            {
                move_all();
            }));
            MoveAll_thread.Start();

        }

        private void move_all()
        {
            int j = dataGridView1.RowCount;
            for (int pnt = 0; pnt <= j-2; pnt++)
            {
                double x_val = double.Parse(dataGridView1.Rows[pnt].Cells[3].Value.ToString());
                double y_val = double.Parse(dataGridView1.Rows[pnt].Cells[4].Value.ToString());
                double z_val = double.Parse(dataGridView1.Rows[pnt].Cells[5].Value.ToString());
                double u_val = double.Parse(dataGridView1.Rows[pnt].Cells[6].Value.ToString());

                if (dataGridView1.Rows[pnt].Cells[0].Value.ToString() == "0")
                {
                    string ecmd = "$execute,\"Move xy(" + x_val + "," + y_val + "," + z_val + "," + u_val + ")\"";
                    Console.WriteLine(pnt + " Move xy(" + x_val + "," + y_val + "," + z_val + "," + u_val + ")");
                    Sndmsg_Lan(ecmd);
                    Thread.Sleep(5000);
                }
                if (teach_act == "stop")
                { break; }

            }
        }

        private void jump_all()
        {
            int j = dataGridView1.RowCount;
            for (int pnt = 0; pnt <= j-2; pnt++)
            {
                double x_val = double.Parse(dataGridView1.Rows[pnt].Cells[3].Value.ToString());
                double y_val = double.Parse(dataGridView1.Rows[pnt].Cells[4].Value.ToString());
                double z_val = double.Parse(dataGridView1.Rows[pnt].Cells[5].Value.ToString());
                double u_val = double.Parse(dataGridView1.Rows[pnt].Cells[6].Value.ToString());

                if (dataGridView1.Rows[pnt].Cells[0].Value.ToString() == "0")
                {
                    string ecmd = "$execute,\"Jump xy(" + x_val + "," + y_val + "," + z_val + "," + u_val + ")\"";
                    Sndmsg_Lan(ecmd);
                    Thread.Sleep(5000);
                }
                if (teach_act == "stop")
                { break; }
            }
        }
        
        private void btn_jumpAll_Click(object sender, EventArgs e)
        {
            Thread JumpAll_thread = new Thread(new ThreadStart(delegate () // thread 생성
            {
                jump_all();
            }));
            JumpAll_thread.Start();
        }

        private void txtBox_StopPos_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtBox_StopPos.Text) > dataGridView1.RowCount)
            {
                txtBox_StopPos.Text = dataGridView1.RowCount.ToString();
            }           
        }

        private void dataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
        }

        private void btn_emg_stop_Click(object sender, EventArgs e)
        {
           // string ecmd = "$Abort";
            Sndmsg_Lan("$Abort");
            teach_act = "stop";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void btn_z_edit_row_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1["Z", dataGridView1.CurrentRow.Index].Value = txtBox_z_fix.Text;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "locate_1.xls";
            sfd.InitialDirectory = "c:\\";
                  
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int num = 0;
                object missingType = Type.Missing;

                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;

                string[] headers = new string[dataGridView1.ColumnCount];
                string[] columns = new string[dataGridView1.ColumnCount];

                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    headers[c] = dataGridView1.Rows[0].Cells[c].OwningColumn.HeaderText.ToString();
                    num = c + 65;
                    columns[c] = Convert.ToString((char)num);
                }

                try
                {
                    objApp = new Excel.Application();
                    objBooks = objApp.Workbooks;
                    objBook = objBooks.Add(Missing.Value);
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                    //if (captions)
                    //{
                        for (int c = 0; c < dataGridView1.ColumnCount; c++)
                        {
                            range = objSheet.get_Range(columns[c] + "1", Missing.Value);
                            range.set_Value(Missing.Value, headers[c]);
                        }
                    //}

                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount-1; j++)
                        {
                            range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2), Missing.Value);
                            range.set_Value(Missing.Value, dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                    }

                    objApp.Visible = false;
                    objApp.UserControl = false;

                    objBook.SaveAs(@sfd.FileName,
                              Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                              missingType, missingType, missingType, missingType,
                              Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                              missingType, missingType, missingType, missingType, missingType);
                    objBook.Close(false, missingType, missingType);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("저장에 성공하였습니다. !!");
                }
                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, theException.Source);
                    MessageBox.Show(errorMessage, "Error");
                }
            }

        



        }

        private void btn_AirOn_Click(object sender, EventArgs e)
        {
            string ecmd = "$execute,\"On 6\"";
            Sndmsg_Lan(ecmd);
            //send_N_check(50);
            //Thread.Sleep(500);
        }

        private void btn_AirOff_Click(object sender, EventArgs e)
        {
            string ecmd = "$execute,\"Off 6\"";
            Sndmsg_Lan(ecmd);
                    }

        private void btn_jpp0_Click(object sender, EventArgs e)
        {
            
            Sndmsg_Lan("$execute,\"Jump P0\"");
                       
        }
    }
}
