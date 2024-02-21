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
             errorMsg.Visible = false;

            // validate the input fields
            if (string.IsNullOrEmpty(StudentNameInput.Text) || string.IsNullOrEmpty(emailInput.Text) ||
                 string.IsNullOrEmpty(passwordInput.Text) ||
                  trackComboBox.SelectedIndex == -1)

            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // add student to students inside users inside root (xml)
                string name = StudentNameInput.Text;
                string password = passwordInput.Text;
                string email = emailInput.Text;
                string track = trackComboBox.SelectedItem.ToString();
                // create unique id for the student based on time and date + random number + machine name
                string id = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999) + Environment.MachineName;

                //validate email regex (@gmail.com) errorMsg

                if (!email.Contains("@gmail.com"))
                {
                    //using messagebox to show error message
                    MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //validate password length
                if (password.Length < 8)
                {
                    
                    MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (name.Length < 3)
                {
                    
                    MessageBox.Show("Name must be at least 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (trackComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a track", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // add student to students inside users inside root (xml)

                //get students node
                XmlDocument doc = XMLControl.ReadAllDocument();
                XmlNode? students = doc.SelectSingleNode("//students");

                // create student node
                XmlNode student = doc.CreateElement("student");

                // create id node
                XmlNode idNode = doc.CreateElement("id");
                idNode.InnerText = id;
                student.AppendChild(idNode);

                // create name node
                XmlNode nameNode = doc.CreateElement("name");
                nameNode.InnerText = name;
                student.AppendChild(nameNode);

                // create password node
                XmlNode passwordNode = doc.CreateElement("password");
                passwordNode.InnerText = password;
                student.AppendChild(passwordNode);

                // create email node
                XmlNode emailNode = doc.CreateElement("email");
                emailNode.InnerText = email;
                student.AppendChild(emailNode);

                // create track node
                XmlNode trackNode = doc.CreateElement("track");
                trackNode.InnerText = track;
                student.AppendChild(trackNode);

                //create attendance node
                XmlNode attendanceNode = doc.CreateElement("attendance");
                student.AppendChild(attendanceNode);

                students?.AppendChild(student);

                // save the document
                doc.Save(XMLControl.GetXMLPath());

                // show success message
                MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear the input fields
                StudentNameInput.Text = "";
                passwordInput.Text = "";
                emailInput.Text = "";
                trackComboBox.SelectedIndex = -1;


            }

        }

      
    }
}
