namespace Attendance_Management_System.UserControls
{
    partial class AdminTeacherCRUD
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
            AdminTeacherCRUDTab = new TabControl();
            AddTeacher = new TabPage();
            markAttendanceLabel = new Label();
            AdminTeacherCRUDTab.SuspendLayout();
            AddTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // AdminTeacherCRUDTab
            // 
            AdminTeacherCRUDTab.Alignment = TabAlignment.Bottom;
            AdminTeacherCRUDTab.Anchor = AnchorStyles.None;
            AdminTeacherCRUDTab.Controls.Add(AddTeacher);
            AdminTeacherCRUDTab.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminTeacherCRUDTab.Location = new Point(0, 0);
            AdminTeacherCRUDTab.Name = "AdminTeacherCRUDTab";
            AdminTeacherCRUDTab.SelectedIndex = 0;
            AdminTeacherCRUDTab.Size = new Size(942, 501);
            AdminTeacherCRUDTab.TabIndex = 1;
            // 
            // AddTeacher
            // 
            AddTeacher.Controls.Add(markAttendanceLabel);
            AddTeacher.Font = new Font("Rockwell", 13.8F);
            AddTeacher.Location = new Point(4, 4);
            AddTeacher.Name = "AddTeacher";
            AddTeacher.Padding = new Padding(3);
            AddTeacher.Size = new Size(934, 465);
            AddTeacher.TabIndex = 0;
            AddTeacher.Text = "Add Teacher";
            AddTeacher.UseVisualStyleBackColor = true;
            // 
            // markAttendanceLabel
            // 
            markAttendanceLabel.AutoSize = true;
            markAttendanceLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            markAttendanceLabel.ForeColor = Color.FromArgb(39, 55, 77);
            markAttendanceLabel.Location = new Point(3, 3);
            markAttendanceLabel.Name = "markAttendanceLabel";
            markAttendanceLabel.Size = new Size(205, 28);
            markAttendanceLabel.TabIndex = 0;
            markAttendanceLabel.Text = "Teacher Register";
            // 
            // AdminTeacherCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AdminTeacherCRUDTab);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AdminTeacherCRUD";
            Size = new Size(942, 501);
            AdminTeacherCRUDTab.ResumeLayout(false);
            AddTeacher.ResumeLayout(false);
            AddTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdminTeacherCRUDTab;
        private TabPage AddTeacher;
        private Label markAttendanceLabel;
    }
}
