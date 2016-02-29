namespace Simon_Says
{
    partial class InstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.instructionsExitButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.playButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsExitButton
            // 
            this.instructionsExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.instructionsExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsExitButton.ForeColor = System.Drawing.Color.White;
            this.instructionsExitButton.Location = new System.Drawing.Point(540, 0);
            this.instructionsExitButton.Name = "instructionsExitButton";
            this.instructionsExitButton.Size = new System.Drawing.Size(60, 50);
            this.instructionsExitButton.TabIndex = 1;
            this.instructionsExitButton.Text = "X";
            this.instructionsExitButton.UseVisualStyleBackColor = false;
            this.instructionsExitButton.Click += new System.EventHandler(this.instructionsExitButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.White;
            this.instructionsLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(45, 67);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(506, 374);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // playButton2
            // 
            this.playButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playButton2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton2.Location = new System.Drawing.Point(54, 483);
            this.playButton2.Name = "playButton2";
            this.playButton2.Size = new System.Drawing.Size(486, 71);
            this.playButton2.TabIndex = 3;
            this.playButton2.Text = "Play Game";
            this.playButton2.UseVisualStyleBackColor = false;
            this.playButton2.Click += new System.EventHandler(this.playButton2_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simon_Says.Properties.Resources.white_background;
            this.Controls.Add(this.playButton2);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.instructionsExitButton);
            this.Name = "InstructionsForm";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instructionsExitButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button playButton2;
    }
}
