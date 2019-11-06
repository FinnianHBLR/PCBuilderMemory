﻿using System;
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

        //Create new Deck
        Deck deck = new Deck();

        //Creates a list with 2 in it.
        List<PictureBox> flippedBoxes = new List<PictureBox>(2);//To keep track of what cards are flipped

        //Int for keeping flip time
        private int flipTime = 0; //Initilaize fliptime
        private int matched = 0;



        public Form1()
        {
            InitializeComponent();


            //Create new picture boxes
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
            //Adds time to label

            currentScore.Text = currentTime.ToString();

            //Flipping or removing cards

            if (flippedBoxes.Count == 2)
            {
                //Checks if 2 cards are flipped
                if (flipTime == 0)
                {
                    //Get first and second indexes to identify cards from the list of flipped cards (These are added from the click event)
                    int firstIndex = Convert.ToInt32(flippedBoxes[0].Name.Substring("PictureBox".Length)) - 1;

                    int secondIndex = Convert.ToInt32(flippedBoxes[1].Name.Substring("PictureBox".Length)) - 1;

                    //Gets the part types from each card and compares, eg "CPU" == "CPU"
                    if (Deck.GetPartCards()[firstIndex].getPartType() == Deck.GetPartCards()[secondIndex].getPartType())
                    {
                        matched++;
                        //Hides cards if they are equal
                        flippedBoxes[0].Visible = false;
                        flippedBoxes[1].Visible = false;

                        //ADD TO LIST OF PARTS use partype
                        switch (Deck.GetPartCards()[firstIndex].getPartType())
                        {
                            case "CPU":
                                gameListParts.Items.Add("CPU", CheckState.Checked);
                                break;
                            case "COOLING":
                                gameListParts.Items.Add("Cooling", CheckState.Checked);
                                break;
                            case "MOTHERBOARD":
                                gameListParts.Items.Add("Motherboard", CheckState.Checked);
                                break;
                            case "MEMORY":
                                gameListParts.Items.Add("Memory", CheckState.Checked);
                                break;
                            case "GPU":
                                gameListParts.Items.Add("GPU", CheckState.Checked);
                                break;
                            case "CASE":
                                gameListParts.Items.Add("Case", CheckState.Checked);
                                break;
                            case "PSU":
                                gameListParts.Items.Add("Power Supply", CheckState.Checked);
                                break;
                            case "OS":
                                gameListParts.Items.Add("Operrating System", CheckState.Checked);
                                break;
                            case "NETWORK":
                                gameListParts.Items.Add("Networking", CheckState.Checked);
                                break;
                            case "STORAGE":
                                gameListParts.Items.Add("Storage", CheckState.Checked);
                                break;
                        }
                    }
                    else
                    {
                        //Else reset the card to cover
                        flippedBoxes[0].Image = Properties.Resources.cover;
                        flippedBoxes[1].Image = Properties.Resources.cover;

                    }
                    //Fliptime sets how long the card will stay up
                    flipTime = 3;

                    flippedBoxes.Remove(flippedBoxes[0]);
                    flippedBoxes.Remove(flippedBoxes[0]); //Remove the first one, then the second one goes into the first spot is

                }
                //Each time clock ticks removes one from flip time
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

            //Resets the score
            currentScore.Text = "0";

            //Enables timer
            game_timer.Enabled = true;

            this.startPanle.Visible = false;

            //Shuffle

        }

        private void UnPauseBtn_Click(object sender, EventArgs e)
        {
            //Starts game timer
            game_timer.Enabled = true;

            //Hides buttons, may not be needed
            this.unPauseBtn.Visible = false;

            this.pausePanel.Visible = false;

        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Exits window
            System.Windows.Forms.Application.Exit();
            //Will need to Save scores
        }

        private void MainQuitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //Quits application
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
            //If there are two cards flipped this will stop the user flipping more
            if (flippedBoxes.Count < 2)
            {
                //Get part names from Deck
                pictureBox1.Image = Deck.GetPartCards()[0].getImage();
                //Sets flip status to true in its object
                Deck.GetPartCards()[0].setFlipStatus(true);
                //Adds card to list of cards in use to comapre them
                flippedBoxes.Add(pictureBox1);
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox2.Image = Deck.GetPartCards()[1].getImage();
                Deck.GetPartCards()[1].setFlipStatus(true);
                flippedBoxes.Add(pictureBox2);
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {

                pictureBox3.Image = Deck.GetPartCards()[2].getImage();
                Deck.GetPartCards()[2].setFlipStatus(true);
                flippedBoxes.Add(pictureBox3);
            }
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox4.Image = Deck.GetPartCards()[3].getImage();
                Deck.GetPartCards()[3].setFlipStatus(true);
                flippedBoxes.Add(pictureBox4);
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox5.Image = Deck.GetPartCards()[4].getImage();
                Deck.GetPartCards()[4].setFlipStatus(true);
                flippedBoxes.Add(pictureBox5);
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox10.Image = Deck.GetPartCards()[9].getImage();
                Deck.GetPartCards()[9].setFlipStatus(true);
                flippedBoxes.Add(pictureBox10);
            }
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {

                pictureBox9.Image = Deck.GetPartCards()[8].getImage();
                Deck.GetPartCards()[8].setFlipStatus(true);
                flippedBoxes.Add(pictureBox9);
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox8.Image = Deck.GetPartCards()[7].getImage();
                Deck.GetPartCards()[7].setFlipStatus(true);
                flippedBoxes.Add(pictureBox8);
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox7.Image = Deck.GetPartCards()[6].getImage();
                Deck.GetPartCards()[6].setFlipStatus(true);
                flippedBoxes.Add(pictureBox7);
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox6.Image = Deck.GetPartCards()[5].getImage();
                Deck.GetPartCards()[5].setFlipStatus(true);
                flippedBoxes.Add(pictureBox6);
            }
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox15.Image = Deck.GetPartCards()[14].getImage();
                Deck.GetPartCards()[14].setFlipStatus(true);
                flippedBoxes.Add(pictureBox15);
            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox14.Image = Deck.GetPartCards()[13].getImage();
                Deck.GetPartCards()[13].setFlipStatus(true);
                flippedBoxes.Add(pictureBox14);
            }
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox13.Image = Deck.GetPartCards()[12].getImage();
                Deck.GetPartCards()[12].setFlipStatus(true);
                flippedBoxes.Add(pictureBox13);
            }
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox12.Image = Deck.GetPartCards()[11].getImage();
                Deck.GetPartCards()[11].setFlipStatus(true);
                flippedBoxes.Add(pictureBox12);
            }
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox11.Image = Deck.GetPartCards()[10].getImage();
                Deck.GetPartCards()[10].setFlipStatus(true);
                flippedBoxes.Add(pictureBox11);
            }
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox20.Image = Deck.GetPartCards()[19].getImage();
                Deck.GetPartCards()[19].setFlipStatus(true);
                flippedBoxes.Add(pictureBox20);
            }
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox19.Image = Deck.GetPartCards()[16].getImage();
                Deck.GetPartCards()[16].setFlipStatus(true);
                flippedBoxes.Add(pictureBox19);
            }
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox18.Image = Deck.GetPartCards()[17].getImage();
                Deck.GetPartCards()[17].setFlipStatus(true);
                flippedBoxes.Add(pictureBox18);
            }
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox17.Image = Deck.GetPartCards()[18].getImage();
                Deck.GetPartCards()[18].setFlipStatus(true);
                flippedBoxes.Add(pictureBox17);
            }
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (flippedBoxes.Count < 2)
            {
                pictureBox16.Image = Deck.GetPartCards()[19].getImage();
                Deck.GetPartCards()[19].setFlipStatus(true);
                flippedBoxes.Add(pictureBox16);
            }
        }
    }
}
