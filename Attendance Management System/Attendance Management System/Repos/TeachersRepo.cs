using Attendance_Management_System.Models;
using System.Xml;

namespace Attendance_Management_System.Repos;

public class TeachersRepo
{
    private static string? path;
    private static XmlReader xmlReader;
    
    static TeachersRepo()
    {
       // path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";
       // xmlReader = XmlReader.Create(path);
    }
    public static List<Teacher> GetTeachers(string path)
    {
        List <Teacher> Teachers = new List<Teacher>();

        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        XmlNodeList TeacherList = doc.SelectNodes("//teachers/teacher");
       

        // Iterate through each teacher
        foreach (XmlNode TeacherNode in TeacherList)
        {
            Teacher teacher = new Teacher()
            {
                ID = int.Parse(TeacherNode.SelectSingleNode("id").InnerText),
                Name = TeacherNode.SelectSingleNode("name").InnerText,
                Email = TeacherNode.SelectSingleNode("email").InnerText,
                Password = TeacherNode.SelectSingleNode("password").InnerText,
                BirthDate = DateOnly.ParseExact(TeacherNode.SelectSingleNode("birthDate").InnerText, "yyyy-MM-dd", null), // Parsing using specific format
                MobileNumber = TeacherNode.SelectSingleNode("mobileNo").InnerText,
                HiringDate = DateOnly.ParseExact(TeacherNode.SelectSingleNode("hiringDate").InnerText, "yyyy-MM-dd", null),
                Salary = int.Parse(TeacherNode.SelectSingleNode("salary").InnerText),
            };

            // Populate TracksNames list for the teacher
            teacher.TracksNames = new List<TrackNAme>();
            XmlNodeList trackNodes = TeacherNode.SelectNodes("tracks/trackName");
            foreach (XmlNode trackNode in trackNodes)
            {
                string trackName = trackNode.InnerText;
                if (Enum.TryParse(trackName, out TrackNAme track))
                {
                    teacher.TracksNames.Add(track);
                }
            }
            Teachers.Add(teacher);

        }
        MessageBox.Show("teachers"+(Teachers.Count).ToString());
        return Teachers;
    }
    public static Teacher getTeacherByID(int id, List<Teacher> teacheList)
    {
        foreach (Teacher teacher in teacheList)
        {
            if (teacher.ID == id)
            {
                MessageBox.Show(teacher.ID.ToString());
                return teacher;
            }
        }
        return null;
    }
}




