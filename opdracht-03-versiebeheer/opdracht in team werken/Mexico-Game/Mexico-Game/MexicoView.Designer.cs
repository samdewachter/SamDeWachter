namespace Mexico
{
    partial class MexicoView
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
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.werpAlleTeerlingenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // werpAlleTeerlingenButton
            // 
            this.werpAlleTeerlingenButton.AutoSize = true;
            this.werpAlleTeerlingenButton.Location = new System.Drawing.Point(24, 13);
            this.werpAlleTeerlingenButton.Name = "werpAlleTeerlingenButton";
            this.werpAlleTeerlingenButton.Size = new System.Drawing.Size(97, 23);
            this.werpAlleTeerlingenButton.TabIndex = 0;
            this.werpAlleTeerlingenButton.Text = "Smijt ze allemaal!";
            this.werpAlleTeerlingenButton.UseVisualStyleBackColor = true;
            this.werpAlleTeerlingenButton.Click += new System.EventHandler(this.smijtAlleTeerlingenButton_click);
            // 
            // MexicoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Mexico_Game.Properties.Resources.red_background;
            this.Controls.Add(this.werpAlleTeerlingenButton);
            this.Name = "MexicoView";
            this.Size = new System.Drawing.Size(297, 360);
            this.Load += new System.EventHandler(this.MexicoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button werpAlleTeerlingenButton;
    }
}
