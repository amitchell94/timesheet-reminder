namespace ReminderApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timesheetBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsThisWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.movementsNextWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.errorText = new System.Windows.Forms.Label();
            this.minimiseCheckbox = new System.Windows.Forms.CheckBox();
            this.bookNowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableTimesheetReminder = new System.Windows.Forms.CheckBox();
            this.timesheetSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillNextWeek = new System.Windows.Forms.Button();
            this.fillThisWeek = new System.Windows.Forms.Button();
            this.movementSettingsButton = new System.Windows.Forms.Button();
            this.enableMovements = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generateOvertimeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Timesheet Reminder is now minimised.";
            this.notifyIcon1.BalloonTipTitle = "Timesheet Reminder";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Timesheet Reminder";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesheetBooking,
            this.movementsThisWeek,
            this.movementsNextWeek,
            this.exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 92);
            // 
            // timesheetBooking
            // 
            this.timesheetBooking.Name = "timesheetBooking";
            this.timesheetBooking.Size = new System.Drawing.Size(215, 22);
            this.timesheetBooking.Text = "Book to timesheet";
            this.timesheetBooking.Click += new System.EventHandler(this.timesheetBooking_Click);
            // 
            // movementsThisWeek
            // 
            this.movementsThisWeek.Name = "movementsThisWeek";
            this.movementsThisWeek.Size = new System.Drawing.Size(215, 22);
            this.movementsThisWeek.Text = "Fill this weeks movements";
            this.movementsThisWeek.Click += new System.EventHandler(this.movementsThisWeek_Click);
            // 
            // movementsNextWeek
            // 
            this.movementsNextWeek.Name = "movementsNextWeek";
            this.movementsNextWeek.Size = new System.Drawing.Size(215, 22);
            this.movementsNextWeek.Text = "Fill next weeks movements";
            this.movementsNextWeek.Click += new System.EventHandler(this.movementsNextWeek_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(215, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(0, 208);
            this.errorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabIndex = 14;
            // 
            // minimiseCheckbox
            // 
            this.minimiseCheckbox.AutoSize = true;
            this.minimiseCheckbox.Location = new System.Drawing.Point(6, 340);
            this.minimiseCheckbox.Name = "minimiseCheckbox";
            this.minimiseCheckbox.Size = new System.Drawing.Size(128, 17);
            this.minimiseCheckbox.TabIndex = 18;
            this.minimiseCheckbox.Text = "Start miminised to tray";
            this.minimiseCheckbox.UseVisualStyleBackColor = true;
            this.minimiseCheckbox.CheckedChanged += new System.EventHandler(this.minimiseCheckbox_CheckedChanged);
            // 
            // bookNowButton
            // 
            this.bookNowButton.Location = new System.Drawing.Point(56, 29);
            this.bookNowButton.Margin = new System.Windows.Forms.Padding(2);
            this.bookNowButton.Name = "bookNowButton";
            this.bookNowButton.Size = new System.Drawing.Size(170, 23);
            this.bookNowButton.TabIndex = 19;
            this.bookNowButton.Text = "Book to timesheet";
            this.bookNowButton.UseVisualStyleBackColor = true;
            this.bookNowButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableTimesheetReminder);
            this.groupBox1.Controls.Add(this.timesheetSettingsButton);
            this.groupBox1.Controls.Add(this.bookNowButton);
            this.groupBox1.Controls.Add(this.errorText);
            this.groupBox1.Location = new System.Drawing.Point(8, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 95);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timesheet Reminders";
            // 
            // enableTimesheetReminder
            // 
            this.enableTimesheetReminder.AutoSize = true;
            this.enableTimesheetReminder.Location = new System.Drawing.Point(6, 72);
            this.enableTimesheetReminder.Name = "enableTimesheetReminder";
            this.enableTimesheetReminder.Size = new System.Drawing.Size(145, 17);
            this.enableTimesheetReminder.TabIndex = 4;
            this.enableTimesheetReminder.Text = "Use Timesheet Reminder";
            this.enableTimesheetReminder.UseVisualStyleBackColor = true;
            this.enableTimesheetReminder.CheckedChanged += new System.EventHandler(this.enableTimesheetReminder_CheckedChanged);
            // 
            // timesheetSettingsButton
            // 
            this.timesheetSettingsButton.Location = new System.Drawing.Point(192, 67);
            this.timesheetSettingsButton.Name = "timesheetSettingsButton";
            this.timesheetSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.timesheetSettingsButton.TabIndex = 4;
            this.timesheetSettingsButton.Text = "Settings...";
            this.timesheetSettingsButton.UseVisualStyleBackColor = true;
            this.timesheetSettingsButton.Click += new System.EventHandler(this.timesheetSettingsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fillNextWeek);
            this.groupBox2.Controls.Add(this.fillThisWeek);
            this.groupBox2.Controls.Add(this.movementSettingsButton);
            this.groupBox2.Controls.Add(this.enableMovements);
            this.groupBox2.Location = new System.Drawing.Point(9, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movements Reminder";
            // 
            // fillNextWeek
            // 
            this.fillNextWeek.Location = new System.Drawing.Point(56, 54);
            this.fillNextWeek.Margin = new System.Windows.Forms.Padding(2);
            this.fillNextWeek.Name = "fillNextWeek";
            this.fillNextWeek.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fillNextWeek.Size = new System.Drawing.Size(170, 23);
            this.fillNextWeek.TabIndex = 21;
            this.fillNextWeek.Text = "Fill next weeks movements";
            this.fillNextWeek.UseVisualStyleBackColor = true;
            this.fillNextWeek.Click += new System.EventHandler(this.fillNextWeek_Click);
            // 
            // fillThisWeek
            // 
            this.fillThisWeek.Location = new System.Drawing.Point(56, 26);
            this.fillThisWeek.Margin = new System.Windows.Forms.Padding(2);
            this.fillThisWeek.Name = "fillThisWeek";
            this.fillThisWeek.Size = new System.Drawing.Size(170, 23);
            this.fillThisWeek.TabIndex = 20;
            this.fillThisWeek.Text = "Fill this weeks movements";
            this.fillThisWeek.UseVisualStyleBackColor = true;
            this.fillThisWeek.Click += new System.EventHandler(this.fillThisWeek_Click);
            // 
            // movementSettingsButton
            // 
            this.movementSettingsButton.Location = new System.Drawing.Point(191, 84);
            this.movementSettingsButton.Name = "movementSettingsButton";
            this.movementSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.movementSettingsButton.TabIndex = 3;
            this.movementSettingsButton.Text = "Settings...";
            this.movementSettingsButton.UseVisualStyleBackColor = true;
            this.movementSettingsButton.Click += new System.EventHandler(this.movementSettingsButton_Click);
            // 
            // enableMovements
            // 
            this.enableMovements.AutoSize = true;
            this.enableMovements.Location = new System.Drawing.Point(5, 89);
            this.enableMovements.Name = "enableMovements";
            this.enableMovements.Size = new System.Drawing.Size(151, 17);
            this.enableMovements.TabIndex = 0;
            this.enableMovements.Text = "Use Movements Reminder";
            this.enableMovements.UseVisualStyleBackColor = true;
            this.enableMovements.CheckedChanged += new System.EventHandler(this.enableMovements_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generateOvertimeButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(8, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 79);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overtime Form Generator";
            // 
            // generateOvertimeButton
            // 
            this.generateOvertimeButton.Location = new System.Drawing.Point(56, 33);
            this.generateOvertimeButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateOvertimeButton.Name = "generateOvertimeButton";
            this.generateOvertimeButton.Size = new System.Drawing.Size(170, 23);
            this.generateOvertimeButton.TabIndex = 19;
            this.generateOvertimeButton.Text = "Generate overtime form";
            this.generateOvertimeButton.UseVisualStyleBackColor = true;
            this.generateOvertimeButton.Click += new System.EventHandler(this.generateOvertimeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(195, 9);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(86, 16);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 369);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimiseCheckbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cougar Reminders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.CheckBox minimiseCheckbox;
        private System.Windows.Forms.Button bookNowButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox enableMovements;
        private System.Windows.Forms.Button movementSettingsButton;
        private System.Windows.Forms.Button timesheetSettingsButton;
        private System.Windows.Forms.CheckBox enableTimesheetReminder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button generateOvertimeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fillNextWeek;
        private System.Windows.Forms.Button fillThisWeek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timesheetBooking;
        private System.Windows.Forms.ToolStripMenuItem movementsThisWeek;
        private System.Windows.Forms.ToolStripMenuItem movementsNextWeek;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

