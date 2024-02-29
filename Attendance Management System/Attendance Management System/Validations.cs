using Attendance_Management_System.Repos;
using System.Text.RegularExpressions;

namespace Attendance_Management_System;

public static class Validations
{
    public static bool isValidUserName(string name,out string msg)
    {
        msg= string.Empty;  

        if (string.IsNullOrWhiteSpace(name))
        {
            msg = "Name can't be empty.";
            return false;
        }

        if(name.Trim().Length < 3)
        {
            msg = "Name should be at least 3 characters.";
            return false;
        }

        if(int.TryParse(name,out int n))
        {
            msg = "name can't be number.";
            return false;
        }

        if(name.Trim().Length > 30)
        {
            msg = "name length shouldn't exceed 30 chars.";
            return false;
        }
        //check uniqueness
        return true;
    }


    public static bool IsValidEmail(string email ,out string msg)
    {
        msg=string.Empty;
        if(string.IsNullOrWhiteSpace(email))
        {
            msg = "Email is required!";
            return false;
        }

        string pattern = @"^[a-zA-Z0-9._%+-]{6,}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (! Regex.IsMatch(email, pattern))
        {
            msg = "Incorrect Email!";
            return false;
        }


        //uniqueness
        if(UsersRepo.GetUserIDByEmail(email) != -1)
        {
            msg = "email is already exists";
            return false;
        }

        return true;
    }

    public static bool IsValidPassword(string password ,out string msg)
    {
        msg=string.Empty;


        string pattern = @"^(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9])(?=.*\d).{8,}$";
        
        if(! Regex.IsMatch(password,pattern))
        {
            msg = "password at least 8 chars,contains at least 1 alphapets and 1 special chars";
            return false;
        }
        return true;
    }


    // incorrect
    public static bool IsValidMobileNo(string mobileNo ,out string msg)
    {
        msg=string.Empty;
        string pattern = @"^(010|011|012|015)\d{8}$";

        if(String.IsNullOrEmpty(mobileNo))
        {
            msg = "Mobile Number is required.";
            return false;
        }

        if (Regex.IsMatch(pattern, mobileNo))
        {
            msg = "Mobile Number isn't correct.";
            return false;
        }

        if (UsersRepo.GetUserIDByMobileNo(mobileNo) != -1)
        {
            msg = "Mobile Number is aleady exists.";
            return false;
        }
        return true;
    }

    public static bool isValidHiringDate(string hiringDate,out string msg)
    {
        msg = string.Empty;
        DateTime date =Convert.ToDateTime(hiringDate);

        if(DateTime.Now.Year - date.Year > 50)
        {
            msg = "incorrect hiring date";
            return false;
        }

        return true;

    }

    public static bool isValidTeacherBirthDate(string birthDate, out string msg)
    {
        msg = string.Empty;
        DateTime date;
        try
        {
            date = Convert.ToDateTime(birthDate);
        }catch(Exception ex)
        {
            throw new Exception("invalid birth date.");
        }

        if (DateTime.Now.Year - date.Year < 22)
        {
            msg = "Teacher age can't be less than 22 years.";
            return false;
        }

        return true;
    }

    public static bool isValidSalary(string salary, out string msg)
    {
        msg = string.Empty;
        if (!int.TryParse(salary, out int sal))
            throw new InvalidCastException("salary is not integer.");

        if (sal < 6000)
        {
            msg = "taecher salary can't be less than 6k";
            return false;
        }
        if (sal > 1_000_000)
        {
            msg = "teacher salary can't exceed 1M";
            return false;
        }

        return true;
    }

}
