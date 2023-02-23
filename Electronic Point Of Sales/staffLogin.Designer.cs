namespace Electronic_Point_Of_Sales
{
    partial class mainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.panelBarTop = new System.Windows.Forms.Panel();
            this.dashLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.eposTitleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.dataDisplayTable = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.panelBarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplayTable)).BeginInit();
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
            this.panelBarTop.Size = new System.Drawing.Size(642, 83);
            this.panelBarTop.TabIndex = 0;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 205);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(230, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 205);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(449, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 205);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 205);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(230, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 205);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(449, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 205);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(12, 544);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 205);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(230, 544);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(205, 205);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(449, 544);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(205, 205);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button_click);
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 49F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.idTextBox.Location = new System.Drawing.Point(676, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(286, 81);
            this.idTextBox.TabIndex = 10;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(676, 108);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(134, 44);
            this.clearButton.TabIndex = 11;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(828, 108);
            this.enterButton.Margin = new System.Windows.Forms.Padding(0);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(134, 44);
            this.enterButton.TabIndex = 12;
            this.enterButton.TabStop = false;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // clockInButton
            // 
            this.clockInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clockInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clockInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clockInButton.ForeColor = System.Drawing.Color.White;
            this.clockInButton.Location = new System.Drawing.Point(676, 161);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(0);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(134, 44);
            this.clockInButton.TabIndex = 13;
            this.clockInButton.TabStop = false;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = false;
            this.clockInButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // clockOutButton
            // 
            this.clockOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clockOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.clockOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clockOutButton.ForeColor = System.Drawing.Color.White;
            this.clockOutButton.Location = new System.Drawing.Point(828, 161);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(134, 44);
            this.clockOutButton.TabIndex = 14;
            this.clockOutButton.TabStop = false;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = false;
            this.clockOutButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(676, 215);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(134, 44);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.logButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.logButton.ForeColor = System.Drawing.Color.White;
            this.logButton.Location = new System.Drawing.Point(828, 215);
            this.logButton.Margin = new System.Windows.Forms.Padding(0);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(134, 44);
            this.logButton.TabIndex = 16;
            this.logButton.TabStop = false;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // dataDisplayTable
            // 
            this.dataDisplayTable.AllowUserToAddRows = false;
            this.dataDisplayTable.AllowUserToDeleteRows = false;
            this.dataDisplayTable.AllowUserToResizeColumns = false;
            this.dataDisplayTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataDisplayTable.BackgroundColor = System.Drawing.Color.White;
            this.dataDisplayTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDisplayTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDisplayTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDisplayTable.EnableHeadersVisualStyles = false;
            this.dataDisplayTable.Location = new System.Drawing.Point(676, 326);
            this.dataDisplayTable.Name = "dataDisplayTable";
            this.dataDisplayTable.ReadOnly = true;
            this.dataDisplayTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataDisplayTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDisplayTable.RowTemplate.Height = 18;
            this.dataDisplayTable.RowTemplate.ReadOnly = true;
            this.dataDisplayTable.Size = new System.Drawing.Size(286, 423);
            this.dataDisplayTable.TabIndex = 24;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(828, 269);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 44);
            this.searchButton.TabIndex = 26;
            this.searchButton.TabStop = false;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(59)))), ((int)(((byte)(75)))));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(676, 269);
            this.returnButton.Margin = new System.Windows.Forms.Padding(0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(134, 44);
            this.returnButton.TabIndex = 25;
            this.returnButton.TabStop = false;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ProcessClick);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.dataDisplayTable);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.clockInButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelBarTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPOS - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelBarTop.ResumeLayout(false);
            this.panelBarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplayTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label eposTitleLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.DataGridView dataDisplayTable;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button returnButton;
    }
}