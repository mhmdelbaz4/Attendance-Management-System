using Attendance_Management_System.Repos;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Attendance_Management_System.UserControls
{
    public partial class AdminMarkAttendance : UserControl
    {

        List<string> tracksNames;
        List<(string, string)> trackTeachers;
        bool initialized;
        public AdminMarkAttendance()
        {
            InitializeComponent();
            initialized = false;

            tracksNames = TracksRepo.GetTrackNames();
            trackTeachers = TracksRepo.GetTrackTeachers(tracksNames.ToArray()[0]);
            
            InitializeAdminMarkAttendanceUserControl();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }


        public void InitializeAdminMarkAttendanceUserControl()
        {
            TrackComboBox.Items.AddRange(tracksNames.ToArray());
            TrackComboBox.SelectedIndex = 0;
            
            populateTeacherComboBox(trackTeachers);

            initialized = true;
            AttendanceDateTimePicker.Value = DateTime.Now.Date;
        }

        public void populateAttendanceGridView(string date, string trackName, string teacherId)
        {
            if(!initialized)
            {
                List<(string, string, bool)> StudentsInfo = TracksRepo.getTrackAttendance(date, trackName, teacherId);

                AttendanceDataGridView.Rows.Clear();

                foreach (var (studentID, studentName, status) in StudentsInfo)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = studentID }); // Student ID
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = studentName }); // Student Name

                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = status; // Set checkbox value based on status
                    row.Cells.Add(checkBoxCell);

                    AttendanceDataGridView.Rows.Add(row);
                }

            }
        }

        private void populateTeacherComboBox(List<(string, string)> trackTeachers)
        {
            foreach ((string id, string name) in trackTeachers)
            {
                TeacherComboBox.Items.Add(new KeyValuePair<string, string>(name, id));
            }
            TeacherComboBox.DisplayMember = "Key";
            TeacherComboBox.ValueMember = "Value";
            TeacherComboBox.SelectedIndex = 0;
        }

        private void getAttendance(object sender, EventArgs e)
        {
         
            string date = AttendanceDateTimePicker.Value.ToString("yyyy-MM-dd");
            string trackName = TrackComboBox.SelectedItem.ToString();
        
            //Console.WriteLine(trackName);
            string teacherID = ((KeyValuePair<string,string>)TeacherComboBox.SelectedItem).Key;
            Console.WriteLine(teacherID);

            populateAttendanceGridView(date, trackName, teacherID);
            Console.WriteLine("Hello World!");



        }
    }
}
