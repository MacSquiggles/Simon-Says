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

namespace Simon_Says
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {

        }

        private void pinkButton_Click(object sender, EventArgs e)
        {

        }

        private void greenButton_Click(object sender, EventArgs e)
        {

        }

        private void gameExitButton_Click(object sender, EventArgs e)
        {

        }

        private void computerTurn()
        {
            Random randNum = new Random();
            int rand = randNum.Next(0, 4);
         }

        private void playerTurn()
        {

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

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(2000);
            computerTurn();
        }
    }
}
