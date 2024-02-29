namespace Attendance_Management_System.UserControls
{
    partial class AdminMarkAttendance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AttendanceDataGridView = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            DateLabel = new Label();
            AttendanceDateTimePicker = new DateTimePicker();
            TeacherComboBox = new ComboBox();
            TrackComboBox = new ComboBox();
            label3 = new Label();
            markAttendanceLabel = new Label();
            trackLabel = new Label();
            TeacherLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AttendanceDataGridView
            // 
            AttendanceDataGridView.BackgroundColor = Color.White;
            AttendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Status });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            AttendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            AttendanceDataGridView.Dock = DockStyle.Bottom;
            AttendanceDataGridView.Location = new Point(0, 168);
            AttendanceDataGridView.Name = "AttendanceDataGridView";
            AttendanceDataGridView.RowHeadersWidth = 51;
            AttendanceDataGridView.Size = new Size(800, 432);
            AttendanceDataGridView.TabIndex = 2;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentID.FillWeight = 250F;
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentName.FillWeight = 250F;
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DateLabel.ForeColor = Color.FromArgb(39, 55, 77);
            DateLabel.Location = new Point(77, 60);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(56, 23);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Date";
            // 
            // AttendanceDateTimePicker
            // 
            AttendanceDateTimePicker.CalendarFont = new Font("Century Gothic", 9F);
            AttendanceDateTimePicker.Font = new Font("Century Gothic", 12F);
            AttendanceDateTimePicker.Format = DateTimePickerFormat.Short;
            AttendanceDateTimePicker.Location = new Point(77, 96);
            AttendanceDateTimePicker.Name = "AttendanceDateTimePicker";
            AttendanceDateTimePicker.Size = new Size(194, 32);
            AttendanceDateTimePicker.TabIndex = 5;
            AttendanceDateTimePicker.ValueChanged += getAttendance;
            // 
            // TeacherComboBox
            // 
            TeacherComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TeacherComboBox.Font = new Font("Century Gothic", 12F);
            TeacherComboBox.FormattingEnabled = true;
            TeacherComboBox.Location = new Point(548, 99);
            TeacherComboBox.Name = "TeacherComboBox";
            TeacherComboBox.Size = new Size(151, 31);
            TeacherComboBox.TabIndex = 6;
            // 
            // TrackComboBox
            // 
            TrackComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TrackComboBox.Font = new Font("Century Gothic", 12F);
            TrackComboBox.FormattingEnabled = true;
            TrackComboBox.Location = new Point(338, 100);
            TrackComboBox.Name = "TrackComboBox";
            TrackComboBox.Size = new Size(151, 31);
            TrackComboBox.TabIndex = 7;
            TrackComboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 60);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // markAttendanceLabel
            // 
            markAttendanceLabel.AutoSize = true;
            markAttendanceLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            markAttendanceLabel.ForeColor = Color.FromArgb(39, 55, 77);
            markAttendanceLabel.Location = new Point(3, 10);
            markAttendanceLabel.Name = "markAttendanceLabel";
            markAttendanceLabel.Size = new Size(181, 23);
            markAttendanceLabel.TabIndex = 9;
            markAttendanceLabel.Text = "Mark Attendance";
            // 
            // trackLabel
            // 
            trackLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            trackLabel.AutoSize = true;
            trackLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            trackLabel.ForeColor = Color.FromArgb(39, 55, 77);
            trackLabel.Location = new Point(338, 60);
            trackLabel.Name = "trackLabel";
            trackLabel.Size = new Size(62, 23);
            trackLabel.TabIndex = 10;
            trackLabel.Text = "Track";
            // 
            // TeacherLabel
            // 
            TeacherLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TeacherLabel.AutoSize = true;
            TeacherLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TeacherLabel.ForeColor = Color.FromArgb(39, 55, 77);
            TeacherLabel.Location = new Point(548, 60);
            TeacherLabel.Name = "TeacherLabel";
            TeacherLabel.Size = new Size(88, 23);
            TeacherLabel.TabIndex = 11;
            TeacherLabel.Text = "Teacher";
            // 
            // AdminMarkAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TeacherLabel);
            Controls.Add(trackLabel);
            Controls.Add(markAttendanceLabel);
            Controls.Add(label3);
            Controls.Add(TrackComboBox);
            Controls.Add(TeacherComboBox);
            Controls.Add(AttendanceDateTimePicker);
            Controls.Add(DateLabel);
            Controls.Add(AttendanceDataGridView);
            Name = "AdminMarkAttendance";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView AttendanceDataGridView;
        private Label DateLabel;
        private DateTimePicker AttendanceDateTimePicker;
        private ComboBox TeacherComboBox;
        private ComboBox TrackComboBox;
        private Label label3;
        private Label markAttendanceLabel;
        private Label trackLabel;
        private Label TeacherLabel;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewCheckBoxColumn Status;
    }
}
