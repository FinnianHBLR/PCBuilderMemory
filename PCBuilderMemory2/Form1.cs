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

        //Creates a list with 2 in it.
        List<PictureBox> flippedBoxes = new List<PictureBox>(2);

        //Int for keeping flip time
        private int flipTime = 0;
        private int matched = 0;

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



        private void game_time(object sender, EventArgs e)
        {
            int currentTime = Convert.ToInt32(currentScore.Text);
            //Gets time from label

            currentTime++;

            currentScore.Text = currentTime.ToString();


            //Flipping or removing cards

            if (flippedBoxes.Count == 2)
            {
                if (flipTime == 0)
                {
                    //Check if same
                    int firstIndex = Convert.ToInt32(flippedBoxes[0].Name.Substring("PictureBox".Length)) - 1;

                    int secondIndex = Convert.ToInt32(flippedBoxes[1].Name.Substring("PictureBox".Length)) - 1;

                    if (gameManager.Deck.GetPartCards()[firstIndex].getPartType() == gameManager.Deck.GetPartCards()[secondIndex].getPartType())
                    {
                        matched++;
                        flippedBoxes[0].Visible = false;
                        flippedBoxes[1].Visible = false;

                        gameListParts.CheckedItems.//THis is list for items

                    }
                    else
                    {

                        flippedBoxes[0].Image = Properties.Resources.cover;
                        flippedBoxes[1].Image = Properties.Resources.cover;

                        flippedBoxes.Remove(flippedBoxes[0]);
                        flippedBoxes.Remove(flippedBoxes[0]); //Remove the first one, then the second one goes into the first spot is

                    }
                    flipTime = 3;

                }
                flipTime--;
            }


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
            if (flippedBoxes.Count < 2)
            {
                pictureBox1.Image = gameManager.Deck.GetPartCards()[0].getImage();
                gameManager.Deck.GetPartCards()[0].setFlipStatus(true);
                flippedBoxes.Add(pictureBox1);
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox2.Image = gameManager.Deck.GetPartCards()[1].getImage();
                gameManager.Deck.GetPartCards()[1].setFlipStatus(true);
                flippedBoxes.Add(pictureBox2);
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {

                pictureBox3.Image = gameManager.Deck.GetPartCards()[2].getImage();
                gameManager.Deck.GetPartCards()[2].setFlipStatus(true);
                flippedBoxes.Add(pictureBox3);
            }
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox4.Image = gameManager.Deck.GetPartCards()[3].getImage();
                gameManager.Deck.GetPartCards()[3].setFlipStatus(true);
                flippedBoxes.Add(pictureBox4);
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox5.Image = gameManager.Deck.GetPartCards()[4].getImage();
                gameManager.Deck.GetPartCards()[4].setFlipStatus(true);
                flippedBoxes.Add(pictureBox5);
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox10.Image = gameManager.Deck.GetPartCards()[9].getImage();
                gameManager.Deck.GetPartCards()[9].setFlipStatus(true);
                flippedBoxes.Add(pictureBox10);
            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {

                pictureBox9.Image = gameManager.Deck.GetPartCards()[8].getImage();
                gameManager.Deck.GetPartCards()[8].setFlipStatus(true);
                flippedBoxes.Add(pictureBox9);
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox8.Image = gameManager.Deck.GetPartCards()[7].getImage();
                gameManager.Deck.GetPartCards()[7].setFlipStatus(true);
                flippedBoxes.Add(pictureBox8);
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox7.Image = gameManager.Deck.GetPartCards()[6].getImage();
                gameManager.Deck.GetPartCards()[6].setFlipStatus(true);
                flippedBoxes.Add(pictureBox7);
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox6.Image = gameManager.Deck.GetPartCards()[5].getImage();
                gameManager.Deck.GetPartCards()[5].setFlipStatus(true);
                flippedBoxes.Add(pictureBox6);
            }
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox15.Image = gameManager.Deck.GetPartCards()[14].getImage();
                gameManager.Deck.GetPartCards()[14].setFlipStatus(true);
                flippedBoxes.Add(pictureBox15);
            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox14.Image = gameManager.Deck.GetPartCards()[13].getImage();
                gameManager.Deck.GetPartCards()[13].setFlipStatus(true);
                flippedBoxes.Add(pictureBox14);
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox13.Image = gameManager.Deck.GetPartCards()[12].getImage();
                gameManager.Deck.GetPartCards()[12].setFlipStatus(true);
                flippedBoxes.Add(pictureBox13);
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox12.Image = gameManager.Deck.GetPartCards()[11].getImage();
                gameManager.Deck.GetPartCards()[11].setFlipStatus(true);
                flippedBoxes.Add(pictureBox12);
            }
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox11.Image = gameManager.Deck.GetPartCards()[10].getImage();
                gameManager.Deck.GetPartCards()[10].setFlipStatus(true);
                flippedBoxes.Add(pictureBox11);
            }
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox20.Image = gameManager.Deck.GetPartCards()[19].getImage();
                gameManager.Deck.GetPartCards()[19].setFlipStatus(true);
                flippedBoxes.Add(pictureBox20);
            }
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox19.Image = gameManager.Deck.GetPartCards()[16].getImage();
                gameManager.Deck.GetPartCards()[16].setFlipStatus(true);
                flippedBoxes.Add(pictureBox19);
            }
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox18.Image = gameManager.Deck.GetPartCards()[17].getImage();
                gameManager.Deck.GetPartCards()[17].setFlipStatus(true);
                flippedBoxes.Add(pictureBox18);
            }
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox17.Image = gameManager.Deck.GetPartCards()[18].getImage();
                gameManager.Deck.GetPartCards()[18].setFlipStatus(true);
                flippedBoxes.Add(pictureBox17);
            }
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox16.Image = gameManager.Deck.GetPartCards()[19].getImage();
                gameManager.Deck.GetPartCards()[19].setFlipStatus(true);
                flippedBoxes.Add(pictureBox16);
            }
        }
    }
}
