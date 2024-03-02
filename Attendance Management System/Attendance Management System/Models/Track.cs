namespace Attendance_Management_System.Models;

public class Track
{
    public TrackNAme? Name { get; set; }

    public List<int> TeachersIDs { get; set; }

}
public enum TrackNAme
{
    AI,OS,PD
}