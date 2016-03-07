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

namespace Simon_Says
{
    public partial class loadingScreen : UserControl
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void loadingScreen_Load(object sender, EventArgs e)
        {
            //makes the loading bar load
            while (loadingBar.Value < loadingBar.Maximum)
            {
                loadingBar.Value = loadingBar.Value + 1;
                Thread.Sleep(10);
                Refresh();
            }
            //if the loading has completed, the loading form closes and the 
            //game screen is added and centred in the middle of the screen
            if (loadingBar.Value >= loadingBar.Maximum)
            {
                GameScreen gs = new GameScreen();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                f.Controls.Add(gs);
                gs.BringToFront();
            }
        }
    }
}
