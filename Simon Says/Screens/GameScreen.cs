/* 
Created by: Quigley
Date: March 2016
Discription: a modern version of the classic game "Simon"
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Simon_Says
{
    public partial class GameScreen : UserControl
    {
        #region Soundplayers
        //created four sounds to later be stored in a list (one player for each button click)
        SoundPlayer player = new SoundPlayer(Properties.Resources.blueBeep);
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.yellowBeep);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.pinkBeep);
        SoundPlayer player3 = new SoundPlayer(Properties.Resources.greenBeep);
        #endregion
        #region Lists
        //created a list to store the sounds, the buttons, the initial button colour and the changed button colour
        List<SoundPlayer> players = new List<SoundPlayer>(4);
        List<Button> buttons = new List<Button>(4);
        List<Color> colourChange = new List<Color>(4);
        List<Color> colourNorm = new List<Color>(4);
        #endregion
        #region Variables
        //Created a variable to keep track of location in the pattern list 
        int guessIndex = 0;
        #endregion
        public GameScreen()
        {
            InitializeComponent();
        }
        #region Buttons
        private void blueButton_Click(object sender, EventArgs e)
        {
            //sends the value 0 to to method playerTurn
            playerTurn(0);
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            //sends the value 1 to to method playerTurn
            playerTurn(1);
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            //sends the value 2 to to method playerTurn
            playerTurn(2);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            //sends the value 3 to to method playerTurn
            playerTurn(3);
        }
        #endregion

        /// <summary>
        /// A method used to add numbers to the pattern and display 
        /// the pattern through a sound and change in button colour
        /// </summary>
        private void computerTurn()
        {
            //sets guess index back to zero
            guessIndex = 0;

            //creates a random number (0, 1, 2, or 3) (one number to represent each button) and 
            //adds it to the pattern list
            Random randNum = new Random();
            int pattNum = randNum.Next(0, 4);
            Form1.pattern.Add(pattNum);

            //A for loop that goes through the whole pattern and plays the according sound and changes the button colour
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                buttons[Form1.pattern[i]].BackColor = colourChange[Form1.pattern[i]];
                players[Form1.pattern[i]].Play();
                Refresh();
                Thread.Sleep(1000);
                buttons[Form1.pattern[i]].BackColor = colourNorm[Form1.pattern[i]];
                Refresh();
            }

            //resets the random number to zero
            pattNum = 0;
        }

        /// <summary>
        ///A method used to chekc if the button pressed follows the pattern 
        /// </summary>
        /// <param name="buttoncorrect"></param>A value reeived from each button press that dictates if the pattern was followed
        private void playerTurn(int buttoncorrect)
        {
            //guess index saves the place in the list pattern
            if (Form1.pattern.Count() > guessIndex)
            {
                //this will run if the pattern and button clicked matches 
                if (Form1.pattern[guessIndex] == buttoncorrect)
                {
                    //the colour of the button will once again become lighter and a sound 
                    //will be made, then it will revert back to normal
                    buttons[Form1.pattern[guessIndex]].BackColor = colourChange[Form1.pattern[guessIndex]];
                    players[Form1.pattern[guessIndex]].Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttons[Form1.pattern[guessIndex]].BackColor = colourNorm[Form1.pattern[guessIndex]];
                    Refresh();
                }
                //if the button clicked doesnt match the pattern then the method Game over is run
                else if (Form1.pattern.Count() > guessIndex)
                {
                    Form1.score = Form1.pattern.Count();
                    gameOver();

                }
                //one is added to the guess index everytime 
                guessIndex++;
            }
            //if the whole pattern has successfully been gone through, one point is 
            //added to the score and the computerturn method runs again
            if (Form1.pattern.Count <= guessIndex)
            {
                Form1.score = Form1.pattern.Count();
                pointsLabel.Text = "Points: " + Form1.score;
                computerTurn();
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //It cleats the list and sets the guess index back to zero so a new
            // pattern can be made then refreshes the screen
            Form1.pattern.Clear();
            guessIndex = 0;
            Refresh();
            Thread.Sleep(1000);

            //Adds a range of sounds (one for each button press) into a list called players
            players.InsertRange(players.Count(), new SoundPlayer[] { player, player1, player2, player3 });
            //Adds a range of buttons (one for each coloured button) into a list called buttons
            buttons.InsertRange(buttons.Count(), new Button[] { blueButton, yellowButton, pinkButton, greenButton });
            //Adds a range of colours (the original colour of each button) into a list called colourNorm
            colourNorm.InsertRange(colourNorm.Count(), new Color[] { Color.Blue, Color.Yellow, Color.MediumVioletRed, Color.Chartreuse });
            //Adds a range of colours (the lighter version for when each button is pressed) into a list called colourChange
            colourChange.InsertRange(colourChange.Count(), new Color[] { Color.Aqua, Color.Beige, Color.Pink, Color.LightGreen });
            computerTurn();
        }

        /// <summary>
        /// Opens the gameOver user control, centres it and brings it to the front of the screen
        /// </summary>
        private void gameOver()
        {
            //creates a soundplayer to play the game over sound
            SoundPlayer failplayer = new SoundPlayer(Properties.Resources.failSound);
            failplayer.Play();
            Thread.Sleep(1000);
            GameOver go = new GameOver();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            go.Location = new Point((f.Width - go.Width) / 2, (f.Height - go.Height) / 2);
            f.Controls.Add(go);
            go.BringToFront();
        }
    }
}