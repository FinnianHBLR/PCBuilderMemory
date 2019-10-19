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
    }
}
