namespace Simon_Says
{
    partial class loadingScreen
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
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Pristina", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(202, 215);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(208, 58);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "Loading . . .";
            // 
            // loadingBar
            // 
            this.loadingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loadingBar.Location = new System.Drawing.Point(28, 302);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(534, 53);
            this.loadingBar.TabIndex = 1;
            // 
            // loadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simon_Says.Properties.Resources.whitebackground;
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.loadingLabel);
            this.Name = "loadingScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.loadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.ProgressBar loadingBar;
    }
}
