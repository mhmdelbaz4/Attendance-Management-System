using Attendance_Management_System.Models;
using Attendance_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            hideAllAdminControls();
            dateAndTime.Start();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //this.TopMost = true; // this will set it on top of everything, including the taskbar
            this.FormBorderStyle = FormBorderStyle.None; // remove the title bar
            this.WindowState = FormWindowState.Maximized; // maximize it to fill the entire screen.
            hideAllAdminControls();// hide all the admin controls
            adminMainDashboard1.Visible = true;// show the main dashboard
            setDashboardNumbers();// set the dashboard numbers
            adminName.Text = Session.currentUser?.Name;


        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
                dateAndTime.Stop();
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
            hideAllAdminControls();
            setDashboardNumbers();
            adminMainDashboard1.Visible = true;

        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(attendanceBtn);
            hideAllAdminControls();
            adminMarkAttendance.Visible = true;
        }

        private void TeacherBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addTeacherBtn);
            hideAllAdminControls();
            adminTeachercrud.Visible = true;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addStudentBtn);
            hideAllAdminControls();
            userControlAddStudent1.Visible = true;
            //reset the track combobox for add student and edit student
            userControlAddStudent1.trackComboBox.Items.Clear();
            userControlAddStudent1.TrackEditComboBox.Items.Clear();

            //get the tracks from the xml file
            XmlNodeList tracks = XMLControl.GetMultipleNodes("//tracks/track/name");
            foreach (XmlNode track in tracks)
            {
                userControlAddStudent1.trackComboBox.Items.Add(track.InnerText);
                userControlAddStudent1.TrackEditComboBox.Items.Add(track.InnerText);
            }

            if (userControlAddStudent1.trackComboBox.Items.Count > 0)
            {
                userControlAddStudent1.trackComboBox.SelectedIndex = 0;
                userControlAddStudent1.TrackEditComboBox.SelectedIndex = 0;
            }
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(addClassBtn);
            hideAllAdminControls();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            moveSideBarPanel(reports);
            hideAllAdminControls();
        }


        // add admin controls here
        private void hideAllAdminControls()
        {
            adminTeachercrud.Visible = false;
            adminMainDashboard1.Visible = false;
            userControlAddStudent1.Visible = false;
            adminMarkAttendance.Visible = false;    
        }


        // set dashboard numbers
        private void setDashboardNumbers()
        {
            // load the dashboard data
            //get the total number of students
            int totalStudents = XMLControl.GetMultipleNodes("//students/student").Count;
            adminMainDashboard1.noStudents.Text = totalStudents.ToString();

            //get the total number of teachers
            int totalTeachers = XMLControl.GetMultipleNodes("//teachers/teacher").Count;
            adminMainDashboard1.noTeachers.Text = totalTeachers.ToString();

            //get the total number of tracks
            int totalTracks = XMLControl.GetMultipleNodes("//tracks/track").Count;
            adminMainDashboard1.noClasses.Text = totalTracks.ToString();
        }
       

   
    }
}
