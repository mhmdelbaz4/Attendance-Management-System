namespace Attendance_Management_System.Models;

public class User
{
    public int ID { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string Password { get; set; }

    public DateTime BirthDate { get; set; }

    public string? MobileNumber { get; set; }


    public override string ToString()
    {
        string str = $"ID :{ID}\nName :{Name}\nEmail :{Email}\nBirthDate:{BirthDate}\nMobile Number :{MobileNumber}";

        return str;
    }


    public override bool Equals(object? obj)
    {
        User? other = obj as User;
        if(other is null)
             return false;

        if(other.GetType() != typeof(User))
            return false;

        if(Object.ReferenceEquals(this,other))
            return true;

        bool isEqual =     this.ID == other.ID 
                        && this.Name == other.Name
                        && this.Email == other.Email
                        && this.BirthDate == other.BirthDate
                        && this.MobileNumber == other.MobileNumber;

        return isEqual;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
