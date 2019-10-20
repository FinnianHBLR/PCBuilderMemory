namespace PCBuilderMemory2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentScore = new System.Windows.Forms.Label();
            this.StartGameTemp = new System.Windows.Forms.Button();
            this.unPauseBtn = new System.Windows.Forms.Button();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.startPanle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mainQuitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.pauseQuitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pausePanel.SuspendLayout();
            this.startPanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current Score:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "CPU",
            "Cooling",
            "Motherboard",
            "Memory",
            "GPU",
            "Case",
            "Power Supply",
            "OS",
            "Network",
            "Storage"});
            this.checkedListBox1.Location = new System.Drawing.Point(1183, 301);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 394);
            this.checkedListBox1.TabIndex = 23;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // game_timer
            // 
            this.game_timer.Interval = 1000;
            this.game_timer.Tick += new System.EventHandler(this.game_time);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::PCBuilderMemory2.Properties.Resources.newPauseBtn;
            this.pictureBox23.Location = new System.Drawing.Point(1300, 25);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(66, 61);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox23.TabIndex = 24;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.PictureBox23_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::PCBuilderMemory2.Properties.Resources.Untitled;
            this.pictureBox22.Location = new System.Drawing.Point(1131, 25);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(147, 120);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox22.TabIndex = 21;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::PCBuilderMemory2.Properties.Resources.os;
            this.pictureBox16.Location = new System.Drawing.Point(575, 573);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(121, 165);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 19;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::PCBuilderMemory2.Properties.Resources.gpu;
            this.pictureBox17.Location = new System.Drawing.Point(434, 573);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(121, 165);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 18;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::PCBuilderMemory2.Properties.Resources.psu;
            this.pictureBox18.Location = new System.Drawing.Point(294, 573);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(121, 165);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::PCBuilderMemory2.Properties.Resources.motherboard;
            this.pictureBox19.Location = new System.Drawing.Point(154, 573);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(121, 165);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 16;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::PCBuilderMemory2.Properties.Resources.cpu;
            this.pictureBox20.Location = new System.Drawing.Point(12, 573);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(121, 165);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 15;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::PCBuilderMemory2.Properties.Resources.cpu;
            this.pictureBox11.Location = new System.Drawing.Point(575, 378);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(121, 165);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 14;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PCBuilderMemory2.Properties.Resources.psu;
            this.pictureBox12.Location = new System.Drawing.Point(434, 378);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(121, 165);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::PCBuilderMemory2.Properties.Resources.os;
            this.pictureBox13.Location = new System.Drawing.Point(294, 378);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(121, 165);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::PCBuilderMemory2.Properties.Resources.cooling;
            this.pictureBox14.Location = new System.Drawing.Point(154, 378);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(121, 165);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::PCBuilderMemory2.Properties.Resources.gpu;
            this.pictureBox15.Location = new System.Drawing.Point(12, 378);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(121, 165);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 10;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PCBuilderMemory2.Properties.Resources.network;
            this.pictureBox6.Location = new System.Drawing.Point(575, 207);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(121, 165);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PCBuilderMemory2.Properties.Resources.motherboard;
            this.pictureBox7.Location = new System.Drawing.Point(434, 207);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(121, 165);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PCBuilderMemory2.Properties.Resources.ram;
            this.pictureBox8.Location = new System.Drawing.Point(294, 207);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 165);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::PCBuilderMemory2.Properties.Resources._case;
            this.pictureBox9.Location = new System.Drawing.Point(154, 207);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(121, 165);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PCBuilderMemory2.Properties.Resources.ram;
            this.pictureBox10.Location = new System.Drawing.Point(12, 207);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(121, 165);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PCBuilderMemory2.Properties.Resources.cooling;
            this.pictureBox5.Location = new System.Drawing.Point(575, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 165);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PCBuilderMemory2.Properties.Resources.ssd;
            this.pictureBox4.Location = new System.Drawing.Point(434, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PCBuilderMemory2.Properties.Resources.ssd;
            this.pictureBox3.Location = new System.Drawing.Point(294, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PCBuilderMemory2.Properties.Resources.network;
            this.pictureBox2.Location = new System.Drawing.Point(154, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCBuilderMemory2.Properties.Resources._case;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScore.Location = new System.Drawing.Point(1053, 39);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(23, 25);
            this.currentScore.TabIndex = 25;
            this.currentScore.Text = "0";
            // 
            // StartGameTemp
            // 
            this.StartGameTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.StartGameTemp.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameTemp.ForeColor = System.Drawing.Color.White;
            this.StartGameTemp.Location = new System.Drawing.Point(592, 282);
            this.StartGameTemp.Name = "StartGameTemp";
            this.StartGameTemp.Size = new System.Drawing.Size(291, 80);
            this.StartGameTemp.TabIndex = 26;
            this.StartGameTemp.Text = "Play";
            this.StartGameTemp.UseVisualStyleBackColor = false;
            this.StartGameTemp.Click += new System.EventHandler(this.StartGameTemp_Click);
            // 
            // unPauseBtn
            // 
            this.unPauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.unPauseBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unPauseBtn.ForeColor = System.Drawing.Color.White;
            this.unPauseBtn.Location = new System.Drawing.Point(561, 218);
            this.unPauseBtn.Name = "unPauseBtn";
            this.unPauseBtn.Size = new System.Drawing.Size(292, 69);
            this.unPauseBtn.TabIndex = 27;
            this.unPauseBtn.Text = "Play";
            this.unPauseBtn.UseVisualStyleBackColor = false;
            this.unPauseBtn.Click += new System.EventHandler(this.UnPauseBtn_Click);
            // 
            // pausePanel
            // 
            this.pausePanel.Controls.Add(this.startPanle);
            this.pausePanel.Controls.Add(this.mainMenuBtn);
            this.pausePanel.Controls.Add(this.pauseQuitBtn);
            this.pausePanel.Controls.Add(this.unPauseBtn);
            this.pausePanel.Controls.Add(this.label2);
            this.pausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pausePanel.Location = new System.Drawing.Point(0, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(1397, 750);
            this.pausePanel.TabIndex = 29;
            // 
            // startPanle
            // 
            this.startPanle.Controls.Add(this.label4);
            this.startPanle.Controls.Add(this.listBox1);
            this.startPanle.Controls.Add(this.label3);
            this.startPanle.Controls.Add(this.mainQuitBtn);
            this.startPanle.Controls.Add(this.StartGameTemp);
            this.startPanle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanle.Location = new System.Drawing.Point(0, 0);
            this.startPanle.Name = "startPanle";
            this.startPanle.Size = new System.Drawing.Size(1397, 750);
            this.startPanle.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 58);
            this.label3.TabIndex = 28;
            this.label3.Text = "PCBuilder Memory";
            // 
            // mainQuitBtn
            // 
            this.mainQuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.mainQuitBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainQuitBtn.ForeColor = System.Drawing.Color.White;
            this.mainQuitBtn.Location = new System.Drawing.Point(592, 390);
            this.mainQuitBtn.Name = "mainQuitBtn";
            this.mainQuitBtn.Size = new System.Drawing.Size(291, 79);
            this.mainQuitBtn.TabIndex = 27;
            this.mainQuitBtn.Text = "Quit";
            this.mainQuitBtn.UseVisualStyleBackColor = false;
            this.mainQuitBtn.Click += new System.EventHandler(this.MainQuitBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.mainMenuBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.ForeColor = System.Drawing.Color.White;
            this.mainMenuBtn.Location = new System.Drawing.Point(561, 431);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(292, 63);
            this.mainMenuBtn.TabIndex = 28;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // pauseQuitBtn
            // 
            this.pauseQuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.pauseQuitBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseQuitBtn.ForeColor = System.Drawing.Color.White;
            this.pauseQuitBtn.Location = new System.Drawing.Point(561, 325);
            this.pauseQuitBtn.Name = "pauseQuitBtn";
            this.pauseQuitBtn.Size = new System.Drawing.Size(292, 70);
            this.pauseQuitBtn.TabIndex = 28;
            this.pauseQuitBtn.Text = "Quit";
            this.pauseQuitBtn.UseVisualStyleBackColor = false;
            this.pauseQuitBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 58);
            this.label2.TabIndex = 31;
            this.label2.Text = "PCBuilder Memory";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(1126, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 303);
            this.listBox1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1165, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 34);
            this.label4.TabIndex = 30;
            this.label4.Text = "Top Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 750);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pausePanel.ResumeLayout(false);
            this.pausePanel.PerformLayout();
            this.startPanle.ResumeLayout(false);
            this.startPanle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Button StartGameTemp;
        private System.Windows.Forms.Button unPauseBtn;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Panel startPanle;
        private System.Windows.Forms.Button pauseQuitBtn;
        private System.Windows.Forms.Button mainQuitBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

