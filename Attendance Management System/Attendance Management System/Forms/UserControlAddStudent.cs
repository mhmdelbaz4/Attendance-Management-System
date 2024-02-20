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
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Forms
{
    public partial class UserControlAddStudent : UserControl
    {
        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            // validate the input fields
            if (string.IsNullOrEmpty(StudentNameInput.Text) || string.IsNullOrEmpty(studentPasswordInput.Text) ||
                 string.IsNullOrEmpty(StudentEmailInput.Text) ||
                  trackComboBox.SelectedIndex == -1 )

            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               // add student to students inside users inside root (xml)
                string name = StudentNameInput.Text;
                string password = studentPasswordInput.Text;
                string email = StudentEmailInput.Text;
                string track = trackComboBox.SelectedItem.ToString();
                // create unique id for the student based on time and date + random number + machine name
                string id = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999) + Environment.MachineName;



                // add student to students inside users inside root (xml)

                //get students node
                 XmlDocument doc = 
                 XMLControl.ReadAllDocument();

            }   
          
        }
    }
}
