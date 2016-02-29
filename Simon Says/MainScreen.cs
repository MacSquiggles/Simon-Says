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
            InstructionsForm inf = new InstructionsForm();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            inf.Location = new Point((f.Width - inf.Width) / 2, (f.Height - inf.Height) / 2);
            f.Controls.Add(inf);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            f.Controls.Add(gs);
            gs.BringToFront();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
