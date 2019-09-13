namespace ReminderApp
{
    partial class OvertimeFormGenerator
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
            this.thisMonthButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lastMonthButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Multiplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.loadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thisMonthButton
            // 
            this.thisMonthButton.Location = new System.Drawing.Point(633, 12);
            this.thisMonthButton.Name = "thisMonthButton";
            this.thisMonthButton.Size = new System.Drawing.Size(155, 43);
            this.thisMonthButton.TabIndex = 1;
            this.thisMonthButton.Text = "Get this months bookings";
            this.thisMonthButton.UseVisualStyleBackColor = true;
            this.thisMonthButton.Click += new System.EventHandler(this.thisMonthButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lastMonthButton
            // 
            this.lastMonthButton.Location = new System.Drawing.Point(633, 61);
            this.lastMonthButton.Name = "lastMonthButton";
            this.lastMonthButton.Size = new System.Drawing.Size(155, 43);
            this.lastMonthButton.TabIndex = 3;
            this.lastMonthButton.Text = "Get last months bookings";
            this.lastMonthButton.UseVisualStyleBackColor = true;
            this.lastMonthButton.Click += new System.EventHandler(this.lastMonthButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 161);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 53);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.ProjectNo,
            this.Description,
            this.Hours,
            this.Multiplier});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 202);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // ProjectNo
            // 
            this.ProjectNo.Text = "Project No";
            this.ProjectNo.Width = 75;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 100;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            // 
            // Multiplier
            // 
            this.Multiplier.Text = "Multiplier";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(633, 177);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(155, 37);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(325, 220);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(155, 37);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // loadingText
            // 
            this.loadingText.AutoSize = true;
            this.loadingText.BackColor = System.Drawing.Color.Transparent;
            this.loadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingText.Location = new System.Drawing.Point(271, 101);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(97, 25);
            this.loadingText.TabIndex = 8;
            this.loadingText.Text = "Loading...";
            // 
            // OvertimeFormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lastMonthButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.thisMonthButton);
            this.Name = "OvertimeFormGenerator";
            this.Text = "OvertimeFormGenerator";
            this.Load += new System.EventHandler(this.OvertimeFormGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button thisMonthButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button lastMonthButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader ProjectNo;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.ColumnHeader Multiplier;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label loadingText;
    }
}