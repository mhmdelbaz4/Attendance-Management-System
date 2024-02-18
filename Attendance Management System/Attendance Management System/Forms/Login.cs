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
                emailMsgLBL.Text = "Email is required";
                emailMsgLBL.Visible = false;
                emailMsgLBL.Text = "";
                return;
            }
            int index = UsersRepo.CheckUserCredentials(email, password);

            emailMsgLBL.Text = index.ToString();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
