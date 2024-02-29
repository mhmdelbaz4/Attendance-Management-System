using Attendance_Management_System.Models;
using System.Buffers;
using System.Xml;

namespace Attendance_Management_System.Repos;

public class TeachersRepo
{
    private static string? path;
    private static XmlReader xmlReader;
    private static XmlWriter xmlWriter; 
    static TeachersRepo()
    {
        path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";
    }

    public static bool AddTeacher(Teacher teacher)
    {
        XmlDocument xmlDoc = new XmlDocument();
        try
        {

            xmlDoc.Load(path);

            XmlElement teacherElement = xmlDoc.CreateElement("teacher");

            XmlElement idElement = xmlDoc.CreateElement("id");
            idElement.InnerText = teacher.ID.ToString();
            teacherElement.AppendChild(idElement);

            XmlElement nameElement = xmlDoc.CreateElement("name");
            nameElement.InnerText = teacher.Name;
            teacherElement.AppendChild(nameElement);

            XmlElement emailElement = xmlDoc.CreateElement("email");
            emailElement.InnerText = teacher.Email;
            teacherElement.AppendChild(emailElement);

            XmlElement passwordElement = xmlDoc.CreateElement("password");
            passwordElement.InnerText = teacher.Password;
            teacherElement.AppendChild(passwordElement);

            XmlElement birthDateElement = xmlDoc.CreateElement("birthDate");
            birthDateElement.InnerText = teacher.BirthDate.ToString("yyyy-MM-dd");
            teacherElement.AppendChild(birthDateElement);

            XmlElement mobileNoElement = xmlDoc.CreateElement("mobileNo");
            mobileNoElement.InnerText = teacher.MobileNumber;
            teacherElement.AppendChild(mobileNoElement);

            XmlElement hiringDateElement = xmlDoc.CreateElement("hiringDate");
            hiringDateElement.InnerText = teacher.HiringDate.ToString("yyyy-MM-dd");
            teacherElement.AppendChild(hiringDateElement);

            XmlElement salaryElement = xmlDoc.CreateElement("salary");
            salaryElement.InnerText = teacher.Salary.ToString();
            teacherElement.AppendChild(salaryElement);

            // Append the new teacher element to the end of the <teachers> node
            XmlNode teachersNode = xmlDoc.SelectSingleNode("//teachers"); // Assuming teachers are direct children of the <teachers> node
            teachersNode.AppendChild(teacherElement);

            // Save the changes back to the XML file
            xmlDoc.Save(path);
        }
        catch(Exception ex)
        {
            throw new Exception("adding not completed");
        }
        finally
        {
            xmlDoc= null;   
        }


        return true;
    }


    public static IEnumerable<Teacher> GetTeachers(string searchBy ,string searchValue)
    {
        List<Teacher> teachers = new List<Teacher>();

        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(path);

            XmlNodeList teacherNodes;


            if (searchBy == null && searchValue == null)
            {
                teacherNodes = xmlDoc.SelectNodes($"//teachers/teacher']");

            }
            else
            {
                teacherNodes = xmlDoc.SelectNodes($"//teachers/teacher[{searchBy}='{searchValue}']");
            }

            if (teacherNodes != null)
            {
                foreach (XmlNode teacherNode in teacherNodes)
                {
                    Teacher teacher = new Teacher();
                    teacher.ID = int.Parse(teacherNode.SelectSingleNode("id").InnerText);
                    teacher.Name = teacherNode.SelectSingleNode("name").InnerText;
                    teacher.Email = teacherNode.SelectSingleNode("email").InnerText;
                    teachers.Add(teacher);
                }
            }
        }
        finally
        {
            xmlDoc = null;
        }

        return teachers;
    }
}