namespace Electronic_Point_Of_Sales
{
    partial class settingsScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsScreen));
            this.panelBarTop = new System.Windows.Forms.Panel();
            this.dashLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.eposTitleLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.permissionsTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showNextForm = new System.Windows.Forms.Button();
            this.previousScreen = new System.Windows.Forms.Button();
            this.systemManagementLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userLookUpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editStaffButton = new System.Windows.Forms.Button();
            this.userLookUpFirstName = new System.Windows.Forms.TextBox();
            this.userLookUpLastName = new System.Windows.Forms.TextBox();
            this.userLookUpClockType = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.asterixLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userLookUpPermissions = new System.Windows.Forms.TextBox();
            this.panelBarTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarTop
            // 
            this.panelBarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.panelBarTop.Controls.Add(this.dashLabel);
            this.panelBarTop.Controls.Add(this.dateLabel);
            this.panelBarTop.Controls.Add(this.timeLabel);
            this.panelBarTop.Controls.Add(this.eposTitleLabel);
            this.panelBarTop.Location = new System.Drawing.Point(12, 12);
            this.panelBarTop.Name = "panelBarTop";
            this.panelBarTop.Size = new System.Drawing.Size(960, 83);
            this.panelBarTop.TabIndex = 1;
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dashLabel.Location = new System.Drawing.Point(299, 15);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(19, 25);
            this.dashLabel.TabIndex = 3;
            this.dashLabel.Text = "-";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateLabel.Location = new System.Drawing.Point(314, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "01/01/01";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.timeLabel.Location = new System.Drawing.Point(241, 18);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(62, 25);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            // 
            // eposTitleLabel
            // 
            this.eposTitleLabel.AutoSize = true;
            this.eposTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.eposTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eposTitleLabel.ForeColor = System.Drawing.Color.White;
            this.eposTitleLabel.Location = new System.Drawing.Point(58, 9);
            this.eposTitleLabel.Name = "eposTitleLabel";
            this.eposTitleLabel.Size = new System.Drawing.Size(177, 63);
            this.eposTitleLabel.TabIndex = 0;
            this.eposTitleLabel.Text = "EPOS";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_tick);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(156, 313);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(134, 44);
            this.registerButton.TabIndex = 6;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Location = new System.Drawing.Point(12, 171);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(278, 30);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Tag = "username";
            this.usernameTextBox.Text = "username";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 206);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(278, 30);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Tag = "password";
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(12, 100);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(277, 31);
            this.accountLabel.TabIndex = 4;
            this.accountLabel.Text = "Account Management";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.lastnameTextBox.Location = new System.Drawing.Point(12, 241);
            this.lastnameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(278, 30);
            this.lastnameTextBox.TabIndex = 3;
            this.lastnameTextBox.Tag = "last name";
            this.lastnameTextBox.Text = "last name";
            this.lastnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // permissionsTextBox
            // 
            this.permissionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionsTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.permissionsTextBox.Location = new System.Drawing.Point(12, 276);
            this.permissionsTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.permissionsTextBox.MaxLength = 1;
            this.permissionsTextBox.Name = "permissionsTextBox";
            this.permissionsTextBox.Size = new System.Drawing.Size(278, 30);
            this.permissionsTextBox.TabIndex = 4;
            this.permissionsTextBox.Tag = "permissions";
            this.permissionsTextBox.Text = "permissions";
            this.permissionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.permissionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.idTextBox.Location = new System.Drawing.Point(12, 136);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idTextBox.MaxLength = 2;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(278, 30);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.Tag = "id";
            this.idTextBox.Text = "id";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(12, 313);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 44);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // showNextForm
            // 
            this.showNextForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.showNextForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.showNextForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.showNextForm.ForeColor = System.Drawing.Color.White;
            this.showNextForm.Location = new System.Drawing.Point(12, 419);
            this.showNextForm.Margin = new System.Windows.Forms.Padding(0);
            this.showNextForm.Name = "showNextForm";
            this.showNextForm.Size = new System.Drawing.Size(277, 44);
            this.showNextForm.TabIndex = 7;
            this.showNextForm.TabStop = false;
            this.showNextForm.Text = "Show Admin Form";
            this.showNextForm.UseVisualStyleBackColor = false;
            this.showNextForm.Click += new System.EventHandler(this.ProcessClick);
            // 
            // previousScreen
            // 
            this.previousScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.previousScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.previousScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.previousScreen.ForeColor = System.Drawing.Color.White;
            this.previousScreen.Location = new System.Drawing.Point(18, 703);
            this.previousScreen.Margin = new System.Windows.Forms.Padding(0);
            this.previousScreen.Name = "previousScreen";
            this.previousScreen.Size = new System.Drawing.Size(954, 44);
            this.previousScreen.TabIndex = 8;
            this.previousScreen.TabStop = false;
            this.previousScreen.Text = "Return To Previous Form";
            this.previousScreen.UseVisualStyleBackColor = false;
            this.previousScreen.Click += new System.EventHandler(this.ProcessClick);
            // 
            // systemManagementLabel
            // 
            this.systemManagementLabel.AutoSize = true;
            this.systemManagementLabel.BackColor = System.Drawing.Color.Transparent;
            this.systemManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemManagementLabel.ForeColor = System.Drawing.Color.White;
            this.systemManagementLabel.Location = new System.Drawing.Point(13, 506);
            this.systemManagementLabel.Name = "systemManagementLabel";
            this.systemManagementLabel.Size = new System.Drawing.Size(269, 31);
            this.systemManagementLabel.TabIndex = 9;
            this.systemManagementLabel.Text = "System Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 44);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "System Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ProcessClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 600);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 44);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "Clockout All Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ProcessClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Lookup";
            // 
            // userLookUpID
            // 
            this.userLookUpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLookUpID.ForeColor = System.Drawing.Color.DarkGray;
            this.userLookUpID.Location = new System.Drawing.Point(427, 136);
            this.userLookUpID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userLookUpID.MaxLength = 2;
            this.userLookUpID.Name = "userLookUpID";
            this.userLookUpID.Size = new System.Drawing.Size(276, 30);
            this.userLookUpID.TabIndex = 13;
            this.userLookUpID.Tag = "id";
            this.userLookUpID.Text = "id";
            this.userLookUpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(710, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(710, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(708, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Second Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(710, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Clock Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(710, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Permissions";
            // 
            // editStaffButton
            // 
            this.editStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.editStaffButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.editStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.editStaffButton.ForeColor = System.Drawing.Color.White;
            this.editStaffButton.Location = new System.Drawing.Point(12, 366);
            this.editStaffButton.Margin = new System.Windows.Forms.Padding(0);
            this.editStaffButton.Name = "editStaffButton";
            this.editStaffButton.Size = new System.Drawing.Size(277, 44);
            this.editStaffButton.TabIndex = 20;
            this.editStaffButton.TabStop = false;
            this.editStaffButton.Text = "Edit Staff Account";
            this.editStaffButton.UseVisualStyleBackColor = false;
            this.editStaffButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // userLookUpFirstName
            // 
            this.userLookUpFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.userLookUpFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLookUpFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.userLookUpFirstName.Location = new System.Drawing.Point(427, 171);
            this.userLookUpFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userLookUpFirstName.Name = "userLookUpFirstName";
            this.userLookUpFirstName.ReadOnly = true;
            this.userLookUpFirstName.Size = new System.Drawing.Size(276, 30);
            this.userLookUpFirstName.TabIndex = 26;
            this.userLookUpFirstName.Tag = "username";
            this.userLookUpFirstName.Text = "username";
            this.userLookUpFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userLookUpLastName
            // 
            this.userLookUpLastName.BackColor = System.Drawing.SystemColors.Window;
            this.userLookUpLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLookUpLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.userLookUpLastName.Location = new System.Drawing.Point(427, 206);
            this.userLookUpLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userLookUpLastName.Name = "userLookUpLastName";
            this.userLookUpLastName.ReadOnly = true;
            this.userLookUpLastName.Size = new System.Drawing.Size(276, 30);
            this.userLookUpLastName.TabIndex = 28;
            this.userLookUpLastName.Tag = "last name";
            this.userLookUpLastName.Text = "last name";
            this.userLookUpLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userLookUpClockType
            // 
            this.userLookUpClockType.BackColor = System.Drawing.SystemColors.Window;
            this.userLookUpClockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLookUpClockType.ForeColor = System.Drawing.Color.DarkGray;
            this.userLookUpClockType.Location = new System.Drawing.Point(427, 241);
            this.userLookUpClockType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userLookUpClockType.MaxLength = 1;
            this.userLookUpClockType.Name = "userLookUpClockType";
            this.userLookUpClockType.ReadOnly = true;
            this.userLookUpClockType.Size = new System.Drawing.Size(277, 30);
            this.userLookUpClockType.TabIndex = 29;
            this.userLookUpClockType.Tag = "clock type";
            this.userLookUpClockType.Text = "clock type";
            this.userLookUpClockType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(427, 312);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 44);
            this.button3.TabIndex = 30;
            this.button3.TabStop = false;
            this.button3.Text = "Lookup Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ProcessClick);
            // 
            // asterixLabel
            // 
            this.asterixLabel.AutoSize = true;
            this.asterixLabel.BackColor = System.Drawing.Color.Transparent;
            this.asterixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterixLabel.ForeColor = System.Drawing.Color.White;
            this.asterixLabel.Location = new System.Drawing.Point(809, 133);
            this.asterixLabel.Name = "asterixLabel";
            this.asterixLabel.Size = new System.Drawing.Size(25, 31);
            this.asterixLabel.TabIndex = 31;
            this.asterixLabel.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(290, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "*";
            // 
            // userLookUpPermissions
            // 
            this.userLookUpPermissions.BackColor = System.Drawing.SystemColors.Window;
            this.userLookUpPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userLookUpPermissions.ForeColor = System.Drawing.Color.DarkGray;
            this.userLookUpPermissions.Location = new System.Drawing.Point(427, 276);
            this.userLookUpPermissions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.userLookUpPermissions.MaxLength = 1;
            this.userLookUpPermissions.Name = "userLookUpPermissions";
            this.userLookUpPermissions.ReadOnly = true;
            this.userLookUpPermissions.Size = new System.Drawing.Size(277, 30);
            this.userLookUpPermissions.TabIndex = 33;
            this.userLookUpPermissions.Tag = "permissions";
            this.userLookUpPermissions.Text = "permissions";
            this.userLookUpPermissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.userLookUpPermissions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.asterixLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.userLookUpClockType);
            this.Controls.Add(this.userLookUpLastName);
            this.Controls.Add(this.userLookUpFirstName);
            this.Controls.Add(this.editStaffButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLookUpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.systemManagementLabel);
            this.Controls.Add(this.previousScreen);
            this.Controls.Add(this.showNextForm);
            this.Controls.Add(this.permissionsTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.panelBarTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingsScreen";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            this.panelBarTop.ResumeLayout(false);
            this.panelBarTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarTop;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label eposTitleLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox permissionsTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showNextForm;
        private System.Windows.Forms.Button previousScreen;
        private System.Windows.Forms.Label systemManagementLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userLookUpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editStaffButton;
        private System.Windows.Forms.TextBox userLookUpFirstName;
        private System.Windows.Forms.TextBox userLookUpLastName;
        private System.Windows.Forms.TextBox userLookUpClockType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label asterixLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userLookUpPermissions;
    }
}