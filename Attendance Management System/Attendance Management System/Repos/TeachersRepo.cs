using System.Xml;

namespace Attendance_Management_System.Repos;

public class TeachersRepo
{
    private static string path;
    private static XmlReader xmlReader;
    
    static TeachersRepo()
    {
        path = @"D:\ITI\Projects\Attendance-Management-System\Attendance Management System\attendance.xml";
        xmlReader = XmlReader.Create(path);
    }
}
