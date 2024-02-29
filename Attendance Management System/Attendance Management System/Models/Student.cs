
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance_Management_System.Models;

public class Student : User
{

    public string? TrackName { get; set; }
    //public int ID { get; set; }
    //public string Name { get; set; }
    

    public List<AttendanceItem>? AttendaceHistory { get; set; }
    public override string ToString()
    {
        string res = $"ID: {ID}, Name: {Name}, Birth Date: {BirthDate}, Email: {Email}, Mobile No: {MobileNumber}, Track Name: {TrackName}";
        foreach (AttendanceItem attendance in AttendaceHistory) { res += attendance.ToString(); }
        return res;

    }

}

