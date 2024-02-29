using Attendance_Management_System.UserControls;

namespace Attendance_Management_System.Forms
{
    partial class Teacher
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            minimize = new PictureBox();
            logout = new PictureBox();
            panel1 = new Panel();
            controlsPanel = new Panel();
            ReportsBtn = new Button();

            ClassesBtn = new Button();

            attendanceBtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dateAndTimeLbl = new Label();
            hoverpanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);

            userControlTry1 = new UserControlTry();
            label1 = new Label();
            label2 = new Label();
            AttendanceDateTimePicker = new DateTimePicker();
            tracksComboBox = new ComboBox();
            AttendancedataGridView = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panel1.SuspendLayout();
            controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            ((System.ComponentModel.ISupportInitialize)AttendancedataGridView).BeginInit();

            SuspendLayout();
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(1149, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(50, 50);
            minimize.SizeMode = PictureBoxSizeMode.Zoom;
            minimize.TabIndex = 2;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Image = Properties.Resources.logout;
            logout.Location = new Point(1205, 0);
            logout.Name = "logout";
            logout.Size = new Size(50, 50);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 3;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 109, 130);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(controlsPanel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 720);
            panel1.TabIndex = 4;
            // 
            // controlsPanel
            // 
            controlsPanel.BackColor = Color.FromArgb(82, 109, 130);
            controlsPanel.Controls.Add(ReportsBtn);

            controlsPanel.Controls.Add(ClassesBtn);
            controlsPanel.Controls.Add(attendanceBtn);
            controlsPanel.Location = new Point(3, 168);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(298, 350);
            controlsPanel.TabIndex = 6;
            controlsPanel.Paint += controlsPanel_Paint;
            // 
            // ReportsBtn
            // 
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.FlatStyle = FlatStyle.Flat;
            ReportsBtn.Font = new Font("Rockwell", 13.8F);
            ReportsBtn.ForeColor = SystemColors.ControlLightLight;
            ReportsBtn.Image = (Image)resources.GetObject("ReportsBtn.Image");
            ReportsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsBtn.Location = new Point(0, 55);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(289, 67);
            ReportsBtn.TabIndex = 7;
            ReportsBtn.Text = "Reports";
            ReportsBtn.UseVisualStyleBackColor = true;
            ReportsBtn.Click += ReportsBtn_Click;
            // 

            // ClassesBtn
            // 
            ClassesBtn.Dock = DockStyle.Top;
            ClassesBtn.FlatAppearance.BorderSize = 0;
            ClassesBtn.FlatStyle = FlatStyle.Flat;
            ClassesBtn.Font = new Font("Rockwell", 13.8F);
            ClassesBtn.ForeColor = SystemColors.ControlLightLight;
            ClassesBtn.Image = (Image)resources.GetObject("ClassesBtn.Image");
            ClassesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClassesBtn.Location = new Point(0, 0);
            ClassesBtn.Name = "ClassesBtn";
            ClassesBtn.Size = new Size(298, 67);
            ClassesBtn.TabIndex = 5;
            ClassesBtn.Text = "Classes";
            ClassesBtn.UseVisualStyleBackColor = true;
            // 
            // attendanceBtn
            // 
            attendanceBtn.FlatAppearance.BorderSize = 0;
            attendanceBtn.FlatStyle = FlatStyle.Flat;
            attendanceBtn.Font = new Font("Rockwell", 13.8F);
            attendanceBtn.ForeColor = SystemColors.ControlLightLight;
            attendanceBtn.Image = (Image)resources.GetObject("attendanceBtn.Image");
            attendanceBtn.ImageAlign = ContentAlignment.MiddleLeft;

            attendanceBtn.Location = new Point(-3, 0);
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.Size = new Size(298, 67);
            attendanceBtn.TabIndex = 6;
            attendanceBtn.Text = "Attendance";
            attendanceBtn.UseVisualStyleBackColor = true;

            attendanceBtn.Click += attendanceBtn_Click;

            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 500);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateAndTimeLbl
            // 
            dateAndTimeLbl.AutoSize = true;
            dateAndTimeLbl.BackColor = SystemColors.Control;
            dateAndTimeLbl.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            dateAndTimeLbl.ForeColor = Color.FromArgb(39, 55, 77);
            dateAndTimeLbl.Location = new Point(323, 9);
            dateAndTimeLbl.Name = "dateAndTimeLbl";
            dateAndTimeLbl.Size = new Size(25, 28);
            dateAndTimeLbl.TabIndex = 6;
            dateAndTimeLbl.Text = "?";
            dateAndTimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hoverpanel
            // 
            hoverpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hoverpanel.BackColor = Color.FromArgb(39, 55, 77);
            hoverpanel.Location = new Point(298, 50);
            hoverpanel.Name = "hoverpanel";
            hoverpanel.Size = new Size(958, 120);
            hoverpanel.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlTry1
            // 
            userControlTry1.Dock = DockStyle.Fill;
            userControlTry1.Location = new Point(298, 0);
            userControlTry1.Name = "userControlTry1";
            userControlTry1.Size = new Size(958, 720);
            userControlTry1.TabIndex = 0;
            userControlTry1.Visible = false;
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 182);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 182);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // AttendanceDateTimePicker
            // 
            AttendanceDateTimePicker.Format = DateTimePickerFormat.Short;
            AttendanceDateTimePicker.Location = new Point(433, 207);
            AttendanceDateTimePicker.Name = "AttendanceDateTimePicker";
            AttendanceDateTimePicker.Size = new Size(200, 27);
            AttendanceDateTimePicker.TabIndex = 10;
            // 
            // tracksComboBox
            // 
            tracksComboBox.FormattingEnabled = true;
            tracksComboBox.Location = new Point(773, 207);
            tracksComboBox.Name = "tracksComboBox";
            tracksComboBox.Size = new Size(151, 28);
            tracksComboBox.TabIndex = 11;
            // 
            // AttendancedataGridView
            // 
            AttendancedataGridView.AllowUserToAddRows = false;
            AttendancedataGridView.AllowUserToDeleteRows = false;
            AttendancedataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AttendancedataGridView.BackgroundColor = Color.White;
            AttendancedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendancedataGridView.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Status });
            AttendancedataGridView.GridColor = Color.White;
            AttendancedataGridView.Location = new Point(323, 250);
            AttendancedataGridView.Name = "AttendancedataGridView";
            AttendancedataGridView.ReadOnly = true;
            AttendancedataGridView.RowHeadersWidth = 51;
            AttendancedataGridView.Size = new Size(800, 400);
            AttendancedataGridView.TabIndex = 12;
            // 
            // StudentID
            // 
            StudentID.FillWeight = 150F;
            StudentID.HeaderText = "Student ID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 250;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 350;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 200;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 720);
            ControlBox = false;

            Controls.Add(userControlTry1);

            Controls.Add(AttendancedataGridView);
            Controls.Add(tracksComboBox);
            Controls.Add(AttendanceDateTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hoverpanel);
            Controls.Add(dateAndTimeLbl);
            Controls.Add(panel1);
            Controls.Add(logout);
            Controls.Add(minimize);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Teacher_Load;
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            panel1.ResumeLayout(false);
            controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ((System.ComponentModel.ISupportInitialize)AttendancedataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox minimize;
        private PictureBox logout;
        private Panel panel1;
        private Panel panel2;
        private Label dateAndTimeLbl;
        private Panel hoverpanel;
        private Button attendanceBtn;
        private Button ReportsBtn;
        private System.Windows.Forms.Timer timer1;
        private Panel controlsPanel;

        private UserControlTry userControlTry1;
     
        private Label label1;
        private Label label2;
        private DateTimePicker AttendanceDateTimePicker;
        private ComboBox tracksComboBox;
        private DataGridView AttendancedataGridView;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewCheckBoxColumn Status;
    }
}