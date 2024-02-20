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
    public partial class Studentff : Form
    {
        public Studentff()
        {
            InitializeComponent();
        }

        private void Studentff_Load(object sender, EventArgs e)
        {

            var studentList = StudentsRepo.GetStudents(@"C:\Users\T.B\Desktop\attendance repo\Attendance-Management-System\xmlf\attendance.xml");
            int studentId = 1; // Example student ID
            Student student = StudentsRepo.getStudentByID(studentId, studentList);
            // this is   a way for listbox in lecture
            /* listBox1.Items.Add(new Student() { Name = "amira", ID = 1});
              listBox1.Items.Add(new Student() { Name = "ali", ID = 2 });
              listBox1.Items.Add(new Student() { Name = "mohamed", ID = 3 });
              listBox1.Items.Add(new Student() { Name = "hgf", ID = 4 });*/
            if (student != null)
            {

                //  listBox1.Items.Add(student);: calling listBox1
                //Bind student data to the DataGridView
                /* dataGridView1.DataSource = new List<Student> { student };// this way doesnt display the AttendaceHistory as it list
                in student , it displays all elemnts except stateDate,TeacherID*/
                // in dataGridView1.DataSource = new List<Student>: i dont  add any columns , this way make everything
                // so i used this way :
                //first i added column to grid
                foreach (var attendanceItem in student.AttendaceHistory)
                {
                    // Add a row for each attendance dataGridView1
                    // then i add values to rows
                    dataGridView1.Rows.Add(student.ID, student.Name, student.TrackName, attendanceItem.TeacherID, attendanceItem.Date, attendanceItem.State);
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
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

