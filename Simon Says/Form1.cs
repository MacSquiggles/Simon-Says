/* 
Created by: Quigley
Date: March 2016
Discription: a modern version of the classic game "Simon"
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Says
{
    public partial class Form1 : Form
    {
        #region Public Variables and Lists
        //a list called pattern is made which is used to store the pattern in and is
        //created publicly to be accessed on other forms
        public static List<int> pattern = new List<int>();

        //a variable called score is made to keep track of the players score in the 
        //game and is made publicly to be accessed on other forms
        public static int score;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //After the form (which suits as a background) opens, the main screen opens
            //and is centred in the middle of the screen 
            MainScreen ms = new MainScreen();
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
            ms.BringToFront();
        }
    }
}
