namespace ReminderApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timesheetRadioButton = new System.Windows.Forms.RadioButton();
            this.noteRadioButton = new System.Windows.Forms.RadioButton();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.projectLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.recentListBox = new System.Windows.Forms.ListBox();
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.technologyComboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // projectComboBox
            // 
            this.projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(11, 141);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(370, 21);
            this.projectComboBox.TabIndex = 2;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // codeComboBox
            // 
            this.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(11, 181);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(370, 21);
            this.codeComboBox.TabIndex = 3;
            this.codeComboBox.SelectedIndexChanged += new System.EventHandler(this.codeComboBox_SelectedIndexChanged);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(11, 263);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(370, 20);
            this.descTextBox.TabIndex = 4;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(138, 296);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(105, 20);
            this.hoursTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timesheetRadioButton
            // 
            this.timesheetRadioButton.AutoSize = true;
            this.timesheetRadioButton.Checked = true;
            this.timesheetRadioButton.Location = new System.Drawing.Point(232, 23);
            this.timesheetRadioButton.Name = "timesheetRadioButton";
            this.timesheetRadioButton.Size = new System.Drawing.Size(110, 17);
            this.timesheetRadioButton.TabIndex = 7;
            this.timesheetRadioButton.TabStop = true;
            this.timesheetRadioButton.Text = "Book to timesheet";
            this.timesheetRadioButton.UseVisualStyleBackColor = true;
            this.timesheetRadioButton.CheckedChanged += new System.EventHandler(this.timesheetRadioButton_CheckedChanged);
            // 
            // noteRadioButton
            // 
            this.noteRadioButton.AutoSize = true;
            this.noteRadioButton.Location = new System.Drawing.Point(93, 23);
            this.noteRadioButton.Name = "noteRadioButton";
            this.noteRadioButton.Size = new System.Drawing.Size(77, 17);
            this.noteRadioButton.TabIndex = 8;
            this.noteRadioButton.Text = "Add a note";
            this.noteRadioButton.UseVisualStyleBackColor = true;
            this.noteRadioButton.CheckedChanged += new System.EventHandler(this.noteRadioButton_CheckedChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(13, 69);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(368, 20);
            this.noteTextBox.TabIndex = 9;
            this.noteTextBox.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(11, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(28, 35);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(8, 125);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(40, 13);
            this.projectLabel.TabIndex = 10;
            this.projectLabel.Text = "Project";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(8, 165);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 11;
            this.codeLabel.Text = "Code";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 246);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(249, 299);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(33, 13);
            this.hoursLabel.TabIndex = 13;
            this.hoursLabel.Text = "hours";
            // 
            // recentListBox
            // 
            this.recentListBox.FormattingEnabled = true;
            this.recentListBox.Location = new System.Drawing.Point(11, 67);
            this.recentListBox.Margin = new System.Windows.Forms.Padding(2);
            this.recentListBox.Name = "recentListBox";
            this.recentListBox.Size = new System.Drawing.Size(370, 56);
            this.recentListBox.TabIndex = 14;
            this.recentListBox.SelectedIndexChanged += new System.EventHandler(this.recentListBox_SelectedIndexChanged);
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.AutoSize = true;
            this.bookingsLabel.Location = new System.Drawing.Point(8, 53);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(89, 13);
            this.bookingsLabel.TabIndex = 16;
            this.bookingsLabel.Text = "Recent Bookings";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Technology";
            // 
            // technologyComboBox
            // 
            this.technologyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technologyComboBox.FormattingEnabled = true;
            this.technologyComboBox.Location = new System.Drawing.Point(11, 222);
            this.technologyComboBox.Name = "technologyComboBox";
            this.technologyComboBox.Size = new System.Drawing.Size(370, 21);
            this.technologyComboBox.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.technologyComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bookingsLabel);
            this.Controls.Add(this.recentListBox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.noteRadioButton);
            this.Controls.Add(this.timesheetRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Timesheet Reminder";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton timesheetRadioButton;
        private System.Windows.Forms.RadioButton noteRadioButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.ListBox recentListBox;
        private System.Windows.Forms.Label bookingsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox technologyComboBox;
        private System.Windows.Forms.Timer timer1;
    }
}