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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private void instructionsButton_Click(object sender, EventArgs e)
        {
            //if the instructions button is clicked, a new user control is added 
            //and centred, and the mainscreen is removed
            InstructionsForm inf = new InstructionsForm();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            inf.Location = new Point((f.Width - inf.Width) / 2, (f.Height - inf.Height) / 2);
            f.Controls.Add(inf);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //if the play button is clicked then the loading screen opens 
            //and is centred and the main screen is removed
            loadingScreen ls = new loadingScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ls.Location = new Point((f.Width - ls.Width) / 2, (f.Height - ls.Height) / 2);
            f.Controls.Add(ls);
            ls.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //if exit button is clicked the program closes
            Application.Exit();
        }
    }
}
