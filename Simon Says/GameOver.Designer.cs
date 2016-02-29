namespace Simon_Says
{
    partial class GameOver
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overExitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overExitButton
            // 
            this.overExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.overExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overExitButton.ForeColor = System.Drawing.Color.White;
            this.overExitButton.Location = new System.Drawing.Point(540, 0);
            this.overExitButton.Name = "overExitButton";
            this.overExitButton.Size = new System.Drawing.Size(60, 50);
            this.overExitButton.TabIndex = 1;
            this.overExitButton.Text = "X";
            this.overExitButton.UseVisualStyleBackColor = false;
            this.overExitButton.Click += new System.EventHandler(this.overExitButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playAgainButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(54, 469);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(486, 71);
            this.playAgainButton.TabIndex = 4;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.overExitButton);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button overExitButton;
        private System.Windows.Forms.Button playAgainButton;
    }
}
