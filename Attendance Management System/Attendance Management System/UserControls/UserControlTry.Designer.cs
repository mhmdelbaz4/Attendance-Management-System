namespace Attendance_Management_System.UserControls
{
    partial class UserControlTry
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabp_TReports = new TabPage();
            lablTeacher = new Label();
            comboBoxTeachers = new ComboBox();
            dataGridView_reports = new DataGridView();
            Student_Name = new DataGridViewTextBoxColumn();
            Student_ID = new DataGridViewTextBoxColumn();
            Track_Name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            pictureBox_PRINT = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox_tRACK = new ComboBox();
            labe_Track = new Label();
            label_Date = new Label();
            label_Track = new Label();
            tabPS_Reports = new TabPage();
            Teaceher_ID_s = new Label();
            comboBoxTeachers_students = new ComboBox();
            pictureBox_print2 = new PictureBox();
            dataGridView1_Students = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Teacher_ID = new DataGridViewTextBoxColumn();
            Att_Date = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            comboBox_Student = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label2_Student = new Label();
            label2_Date = new Label();
            labl_student = new Label();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabp_TReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PRINT).BeginInit();
            tabPS_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_print2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Students).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabp_TReports);
            tabControl1.Controls.Add(tabPS_Reports);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Yu Gothic", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1415, 708);
            tabControl1.TabIndex = 0;
            // 
            // tabp_TReports
            // 
            tabp_TReports.Controls.Add(lablTeacher);
            tabp_TReports.Controls.Add(comboBoxTeachers);
            tabp_TReports.Controls.Add(dataGridView_reports);
            tabp_TReports.Controls.Add(pictureBox_PRINT);
            tabp_TReports.Controls.Add(dateTimePicker1);
            tabp_TReports.Controls.Add(comboBox_tRACK);
            tabp_TReports.Controls.Add(labe_Track);
            tabp_TReports.Controls.Add(label_Date);
            tabp_TReports.Controls.Add(label_Track);
            tabp_TReports.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabp_TReports.ForeColor = Color.Blue;
            tabp_TReports.Location = new Point(4, 4);
            tabp_TReports.Name = "tabp_TReports";
            tabp_TReports.Padding = new Padding(3);
            tabp_TReports.Size = new Size(1407, 673);
            tabp_TReports.TabIndex = 0;
            tabp_TReports.Text = "Track Report";
            tabp_TReports.UseVisualStyleBackColor = true;
            // 
            // lablTeacher
            // 
            lablTeacher.AutoSize = true;
            lablTeacher.Location = new Point(489, 79);
            lablTeacher.Name = "lablTeacher";
            lablTeacher.Size = new Size(128, 26);
            lablTeacher.TabIndex = 9;
            lablTeacher.Text = "Teacher_ID :";
            // 
            // comboBoxTeachers
            // 
            comboBoxTeachers.FormattingEnabled = true;
            comboBoxTeachers.Location = new Point(489, 122);
            comboBoxTeachers.Name = "comboBoxTeachers";
            comboBoxTeachers.Size = new Size(354, 34);
            comboBoxTeachers.TabIndex = 8;
            comboBoxTeachers.SelectedIndexChanged += comboBoxTeachers_SelectedIndexChanged;
            // 
            // dataGridView_reports
            // 
            dataGridView_reports.AllowUserToAddRows = false;
            dataGridView_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_reports.BackgroundColor = Color.White;
            dataGridView_reports.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(192, 0, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reports.Columns.AddRange(new DataGridViewColumn[] { Student_Name, Student_ID, Track_Name, ID, Date, status });
            dataGridView_reports.GridColor = Color.White;
            dataGridView_reports.Location = new Point(92, 173);
            dataGridView_reports.Name = "dataGridView_reports";
            dataGridView_reports.RowHeadersWidth = 51;
            dataGridView_reports.Size = new Size(1101, 439);
            dataGridView_reports.TabIndex = 7;
            // 
            // Student_Name
            // 
            Student_Name.HeaderText = "Student_Name";
            Student_Name.MinimumWidth = 6;
            Student_Name.Name = "Student_Name";
            // 
            // Student_ID
            // 
            Student_ID.HeaderText = "Student_ID";
            Student_ID.MinimumWidth = 6;
            Student_ID.Name = "Student_ID";
            // 
            // Track_Name
            // 
            Track_Name.HeaderText = "Track_Name";
            Track_Name.MinimumWidth = 6;
            Track_Name.Name = "Track_Name";
            // 
            // ID
            // 
            ID.HeaderText = "Teacher_ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // status
            // 
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // pictureBox_PRINT
            // 
            pictureBox_PRINT.Image = Properties.Resources.print;
            pictureBox_PRINT.Location = new Point(1060, 15);
            pictureBox_PRINT.Name = "pictureBox_PRINT";
            pictureBox_PRINT.Size = new Size(125, 62);
            pictureBox_PRINT.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_PRINT.TabIndex = 6;
            pictureBox_PRINT.TabStop = false;
            pictureBox_PRINT.Click += pictureBox_PRINT_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Font = new Font("Yu Gothic", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(92, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 32);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox_tRACK
            // 
            comboBox_tRACK.FormattingEnabled = true;
            comboBox_tRACK.Items.AddRange(new object[] { "OS", "PD" });
            comboBox_tRACK.Location = new Point(865, 122);
            comboBox_tRACK.Name = "comboBox_tRACK";
            comboBox_tRACK.Size = new Size(320, 34);
            comboBox_tRACK.TabIndex = 4;
            comboBox_tRACK.SelectedIndexChanged += comboBoxTrack_SelectedIndexChanged;
            // 
            // labe_Track
            // 
            labe_Track.AutoSize = true;
            labe_Track.Location = new Point(850, 79);
            labe_Track.Name = "labe_Track";
            labe_Track.Size = new Size(74, 26);
            labe_Track.TabIndex = 3;
            labe_Track.Text = "Track :";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Location = new Point(92, 79);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(68, 26);
            label_Date.TabIndex = 2;
            label_Date.Text = "Date :";
            // 
            // label_Track
            // 
            label_Track.AutoSize = true;
            label_Track.Location = new Point(30, 15);
            label_Track.Name = "label_Track";
            label_Track.Size = new Size(129, 26);
            label_Track.TabIndex = 1;
            label_Track.Text = "Track Report";
            // 
            // tabPS_Reports
            // 
            tabPS_Reports.Controls.Add(Teaceher_ID_s);
            tabPS_Reports.Controls.Add(comboBoxTeachers_students);
            tabPS_Reports.Controls.Add(pictureBox_print2);
            tabPS_Reports.Controls.Add(dataGridView1_Students);
            tabPS_Reports.Controls.Add(comboBox_Student);
            tabPS_Reports.Controls.Add(dateTimePicker2);
            tabPS_Reports.Controls.Add(label2_Student);
            tabPS_Reports.Controls.Add(label2_Date);
            tabPS_Reports.Controls.Add(labl_student);
            tabPS_Reports.Font = new Font("Yu Gothic", 12F);
            tabPS_Reports.ForeColor = Color.Blue;
            tabPS_Reports.Location = new Point(4, 4);
            tabPS_Reports.Name = "tabPS_Reports";
            tabPS_Reports.Padding = new Padding(3);
            tabPS_Reports.Size = new Size(1407, 673);
            tabPS_Reports.TabIndex = 1;
            tabPS_Reports.Text = "Student Report";
            tabPS_Reports.UseVisualStyleBackColor = true;
            // 
            // Teaceher_ID_s
            // 
            Teaceher_ID_s.AutoSize = true;
            Teaceher_ID_s.Location = new Point(480, 81);
            Teaceher_ID_s.Name = "Teaceher_ID_s";
            Teaceher_ID_s.Size = new Size(128, 26);
            Teaceher_ID_s.TabIndex = 11;
            Teaceher_ID_s.Text = "Teacher_ID :";
            // 
            // comboBoxTeachers_students
            // 
            comboBoxTeachers_students.FormattingEnabled = true;
            comboBoxTeachers_students.Location = new Point(480, 141);
            comboBoxTeachers_students.Name = "comboBoxTeachers_students";
            comboBoxTeachers_students.Size = new Size(315, 34);
            comboBoxTeachers_students.TabIndex = 10;
            comboBoxTeachers_students.SelectedIndexChanged += comboBoxTeachers_students_SelectedIndexChanged;
            // 
            // pictureBox_print2
            // 
            pictureBox_print2.Image = Properties.Resources.print;
            pictureBox_print2.Location = new Point(1055, 20);
            pictureBox_print2.Name = "pictureBox_print2";
            pictureBox_print2.Size = new Size(125, 62);
            pictureBox_print2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_print2.TabIndex = 9;
            pictureBox_print2.TabStop = false;
            pictureBox_print2.Click += pictureBox_print2_Click;
            // 
            // dataGridView1_Students
            // 
            dataGridView1_Students.AllowUserToAddRows = false;
            dataGridView1_Students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Students.BackgroundColor = Color.White;
            dataGridView1_Students.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Students.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Teacher_ID, Att_Date, state });
            dataGridView1_Students.GridColor = Color.White;
            dataGridView1_Students.Location = new Point(86, 196);
            dataGridView1_Students.Name = "dataGridView1_Students";
            dataGridView1_Students.RowHeadersWidth = 51;
            dataGridView1_Students.Size = new Size(1101, 439);
            dataGridView1_Students.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Student_Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Track_Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Teacher_ID
            // 
            Teacher_ID.HeaderText = "Teacher_ID";
            Teacher_ID.MinimumWidth = 6;
            Teacher_ID.Name = "Teacher_ID";
            // 
            // Att_Date
            // 
            Att_Date.HeaderText = "Date";
            Att_Date.MinimumWidth = 6;
            Att_Date.Name = "Att_Date";
            // 
            // state
            // 
            state.HeaderText = "Status";
            state.MinimumWidth = 6;
            state.Name = "state";
            // 
            // comboBox_Student
            // 
            comboBox_Student.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox_Student.Font = new Font("Yu Gothic", 12F);
            comboBox_Student.ForeColor = Color.Blue;
            comboBox_Student.FormattingEnabled = true;
            comboBox_Student.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox_Student.Location = new Point(833, 141);
            comboBox_Student.Name = "comboBox_Student";
            comboBox_Student.Size = new Size(347, 34);
            comboBox_Student.TabIndex = 7;
            comboBox_Student.SelectedIndexChanged += comboBox_Student_SelectedIndexChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Font = new Font("Yu Gothic", 9F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(86, 141);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(324, 32);
            dateTimePicker2.TabIndex = 6;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2_Student
            // 
            label2_Student.AutoSize = true;
            label2_Student.Font = new Font("Yu Gothic", 12F);
            label2_Student.ForeColor = Color.Blue;
            label2_Student.Location = new Point(833, 93);
            label2_Student.Name = "label2_Student";
            label2_Student.Size = new Size(125, 26);
            label2_Student.TabIndex = 4;
            label2_Student.Text = "Student ID :";
            // 
            // label2_Date
            // 
            label2_Date.AutoSize = true;
            label2_Date.Font = new Font("Yu Gothic", 12F);
            label2_Date.ForeColor = Color.Blue;
            label2_Date.Location = new Point(86, 93);
            label2_Date.Name = "label2_Date";
            label2_Date.Size = new Size(68, 26);
            label2_Date.TabIndex = 3;
            label2_Date.Text = "Date :";
            // 
            // labl_student
            // 
            labl_student.AutoSize = true;
            labl_student.BackColor = Color.White;
            labl_student.Font = new Font("Yu Gothic", 12F);
            labl_student.ForeColor = Color.Blue;
            labl_student.Location = new Point(32, 20);
            labl_student.Name = "labl_student";
            labl_student.Size = new Size(153, 26);
            labl_student.TabIndex = 2;
            labl_student.Text = "Student Report";
            // 
            // UserControlTry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tabControl1);
            Name = "UserControlTry";
            Size = new Size(1415, 708);
            tabControl1.ResumeLayout(false);
            tabp_TReports.ResumeLayout(false);
            tabp_TReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PRINT).EndInit();
            tabPS_Reports.ResumeLayout(false);
            tabPS_Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_print2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Students).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabp_TReports;
        private TabPage tabPS_Reports;
        private Label labe_Track;
        private Label label_Date;
        private Label label_Track;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox_tRACK;
        private DataGridView dataGridView_reports;
        private PictureBox pictureBox_PRINT;
        private Label labl_student;
        private DataGridView dataGridView1_Students;
        private ComboBox comboBox_Student;
        private DateTimePicker dateTimePicker2;
        private Label label2_Student;
        private Label label2_Date;
        private PictureBox pictureBox_print2;
        private ToolTip toolTip1;
        private Label lablTeacher;
        private ComboBox comboBoxTeachers;
        private Label Teaceher_ID_s;
        private ComboBox comboBoxTeachers_students;
        private DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn Student_ID;
        private DataGridViewTextBoxColumn Track_Name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Teacher_ID;
        private DataGridViewTextBoxColumn Att_Date;
        private DataGridViewTextBoxColumn state;
    }
}
