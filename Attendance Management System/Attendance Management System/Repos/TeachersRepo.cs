using System.Xml;

namespace Attendance_Management_System.Repos;

public class TeachersRepo
{
    private static string? path;
    private static XmlReader xmlReader;
    
    static TeachersRepo()
    {
        path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";
        xmlReader = XmlReader.Create(path);
    }
}
