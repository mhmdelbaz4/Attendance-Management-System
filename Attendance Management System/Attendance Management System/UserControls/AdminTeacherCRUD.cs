using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using Teacher = Attendance_Management_System.Models.Teacher;


namespace Attendance_Management_System.UserControls
{
    public partial class AdminTeacherCRUD : UserControl
    {
        public AdminTeacherCRUD()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string msg;

            string name = nametextBox.Text;
            if(! Validations.isValidUserName(name,out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string email = EmailtextBox.Text;
            if(! Validations.IsValidEmail(email,out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string password = passwordTextBox.Text;
            if(! Validations.IsValidPassword(password,out msg))
            {
                validationLabel.Text=msg;
                validationLabel.Visible = true;
                return;
            }

            string MobileNo = MobileNomaskedTextBox.Text;
            if(! Validations.IsValidMobileNo(MobileNo,out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string hiringdate = HiringDateDateTimePicker.Text;
            if(! Validations.isValidHiringDate(hiringdate ,out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string BithDate = BirthDateDateTimePicker.Text;
            if (!Validations.isValidTeacherBirthDate(hiringdate, out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }

            string salary = SalarytextBox.Text;
            if(! Validations.isValidSalary(salary,out msg))
            {
                validationLabel.Text = msg;
                validationLabel.Visible = true;
                return;
            }


            Teacher teacher = new Teacher()
            {
                Name = name,
                Email = email,
                Password = password,
                MobileNumber = MobileNo,
                Salary = int.Parse(salary),
                BirthDate = Convert.ToDateTime(BithDate),
                HiringDate = Convert.ToDateTime(hiringdate)
            };
        }
    }
}
