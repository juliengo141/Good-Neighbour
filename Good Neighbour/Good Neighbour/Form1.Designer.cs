namespace Good_Neighbour
{
    partial class GoodNeighbourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodNeighbourForm));
            this.GoodNeigbourLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoodNeigbourLabel
            // 
            this.GoodNeigbourLabel.AutoSize = true;
            this.GoodNeigbourLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodNeigbourLabel.Location = new System.Drawing.Point(72, 104);
            this.GoodNeigbourLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.GoodNeigbourLabel.Name = "GoodNeigbourLabel";
            this.GoodNeigbourLabel.Size = new System.Drawing.Size(141, 17);
            this.GoodNeigbourLabel.TabIndex = 0;
            this.GoodNeigbourLabel.Text = "Good Neigbour";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(70, 142);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(138, 23);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(71, 177);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(143, 24);
            this.CreateAccountButton.TabIndex = 2;
            this.CreateAccountButton.Text = "Create an Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // GoodNeighbourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 515);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.GoodNeigbourLabel);
            this.Name = "GoodNeighbourForm";
            this.Text = "Good Neighbour";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoodNeigbourLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button CreateAccountButton;
    }
}

