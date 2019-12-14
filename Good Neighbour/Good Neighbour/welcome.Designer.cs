namespace Good_Neighbour
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.makeARequestButton = new System.Windows.Forms.Button();
            this.findAJobButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.janeDoePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.janeDoePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(49, 49);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(108, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, Jane!";
            // 
            // makeARequestButton
            // 
            this.makeARequestButton.Location = new System.Drawing.Point(40, 381);
            this.makeARequestButton.Name = "makeARequestButton";
            this.makeARequestButton.Size = new System.Drawing.Size(116, 47);
            this.makeARequestButton.TabIndex = 1;
            this.makeARequestButton.Text = "Make a Request";
            this.makeARequestButton.UseVisualStyleBackColor = true;
            this.makeARequestButton.Click += new System.EventHandler(this.makeARequestButton_Click);
            // 
            // findAJobButton
            // 
            this.findAJobButton.Location = new System.Drawing.Point(169, 380);
            this.findAJobButton.Name = "findAJobButton";
            this.findAJobButton.Size = new System.Drawing.Size(116, 47);
            this.findAJobButton.TabIndex = 2;
            this.findAJobButton.Text = "Find A Job";
            this.findAJobButton.UseVisualStyleBackColor = true;
            this.findAJobButton.Click += new System.EventHandler(this.findAJobButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(190, 470);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(94, 24);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // janeDoePictureBox
            // 
            this.janeDoePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("janeDoePictureBox.Image")));
            this.janeDoePictureBox.Location = new System.Drawing.Point(61, 91);
            this.janeDoePictureBox.Name = "janeDoePictureBox";
            this.janeDoePictureBox.Size = new System.Drawing.Size(200, 200);
            this.janeDoePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.janeDoePictureBox.TabIndex = 4;
            this.janeDoePictureBox.TabStop = false;
            this.janeDoePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 515);
            this.Controls.Add(this.janeDoePictureBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.findAJobButton);
            this.Controls.Add(this.makeARequestButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "welcome";
            this.Text = "welcome";
            ((System.ComponentModel.ISupportInitialize)(this.janeDoePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button makeARequestButton;
        private System.Windows.Forms.Button findAJobButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox janeDoePictureBox;
    }
}