namespace Attendance_Management_System.Forms
{
    partial class Studentff
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            TeacherID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Attendance, TeacherID, Date, State });
            dataGridView1.Location = new Point(189, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1148, 609);
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
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 143);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Student Data";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(3, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 207);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Studentff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 623);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
           // Name = "Studentff";
            Text = "Student";
            Load += Studentff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Attendance;
        private DataGridViewTextBoxColumn TeacherID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn State;
    }
}