namespace FLG_RP_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.LaunchGame = new System.Windows.Forms.Button();
            this.LaunchWebsite = new System.Windows.Forms.Button();
            this.LaunchCad = new System.Windows.Forms.Button();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LaunchGame
            // 
            this.LaunchGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LaunchGame.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LaunchGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaunchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchGame.ForeColor = System.Drawing.Color.White;
            this.LaunchGame.Location = new System.Drawing.Point(280, 360);
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.Size = new System.Drawing.Size(140, 40);
            this.LaunchGame.TabIndex = 1;
            this.LaunchGame.Text = "Play FLG-RP";
            this.LaunchGame.UseVisualStyleBackColor = false;
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // LaunchWebsite
            // 
            this.LaunchWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LaunchWebsite.BackColor = System.Drawing.SystemColors.Highlight;
            this.LaunchWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaunchWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchWebsite.ForeColor = System.Drawing.Color.White;
            this.LaunchWebsite.Location = new System.Drawing.Point(20, 360);
            this.LaunchWebsite.Name = "LaunchWebsite";
            this.LaunchWebsite.Size = new System.Drawing.Size(140, 40);
            this.LaunchWebsite.TabIndex = 2;
            this.LaunchWebsite.Text = "View Website";
            this.LaunchWebsite.UseVisualStyleBackColor = false;
            this.LaunchWebsite.Click += new System.EventHandler(this.LaunchWebsite_Click);
            // 
            // LaunchCad
            // 
            this.LaunchCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchCad.BackColor = System.Drawing.Color.Firebrick;
            this.LaunchCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaunchCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchCad.ForeColor = System.Drawing.Color.White;
            this.LaunchCad.Location = new System.Drawing.Point(542, 360);
            this.LaunchCad.Name = "LaunchCad";
            this.LaunchCad.Size = new System.Drawing.Size(140, 40);
            this.LaunchCad.TabIndex = 3;
            this.LaunchCad.Text = "CAD/MDT";
            this.LaunchCad.UseVisualStyleBackColor = false;
            this.LaunchCad.Click += new System.EventHandler(this.LaunchCad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.LaunchCad);
            this.Controls.Add(this.LaunchWebsite);
            this.Controls.Add(this.LaunchGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "FLG-RP Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button LaunchGame;
        private System.Windows.Forms.Button LaunchWebsite;
        private System.Windows.Forms.Button LaunchCad;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

