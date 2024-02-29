using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            //InitializeAttendance();
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

        public void InitializeAttendance()
        {
            AttendanceDateTimePicker.Value = DateTime.Now.Date;

            tracksComboBox.Items.AddRange(TracksRepo.GetTrackNames().ToArray());
            tracksComboBox.SelectedItem = TracksRepo.GetTrackNames().ToArray()[0];

            List<(string, string, string)> result = new List<(string, string, string)>();

            //TracksRepo.getTrackAttendance(DateTime.Now.Date.ToString("yyyy-MM-dd"), TracksRepo.GetTrackNames().ToArray()[0], Session.currentUser.ID.ToString());
            //fillDataGridView(result);

        }


        public void fillDataGridView(List<Tuple<string,string,string>> result)
        {
            foreach (var attendance in result)
            {
                // Create a new row
                DataGridViewRow row = new DataGridViewRow();

                // Add cells to the row
                row.Cells.Add(new DataGridViewTextBoxCell { Value = attendance.Item1 });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = attendance.Item2 });

                // Create a checkbox cell for attendance status
                DataGridViewCheckBoxCell checkboxCell = new DataGridViewCheckBoxCell();

                checkboxCell.Value = attendance.Item3 == "attendant";
                row.Cells.Add(checkboxCell);

                // Add the row to the DataGridView
                AttendancedataGridView.Rows.Add(row);
            }
        }

        private void listen()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateAndTimeLbl.Text = now.ToString("f");
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {

        }

        private void controlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClassesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
