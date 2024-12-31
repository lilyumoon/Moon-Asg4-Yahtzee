using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg4_Yahtzee
{
    public partial class Form1 : Form
    {
        private bool[] heldDice = new bool[5];

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            for (int i = 0; i < heldDice.Length; i++)
                heldDice[i] = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox5_Click(object sender, EventArgs e)
        {

        }


    }
}
