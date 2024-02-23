﻿using System.Globalization;
 using System.Xml;
using Attendance_Management_System.Repos;
using Attendance_Management_System.Models;

namespace Attendance_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string? email = emailInput.Text;
            string? password = passwordInput.Text;

            if (String.IsNullOrWhiteSpace(email))
            {
                errorMsg.Text = "Email is required";
                errorMsg.Visible = true;
                return;
            }

            XmlNode? userNode = XMLControl.GetNode("//*", "email", email);

            if (userNode == null)
            {
                errorMsg.Text = "Email is not registered";
                errorMsg.Visible = true;
                return;
            }
            else
            {
                if (userNode.SelectSingleNode("password").InnerText != password)
                {
                    errorMsg.Text = "Password is incorrect";
                    errorMsg.Visible = true;
                    return;
                }

                //get user data from xml
                int id = int.Parse(userNode.SelectSingleNode("id").InnerText);
                string name = userNode.SelectSingleNode("name").InnerText;

                //convert birthdate from string to dateOnly and store it in birthDate DateTime object
                // 15-4-2020 to DateTime object 
                //string was not in the correct format
                //DateTime birthDate = DateTime.ParseExact(userNode.SelectSingleNode("birthDate").InnerText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                //string birthdateString = "15-4-2020";
                //DateTime birthDate = DateTime.ParseExact(birthdateString, "dd-MM-yyyy", null);
                //Console.WriteLine(birthDate);




                string mobileNumber = userNode.SelectSingleNode("mobileNo").InnerText;



                if (userNode.Name == "student")
                {
                    // create student form
                    StudentF studentForm = new Forms.StudentF();
                    // get student track name
                    string trackName = userNode.SelectSingleNode("trackName").InnerText;
                    // create student object
                    Session.currentUser = new Student(){ ID = id, Name = name, Email = email, Password = password,MobileNumber = mobileNumber, TrackName = trackName };
                    // set session details
                    Session.currentUserRole = "student";
                    // set login time
                    Session.loginTime = DateTime.Now;
                    // show student form
                    studentForm.Show();
                    // hide login form
                    this.Hide();


                }
                else if (userNode.Name == "teacher")
                {
                    // create teacher form
                    Teacher teacherForm = new Forms.Teacher();
                    // create teacher object
                    Session.currentUser = new Models.Teacher() { ID = id, Name = name, Email = email, Password = password, MobileNumber = mobileNumber };
                    // set session details
                    Session.currentUserRole = "teacher";
                    // set login time
                    Session.loginTime = DateTime.Now;
                    // show teacher form
                    teacherForm.Show();
                    // hide login form
                    this.Hide();

                }
                else if (userNode.Name == "admin")
                {
                    // create admin form
                    AdminForm adminForm = new AdminForm();

                    // create admin object
                    Session.currentUser = new Models.Admin() { ID = id, Name = name, Email = email, Password = password, MobileNumber = mobileNumber };

                    // set session details
                    Session.currentUserRole = "admin";
                    Session.loginTime = DateTime.Now;

                    // show admin form
                    adminForm.Show();
                    // hide login form
                    this.Hide();
                }


            }


        }




        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //opened / closed eye
            //check if password is visible
            if (passwordInput.PasswordChar == '*')
            {
                passwordInput.PasswordChar = '\0';
                showPasswordBtn.Image = Image.FromFile(@"../../../../assets/icons8-eye-50.png");
            }
            else
            {
                passwordInput.PasswordChar = '*';
                showPasswordBtn.Image = Image.FromFile(@"../../../../assets/icons8-closed-eye-50.png");

            }

        }


    }
}
