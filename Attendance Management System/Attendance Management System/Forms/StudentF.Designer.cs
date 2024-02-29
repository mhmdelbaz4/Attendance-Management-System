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
            Name = new DataGridViewTextBoxColumn();
            Attendance = new DataGridViewTextBoxColumn();
            TeacherID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            labelNotFound = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // labelNotFound
            // 
            labelNotFound.AutoSize = true;
            labelNotFound.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNotFound.ForeColor = Color.Blue;
            labelNotFound.Location = new Point(594, 187);
            labelNotFound.Name = "labelNotFound";
            labelNotFound.Size = new Size(284, 39);
            labelNotFound.TabIndex = 0;
            labelNotFound.Text = "Student not found";
            labelNotFound.Visible = false;
            labelNotFound.Click += labelNotFound_Click;
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
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.StudentForm;
            pictureBox1.Location = new Point(12, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 207);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // StudentF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 623);
            Controls.Add(labelNotFound);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
        
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
        private new DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Attendance;
        private DataGridViewTextBoxColumn TeacherID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn State;
        private Label labelNotFound; // Add label for "Student not found" message
        private ColorDialog colorDialog1;
    }
}
