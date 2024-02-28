using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using System.Xml;
using Teacher = Attendance_Management_System.Models.Teacher;

namespace Attendance_Management_System.UserControls
{
    public partial class AdminTeacherCRUD : UserControl
    {
        public AdminTeacherCRUD()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string msg;
            validationLabel.ForeColor = Color.Red;
            string name = nametextBox.Text;
            if (!Validations.isValidUserName(name, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string email = EmailtextBox.Text;
            if (!Validations.IsValidEmail(email, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string password = passwordTextBox.Text;
            if (!Validations.IsValidPassword(password, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string MobileNo = MobileNomaskedTextBox.Text.Trim();
            if (!Validations.IsValidMobileNo(MobileNo, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string hiringdate = HiringDateDateTimePicker.Text;
            if (!Validations.isValidHiringDate(hiringdate, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string BithDate = BirthDateDateTimePicker.Text;
            if (!Validations.isValidTeacherBirthDate(BithDate, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string salary = SalarytextBox.Text;
            if (!Validations.isValidSalary(salary, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }


            Teacher teacher = new Teacher()
            {
                ID = UsersRepo.GenerateID(),
                Name = name,
                Email = email,
                Password = password,
                MobileNumber = MobileNo,
                Salary = int.Parse(salary),
                BirthDate = Convert.ToDateTime(BithDate),
                HiringDate = Convert.ToDateTime(hiringdate)
            };

            TeachersRepo.AddTeacher(teacher);
            validationLabel.Text = "Added Successfully.";
            validationLabel.ForeColor = Color.Green;
            validationLabel.Visible = true;
        }

        private void AdminTeacherCRUD_Load(object sender, EventArgs e)
        {

        }

        private void handleIndexChange(object sender, EventArgs e)
        {
            //if selected is second tab then reload students from xml to display in the datagridview

            //Console.WriteLine(AdminTeacherCRUDTab.SelectedIndex);
            //if (AdminTeacherCRUDTab.SelectedIndex == 0)
            //{
            //    //if there are tracks in the combobox then set the selected index to 0
            //    if (trackComboBox.Items.Count > 0)
            //    {
            //        trackComboBox.SelectedIndex = 0;
            //    }
            //}

            if (AdminTeacherCRUDTab.SelectedIndex == 1)
            {
                searchByComboBox.SelectedIndex = 0;

                //XmlNodeList students = XMLControl.GetMultipleNodes("//students/student");

                //dataGridStudent.Rows.Clear();
                //foreach (XmlNode student in students)
                //{
                //    string id = student.SelectSingleNode("id").InnerText;
                //    string name = student.SelectSingleNode("name").InnerText;
                //    string email = student.SelectSingleNode("email").InnerText;
                //    string track = student.SelectSingleNode("mobileNo").InnerText;
                //    dataGridStudent.Rows.Add(id, name, email, track);
                //}

                IEnumerable<Teacher> teachers =TeachersRepo.GetTeachers(null,null);
                dataGridTeachers.Rows.Clear();
                foreach (Teacher teacher in teachers)
                {
                    dataGridTeachers.Rows.Add(teacher.ID, teacher.Name, teacher.Email);
                }

            }

            //if (AdminTeacherCRUDTab.SelectedIndex == 2)
            //{
            //    // if there are tracks in the combobox then set the selected index to 0
            //    if (TrackEditComboBox.Items.Count > 0)
            //    {
            //        TrackEditComboBox.SelectedIndex = 0;
            //    }
            //}
        }


        private void search(object sender, EventArgs e)
        {
            string searchValue = SearchtextBox.Text.Trim().ToLower();
            string searchBy = searchByComboBox.SelectedItem.ToString();

            if (searchBy == "track")
            {
                searchBy = "trackName";
                searchValue = searchValue.ToUpper();
            }


            //XmlNodeList students = XMLControl.GetMultipleNodes($"//teachers/teacher[contains({searchBy},'{searchValue}')]");
            
            dataGridTeachers.Rows.Clear();
            IEnumerable<Teacher> teachers = TeachersRepo.GetTeachers(searchBy, searchValue);
            foreach (Teacher teacher in teachers)
            {
                dataGridTeachers.Rows.Add(teacher.ID, teacher.Name, teacher.Email);
            }
        }


    }
}
