namespace Simon_Says
{
    partial class GameScreen
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
            this.gameExitButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.simonTitle = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameExitButton
            // 
            this.gameExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameExitButton.ForeColor = System.Drawing.Color.White;
            this.gameExitButton.Location = new System.Drawing.Point(540, 3);
            this.gameExitButton.Name = "gameExitButton";
            this.gameExitButton.Size = new System.Drawing.Size(60, 50);
            this.gameExitButton.TabIndex = 1;
            this.gameExitButton.Text = "X";
            this.gameExitButton.UseVisualStyleBackColor = false;
            this.gameExitButton.Click += new System.EventHandler(this.gameExitButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yellowButton.Location = new System.Drawing.Point(48, 142);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(235, 148);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Aqua;
            this.blueButton.Location = new System.Drawing.Point(302, 142);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(235, 148);
            this.blueButton.TabIndex = 3;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Chartreuse;
            this.greenButton.Location = new System.Drawing.Point(48, 296);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(235, 148);
            this.greenButton.TabIndex = 4;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.HotPink;
            this.pinkButton.Location = new System.Drawing.Point(302, 296);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(235, 148);
            this.pinkButton.TabIndex = 5;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // simonTitle
            // 
            this.simonTitle.AutoSize = true;
            this.simonTitle.BackColor = System.Drawing.Color.Transparent;
            this.simonTitle.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simonTitle.Location = new System.Drawing.Point(205, 44);
            this.simonTitle.Name = "simonTitle";
            this.simonTitle.Size = new System.Drawing.Size(198, 95);
            this.simonTitle.TabIndex = 6;
            this.simonTitle.Text = "Simon";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(173, 477);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(110, 52);
            this.pointsLabel.TabIndex = 7;
            this.pointsLabel.Text = "Points:";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Simon_Says.Properties.Resources.white_background;
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.simonTitle);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.gameExitButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameExitButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Label simonTitle;
        private System.Windows.Forms.Label pointsLabel;
    }
}
