namespace KES_1_for_LAN
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Skip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_z_edit = new System.Windows.Forms.Button();
            this.btn_teachmode = new System.Windows.Forms.Button();
            this.txtBox_z_fix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_px = new System.Windows.Forms.Button();
            this.btn_ny = new System.Windows.Forms.Button();
            this.btn_py = new System.Windows.Forms.Button();
            this.btn_nx = new System.Windows.Forms.Button();
            this.btn_nz = new System.Windows.Forms.Button();
            this.btn_pz = new System.Windows.Forms.Button();
            this.rob_group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_pitch_txt = new System.Windows.Forms.TextBox();
            this.usr_radiobtn = new System.Windows.Forms.RadioButton();
            this.m10_radiobtn = new System.Windows.Forms.RadioButton();
            this.m1_radiobtn = new System.Windows.Forms.RadioButton();
            this.m01_radiobtn = new System.Windows.Forms.RadioButton();
            this.btn_pu = new System.Windows.Forms.Button();
            this.btn_nu = new System.Windows.Forms.Button();
            this.btn_teach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_u = new System.Windows.Forms.TextBox();
            this.txtBox_z = new System.Windows.Forms.TextBox();
            this.txtBox_y = new System.Windows.Forms.TextBox();
            this.txtBox_x = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_move_all = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_jump = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn_emg_stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rob_group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Skip,
            this.No,
            this.point,
            this.x,
            this.y,
            this.z,
            this.u,
            this.hand});
            this.dataGridView1.Location = new System.Drawing.Point(41, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Skip
            // 
            this.Skip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Skip.Frozen = true;
            this.Skip.HeaderText = "Skip";
            this.Skip.Name = "Skip";
            this.Skip.Width = 50;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 60;
            // 
            // point
            // 
            this.point.HeaderText = "point No.";
            this.point.Name = "point";
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            // 
            // z
            // 
            this.z.HeaderText = "Z";
            this.z.Name = "z";
            // 
            // u
            // 
            this.u.HeaderText = "U";
            this.u.Name = "u";
            // 
            // hand
            // 
            this.hand.HeaderText = "HAND";
            this.hand.Name = "hand";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(842, 36);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(134, 41);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "Insert Point";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.insert_btn_Click_1);
            // 
            // btn_z_edit
            // 
            this.btn_z_edit.Location = new System.Drawing.Point(842, 95);
            this.btn_z_edit.Name = "btn_z_edit";
            this.btn_z_edit.Size = new System.Drawing.Size(134, 42);
            this.btn_z_edit.TabIndex = 2;
            this.btn_z_edit.Text = "Z Edit";
            this.btn_z_edit.UseVisualStyleBackColor = true;
            this.btn_z_edit.Click += new System.EventHandler(this.data_btn_Click);
            // 
            // btn_teachmode
            // 
            this.btn_teachmode.Location = new System.Drawing.Point(842, 450);
            this.btn_teachmode.Name = "btn_teachmode";
            this.btn_teachmode.Size = new System.Drawing.Size(134, 36);
            this.btn_teachmode.TabIndex = 3;
            this.btn_teachmode.Text = "TEACH MODE";
            this.btn_teachmode.UseVisualStyleBackColor = true;
            this.btn_teachmode.Click += new System.EventHandler(this.btn_teachmode_Click);
            // 
            // txtBox_z_fix
            // 
            this.txtBox_z_fix.Location = new System.Drawing.Point(896, 146);
            this.txtBox_z_fix.Name = "txtBox_z_fix";
            this.txtBox_z_fix.Size = new System.Drawing.Size(79, 21);
            this.txtBox_z_fix.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Z Value";
            // 
            // btn_px
            // 
            this.btn_px.Location = new System.Drawing.Point(11, 51);
            this.btn_px.Name = "btn_px";
            this.btn_px.Size = new System.Drawing.Size(80, 50);
            this.btn_px.TabIndex = 6;
            this.btn_px.Text = "+ X";
            this.btn_px.UseVisualStyleBackColor = true;
            this.btn_px.Click += new System.EventHandler(this.btn_px_Click);
            // 
            // btn_ny
            // 
            this.btn_ny.Location = new System.Drawing.Point(97, 24);
            this.btn_ny.Name = "btn_ny";
            this.btn_ny.Size = new System.Drawing.Size(80, 50);
            this.btn_ny.TabIndex = 6;
            this.btn_ny.Text = "- Y";
            this.btn_ny.UseVisualStyleBackColor = true;
            this.btn_ny.Click += new System.EventHandler(this.btn_ny_Click);
            // 
            // btn_py
            // 
            this.btn_py.Location = new System.Drawing.Point(97, 80);
            this.btn_py.Name = "btn_py";
            this.btn_py.Size = new System.Drawing.Size(80, 50);
            this.btn_py.TabIndex = 6;
            this.btn_py.Text = "+ Y";
            this.btn_py.UseVisualStyleBackColor = true;
            this.btn_py.Click += new System.EventHandler(this.btn_py_Click);
            // 
            // btn_nx
            // 
            this.btn_nx.Location = new System.Drawing.Point(184, 51);
            this.btn_nx.Name = "btn_nx";
            this.btn_nx.Size = new System.Drawing.Size(80, 50);
            this.btn_nx.TabIndex = 6;
            this.btn_nx.Text = "- X";
            this.btn_nx.UseVisualStyleBackColor = true;
            this.btn_nx.Click += new System.EventHandler(this.btn_nx_Click);
            // 
            // btn_nz
            // 
            this.btn_nz.Location = new System.Drawing.Point(11, 137);
            this.btn_nz.Name = "btn_nz";
            this.btn_nz.Size = new System.Drawing.Size(116, 33);
            this.btn_nz.TabIndex = 6;
            this.btn_nz.Text = "- Z";
            this.btn_nz.UseVisualStyleBackColor = true;
            this.btn_nz.Click += new System.EventHandler(this.btn_nz_Click);
            // 
            // btn_pz
            // 
            this.btn_pz.Location = new System.Drawing.Point(148, 137);
            this.btn_pz.Name = "btn_pz";
            this.btn_pz.Size = new System.Drawing.Size(116, 33);
            this.btn_pz.TabIndex = 6;
            this.btn_pz.Text = "+ Z";
            this.btn_pz.UseVisualStyleBackColor = true;
            this.btn_pz.Click += new System.EventHandler(this.btn_pz_Click);
            // 
            // rob_group
            // 
            this.rob_group.Controls.Add(this.label2);
            this.rob_group.Controls.Add(this.user_pitch_txt);
            this.rob_group.Controls.Add(this.usr_radiobtn);
            this.rob_group.Controls.Add(this.m10_radiobtn);
            this.rob_group.Controls.Add(this.m1_radiobtn);
            this.rob_group.Controls.Add(this.m01_radiobtn);
            this.rob_group.Controls.Add(this.btn_nx);
            this.rob_group.Controls.Add(this.btn_pz);
            this.rob_group.Controls.Add(this.btn_py);
            this.rob_group.Controls.Add(this.btn_pu);
            this.rob_group.Controls.Add(this.btn_nu);
            this.rob_group.Controls.Add(this.btn_nz);
            this.rob_group.Controls.Add(this.btn_ny);
            this.rob_group.Controls.Add(this.btn_px);
            this.rob_group.Location = new System.Drawing.Point(611, 501);
            this.rob_group.Name = "rob_group";
            this.rob_group.Size = new System.Drawing.Size(364, 212);
            this.rob_group.TabIndex = 7;
            this.rob_group.TabStop = false;
            this.rob_group.Text = "ROBOT MOVE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "mm";
            // 
            // user_pitch_txt
            // 
            this.user_pitch_txt.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_pitch_txt.Location = new System.Drawing.Point(281, 173);
            this.user_pitch_txt.Name = "user_pitch_txt";
            this.user_pitch_txt.Size = new System.Drawing.Size(41, 30);
            this.user_pitch_txt.TabIndex = 11;
            // 
            // usr_radiobtn
            // 
            this.usr_radiobtn.AutoSize = true;
            this.usr_radiobtn.Location = new System.Drawing.Point(281, 145);
            this.usr_radiobtn.Name = "usr_radiobtn";
            this.usr_radiobtn.Size = new System.Drawing.Size(71, 16);
            this.usr_radiobtn.TabIndex = 10;
            this.usr_radiobtn.TabStop = true;
            this.usr_radiobtn.Text = "User Set";
            this.usr_radiobtn.UseVisualStyleBackColor = true;
            // 
            // m10_radiobtn
            // 
            this.m10_radiobtn.AutoSize = true;
            this.m10_radiobtn.Location = new System.Drawing.Point(281, 104);
            this.m10_radiobtn.Name = "m10_radiobtn";
            this.m10_radiobtn.Size = new System.Drawing.Size(65, 16);
            this.m10_radiobtn.TabIndex = 9;
            this.m10_radiobtn.TabStop = true;
            this.m10_radiobtn.Text = "10  mm";
            this.m10_radiobtn.UseVisualStyleBackColor = true;
            // 
            // m1_radiobtn
            // 
            this.m1_radiobtn.AutoSize = true;
            this.m1_radiobtn.Location = new System.Drawing.Point(281, 63);
            this.m1_radiobtn.Name = "m1_radiobtn";
            this.m1_radiobtn.Size = new System.Drawing.Size(63, 16);
            this.m1_radiobtn.TabIndex = 8;
            this.m1_radiobtn.Text = "1   mm";
            this.m1_radiobtn.UseVisualStyleBackColor = true;
            // 
            // m01_radiobtn
            // 
            this.m01_radiobtn.AutoSize = true;
            this.m01_radiobtn.Checked = true;
            this.m01_radiobtn.Location = new System.Drawing.Point(281, 22);
            this.m01_radiobtn.Name = "m01_radiobtn";
            this.m01_radiobtn.Size = new System.Drawing.Size(65, 16);
            this.m01_radiobtn.TabIndex = 7;
            this.m01_radiobtn.TabStop = true;
            this.m01_radiobtn.Text = "0.1 mm";
            this.m01_radiobtn.UseVisualStyleBackColor = true;
            // 
            // btn_pu
            // 
            this.btn_pu.Location = new System.Drawing.Point(148, 175);
            this.btn_pu.Name = "btn_pu";
            this.btn_pu.Size = new System.Drawing.Size(116, 28);
            this.btn_pu.TabIndex = 6;
            this.btn_pu.Text = "+ U (ccw)";
            this.btn_pu.UseVisualStyleBackColor = true;
            this.btn_pu.Click += new System.EventHandler(this.btn_pu_Click);
            // 
            // btn_nu
            // 
            this.btn_nu.Location = new System.Drawing.Point(11, 175);
            this.btn_nu.Name = "btn_nu";
            this.btn_nu.Size = new System.Drawing.Size(116, 28);
            this.btn_nu.TabIndex = 6;
            this.btn_nu.Text = "- U (cw)";
            this.btn_nu.UseVisualStyleBackColor = true;
            this.btn_nu.Click += new System.EventHandler(this.btn_nu_Click);
            // 
            // btn_teach
            // 
            this.btn_teach.Location = new System.Drawing.Point(518, 655);
            this.btn_teach.Name = "btn_teach";
            this.btn_teach.Size = new System.Drawing.Size(87, 58);
            this.btn_teach.TabIndex = 8;
            this.btn_teach.Text = "TEACH";
            this.btn_teach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBox_u);
            this.groupBox2.Controls.Add(this.txtBox_z);
            this.groupBox2.Controls.Add(this.txtBox_y);
            this.groupBox2.Controls.Add(this.txtBox_x);
            this.groupBox2.Location = new System.Drawing.Point(272, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURRENT POSITION";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(247, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "U (deg)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(167, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Z (mm)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(87, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y (mm)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "X (mm)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_u
            // 
            this.txtBox_u.Location = new System.Drawing.Point(249, 38);
            this.txtBox_u.Name = "txtBox_u";
            this.txtBox_u.Size = new System.Drawing.Size(70, 21);
            this.txtBox_u.TabIndex = 0;
            // 
            // txtBox_z
            // 
            this.txtBox_z.Location = new System.Drawing.Point(169, 38);
            this.txtBox_z.Name = "txtBox_z";
            this.txtBox_z.Size = new System.Drawing.Size(70, 21);
            this.txtBox_z.TabIndex = 0;
            // 
            // txtBox_y
            // 
            this.txtBox_y.Location = new System.Drawing.Point(89, 38);
            this.txtBox_y.Name = "txtBox_y";
            this.txtBox_y.Size = new System.Drawing.Size(70, 21);
            this.txtBox_y.TabIndex = 0;
            // 
            // txtBox_x
            // 
            this.txtBox_x.Location = new System.Drawing.Point(9, 38);
            this.txtBox_x.Name = "txtBox_x";
            this.txtBox_x.Size = new System.Drawing.Size(70, 21);
            this.txtBox_x.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_move_all);
            this.groupBox3.Controls.Add(this.btn_move);
            this.groupBox3.Controls.Add(this.btn_jump);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Location = new System.Drawing.Point(272, 582);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 67);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "POINT CHECK";
            // 
            // btn_move_all
            // 
            this.btn_move_all.Location = new System.Drawing.Point(246, 20);
            this.btn_move_all.Name = "btn_move_all";
            this.btn_move_all.Size = new System.Drawing.Size(80, 35);
            this.btn_move_all.TabIndex = 1;
            this.btn_move_all.Text = "MOVE ALL";
            this.btn_move_all.UseVisualStyleBackColor = true;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(160, 20);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(80, 35);
            this.btn_move.TabIndex = 1;
            this.btn_move.Text = "MOVE";
            this.btn_move.UseVisualStyleBackColor = true;
            // 
            // btn_jump
            // 
            this.btn_jump.Location = new System.Drawing.Point(74, 20);
            this.btn_jump.Name = "btn_jump";
            this.btn_jump.Size = new System.Drawing.Size(80, 35);
            this.btn_jump.TabIndex = 1;
            this.btn_jump.Text = "JUMP";
            this.btn_jump.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.Location = new System.Drawing.Point(9, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 34);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_emg_stop
            // 
            this.btn_emg_stop.Location = new System.Drawing.Point(272, 655);
            this.btn_emg_stop.Name = "btn_emg_stop";
            this.btn_emg_stop.Size = new System.Drawing.Size(237, 58);
            this.btn_emg_stop.TabIndex = 11;
            this.btn_emg_stop.Text = "EMERGENCY STOP";
            this.btn_emg_stop.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KES_1_for_LAN.Properties.Resources.x0y0;
            this.pictureBox1.Location = new System.Drawing.Point(41, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(842, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 187);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(837, 197);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(96, 40);
            this.button15.TabIndex = 14;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_emg_stop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_teach);
            this.Controls.Add(this.rob_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_z_fix);
            this.Controls.Add(this.btn_teachmode);
            this.Controls.Add(this.btn_z_edit);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.point_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rob_group.ResumeLayout(false);
            this.rob_group.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_z_edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Skip;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn u;
        private System.Windows.Forms.DataGridViewTextBoxColumn hand;
        private System.Windows.Forms.Button btn_teachmode;
        private System.Windows.Forms.TextBox txtBox_z_fix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_px;
        private System.Windows.Forms.Button btn_ny;
        private System.Windows.Forms.Button btn_py;
        private System.Windows.Forms.Button btn_nx;
        private System.Windows.Forms.Button btn_nz;
        private System.Windows.Forms.Button btn_pz;
        private System.Windows.Forms.GroupBox rob_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_pitch_txt;
        private System.Windows.Forms.RadioButton usr_radiobtn;
        private System.Windows.Forms.RadioButton m10_radiobtn;
        private System.Windows.Forms.RadioButton m1_radiobtn;
        private System.Windows.Forms.RadioButton m01_radiobtn;
        private System.Windows.Forms.Button btn_teach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_u;
        private System.Windows.Forms.TextBox txtBox_z;
        private System.Windows.Forms.TextBox txtBox_y;
        private System.Windows.Forms.TextBox txtBox_x;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_jump;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn_move_all;
        private System.Windows.Forms.Button btn_emg_stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_pu;
        private System.Windows.Forms.Button btn_nu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button15;
    }
}