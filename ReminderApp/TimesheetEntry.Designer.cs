namespace ReminderApp
{
    partial class TimesheetEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesheetEntry));
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
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.technologyLabel = new System.Windows.Forms.Label();
            this.technologyComboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bookingsListView = new System.Windows.Forms.ListView();
            this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Technology = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookedHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // projectComboBox
            // 
            this.projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(15, 174);
            this.projectComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(707, 24);
            this.projectComboBox.TabIndex = 2;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // codeComboBox
            // 
            this.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(15, 223);
            this.codeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(707, 24);
            this.codeComboBox.TabIndex = 3;
            this.codeComboBox.SelectedIndexChanged += new System.EventHandler(this.codeComboBox_SelectedIndexChanged);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(15, 324);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(707, 22);
            this.descTextBox.TabIndex = 4;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(282, 364);
            this.hoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(139, 22);
            this.hoursTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okButton_Click);
            // 
            // timesheetRadioButton
            // 
            this.timesheetRadioButton.AutoSize = true;
            this.timesheetRadioButton.Checked = true;
            this.timesheetRadioButton.Location = new System.Drawing.Point(411, 17);
            this.timesheetRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.timesheetRadioButton.Name = "timesheetRadioButton";
            this.timesheetRadioButton.Size = new System.Drawing.Size(142, 21);
            this.timesheetRadioButton.TabIndex = 7;
            this.timesheetRadioButton.TabStop = true;
            this.timesheetRadioButton.Text = "Book to timesheet";
            this.timesheetRadioButton.UseVisualStyleBackColor = true;
            this.timesheetRadioButton.CheckedChanged += new System.EventHandler(this.timesheetRadioButton_CheckedChanged);
            // 
            // noteRadioButton
            // 
            this.noteRadioButton.AutoSize = true;
            this.noteRadioButton.Location = new System.Drawing.Point(226, 17);
            this.noteRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.noteRadioButton.Name = "noteRadioButton";
            this.noteRadioButton.Size = new System.Drawing.Size(98, 21);
            this.noteRadioButton.TabIndex = 8;
            this.noteRadioButton.Text = "Add a note";
            this.noteRadioButton.UseVisualStyleBackColor = true;
            this.noteRadioButton.CheckedChanged += new System.EventHandler(this.noteRadioButton_CheckedChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(17, 63);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(704, 322);
            this.noteTextBox.TabIndex = 9;
            this.noteTextBox.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 6);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(37, 43);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(11, 154);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(52, 17);
            this.projectLabel.TabIndex = 10;
            this.projectLabel.Text = "Project";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(11, 203);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(41, 17);
            this.codeLabel.TabIndex = 11;
            this.codeLabel.Text = "Code";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 303);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(430, 368);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(44, 17);
            this.hoursLabel.TabIndex = 13;
            this.hoursLabel.Text = "hours";
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.AutoSize = true;
            this.bookingsLabel.Location = new System.Drawing.Point(11, 42);
            this.bookingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(115, 17);
            this.bookingsLabel.TabIndex = 16;
            this.bookingsLabel.Text = "Recent Bookings";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(402, 396);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // technologyLabel
            // 
            this.technologyLabel.AutoSize = true;
            this.technologyLabel.Location = new System.Drawing.Point(11, 254);
            this.technologyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.technologyLabel.Name = "technologyLabel";
            this.technologyLabel.Size = new System.Drawing.Size(82, 17);
            this.technologyLabel.TabIndex = 19;
            this.technologyLabel.Text = "Technology";
            // 
            // technologyComboBox
            // 
            this.technologyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technologyComboBox.FormattingEnabled = true;
            this.technologyComboBox.Location = new System.Drawing.Point(15, 273);
            this.technologyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.technologyComboBox.Name = "technologyComboBox";
            this.technologyComboBox.Size = new System.Drawing.Size(707, 24);
            this.technologyComboBox.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bookingsListView
            // 
            this.bookingsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project,
            this.Code,
            this.Technology,
            this.Description,
            this.BookedHours});
            this.bookingsListView.FullRowSelect = true;
            this.bookingsListView.Location = new System.Drawing.Point(14, 62);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(708, 89);
            this.bookingsListView.TabIndex = 20;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.View = System.Windows.Forms.View.Details;
            this.bookingsListView.SelectedIndexChanged += new System.EventHandler(this.bookingsListView_SelectedIndexChanged);
            // 
            // Project
            // 
            this.Project.Text = "Project";
            this.Project.Width = 150;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // Technology
            // 
            this.Technology.Text = "Technology";
            this.Technology.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // BookedHours
            // 
            this.BookedHours.Text = "Hours";
            this.BookedHours.Width = 50;
            // 
            // TimesheetEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 433);
            this.Controls.Add(this.bookingsListView);
            this.Controls.Add(this.technologyLabel);
            this.Controls.Add(this.technologyComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bookingsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.noteRadioButton);
            this.Controls.Add(this.timesheetRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.noteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimesheetEntry";
            this.Text = "Timesheet Reminder";
            this.Load += new System.EventHandler(this.TimesheetEntry_Load);
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
        private System.Windows.Forms.Label bookingsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label technologyLabel;
        private System.Windows.Forms.ComboBox technologyComboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView bookingsListView;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Technology;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader BookedHours;
    }
}