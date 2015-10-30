namespace Mexico
{
    partial class GameView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRegel1 = new System.Windows.Forms.Label();
            this.lblRegel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(197, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRegel1
            // 
            this.lblRegel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegel1.Location = new System.Drawing.Point(16, 284);
            this.lblRegel1.Name = "lblRegel1";
            this.lblRegel1.Size = new System.Drawing.Size(233, 19);
            this.lblRegel1.TabIndex = 1;
            this.lblRegel1.Text = "2 + 1 = iedereen adje";
            this.lblRegel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegel2
            // 
            this.lblRegel2.BackColor = System.Drawing.Color.White;
            this.lblRegel2.Location = new System.Drawing.Point(16, 337);
            this.lblRegel2.Name = "lblRegel2";
            this.lblRegel2.Size = new System.Drawing.Size(256, 18);
            this.lblRegel2.TabIndex = 2;
            this.lblRegel2.Text = "3 + 1 = iedereen half adje";
            this.lblRegel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Mexico_Game.Properties.Resources.red_background;
            this.ClientSize = new System.Drawing.Size(284, 373);
            this.Controls.Add(this.lblRegel2);
            this.Controls.Add(this.lblRegel1);
            this.Controls.Add(this.btnReset);
            this.Name = "GameView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRegel1;
        private System.Windows.Forms.Label lblRegel2;
    }
}

