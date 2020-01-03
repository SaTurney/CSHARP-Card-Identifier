//Sabrina Turney
//COP 2360
//Module 1, Chapter 2 Program 3 - Card Identifier
//Last edited: August 25 2019
//This program allows the user to click to exit, as well as display cards clicked.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //This exits the program, attached to the exit button being clicked.
        }

        private void QueenHeartsCard_Click(object sender, EventArgs e)
        {
            //The Queen of Hearts Card has been clicked. We tell our label box to display this to the user.
            cardIdentifyBox.Text = "The Queen of Hearts";
        }

        private void TwoDiamondsCard_Click(object sender, EventArgs e)
        {
            //The Two of Diamonds Card has been clicked. We tell our label box to display this to the user.
            cardIdentifyBox.Text = "The Two of Diamonds";
        }

        private void FiveClubsCard_Click(object sender, EventArgs e)
        {
            //The Five of Clubs Card has been clicked. We tell our label box to display this to the user.
            cardIdentifyBox.Text = "The Five of Clubs";
        }

        private void KingSpadesCard_Click(object sender, EventArgs e)
        {

            //The King of Spades Card has been clicked. We tell our label box to display this to the user.
            cardIdentifyBox.Text = "The King of Spades";
        }

        private void EightSpadesCard_Click(object sender, EventArgs e)
        {
            //The Eight of Spades Card has been clicked. We tell our label box to display this to the user.
            cardIdentifyBox.Text = "The Eight of Spades";
        }
    }
}
