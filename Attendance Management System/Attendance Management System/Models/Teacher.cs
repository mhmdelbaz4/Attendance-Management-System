namespace Attendance_Management_System.Models;

public class Teacher :User
{
    public DateOnly HiringDate { get; set; }

    public int Salary { get; set; }

    public List<string>? Courses { get; set; } // js ,xml ,html

    public Dictionary<string,string>? TracksCourses { get; set; }

    // pd xml
    // js os

}