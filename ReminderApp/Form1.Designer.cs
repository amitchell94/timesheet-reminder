﻿namespace ReminderApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.timesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.reminderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minimiseCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(313, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 33);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Timesheet Reminder";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 255);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add Time";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timesListBox
            // 
            this.timesListBox.FormattingEnabled = true;
            this.timesListBox.ItemHeight = 16;
            this.timesListBox.Location = new System.Drawing.Point(8, 91);
            this.timesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timesListBox.Name = "timesListBox";
            this.timesListBox.Size = new System.Drawing.Size(260, 132);
            this.timesListBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reminder times";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(8, 290);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 17);
            this.errorText.TabIndex = 14;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(8, 39);
            this.filePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(260, 22);
            this.filePath.TabIndex = 15;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(269, 36);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(77, 27);
            this.browseButton.TabIndex = 16;
            this.browseButton.Text = "Browse..";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // reminderTimePicker
            // 
            this.reminderTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderTimePicker.Location = new System.Drawing.Point(8, 255);
            this.reminderTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reminderTimePicker.Name = "reminderTimePicker";
            this.reminderTimePicker.Size = new System.Drawing.Size(159, 26);
            this.reminderTimePicker.TabIndex = 17;
            // 
            // minimiseCheckbox
            // 
            this.minimiseCheckbox.AutoSize = true;
            this.minimiseCheckbox.Location = new System.Drawing.Point(8, 302);
            this.minimiseCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimiseCheckbox.Name = "minimiseCheckbox";
            this.minimiseCheckbox.Size = new System.Drawing.Size(170, 21);
            this.minimiseCheckbox.TabIndex = 18;
            this.minimiseCheckbox.Text = "Start miminised to tray";
            this.minimiseCheckbox.UseVisualStyleBackColor = true;
            this.minimiseCheckbox.CheckedChanged += new System.EventHandler(this.minimiseCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 337);
            this.Controls.Add(this.minimiseCheckbox);
            this.Controls.Add(this.reminderTimePicker);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timesListBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox timesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.DateTimePicker reminderTimePicker;
        private System.Windows.Forms.CheckBox minimiseCheckbox;
    }
}

