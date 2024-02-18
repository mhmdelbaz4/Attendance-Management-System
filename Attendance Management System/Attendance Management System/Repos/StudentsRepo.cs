using Attendance_Management_System.Models;
using System.Xml;

namespace Attendance_Management_System.Repos;

public static class StudentsRepo
{
    private static string path;
    private static XmlReader xmlReader;
    static StudentsRepo()
    {
        path = @"D:\ITI\Projects\Attendance-Management-System\Attendance Management System\attendance.xml";
        xmlReader = XmlReader.Create(path);
    }




}
