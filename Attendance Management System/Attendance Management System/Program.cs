using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Admin = Attendance_Management_System.Forms.AdminForm;
using Teacher = Attendance_Management_System.Forms.Teacher;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Admin());

    }
}