namespace Attendance_Management_System.Forms
{
    partial class AdminMainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainDashboard));
            dashboardCardTeacher = new Panel();
            noTeachers = new Label();
            teacherLabel = new Label();
            pictureBox1 = new PictureBox();
            dashboardCardStudent = new Panel();
            noStudents = new Label();
            StudentsLabel = new Label();
            pictureBox2 = new PictureBox();
            dashboardCardClasses = new Panel();
            noClasses = new Label();
            ClassLabel = new Label();
            pictureBox3 = new PictureBox();
            dashboardCardTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dashboardCardStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            dashboardCardClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dashboardCardTeacher
            // 
            dashboardCardTeacher.Anchor = AnchorStyles.Top;
            dashboardCardTeacher.BackColor = Color.FromArgb(82, 211, 216);
            dashboardCardTeacher.Controls.Add(noTeachers);
            dashboardCardTeacher.Controls.Add(teacherLabel);
            dashboardCardTeacher.Controls.Add(pictureBox1);
            dashboardCardTeacher.Location = new Point(229, 187);
            dashboardCardTeacher.Name = "dashboardCardTeacher";
            dashboardCardTeacher.Size = new Size(349, 184);
            dashboardCardTeacher.TabIndex = 0;
            // 
            // noTeachers
            // 
            noTeachers.AutoSize = true;
            noTeachers.BackColor = Color.Transparent;
            noTeachers.Font = new Font("Rockwell Extra Bold", 13.8F, FontStyle.Bold);
            noTeachers.ForeColor = Color.AliceBlue;
            noTeachers.Location = new Point(245, 120);
            noTeachers.Name = "noTeachers";
            noTeachers.Size = new Size(44, 27);
            noTeachers.TabIndex = 2;
            noTeachers.Text = "15";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.BackColor = Color.Transparent;
            teacherLabel.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            teacherLabel.ForeColor = Color.AliceBlue;
            teacherLabel.Location = new Point(76, 113);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new Size(163, 38);
            teacherLabel.TabIndex = 1;
            teacherLabel.Text = "Teachers:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dashboardCardStudent
            // 
            dashboardCardStudent.Anchor = AnchorStyles.Top;
            dashboardCardStudent.BackColor = Color.FromArgb(255, 64, 125);
            dashboardCardStudent.Controls.Add(noStudents);
            dashboardCardStudent.Controls.Add(StudentsLabel);
            dashboardCardStudent.Controls.Add(pictureBox2);
            dashboardCardStudent.Location = new Point(871, 190);
            dashboardCardStudent.Name = "dashboardCardStudent";
            dashboardCardStudent.Size = new Size(349, 184);
            dashboardCardStudent.TabIndex = 3;
            // 
            // noStudents
            // 
            noStudents.AutoSize = true;
            noStudents.BackColor = Color.Transparent;
            noStudents.Font = new Font("Rockwell Extra Bold", 13.8F, FontStyle.Bold);
            noStudents.ForeColor = Color.AliceBlue;
            noStudents.Location = new Point(245, 120);
            noStudents.Name = "noStudents";
            noStudents.Size = new Size(44, 27);
            noStudents.TabIndex = 2;
            noStudents.Text = "15";
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.BackColor = Color.Transparent;
            StudentsLabel.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            StudentsLabel.ForeColor = Color.AliceBlue;
            StudentsLabel.Location = new Point(76, 113);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(155, 38);
            StudentsLabel.TabIndex = 1;
            StudentsLabel.Text = "Students:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dashboardCardClasses
            // 
            dashboardCardClasses.Anchor = AnchorStyles.Top;
            dashboardCardClasses.BackColor = Color.FromArgb(202, 166, 166);
            dashboardCardClasses.Controls.Add(noClasses);
            dashboardCardClasses.Controls.Add(ClassLabel);
            dashboardCardClasses.Controls.Add(pictureBox3);
            dashboardCardClasses.Location = new Point(550, 489);
            dashboardCardClasses.Name = "dashboardCardClasses";
            dashboardCardClasses.Size = new Size(349, 184);
            dashboardCardClasses.TabIndex = 4;
            // 
            // noClasses
            // 
            noClasses.AutoSize = true;
            noClasses.BackColor = Color.Transparent;
            noClasses.Font = new Font("Rockwell Extra Bold", 13.8F, FontStyle.Bold);
            noClasses.ForeColor = Color.AliceBlue;
            noClasses.Location = new Point(245, 120);
            noClasses.Name = "noClasses";
            noClasses.Size = new Size(44, 27);
            noClasses.TabIndex = 2;
            noClasses.Text = "15";
            // 
            // ClassLabel
            // 
            ClassLabel.AutoSize = true;
            ClassLabel.BackColor = Color.Transparent;
            ClassLabel.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            ClassLabel.ForeColor = Color.AliceBlue;
            ClassLabel.Location = new Point(76, 113);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(141, 38);
            ClassLabel.TabIndex = 1;
            ClassLabel.Text = "Classes:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // AdminMainDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            Controls.Add(dashboardCardClasses);
            Controls.Add(dashboardCardStudent);
            Controls.Add(dashboardCardTeacher);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AdminMainDashboard";
            Size = new Size(1449, 740);
            dashboardCardTeacher.ResumeLayout(false);
            dashboardCardTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dashboardCardStudent.ResumeLayout(false);
            dashboardCardStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            dashboardCardClasses.ResumeLayout(false);
            dashboardCardClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardCardTeacher;
        private Label teacherLabel;
        private PictureBox pictureBox1;
        public Label noTeachers;
        private Panel dashboardCardStudent;
        public Label noStudents;
        private Label StudentsLabel;
        private PictureBox pictureBox2;
        private Panel dashboardCardClasses;
        public Label noClasses;
        private Label ClassLabel;
        private PictureBox pictureBox3;
    }
}
