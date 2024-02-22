namespace Attendance_Management_System.Models;

public class AttendanceItem
{
    public DateOnly Date { get; set; }

    public int TeacherID { get; set; }

    public AttendanceState State { get; set; }
}
