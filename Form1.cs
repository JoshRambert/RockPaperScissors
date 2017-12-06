using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_3_Rock_paper
{
    public partial class Form1 : Form
    {
        //Have the user pick either rock papaer or scissors
        //and have the computer pick either rock papar or scissors randomly 
        //Display the total number of wins in the user display and the computer display
        //Display either a rock a paper or a pair of scissors for whichever is picked

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayRock()
        {
            //display the rock image 
            pictureBox1.Visible = true;

            //choose the rock image from the resources
            pictureBox1.Image = Properties.Resources.rock;
        }

        private void DisplayPaper()
        {
            //make the image visible
            pictureBox1.Visible = true;

            //choose the paper image from the resources
            pictureBox1.Image = Properties.Resources.paper;
        }

        private void DisplayScissors()
        {
            //make the image visible
            pictureBox1.Visible = true;

            //choose the scissors image from the resources
            pictureBox1.Image = Properties.Resources.scissors;
        }

        //assign constanats to be used throughout the program
        int rock = 1;
        int paper = 2;
        int scissors = 3;
        int number;

        //Assign the random value to the computer variable
        Random comp = new Random();
        int countComp;
        int countUser;

        //Retrieve picture files to be used within the program

        private void rockButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                //call the display rock method
                DisplayRock();
            }
            else
            {
                //display an error message
                MessageBox.Show("Program is not working correctly");
            }

            //Declare the random variable for the computer
            number = comp.Next(4) + 1;

            //Calculate user versus computer
            if(number == paper)
            {
                //Display the number of times the computer won
                //MessageBox.Show("Computer wins");
                countComp = countComp + 1;
                compDisplayWinsLabel.Text = countComp.ToString();

                //Dsplay the paper picture in the picture box
                pictureBox2.Image = Properties.Resources.paper;
            }
            else if(number == scissors)
            {
                //Display the number of times the use won
                //MessageBox.Show("User wins");
                countUser = countUser + 1;
                userDisplayWinsLabel.Text = countUser.ToString();

                //display the scissors picture in the computers ppicture box
                pictureBox2.Image = Properties.Resources.scissors;
            }
            else if (number == rock)
            {
                //Display a message if its a draw
                //MessageBox.Show("Its a draw!");

                //display the rock picture in the computers picture box
                pictureBox2.Image = Properties.Resources.rock;
            }
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //Retrieve the paper image from the method created
            if (pictureBox1.Visible == true)
            {
                DisplayPaper(); 
            }
            else
            {
                //Display an error message
                MessageBox.Show("The program is not working correctly");
            }

            //Declare the random variable for th computer
            number = comp.Next(4) + 1;

            //Calculate user versus computer
            if (number == scissors)
            {
                //Display the number of times the user won
                //MessageBox.Show("Computer Wins");
                countComp = countComp + 1;
                compDisplayWinsLabel.Text = countComp.ToString();

                //display the scissors picture in the computers ppicture box
                pictureBox2.Image = Properties.Resources.scissors;
            }
            else if (number == rock)
            {
                //Display the number of times the user won
                //MessageBox.Show("User wins");
                countUser = countUser + 1;
                userDisplayWinsLabel.Text = countUser.ToString();

                //display the rock picture in the computers picture box
                pictureBox2.Image = Properties.Resources.rock;
            }
            else if (number == paper)
            {
                //Display a mesage if it is a draw
                //MessageBox.Show("Its a Draw!");

                //Display the paper picture in the picture box
                pictureBox2.Image = Properties.Resources.paper;
            }
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                //call the scissors method
                DisplayScissors();
            }
            else
            {
                //display an error message
                MessageBox.Show("The program is not working correctly");
            }

            //Declare the random variable within the click handle
            number = comp.Next(4) + 1;

            //Claculate user versus computer
            if (number == paper)
            {
                //Display the nuber of times the user won
                //MessageBox.Show("User wins");
                countUser = countUser + 1;
                userDisplayWinsLabel.Text = countUser.ToString();

                //Display the paper picture in the picture box
                pictureBox2.Image = Properties.Resources.paper;
            }
            else if (number == rock)
            {
                //Display the number of times the computer won
                //MessageBox.Show("Computer wins");
                countComp = countComp + 1;
                compDisplayWinsLabel.Text = countComp.ToString();

                //display the rock picture in the computers picture box
                pictureBox2.Image = Properties.Resources.rock;
            }
            else if (number == scissors)
            {
                //Display a message if it is a draw
                //MessageBox.Show("Its a draw!");

                //display the scissors picture in the computers ppicture box
                pictureBox2.Image = Properties.Resources.scissors;
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //Clear both display labels to give the user a clean slate
            userDisplayWinsLabel.Text = " ";
            compDisplayWinsLabel.Text = " ";

            //Clear the text boxes to give the user a clean slate
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            //Erase the count total and start again
            countComp = 0;
            countUser = 0;
        }
    }
}