namespace Simon_Says
{
    partial class MainScreen
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
            this.mainExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainExitButton
            // 
            this.mainExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainExitButton.ForeColor = System.Drawing.Color.White;
            this.mainExitButton.Location = new System.Drawing.Point(540, 0);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(60, 50);
            this.mainExitButton.TabIndex = 0;
            this.mainExitButton.Text = "X";
            this.mainExitButton.UseVisualStyleBackColor = false;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 126);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simon";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(55, 303);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(471, 71);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.instructionsButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.Location = new System.Drawing.Point(55, 401);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(471, 71);
            this.instructionsButton.TabIndex = 3;
            this.instructionsButton.Text = "Instructions";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simon_Says.Properties.Resources.white_background;
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainExitButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button instructionsButton;
    }
}
