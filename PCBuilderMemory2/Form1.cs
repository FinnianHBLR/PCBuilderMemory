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
        GameManager gameManager = new GameManager();

        public Form1()
        {
            InitializeComponent();



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
            //SHUFFLE

            this.pausePanel.Visible = false;


            currentScore.Text = "0";

            game_timer.Enabled = true;

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

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            //This will not save the score
            this.startPanle.Visible = true;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = gameManager.Deck.GetPartCards()[0].getImage();
            gameManager.Deck.GetPartCards()[0].setFlipStatus(true);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = gameManager.Deck.GetPartCards()[1].getImage();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = gameManager.Deck.GetPartCards()[2].getImage();

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = gameManager.Deck.GetPartCards()[3].getImage();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = gameManager.Deck.GetPartCards()[4].getImage();

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = gameManager.Deck.GetPartCards()[5].getImage();

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = gameManager.Deck.GetPartCards()[6].getImage();

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = gameManager.Deck.GetPartCards()[7].getImage();

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = gameManager.Deck.GetPartCards()[8].getImage();

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = gameManager.Deck.GetPartCards()[9].getImage();

        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = gameManager.Deck.GetPartCards()[10].getImage();

        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = gameManager.Deck.GetPartCards()[11].getImage();

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = gameManager.Deck.GetPartCards()[12].getImage();

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = gameManager.Deck.GetPartCards()[13].getImage();

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = gameManager.Deck.GetPartCards()[14].getImage();

        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = gameManager.Deck.GetPartCards()[15].getImage();

        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = gameManager.Deck.GetPartCards()[16].getImage();

        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = gameManager.Deck.GetPartCards()[17].getImage();

        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = gameManager.Deck.GetPartCards()[18].getImage();

        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = gameManager.Deck.GetPartCards()[19].getImage();

        }
    }
}
