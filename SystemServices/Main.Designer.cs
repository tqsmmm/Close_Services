
namespace SystemServices
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.tmrHours = new System.Windows.Forms.Timer(this.components);
            this.rbnCount = new System.Windows.Forms.RadioButton();
            this.rbnDate = new System.Windows.Forms.RadioButton();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // niMain
            // 
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "SystemService";
            this.niMain.Visible = true;
            this.niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(258, 616);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(276, 12);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(258, 616);
            this.checkedListBox2.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(715, 585);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(821, 585);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(100, 40);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(750, 32);
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(87, 23);
            this.nudHours.TabIndex = 5;
            this.nudHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tmrHours
            // 
            this.tmrHours.Interval = 3600000;
            this.tmrHours.Tick += new System.EventHandler(this.tmrHours_Tick);
            // 
            // rbnCount
            // 
            this.rbnCount.AutoSize = true;
            this.rbnCount.Checked = true;
            this.rbnCount.Location = new System.Drawing.Point(606, 34);
            this.rbnCount.Name = "rbnCount";
            this.rbnCount.Size = new System.Drawing.Size(138, 21);
            this.rbnCount.TabIndex = 6;
            this.rbnCount.TabStop = true;
            this.rbnCount.Text = "Countdown(Hours):";
            this.rbnCount.UseVisualStyleBackColor = true;
            // 
            // rbnDate
            // 
            this.rbnDate.AutoSize = true;
            this.rbnDate.Location = new System.Drawing.Point(606, 61);
            this.rbnDate.Name = "rbnDate";
            this.rbnDate.Size = new System.Drawing.Size(84, 21);
            this.rbnDate.TabIndex = 7;
            this.rbnDate.Text = "DateTime:";
            this.rbnDate.UseVisualStyleBackColor = true;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(750, 61);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(151, 23);
            this.dtpDateTime.TabIndex = 8;
            // 
            // tmrDate
            // 
            this.tmrDate.Interval = 3600000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(609, 585);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 40);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 637);
            this.ControlBox = false;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.rbnDate);
            this.Controls.Add(this.rbnCount);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Timer tmrHours;
        private System.Windows.Forms.RadioButton rbnCount;
        private System.Windows.Forms.RadioButton rbnDate;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Button btnTest;
    }
}