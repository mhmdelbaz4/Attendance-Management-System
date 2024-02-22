namespace Attendance_Management_System.UserControls
{
    partial class TeacherMarkAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabpageMarkAttendance = new TabControl();
            markaatendancetab = new TabPage();
            ClassComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            classlbl = new Label();
            DateLbl = new Label();
            markAttendanceLabel = new Label();
            attendanceGridView = new DataGridView();
            tabpageMarkAttendance.SuspendLayout();
            markaatendancetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGridView).BeginInit();
            SuspendLayout();
            // 
            // tabpageMarkAttendance
            // 
            tabpageMarkAttendance.Alignment = TabAlignment.Bottom;
            tabpageMarkAttendance.Anchor = AnchorStyles.None;
            tabpageMarkAttendance.Controls.Add(markaatendancetab);
            tabpageMarkAttendance.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            tabpageMarkAttendance.Location = new Point(0, 0);
            tabpageMarkAttendance.Name = "tabpageMarkAttendance";
            tabpageMarkAttendance.SelectedIndex = 0;
            tabpageMarkAttendance.Size = new Size(942, 501);
            tabpageMarkAttendance.TabIndex = 0;
            // 
            // markaatendancetab
            // 
            markaatendancetab.Controls.Add(attendanceGridView);
            markaatendancetab.Controls.Add(ClassComboBox);
            markaatendancetab.Controls.Add(dateTimePicker1);
            markaatendancetab.Controls.Add(classlbl);
            markaatendancetab.Controls.Add(DateLbl);
            markaatendancetab.Controls.Add(markAttendanceLabel);
            markaatendancetab.Font = new Font("Rockwell", 13.8F);
            markaatendancetab.Location = new Point(4, 4);
            markaatendancetab.Name = "markaatendancetab";
            markaatendancetab.Padding = new Padding(3);
            markaatendancetab.Size = new Size(934, 468);
            markaatendancetab.TabIndex = 0;
            markaatendancetab.Text = "Mark Attendance";
            markaatendancetab.UseVisualStyleBackColor = true;
            // 
            // ClassComboBox
            // 
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(541, 86);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(216, 34);
            ClassComboBox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(178, 84);
            dateTimePicker1.MaxDate = new DateTime(2024, 2, 21, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 35);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2024, 2, 21, 0, 0, 0, 0);
            // 
            // classlbl
            // 
            classlbl.AutoSize = true;
            classlbl.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            classlbl.ForeColor = Color.FromArgb(39, 55, 77);
            classlbl.Location = new Point(617, 53);
            classlbl.Name = "classlbl";
            classlbl.Size = new Size(75, 28);
            classlbl.TabIndex = 2;
            classlbl.Text = "Class";
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            DateLbl.ForeColor = Color.FromArgb(39, 55, 77);
            DateLbl.Location = new Point(252, 53);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(64, 28);
            DateLbl.TabIndex = 1;
            DateLbl.Text = "Date";
            // 
            // markAttendanceLabel
            // 
            markAttendanceLabel.AutoSize = true;
            markAttendanceLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            markAttendanceLabel.ForeColor = Color.FromArgb(39, 55, 77);
            markAttendanceLabel.Location = new Point(0, 0);
            markAttendanceLabel.Name = "markAttendanceLabel";
            markAttendanceLabel.Size = new Size(206, 28);
            markAttendanceLabel.TabIndex = 0;
            markAttendanceLabel.Text = "Mark Attendance";
            // 
            // attendanceGridView
            // 
            attendanceGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            attendanceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceGridView.Location = new Point(0, 128);
            attendanceGridView.Name = "attendanceGridView";
            attendanceGridView.RowHeadersWidth = 51;
            attendanceGridView.Size = new Size(935, 340);
            attendanceGridView.TabIndex = 9;
            // 
            // TeacherMarkAttendance
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabpageMarkAttendance);
            Font = new Font("Rockwell", 13.8F);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(5, 4, 5, 4);
            Name = "TeacherMarkAttendance";
            Size = new Size(942, 501);
            tabpageMarkAttendance.ResumeLayout(false);
            markaatendancetab.ResumeLayout(false);
            markaatendancetab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabpageMarkAttendance;
        private TabPage markaatendancetab;
        private Label markAttendanceLabel;
        private Label classlbl;
        private Label DateLbl;
        private DateTimePicker dateTimePicker1;
        private ComboBox ClassComboBox;
        private DataGridView attendanceGridView;
    }
}
