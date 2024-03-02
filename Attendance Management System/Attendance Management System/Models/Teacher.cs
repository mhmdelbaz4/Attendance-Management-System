namespace Attendance_Management_System.Models;

public class Teacher :User
{
    public DateTime HiringDate { get; set; }

    public int Salary { get; set; }

    public List<TrackNAme>? TracksNames{ get; set; }// EVERY TEACHER CAN BE FOUND IN MORE THAN ONE TRACK OR CLASS 

    /* public static implicit operator Teacher(Teacher v)
     {
         throw new NotImplementedException();
     }*/
    public override string ToString()
    {
        string tracks = TracksNames != null ? string.Join(", ", TracksNames) : "None";
        return $"ID: {ID}, Name: {Name}, Hiring Date: {HiringDate}, Salary: {Salary}, Tracks: {tracks}";
    }
}