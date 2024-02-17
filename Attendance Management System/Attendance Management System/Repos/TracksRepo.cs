using System.Xml;

namespace Attendance_Management_System.Repos;

public class TracksRepo
{
    private static string path;
    private static XmlReader xmlReader;

    static TracksRepo()
    {
        path = @"D:\ITI\Projects\Attendance-Management-System\Attendance Management System\attendance.xml";
        xmlReader = XmlReader.Create(path);
    }

}
