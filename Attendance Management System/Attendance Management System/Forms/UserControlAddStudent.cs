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
                string name = StudentNameInput.Text.Trim().ToLower();
                string password = passwordInput.Text.Trim();
                string email = emailInput.Text.Trim().ToLower();
                string track = trackComboBox.SelectedItem.ToString().Trim().ToLower();
                // create unique id for the student based on time and date + random number + machine name
                string id = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999);

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
                XmlNode trackNode = doc.CreateElement("trackName");
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

        private void handleIndexChange(object sender, EventArgs e)
        {
            //if selected is second tab then reload students from xml to display in the datagridview

            Console.WriteLine(tabStudent.SelectedIndex);
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
            string searchValue = searchInput.Text.Trim().ToLower();

            // get the search by value
            string searchBy = searchByComboBox.SelectedItem.ToString();

            if (searchBy == "track")
            {
                searchBy = "trackName";
                searchValue = searchValue.ToUpper();
            }

            // get students from xml based on the search value and search by
            XmlNodeList students = XMLControl.GetMultipleNodes($"//students/student[contains({searchBy},'{searchValue}')]");

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
            TrackEditComboBox.SelectedItem = track;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == "") return;

            // get the values from the input fields
            string name = nameEditInput.Text.Trim().ToLower();
            string email = emailEditInputt.Text.Trim().ToLower();
            string track = TrackEditComboBox.SelectedItem.ToString().ToLower();
            string password = passwordEditInput.Text.Trim();

            // validate the input fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                track == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //read the xml
                XmlDocument doc = XMLControl.ReadAllDocument();

                // get the student node from the xml
                XmlNode? student = doc.SelectSingleNode($"//students/student[id='{selectedStudentId}']");

                if (student != null)
                {
                    // update the values
                    student.SelectSingleNode("name").InnerText = name;
                    student.SelectSingleNode("email").InnerText = email;
                    student.SelectSingleNode("trackName").InnerText = track;
                    student.SelectSingleNode("password").InnerText = password;

                    // save the document
                    doc.Save(XMLControl.GetXMLPath());


                    // show success message
                    MessageBox.Show("Student updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear the input fields
                    nameEditInput.Text = "";
                    emailEditInputt.Text = "";
                    passwordEditInput.Text = "";
                    TrackEditComboBox.SelectedIndex = -1;
                    tabStudent.SelectedIndex = 1;

                }
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
                    tabStudent.SelectedIndex = 1;
                }
            }
        }
    }
}

