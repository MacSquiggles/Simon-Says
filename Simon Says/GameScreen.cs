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
            player.Play();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            playerTurn(1);
            player1.Play();
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            playerTurn(2);
            player2.Play();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            playerTurn(3);
            player3.Play();
        }

        private void computerTurn()
        { 
            Random randNum = new Random();
            int pattNum = randNum.Next(0, 4);
            Form1.pattern.Add(pattNum);
            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                buttons[Form1.pattern[guessIndex]].BackColor = colourChange[Form1.pattern[guessIndex]];
                players[Form1.pattern[guessIndex]].Play();
                Refresh();
                Thread.Sleep(2000);
                buttons[Form1.pattern[guessIndex]].BackColor = colourNorm[Form1.pattern[guessIndex]];
                Refresh();
            }
        }

        private void playerTurn(int buttoncorrect)
        {
            if (Form1.pattern.Count() > guessIndex)
            {
                if (Form1.pattern[guessIndex] == buttoncorrect)
                {
                    buttons[Form1.pattern[guessIndex]].BackColor = colourChange[Form1.pattern[guessIndex]];
                    players[Form1.pattern[guessIndex]].Play();
                    Refresh();
                    Thread.Sleep(2000);
                    buttons[Form1.pattern[guessIndex]].BackColor = colourNorm[Form1.pattern[guessIndex]];
                    Refresh();
                }
                guessIndex++;
            }
            else if(Form1.pattern.Count() > guessIndex)
            {
                gameOver();
                Form1.score = Form1.pattern.Count();
            }
            if (Form1.pattern.Count <= guessIndex)
            {
                Form1.score++;
                computerTurn();
            }
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(2000);
            players.InsertRange(players.Count(), new SoundPlayer[] {player, player1, player2, player3});
            buttons.InsertRange(buttons.Count(), new Button[] { blueButton, yellowButton, pinkButton, greenButton });
            colourNorm.InsertRange(colourNorm.Count(), new Color[] { Color.Blue, Color.Yellow, Color.MediumVioletRed, Color.Chartreuse });
            colourChange.InsertRange(colourChange.Count(), new Color[] { Color.Aqua, Color.Beige, Color.Pink, Color.LightGreen });
            computerTurn();
        }
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
