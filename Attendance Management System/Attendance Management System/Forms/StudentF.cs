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
            var studentList = StudentsRepo.GetStudents(@"../../../../attendance.xml");

         
                int studentId = 30; // Example student ID
                Student student = StudentsRepo.getStudentByID(studentId, studentList);
            

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
                dataGridView1.Rows.Add("Student not found.", "", "", "", "", "");

                /* MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 using (Form messageForm = new Form())
                 {
                     messageForm.Size = new Size(400, 200);
                     messageForm.StartPosition = FormStartPosition.CenterScreen;
                     Label label = new Label();
                     label.Text = "Student not found.";
                     label.Location = new Point(20, 20);
                     messageForm.Controls.Add(label);
                     messageForm.ShowDialog();
                 }
                 this.Close();*/
                // Clear existing rows
                dataGridView1.Visible = false;

                // Show a message or perform any other actions as needed
                labelNotFound.Visible = true;

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

       
    }
}

