using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace Attendance_Management_System.Models;

public class AttendanceItem
{
    public DateOnly Date { get; set; }

    public int? TeacherID { get; set; }

    public AttendanceState State { get; set; }
    public override string ToString()
    {
        return $" AttendanceData ===>>Teacher ID: {TeacherID}, Date: {Date}, State: {State}";
    }
}
