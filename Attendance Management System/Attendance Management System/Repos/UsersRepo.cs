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
       path = Directory.GetParent("./../../../..")?.FullName + "/xml/attendance.xml";
    }


    /// <summary>
    /// gets Id of the user using email
    /// </summary>
    /// <param name="email">user email</param>
    /// <returns>returns the id of the user and if there's no user with this email returns -1</returns>
    public static int GetUserIDByEmail(string email)
    {
        int userId = -1;
        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(path);

            //XmlNode userNode = xmlDoc.SelectSingleNode($"//users/*/user[email='{email}']");
            XmlNode userNode = xmlDoc.SelectSingleNode($"//users/*/student[email='{email}'] | //users/*/teacher[email='{email}'] | //users/*/admin[email='{email}']");

            if (userNode != null)
            {
                XmlNode idNode = userNode.SelectSingleNode("id");
                if (idNode != null)
                {
                    userId = Convert.ToInt32(idNode.InnerText);
                }
            }
        }
        finally
        {
            xmlDoc.Save(path);
            xmlDoc = null;
        }
        return userId;
    }

    /// <summary>
    /// gets Id of the user using mobile number
    /// </summary>
    /// <param name="mobile">user mobileNo</param>
    /// <returns>returns the id of the user and if there's no user with this mobileNo returns -1</returns>


    public static int GetUserIDByMobileNo(string mobileNo)
    {
        int userId = -1;

        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(path);

            XmlNode userNode = xmlDoc.SelectSingleNode($"//users/*/student[mobileNo='{mobileNo}'] | //users/*/teacher[mobileNo='{mobileNo}'] | //users/*/admin[mobileNo='{mobileNo}']");
            if (userNode != null)
            {
                XmlNode idNode = userNode.SelectSingleNode("id");
                if (idNode != null)
                {
                    userId = Convert.ToInt32(idNode.InnerText);
                }
            }
        }
        finally
        {
            xmlDoc =null;
        }

        return userId;
    }


    /// <summary>
    /// Generate unqiue Id for new users
    /// </summary>
    /// <returns>returns integer ID for new users</returns>
    public static int GenerateID()
    {
        xmlReader = XmlReader.Create(path);
        long ticks = DateTime.UtcNow.Ticks;

        int userId = (int)(ticks % int.MaxValue);
        xmlReader.Close();
        return userId;
    }
}