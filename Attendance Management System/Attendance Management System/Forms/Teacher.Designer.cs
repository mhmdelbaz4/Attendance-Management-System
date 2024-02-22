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
            admin = new Admin();
            panel1 = new Panel();
            panel2 = new Panel();
            ReportsBtn = new Button();
            attendanceBtn = new Button();
            pictureBox1 = new PictureBox();
            ClassesBtn = new Button();
            dateAndTimeLbl = new Label();
            hoverpanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            controlsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            controlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(1093, 0);
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
            logout.Location = new Point(1149, 0);
            logout.Name = "logout";
            logout.Size = new Size(50, 50);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 3;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // admin
            // 
            admin.ClientSize = new Size(0, 0);
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Icon = (Icon)resources.GetObject("admin.Icon");
            admin.Location = new Point(-32000, -32000);
            admin.Name = "admin";
            admin.Text = "Admin";
            admin.TopMost = true;
            admin.Visible = false;
            admin.WindowState = FormWindowState.Minimized;
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
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 500);
            panel2.TabIndex = 1;
            // 
            // ReportsBtn
            // 
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.FlatStyle = FlatStyle.Flat;
            ReportsBtn.Font = new Font("Rockwell", 13.8F);
            ReportsBtn.ForeColor = SystemColors.ControlLightLight;
            ReportsBtn.Image = (Image)resources.GetObject("ReportsBtn.Image");
            ReportsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsBtn.Location = new Point(3, 122);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(298, 67);
            ReportsBtn.TabIndex = 7;
            ReportsBtn.Text = "Reports";
            ReportsBtn.UseVisualStyleBackColor = true;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // attendanceBtn
            // 
            attendanceBtn.FlatAppearance.BorderSize = 0;
            attendanceBtn.FlatStyle = FlatStyle.Flat;
            attendanceBtn.Font = new Font("Rockwell", 13.8F);
            attendanceBtn.ForeColor = SystemColors.ControlLightLight;
            attendanceBtn.Image = (Image)resources.GetObject("attendanceBtn.Image");
            attendanceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceBtn.Location = new Point(0, 60);
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.Size = new Size(298, 67);
            attendanceBtn.TabIndex = 6;
            attendanceBtn.Text = "Attendance";
            attendanceBtn.UseVisualStyleBackColor = true;
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
            hoverpanel.Size = new Size(902, 120);
            hoverpanel.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            controlsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox closePictureBox;
        private PictureBox minimize;
        private PictureBox logout;
        private Admin admin;
        private Panel panel1;
        private Panel panel2;
        private Label dateAndTimeLbl;
        private Panel hoverpanel;
        private Button attendanceBtn;
        private Button ReportsBtn;
        private System.Windows.Forms.Timer timer1;
        private Button ClassesBtn;
        private Panel controlsPanel;
    }
}