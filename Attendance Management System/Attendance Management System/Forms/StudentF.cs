using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.Models;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Attendance_Management_System.Repos;

namespace Attendance_Management_System.Forms
{
    public partial class StudentF : Form
    {
        public StudentF()
        {
            InitializeComponent();
        }
        private void Studentff_Load(object sender, EventArgs e)
        {


            // Load student list from XML file
            var studentList = StudentsRepo.GetStudents(@"../../../../../xml/attendance.xml");

            // Get the ID of the logged-in student
            int studentId = Session.currentUser.ID;

            // Find the logged-in student in the list
            Student student = StudentsRepo.getStudentByID(studentId, studentList);

            // Check if the student exists
            if (student != null)
            {
                // Bind student data to the DataGridView
                foreach (var attendanceItem in student.AttendaceHistory)
                {
                    dataGridView1.Rows.Add(student.ID, student.Name, student.TrackName, attendanceItem.TeacherID, attendanceItem.Date, attendanceItem.State);
                  
                }
            }
            else
            {
                // If the student is not found, clear existing rows and display a message
                dataGridView1.Visible = false;
              
                MessageBox.Show("not found");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNotFound_Click(object sender, EventArgs e)
        {

        }
    }
}

