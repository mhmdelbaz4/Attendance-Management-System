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
        path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\", "attendance.xml"));
        xmlReader = XmlReader.Create(path);
    }

    public static int CheckUserCredentials(string email, string password)
    {
        
        return 0;
    }
}