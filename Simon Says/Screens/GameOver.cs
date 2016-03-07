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

namespace Simon_Says
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //if the play again button is pressed, the gameOver user control closes, and
            //the gamescreen opens and is centred in the screen
            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            f.Controls.Add(gs);
            gs.BringToFront();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            //when the gameOver user control is loaded, the score is
            //displayed on the screen
            scoreLabel.Text = "Correct Guesses: " + Form1.score;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //if the main menu button is pressed, the gameOver user control closes, and
            //the main screen opens and is centred in the screen
            MainScreen ms = new MainScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            f.Controls.Add(ms);
            ms.BringToFront();
        }
    }
}
