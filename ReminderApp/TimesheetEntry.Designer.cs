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
            this.label1 = new System.Windows.Forms.Label();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.Overtime1radioButton = new System.Windows.Forms.RadioButton();
            this.overtime15radioButton = new System.Windows.Forms.RadioButton();
            this.overtimer2radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.regionRadioButton = new System.Windows.Forms.RadioButton();
            this.teamRadioButton = new System.Windows.Forms.RadioButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectComboBox
            // 
            this.projectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(11, 215);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(531, 21);
            this.projectComboBox.TabIndex = 2;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // codeComboBox
            // 
            this.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(11, 254);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(531, 21);
            this.codeComboBox.TabIndex = 3;
            this.codeComboBox.SelectedIndexChanged += new System.EventHandler(this.codeComboBox_SelectedIndexChanged);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(11, 336);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(531, 20);
            this.descTextBox.TabIndex = 4;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(212, 413);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(105, 20);
            this.hoursTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.okButton_Click);
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
            this.projectLabel.Location = new System.Drawing.Point(8, 198);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(40, 13);
            this.projectLabel.TabIndex = 10;
            this.projectLabel.Text = "Project";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(8, 238);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 11;
            this.codeLabel.Text = "Code";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 319);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(322, 416);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(33, 13);
            this.hoursLabel.TabIndex = 13;
            this.hoursLabel.Text = "hours";
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.AutoSize = true;
            this.bookingsLabel.Location = new System.Drawing.Point(8, 11);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(89, 13);
            this.bookingsLabel.TabIndex = 16;
            this.bookingsLabel.Text = "Recent Bookings";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(302, 484);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // technologyLabel
            // 
            this.technologyLabel.AutoSize = true;
            this.technologyLabel.Location = new System.Drawing.Point(8, 280);
            this.technologyLabel.Name = "technologyLabel";
            this.technologyLabel.Size = new System.Drawing.Size(63, 13);
            this.technologyLabel.TabIndex = 19;
            this.technologyLabel.Text = "Technology";
            // 
            // technologyComboBox
            // 
            this.technologyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technologyComboBox.FormattingEnabled = true;
            this.technologyComboBox.Location = new System.Drawing.Point(11, 295);
            this.technologyComboBox.Name = "technologyComboBox";
            this.technologyComboBox.Size = new System.Drawing.Size(531, 21);
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
            this.bookingsListView.HideSelection = false;
            this.bookingsListView.Location = new System.Drawing.Point(10, 28);
            this.bookingsListView.Margin = new System.Windows.Forms.Padding(2);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(532, 147);
            this.bookingsListView.TabIndex = 20;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.View = System.Windows.Forms.View.Details;
            this.bookingsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.bookingsListView_ItemSelectionChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Extension";
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Location = new System.Drawing.Point(11, 376);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(531, 21);
            this.extensionComboBox.TabIndex = 21;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(33, 10);
            this.normalRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.normalRadioButton.TabIndex = 23;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // Overtime1radioButton
            // 
            this.Overtime1radioButton.AutoSize = true;
            this.Overtime1radioButton.Location = new System.Drawing.Point(119, 10);
            this.Overtime1radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.Overtime1radioButton.Name = "Overtime1radioButton";
            this.Overtime1radioButton.Size = new System.Drawing.Size(81, 17);
            this.Overtime1radioButton.TabIndex = 24;
            this.Overtime1radioButton.TabStop = true;
            this.Overtime1radioButton.Text = "Overtime x1";
            this.Overtime1radioButton.UseVisualStyleBackColor = true;
            // 
            // overtime15radioButton
            // 
            this.overtime15radioButton.AutoSize = true;
            this.overtime15radioButton.Location = new System.Drawing.Point(227, 10);
            this.overtime15radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.overtime15radioButton.Name = "overtime15radioButton";
            this.overtime15radioButton.Size = new System.Drawing.Size(90, 17);
            this.overtime15radioButton.TabIndex = 25;
            this.overtime15radioButton.TabStop = true;
            this.overtime15radioButton.Text = "Overtime x1.5";
            this.overtime15radioButton.UseVisualStyleBackColor = true;
            // 
            // overtimer2radioButton
            // 
            this.overtimer2radioButton.AutoSize = true;
            this.overtimer2radioButton.Location = new System.Drawing.Point(344, 10);
            this.overtimer2radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.overtimer2radioButton.Name = "overtimer2radioButton";
            this.overtimer2radioButton.Size = new System.Drawing.Size(81, 17);
            this.overtimer2radioButton.TabIndex = 26;
            this.overtimer2radioButton.TabStop = true;
            this.overtimer2radioButton.Text = "Overtime x2";
            this.overtimer2radioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.overtimer2radioButton);
            this.panel1.Controls.Add(this.normalRadioButton);
            this.panel1.Controls.Add(this.overtime15radioButton);
            this.panel1.Controls.Add(this.Overtime1radioButton);
            this.panel1.Location = new System.Drawing.Point(59, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 35);
            this.panel1.TabIndex = 27;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(178, 180);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 28;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // regionRadioButton
            // 
            this.regionRadioButton.AutoSize = true;
            this.regionRadioButton.Location = new System.Drawing.Point(239, 180);
            this.regionRadioButton.Name = "regionRadioButton";
            this.regionRadioButton.Size = new System.Drawing.Size(59, 17);
            this.regionRadioButton.TabIndex = 29;
            this.regionRadioButton.TabStop = true;
            this.regionRadioButton.Text = "Region";
            this.regionRadioButton.UseVisualStyleBackColor = true;
            this.regionRadioButton.CheckedChanged += new System.EventHandler(this.regionRadioButton_CheckedChanged);
            // 
            // teamRadioButton
            // 
            this.teamRadioButton.AutoSize = true;
            this.teamRadioButton.Location = new System.Drawing.Point(323, 180);
            this.teamRadioButton.Name = "teamRadioButton";
            this.teamRadioButton.Size = new System.Drawing.Size(52, 17);
            this.teamRadioButton.TabIndex = 30;
            this.teamRadioButton.TabStop = true;
            this.teamRadioButton.Text = "Team";
            this.teamRadioButton.UseVisualStyleBackColor = true;
            this.teamRadioButton.CheckedChanged += new System.EventHandler(this.teamRadioButton_CheckedChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimesheetEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 519);
            this.Controls.Add(this.teamRadioButton);
            this.Controls.Add(this.regionRadioButton);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.bookingsListView);
            this.Controls.Add(this.technologyLabel);
            this.Controls.Add(this.technologyComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bookingsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimesheetEntry";
            this.Text = "Timesheet Reminder";
            this.Load += new System.EventHandler(this.TimesheetEntry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton Overtime1radioButton;
        private System.Windows.Forms.RadioButton overtime15radioButton;
        private System.Windows.Forms.RadioButton overtimer2radioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton regionRadioButton;
        private System.Windows.Forms.RadioButton teamRadioButton;
        private System.Windows.Forms.Timer timer2;
    }
}