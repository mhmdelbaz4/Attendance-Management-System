﻿using System.Xml;
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

                //create user (admin, teacher, student) object depending on the role node name

                if (userNode.Name == "student")
                {
                    // create student form
                    Student student = new Student();
                    student.Show();
                    this.Hide();


                }
                else if (userNode.Name == "teacher")
                {
                    // Login teacher
                    Teacher teacher = new Teacher();
                    teacher.Show();
                    this.Hide();

                }
                else if (userNode.Name == "admin")
                {
                    // Login admin
                    Admin admin = new Admin();
                    admin.Show();
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
