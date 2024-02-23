using Attendance_Management_System.UserControls;

namespace Attendance_Management_System.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            sidebar = new Panel();
            reports = new Button();
            addClassBtn = new Button();
            addStudentBtn = new Button();
            addTeacherBtn = new Button();
            attendanceBtn = new Button();
            dashboardBtn = new Button();
            sidebarHoverContainer = new Panel();
            sidebarHover = new Panel();
            sidebarHeader = new Panel();
            adminLogo = new PictureBox();
            navbar = new Panel();
            minimize = new PictureBox();
            logout = new PictureBox();
            dateAndTime = new System.Windows.Forms.Timer(components);
            dateAndTimeLbl = new Label();
            userControlAddStudent1 = new UserControlAddStudent();
            panel1 = new Panel();
            adminTeachercrud = new AdminTeacherCRUD();
            adminMainDashboard1 = new AdminMainDashboard();
            welcomeLabel = new Label();
            adminName = new Label();
            sidebar.SuspendLayout();
            sidebarHoverContainer.SuspendLayout();
            sidebarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminLogo).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(82, 109, 130);
            sidebar.Controls.Add(reports);
            sidebar.Controls.Add(addClassBtn);
            sidebar.Controls.Add(addStudentBtn);
            sidebar.Controls.Add(addTeacherBtn);
            sidebar.Controls.Add(attendanceBtn);
            sidebar.Controls.Add(dashboardBtn);
            sidebar.Controls.Add(sidebarHoverContainer);
            sidebar.Controls.Add(sidebarHeader);
            sidebar.Dock = DockStyle.Left;
            sidebar.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(298, 720);
            sidebar.TabIndex = 0;
            // 
            // reports
            // 
            reports.Dock = DockStyle.Top;
            reports.FlatAppearance.BorderSize = 0;
            reports.FlatStyle = FlatStyle.Flat;
            reports.ForeColor = SystemColors.ControlLightLight;
            reports.Image = (Image)resources.GetObject("reports.Image");
            reports.ImageAlign = ContentAlignment.MiddleLeft;
            reports.Location = new Point(10, 497);
            reports.Name = "reports";
            reports.Size = new Size(288, 67);
            reports.TabIndex = 9;
            reports.Text = "         Reports";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // addClassBtn
            // 
            addClassBtn.Dock = DockStyle.Top;
            addClassBtn.FlatAppearance.BorderSize = 0;
            addClassBtn.FlatStyle = FlatStyle.Flat;
            addClassBtn.ForeColor = SystemColors.ControlLightLight;
            addClassBtn.Image = (Image)resources.GetObject("addClassBtn.Image");
            addClassBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addClassBtn.Location = new Point(10, 430);
            addClassBtn.Name = "addClassBtn";
            addClassBtn.Size = new Size(288, 67);
            addClassBtn.TabIndex = 8;
            addClassBtn.Text = "      Track";
            addClassBtn.UseVisualStyleBackColor = true;
            addClassBtn.Click += addClassBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Dock = DockStyle.Top;
            addStudentBtn.FlatAppearance.BorderSize = 0;
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.ForeColor = SystemColors.ControlLightLight;
            addStudentBtn.Image = (Image)resources.GetObject("addStudentBtn.Image");
            addStudentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addStudentBtn.Location = new Point(10, 363);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(288, 67);
            addStudentBtn.TabIndex = 7;
            addStudentBtn.Text = "       Student";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // addTeacherBtn
            // 
            addTeacherBtn.Dock = DockStyle.Top;
            addTeacherBtn.FlatAppearance.BorderSize = 0;
            addTeacherBtn.FlatStyle = FlatStyle.Flat;
            addTeacherBtn.ForeColor = SystemColors.ControlLightLight;
            addTeacherBtn.Image = (Image)resources.GetObject("addTeacherBtn.Image");
            addTeacherBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTeacherBtn.Location = new Point(10, 296);
            addTeacherBtn.Name = "addTeacherBtn";
            addTeacherBtn.Size = new Size(288, 67);
            addTeacherBtn.TabIndex = 6;
            addTeacherBtn.Text = "        Teacher";
            addTeacherBtn.UseVisualStyleBackColor = true;
            addTeacherBtn.Click += TeacherBtn_Click;
            // 
            // attendanceBtn
            // 
            attendanceBtn.Dock = DockStyle.Top;
            attendanceBtn.FlatAppearance.BorderSize = 0;
            attendanceBtn.FlatStyle = FlatStyle.Flat;
            attendanceBtn.ForeColor = SystemColors.ControlLightLight;
            attendanceBtn.Image = (Image)resources.GetObject("attendanceBtn.Image");
            attendanceBtn.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceBtn.Location = new Point(10, 229);
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.Size = new Size(288, 67);
            attendanceBtn.TabIndex = 5;
            attendanceBtn.Text = "         Attendance";
            attendanceBtn.UseVisualStyleBackColor = true;
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Dock = DockStyle.Top;
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.ForeColor = SystemColors.ControlLightLight;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(10, 162);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(288, 67);
            dashboardBtn.TabIndex = 4;
            dashboardBtn.Text = "         Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // sidebarHoverContainer
            // 
            sidebarHoverContainer.Controls.Add(sidebarHover);
            sidebarHoverContainer.Dock = DockStyle.Left;
            sidebarHoverContainer.Location = new Point(0, 162);
            sidebarHoverContainer.Name = "sidebarHoverContainer";
            sidebarHoverContainer.Size = new Size(10, 558);
            sidebarHoverContainer.TabIndex = 1;
            // 
            // sidebarHover
            // 
            sidebarHover.BackColor = Color.White;
            sidebarHover.Location = new Point(0, 0);
            sidebarHover.Name = "sidebarHover";
            sidebarHover.Size = new Size(15, 67);
            sidebarHover.TabIndex = 4;
            // 
            // sidebarHeader
            // 
            sidebarHeader.Controls.Add(adminLogo);
            sidebarHeader.Dock = DockStyle.Top;
            sidebarHeader.Location = new Point(0, 0);
            sidebarHeader.Name = "sidebarHeader";
            sidebarHeader.Size = new Size(298, 162);
            sidebarHeader.TabIndex = 0;
            // 
            // adminLogo
            // 
            adminLogo.BackgroundImageLayout = ImageLayout.Stretch;
            adminLogo.Dock = DockStyle.Fill;
            adminLogo.Image = (Image)resources.GetObject("adminLogo.Image");
            adminLogo.Location = new Point(0, 0);
            adminLogo.Name = "adminLogo";
            adminLogo.Size = new Size(298, 162);
            adminLogo.SizeMode = PictureBoxSizeMode.Zoom;
            adminLogo.TabIndex = 0;
            adminLogo.TabStop = false;
            // 
            // navbar
            // 
            navbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navbar.BackColor = Color.FromArgb(39, 55, 77);
            navbar.Controls.Add(adminName);
            navbar.Controls.Add(welcomeLabel);
            navbar.Location = new Point(296, 50);
            navbar.Name = "navbar";
            navbar.Size = new Size(904, 85);
            navbar.TabIndex = 1;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.Image = (Image)resources.GetObject("minimize.Image");
            minimize.Location = new Point(1094, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(50, 50);
            minimize.SizeMode = PictureBoxSizeMode.Zoom;
            minimize.TabIndex = 3;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(1150, 0);
            logout.Name = "logout";
            logout.Size = new Size(50, 50);
            logout.SizeMode = PictureBoxSizeMode.Zoom;
            logout.TabIndex = 2;
            logout.TabStop = false;
            logout.Click += logout_Click;
            // 
            // dateAndTime
            // 
            dateAndTime.Tick += dateAndTime_Tick;
            // 
            // dateAndTimeLbl
            // 
            dateAndTimeLbl.AutoSize = true;
            dateAndTimeLbl.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateAndTimeLbl.ForeColor = Color.FromArgb(39, 55, 77);
            dateAndTimeLbl.Location = new Point(346, 9);
            dateAndTimeLbl.Name = "dateAndTimeLbl";
            dateAndTimeLbl.Size = new Size(60, 28);
            dateAndTimeLbl.TabIndex = 1;
            dateAndTimeLbl.Text = "date";
            // 
            // userControlAddStudent1
            // 
            userControlAddStudent1.BackColor = Color.FromArgb(221, 230, 237);
            userControlAddStudent1.Dock = DockStyle.Fill;
            userControlAddStudent1.Location = new Point(298, 135);
            userControlAddStudent1.Name = "userControlAddStudent1";
            userControlAddStudent1.Size = new Size(902, 585);
            userControlAddStudent1.TabIndex = 4;
            userControlAddStudent1.Visible = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(298, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 135);
            panel1.TabIndex = 0;
            // 
            // adminTeachercrud
            // 
            adminTeachercrud.BackColor = Color.White;
            adminTeachercrud.Dock = DockStyle.Fill;
            adminTeachercrud.Font = new Font("Century Gothic", 12F);
            adminTeachercrud.Location = new Point(298, 135);
            adminTeachercrud.Margin = new Padding(0);
            adminTeachercrud.Name = "adminTeachercrud";
            adminTeachercrud.Size = new Size(902, 585);
            adminTeachercrud.TabIndex = 4;
            adminTeachercrud.Visible = false;
            // 
            // adminMainDashboard1
            // 
            adminMainDashboard1.BackColor = Color.FromArgb(221, 230, 237);
            adminMainDashboard1.Dock = DockStyle.Fill;
            adminMainDashboard1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMainDashboard1.Location = new Point(298, 135);
            adminMainDashboard1.Name = "adminMainDashboard1";
            adminMainDashboard1.Size = new Size(902, 585);
            adminMainDashboard1.TabIndex = 5;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.FromArgb(221, 230, 237);
            welcomeLabel.Location = new Point(50, 28);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(132, 28);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "Welcome, ";
            // 
            // adminName
            // 
            adminName.AutoSize = true;
            adminName.BackColor = Color.Transparent;
            adminName.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminName.ForeColor = Color.FromArgb(221, 230, 237);
            adminName.Location = new Point(176, 28);
            adminName.Name = "adminName";
            adminName.Size = new Size(132, 28);
            adminName.TabIndex = 3;
            adminName.Text = "Welcome, ";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            Controls.Add(adminMainDashboard1);
            Controls.Add(userControlAddStudent1);
            Controls.Add(adminTeachercrud);
            Controls.Add(navbar);
            Controls.Add(logout);
            Controls.Add(minimize);
            Controls.Add(dateAndTimeLbl);
            Controls.Add(panel1);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Admin_Load;
            sidebar.ResumeLayout(false);
            sidebarHoverContainer.ResumeLayout(false);
            sidebarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminLogo).EndInit();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebar;
        private Panel sidebarHeader;
        private PictureBox adminLogo;
        private Panel navbar;
        private PictureBox minimize;
        private PictureBox logout;
        private Panel sidebarHoverContainer;
        private Button dashboardBtn;
        private Panel sidebarHover;
        private Button attendanceBtn;
        private Button addTeacherBtn;
        private Button reports;
        private Button addClassBtn;
        private Button addStudentBtn;
        private System.Windows.Forms.Timer dateAndTime;
        private Label dateAndTimeLbl;
        private UserControlAddStudent userControlAddStudent1;
        private AdminTeacherCRUD adminTeacherCRUD;
        private Panel panel1;
        private AdminTeacherCRUD adminTeachercrud;
        private AdminMainDashboard adminMainDashboard1;
        private Label welcomeLabel;
        public Label adminName;
    }
}