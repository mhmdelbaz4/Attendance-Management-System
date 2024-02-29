using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.UserControls;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Forms
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
         // sidebarHover = new Panel(); // Initialize the sidebarHover control
        }
        public Teacher(Panel hoverpanel)
        {
            this.hoverpanel = hoverpanel;
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

        private void Teacher_Load(object sender, EventArgs e)
        {

            this.TopMost = true; // this will set it on top of everything, including the taskbar
            this.FormBorderStyle = FormBorderStyle.None; // remove the title bar
            this.WindowState = FormWindowState.Maximized; // maximize it to fill the entire screen.

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateAndTimeLbl.Text = now.ToString("f");
        }
    

        private void ReportsBtn_Click(object sender, EventArgs e)//
        {
            userControlTry1.Visible = true;
            userControlTry1.ExecuteTab();
        }

        private void controlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {

        }

        private void teacherUserControlReport1_Load(object sender, EventArgs e)
        {

        }
    }
}
