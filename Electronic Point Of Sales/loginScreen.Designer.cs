namespace Electronic_Point_Of_Sales
{
    partial class loginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(433, 246);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(118, 46);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Location = new System.Drawing.Point(389, 306);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(198, 30);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Tag = "username";
            this.usernameTextBox.Text = "username";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(223)))), ((int)(((byte)(137)))));
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(223)))), ((int)(((byte)(137)))));
            this.signInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(223)))), ((int)(((byte)(137)))));
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(389, 389);
            this.signInButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(198, 30);
            this.signInButton.TabIndex = 0;
            this.signInButton.TabStop = false;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(389, 347);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(198, 30);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Tag = "password";
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPOS - Login Screen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

