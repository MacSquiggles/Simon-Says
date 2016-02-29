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
    public partial class InstructionsForm : UserControl
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void playButton2_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            f.Controls.Add(gs);
            gs.BringToFront();
        }

        private void instructionsExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
