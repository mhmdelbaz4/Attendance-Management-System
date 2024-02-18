using System.Xml;
using Attendance_Management_System.Models;
namespace Attendance_Management_System.Repos;

public static class UsersRepo
{
    private static string path;
    private static XmlReader xmlReader;
    private static XmlWriter xmlWriter;

    static UsersRepo()
    {
       path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml"; ;
       xmlReader = XmlReader.Create(path);
    }


    public static bool isexists()
    {
        return File.Exists(path);
    }
}