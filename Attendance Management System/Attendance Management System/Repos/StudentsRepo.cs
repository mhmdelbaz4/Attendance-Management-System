
//using Attendance_Management_System.Forms;
//using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Attendance_Management_System.Repos;

public static class StudentsRepo
{
    //private static string path;
    //private static XmlReader xmlReader;
    static StudentsRepo()
    {
        // path = @"C:\Users\T.B\Desktop\c# pathes\Attendance-Management-System\Attendance Management System\attendance.xml";
        //xmlReader = XmlReader.Create(path);
    }
    public static List<Student> GetStudents(string path)
    {
        var students = new List<Student>();

        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load(path);

        // Get all student nodes
        XmlNodeList studentList = doc.SelectNodes("//students/student");
        MessageBox.Show((studentList.Count).ToString());

        // Iterate through each student
        foreach (XmlNode studentNode in studentList)
        {
            Student s1 = new Student()
            {
                // int.Parse(studentNode.SelectSingleNode("id").InnerText)
                //ID = int.Parse(studentNode.SelectSingleNode("id").InnerText),
                ID = int.Parse(studentNode.SelectSingleNode("id").InnerText),
                Name = studentNode.SelectSingleNode("name").InnerText,
                Email = studentNode.SelectSingleNode("email").InnerText,
                Password = studentNode.SelectSingleNode("password").InnerText,
                BirthDate = DateOnly.ParseExact(studentNode.SelectSingleNode("birthDate").InnerText, "yyyy-MM-dd", null), // Parsing using specific format
                MobileNumber = studentNode.SelectSingleNode("mobileNo").InnerText,
                TrackName = studentNode.SelectSingleNode("trackName").InnerText,

            };

            s1.AttendaceHistory = new List<AttendanceItem>();
            // Get attendance information
            XmlNodeList attendanceList = studentNode.SelectNodes("attendance/item");
            foreach (XmlNode attendanceNode in attendanceList)
            {
                AttendanceItem attendance = new AttendanceItem()
                {
                    TeacherID = int.Parse(attendanceNode.SelectSingleNode("teacherID").InnerText),
                    Date = DateOnly.Parse(attendanceNode.SelectSingleNode("date").InnerText),
                    State = (AttendanceState)Enum.Parse(typeof(AttendanceState), attendanceNode.SelectSingleNode("state").InnerText, ignoreCase: true)


                };
                s1.AttendaceHistory.Add(attendance);
            }//end of second foreach
            students.Add(s1);

        }

        return students;
    }
    public static Student getStudentByID(int id, List<Student> studentList)
    {
        foreach (Student student in studentList)
        {
            if (student.ID == id)
            {
                MessageBox.Show(student.ID.ToString());
                return student;
            }
        }
        return null;
    }
}
