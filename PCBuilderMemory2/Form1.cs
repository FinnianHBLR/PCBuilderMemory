using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilderMemory2
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes;
        List<Bitmap> images;
        public Form1()
        {
            InitializeComponent();
            //this.menuPanel.Visible = false;


            //Hides pause button
            this.unPauseBtn.Visible = false;
            this.pausePanel.Visible = false;


            pictureBoxes = new List<PictureBox>()
            {
                this.pictureBox1,
                this.pictureBox2,
                this.pictureBox4,
                this.pictureBox5,
                this.pictureBox6,
                this.pictureBox7,
                this.pictureBox8,
                this.pictureBox9,
                this.pictureBox10,
                this.pictureBox12,
                this.pictureBox13,
                this.pictureBox14,
                this.pictureBox15,
                this.pictureBox16,
                this.pictureBox17,
                this.pictureBox18,
                this.pictureBox19,
                this.pictureBox20
            };

            images = new List<Bitmap>()
            {
                Properties.Resources.gpu,
                Properties.Resources.gpu,

                Properties.Resources.cpu,
                Properties.Resources.cpu,

                Properties.Resources.cooling,
                Properties.Resources.cooling,

                Properties.Resources.motherboard,
                Properties.Resources.motherboard,

                Properties.Resources.network,
                Properties.Resources.network,

                Properties.Resources.os,
                Properties.Resources.os,

                Properties.Resources.psu,
                Properties.Resources.psu,

                Properties.Resources.ram,
                Properties.Resources.ram,

                Properties.Resources.ssd,
                Properties.Resources.ssd,

                Properties.Resources._case,
                Properties.Resources._case
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void game_time(object sender, EventArgs e)
        {
            int currentTime = Convert.ToInt32(currentScore.Text);
            //Gets time from label

            currentTime++;

            currentScore.Text = currentTime.ToString();
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            game_timer.Enabled = false;

            this.unPauseBtn.Visible = true;

            this.pausePanel.Visible = true;
        }

        private void StartGameTemp_Click(object sender, EventArgs e)
        {
            currentScore.Text = "0";

            game_timer.Enabled = true;

            this.StartGameTemp.Visible = false;

            this.startPanle.Visible = false;

            //Shuffle


        }

        private void UnPauseBtn_Click(object sender, EventArgs e)
        {
            game_timer.Enabled = true;

            this.unPauseBtn.Visible = false;

            this.pausePanel.Visible = false;

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //Save score
        }

        private void MainQuitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
