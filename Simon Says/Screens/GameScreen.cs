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
        SoundPlayer player = new SoundPlayer(Properties.Resources.blueBeep);
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.yellowBeep);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.pinkBeep);
        SoundPlayer player3 = new SoundPlayer(Properties.Resources.greenBeep);
        List<SoundPlayer> players = new List<SoundPlayer>(4);
        List<Button> buttons = new List<Button>(4);
        List<Color> colourChange = new List<Color>(4);
        List<Color> colourNorm = new List<Color>(4);
        int guessIndex = 0;

        public GameScreen()
        {
            InitializeComponent();
            Form1.pattern.Clear();
            Form1.score = 0;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            playerTurn(0);
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            playerTurn(1);
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            playerTurn(2);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            playerTurn(3);
        }

        private void computerTurn()
        {
            guessIndex = 0;
            Random randNum = new Random();
            int pattNum = randNum.Next(0, 4);
            Form1.pattern.Add(pattNum);
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                buttons[Form1.pattern[i]].BackColor = colourChange[Form1.pattern[i]];
                players[Form1.pattern[i]].Play();
                Refresh();
                Thread.Sleep(1000);
                buttons[Form1.pattern[i]].BackColor = colourNorm[Form1.pattern[i]];
                Refresh();
            }
            pattNum = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buttoncorrect"></param>A value reeived from each button press that dictates if the pattern was followed
        private void playerTurn(int buttoncorrect)
        {
            if (Form1.pattern.Count() > guessIndex)
            {
                if (Form1.pattern[guessIndex] == buttoncorrect)
                {
                    buttons[Form1.pattern[guessIndex]].BackColor = colourChange[Form1.pattern[guessIndex]];
                    players[Form1.pattern[guessIndex]].Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttons[Form1.pattern[guessIndex]].BackColor = colourNorm[Form1.pattern[guessIndex]];
                    Refresh();
                }
                else if (Form1.pattern.Count() > guessIndex)
                {
                    Form1.score = Form1.pattern.Count();
                    gameOver();
                    
                }
                guessIndex++;
            }

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
            // pattern can be made then refreashes the screen
            Form1.pattern.Clear();
            guessIndex = 0;
            Refresh();
            Thread.Sleep(1000);

            //Adds a range of sounds (one for each button press) into a list called players
            players.InsertRange(players.Count(), new SoundPlayer[] {player, player1, player2, player3});
            //Adds a range of buttons (one for each coloured button) into a list called buttons
            buttons.InsertRange(buttons.Count(), new Button[] { blueButton, yellowButton, pinkButton, greenButton });
            //Adds a range of colours (the original colour of each button) into a list called colourNorm
            colourNorm.InsertRange(colourNorm.Count(), new Color[] { Color.Blue, Color.Yellow, Color.MediumVioletRed, Color.Chartreuse });
            //Adds a range of colours (the lighter version for when each button is pressed) into a list called colourChange
            colourChange.InsertRange(colourChange.Count(), new Color[] { Color.Aqua, Color.Beige, Color.Pink, Color.LightGreen });
            computerTurn();
        }

        /// <summary>
        /// Opens the game over screeen, centres it and brings it to the front of the screen
        /// </summary>
        private void gameOver()
        {
            GameOver go = new GameOver();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            go.Location = new Point((f.Width - go.Width) / 2, (f.Height - go.Height) / 2);
            f.Controls.Add(go);
            go.BringToFront();
        }
    }
}
