﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            dateAndTime.Start();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.TopMost = true; // this will set it on top of everything, including the taskbar
            this.FormBorderStyle = FormBorderStyle.None; // remove the title bar
            this.WindowState = FormWindowState.Maximized; // maximize it to fill the entire screen.
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }

        }

        private void minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void dateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateAndTimeLbl.Text = now.ToString("F");
        }

        private void moveSideBarPanel(Control btn)
        {
            sidebarHover.Location = new Point(btn.Location.X - btn.Location.X, btn.Location.Y - 162);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(dashboardBtn);
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(attendanceBtn);
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addTeacherBtn);
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addStudentBtn);
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addClassBtn);
        }

        private void reports_Click(object sender, EventArgs e)
        {
            moveSideBarPanel( reports);
        }
    }
}
