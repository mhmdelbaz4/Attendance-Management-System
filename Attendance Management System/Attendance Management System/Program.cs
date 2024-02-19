using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;

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
        Application.Run(new Studentff());
        /*var studentList = StudentsRepo.GetStudents(@"C:\Users\T.B\Desktop\attendance repo\Attendance-Management-System\xmlf\attendance.xml");

        // Example: Displaying a specific student's data in the DataGridView
        int studentId = 1; // Example student ID
        Student student = StudentsRepo.getStudentByID(studentId, studentList);
        Console.WriteLine(student);*/
    }
}