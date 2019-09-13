namespace ReminderApp
{
    partial class TimesheetSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timesListBox = new System.Windows.Forms.ListBox();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reminderTimePicker);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.errorText);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timesListBox);
            this.groupBox1.Controls.Add(this.addTimeButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 202);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timesheet Reminders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Notes folder location";
            // 
            // reminderTimePicker
            // 
            this.reminderTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderTimePicker.Location = new System.Drawing.Point(7, 171);
            this.reminderTimePicker.Name = "reminderTimePicker";
            this.reminderTimePicker.Size = new System.Drawing.Size(120, 22);
            this.reminderTimePicker.TabIndex = 17;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(203, 35);
            this.browseButton.Margin = new System.Windows.Forms.Padding(2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(58, 22);
            this.browseButton.TabIndex = 16;
            this.browseButton.Text = "Browse..";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(7, 38);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(196, 20);
            this.filePath.TabIndex = 15;
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
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(203, 80);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(62, 25);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reminder times";
            // 
            // timesListBox
            // 
            this.timesListBox.FormattingEnabled = true;
            this.timesListBox.Location = new System.Drawing.Point(7, 80);
            this.timesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.timesListBox.Name = "timesListBox";
            this.timesListBox.Size = new System.Drawing.Size(196, 69);
            this.timesListBox.Sorted = true;
            this.timesListBox.TabIndex = 11;
            // 
            // addTimeButton
            // 
            this.addTimeButton.Location = new System.Drawing.Point(135, 171);
            this.addTimeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(82, 22);
            this.addTimeButton.TabIndex = 10;
            this.addTimeButton.Text = "Add Time";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // TimesheetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimesheetSettings";
            this.Text = "TimesheetSettings";
            this.Load += new System.EventHandler(this.TimesheetSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker reminderTimePicker;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox timesListBox;
        private System.Windows.Forms.Button addTimeButton;
        private System.Windows.Forms.Label label2;
    }
}