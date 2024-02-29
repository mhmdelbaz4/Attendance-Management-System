﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
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
            string msg;


            // validate the input fields
            if (string.IsNullOrEmpty(StudentNameInput.Text) || string.IsNullOrEmpty(emailInput.Text) ||
                 string.IsNullOrEmpty(passwordInput.Text) ||
                  trackComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(BirthDateDateTimePicker.Text) || string.IsNullOrEmpty(MobileNomaskedTextBox.Text))

            {
                errorMsg.Text = "Please fill all the fields";
                errorMsg.Visible = true;
                return;
            }

            // add student to students inside users inside root (xml)
            string name = StudentNameInput.Text.Trim().ToLower();
            string password = passwordInput.Text.Trim();
            string email = emailInput.Text.Trim().ToLower();
            string track = trackComboBox.SelectedItem.ToString().Trim();
            string birthDate = BirthDateDateTimePicker.Text;
            string MobileNo = MobileNomaskedTextBox.Text.Trim();

            // create unique id for the student based on time and date + random number 
            string id = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999);





            if (!Validations.IsValidEmail(email, out msg))
            {
                errorMsg.Text = msg;
                errorMsg.Visible = true;
                return;
            }

            //validate password length
            if (!Validations.IsValidPassword(password, out msg))
            {
                errorMsg.Text = msg;
                errorMsg.Visible = true;
                return;
            }


            if (!Validations.isValidUserName(name, out msg))
            {
                errorMsg.Text = msg;
                errorMsg.Visible = true;
                return;
            }


            if (trackComboBox.SelectedIndex == -1)
            {

                errorMsg.Text = "Please select a track";
                errorMsg.Visible = true;
                return;

            }



            if (!Validations.isValidStudentBirthDate(birthDate, out msg))
            {
                errorMsg.Text = msg;
                errorMsg.Visible = true;
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
            XmlNode trackNode = doc.CreateElement("trackName");
            trackNode.InnerText = track;
            student.AppendChild(trackNode);

            // create birthDate node ("yyyy-MM-dd")
            XmlNode birthDateNode = doc.CreateElement("birthDate");
            birthDateNode.InnerText = Convert.ToDateTime(birthDate).ToString("yyyy-MM-dd");
            student.AppendChild(birthDateNode);

            // create mobileNo node
            XmlNode mobileNoNode = doc.CreateElement("mobileNo");
            mobileNoNode.InnerText = MobileNo;
            student.AppendChild(mobileNoNode);



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
            Mobilelabel.Text = "";
            trackComboBox.SelectedIndex = -1;
        }

        private void handleIndexChange(object sender, EventArgs e)
        {
            //if selected is second tab then reload students from xml to display in the datagridview

            if (tabStudent.SelectedIndex == 0)
            {
                //if there are tracks in the combobox then set the selected index to 0
                if (trackComboBox.Items.Count > 0)
                {
                    trackComboBox.SelectedIndex = 0;
                }
            }

            if (tabStudent.SelectedIndex == 1)
            {
                // set default search by id
                searchByComboBox.SelectedIndex = 0;

                //get students from xml
                XmlNodeList students = XMLControl.GetMultipleNodes("//students/student");
                //clear the datagridview
                dataGridStudent.Rows.Clear();
                //add students to the datagridview
                foreach (XmlNode student in students)
                {
                    string id = student.SelectSingleNode("id").InnerText;
                    string name = student.SelectSingleNode("name").InnerText;
                    string email = student.SelectSingleNode("email").InnerText;
                    string track = student.SelectSingleNode("trackName").InnerText;
                    dataGridStudent.Rows.Add(id, name, email, track);
                }
            }

            if (tabStudent.SelectedIndex == 2)
            {
                //check if there is student selected
                if (selectedStudentId == "")
                {
                    MessageBox.Show("Please select a student to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabStudent.SelectedIndex = 1;
                }
                // if there are tracks in the combobox then set the selected index to 0
                if (TrackEditComboBox.Items.Count > 0)
                {
                    TrackEditComboBox.SelectedIndex = 0;
                }
            }
        }

        private void search(object sender, EventArgs e)
        {
            // get the search value
            string searchValue = searchInput.Text.Trim();

            // get the search by value
            string searchBy = searchByComboBox.SelectedItem.ToString();

            if (searchBy == "track")
            {
                searchBy = "trackName";
            }

            // get students from xml based on the search value and search by case insensitive and contains search value using translate function
            XmlNodeList students = XMLControl.GetMultipleNodes($"//students/student[contains(translate({searchBy}, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{searchValue.ToLower()}')]");

            //clear the datagridview
            dataGridStudent.Rows.Clear();

            //add students to the datagridview
            foreach (XmlNode student in students)
            {
                string id = student.SelectSingleNode("id").InnerText;
                string name = student.SelectSingleNode("name").InnerText;
                string email = student.SelectSingleNode("email").InnerText;
                string track = student.SelectSingleNode("trackName").InnerText;
                dataGridStudent.Rows.Add(id, name, email, track);
            }

        }

        private void selectStudent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridStudent.Rows[e.RowIndex];

            selectedStudentId = row.Cells[0].Value.ToString();

            // set the values to the input fields
            string name = row.Cells[1].Value.ToString();
            string email = row.Cells[2].Value.ToString();
            string track = row.Cells[3].Value.ToString();

            nameEditInput.Text = name;
            emailEditInputt.Text = email;

            //edit the track combobox by setting the selected item to the track of the student
            //get the index of the track from the combobox and set it to the selected index
            int index = TrackEditComboBox.Items.IndexOf(track);
            TrackEditComboBox.SelectedIndex = index;






            XmlDocument doc = XMLControl.ReadAllDocument();
            //get student node by id to set the password and birthdate and mobileNo
            XmlNode student = doc.SelectSingleNode($"//students/student[id='{selectedStudentId}']");
            if (student != null)
            {
                passwordEditInput.Text = student.SelectSingleNode("password").InnerText;
                maskedTextBoxMobileNoEdit.Text = student.SelectSingleNode("mobileNo").InnerText;
                // turn the birthdate to the format of the datetimepicker
                dateTimePickerEdit.Value = Convert.ToDateTime(student.SelectSingleNode("birthDate").InnerText);
            }

            // switch to the edit tab
            tabStudent.SelectedIndex = 2;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string msg;

            // hide the error message
            editErrorMsg.Visible = false;

            if (selectedStudentId == "") return;

            // get the values from the input fields
            string name = nameEditInput.Text.Trim().ToLower();
            string email = emailEditInputt.Text.Trim().ToLower();
            string track = TrackEditComboBox.SelectedItem.ToString();
            string password = passwordEditInput.Text.Trim();

            string birthDate = dateTimePickerEdit.Text;
            string MobileNo = maskedTextBoxMobileNoEdit.Text.Trim();



            // validate the input fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                track == "" || string.IsNullOrEmpty(birthDate) || string.IsNullOrEmpty(MobileNo))
            {
                editErrorMsg.Text = "Please fill all the fields";
                editErrorMsg.Visible = true;
                return;

            }



            //read the xml
            XmlDocument doc = XMLControl.ReadAllDocument();

            //check if the email is already exists
            if (!email.Equals(doc.SelectSingleNode($"//students/student[id='{selectedStudentId}']/email").InnerText))
            {
                if (!Validations.IsValidEmail(email, out msg))
                {
                    editErrorMsg.Text = msg;
                    editErrorMsg.Visible = true;
                    return;
                }
            }

            // validate password 
            if (!Validations.IsValidPassword(password, out msg))
            {
                editErrorMsg.Text = msg;
                editErrorMsg.Visible = true;
                return;
            }

            if (!Validations.isValidUserName(name, out msg))
            {
                editErrorMsg.Text = msg;
                editErrorMsg.Visible = true;
                return;
            }

            if (!Validations.isValidStudentBirthDate(birthDate, out msg))
            {
                editErrorMsg.Text = msg;
                editErrorMsg.Visible = true;
                return;
            }

            if (track == "")
            {
                editErrorMsg.Text = "Please select a track";
                editErrorMsg.Visible = true;
                return;
            }

            if (!Validations.IsValidMobileNo(MobileNo, out msg))
            {
                editErrorMsg.Text = msg;
                editErrorMsg.Visible = true;
                return;
            }



            // get the student node from the xml
            XmlNode? student = doc.SelectSingleNode($"//students/student[id='{selectedStudentId}']");

            if (student != null)
            {
                // update the values
                student.SelectSingleNode("name").InnerText = name;
                student.SelectSingleNode("email").InnerText = email;
                student.SelectSingleNode("trackName").InnerText = track;
                student.SelectSingleNode("password").InnerText = password;

                student.SelectSingleNode("birthDate").InnerText = Convert.ToDateTime(birthDate).ToString("yyyy-MM-dd");
                student.SelectSingleNode("mobileNo").InnerText = MobileNo;

                // save the document
                doc.Save(XMLControl.GetXMLPath());


                // show success message
                MessageBox.Show("Student updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear the input fields
                nameEditInput.Text = "";
                emailEditInputt.Text = "";
                passwordEditInput.Text = "";
                maskedTextBoxMobileNoEdit.Text = "";


                
                TrackEditComboBox.SelectedIndex = -1;
                tabStudent.SelectedIndex = 1;
                
                //  clear the selected student id
                selectedStudentId = "";

            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (selectedStudentId == "") return;

            if (MessageBox.Show("Are you sure you want to delete this student?", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //read the xml
                XmlDocument doc = XMLControl.ReadAllDocument();

                // get the student node from the xml
                XmlNode? student = doc.SelectSingleNode($"//students/student[id='{selectedStudentId}']");

                if (student != null)
                {
                    // remove the student node
                    student.ParentNode?.RemoveChild(student);

                    // save the document
                    doc.Save(XMLControl.GetXMLPath());

                    // show success message
                    MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear the input fields
                    nameEditInput.Text = "";
                    emailEditInputt.Text = "";
                    passwordEditInput.Text = "";
                    TrackEditComboBox.SelectedIndex = -1;

                    // switch to the search tab
                    tabStudent.SelectedIndex = 1;

                    //  clear the selected student id
                    selectedStudentId = "";
                }
            }
        }


    }
}

