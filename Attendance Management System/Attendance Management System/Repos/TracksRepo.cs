using Attendance_Management_System.Forms;
using Attendance_Management_System.Models;
using System.Xml;

namespace Attendance_Management_System.Repos;

public static class TracksRepo
{
    private static string path;
    private static XmlDocument xmlDoc;
    static TracksRepo()
    {
        path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";
        xmlDoc = new XmlDocument();
    }

    public static List<string> GetTrackNames()
    {
        List<string> trackNames = new List<string>();

        try
        {
            xmlDoc.Load(path);

            XmlNodeList trackNodes = xmlDoc.SelectNodes("/attendanceSystem/tracks/track/name");

            if (trackNodes != null)
            {
                foreach (XmlNode trackNode in trackNodes)
                {
                    string trackName = trackNode.InnerText;
                    trackNames.Add(trackName);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        return trackNames;
    }

    public static List<(string,string,bool)> getTrackAttendance(string date ,string trackName ,string teacherId)
    {
        List<(string, string, bool)> trackAttendance = new List<(string, string, bool)>();

        XmlNodeList studentNodes = xmlDoc.SelectNodes($"//student[trackName='{trackName}']");

        if (studentNodes != null)
        {
            foreach (XmlNode studentNode in studentNodes)
            {
                string studentId = studentNode.SelectSingleNode("id")?.InnerText;
                string studentName = studentNode.SelectSingleNode("name")?.InnerText;

                // Check if attendance item exists for the student, teacher, and date
                XmlNode attendanceNode = studentNode.SelectSingleNode($"attendance/item[date='{date}' and teacherID='{teacherId}']");

                // Determine checkbox status based on attendance item
                bool isChecked = false;
                if (attendanceNode != null)
                {
                    string state = attendanceNode.SelectSingleNode("state")?.InnerText;
                    isChecked = (state == "attendant");
                }

                // Add student info and checkbox status to the list
                trackAttendance.Add((studentId, studentName, isChecked));
            }
        }

        return trackAttendance;
    }


    public static List<(string,string)> GetTrackTeachers(string trackName)
    {
        List<(string, string)> trackTeachers = new List<(string, string)>();

        // Select teachers associated with the given track name from the XML document
        XmlNodeList trackNodes = xmlDoc.SelectNodes($"//tracks/track[name='{trackName}']/teachers/teacherID");

        if (trackNodes != null)
        {
            foreach (XmlNode trackNode in trackNodes)
            {
                string teacherId = trackNode.InnerText;
                string teacherName = GetTeacherNameById(teacherId);
                trackTeachers.Add((teacherId, teacherName));
            }
        }

        return trackTeachers;
    }

    public static string GetTeacherNameById(string teacherId)
    {
        XmlNode teacherNode = xmlDoc.SelectSingleNode($"//teachers/teacher[id='{teacherId}']");

        if (teacherNode != null)
        {
            XmlNode nameNode = teacherNode.SelectSingleNode("name");
            if (nameNode != null)
            {
                return nameNode.InnerText;
            }
        }

        return null; 
    }

}
