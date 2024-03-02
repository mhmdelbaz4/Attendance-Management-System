namespace Attendance_Management_System.Forms
{
    partial class StudentF
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student_Name = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            TeacherID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Student_Name, Attendance, TeacherID, Date, State });
            dataGridView1.Location = new Point(59, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1276, 252);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Name
            // 
            Student_Name.HeaderText = "Name";
            Student_Name.MinimumWidth = 6;
            Student_Name.Name = "Name";
            // 
            // Attendance
            // 
            Attendance.HeaderText = "TrackName";
            Attendance.MinimumWidth = 6;
            Attendance.Name = "Attendance";
            // 
            // TeacherID
            // 
            TeacherID.HeaderText = "TeacherID";
            TeacherID.MinimumWidth = 6;
            TeacherID.Name = "TeacherID";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // State
            // 
            State.HeaderText = "State";
            State.MinimumWidth = 6;
            State.Name = "State";
            // 
            // StudentF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 623);
            Controls.Add(dataGridView1);
            Name = "StudentF";
            Text = "Student";
            Load += Studentff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private new DataGridViewTextBoxColumn Student_Name;
        private DataGridViewTextBoxColumn Attendance;
        private DataGridViewTextBoxColumn TeacherID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn State;
        private ColorDialog colorDialog1;
    }
}
