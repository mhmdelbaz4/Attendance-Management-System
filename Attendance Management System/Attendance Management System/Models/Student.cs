
namespace Attendance_Management_System.Models;

class Student : User
{
    public string? TrackName { get; set; }

    public List<AttendanceItem>? AttendaceHistory  { get; set; }

}
