namespace Attendance_Management_System.Models;

public class Teacher :User
{
    public DateOnly HiringDate { get; set; }

    public int Salary { get; set; }

    public List<string>? TracksNames{ get; set; }
}