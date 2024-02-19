using System.Xml;

namespace Attendance_Management_System.Repos;

public class TracksRepo
{
    private static string path;
    private static XmlReader xmlReader;

    static TracksRepo()
    {
        path = @"C:\Users\T.B\Desktop\attendance repo\Attendance-Management-System\xmlf\attendance.xmll";
        xmlReader = XmlReader.Create(path);
    }

}
