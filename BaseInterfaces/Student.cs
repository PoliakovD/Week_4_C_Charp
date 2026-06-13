namespace BaseInterfaces;

public class Student : IComparable, ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard StudentCard { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is Student)
        {
            return BirthDate.CompareTo((obj as Student).BirthDate);
        }

        
        throw new ArgumentException("Object is not a Student");
    }
    public override string ToString() 
        => $"{FirstName} {LastName},{BirthDate}, {StudentCard.Number+StudentCard.Series}";

    public object Clone()
    {
        var newStudent = MemberwiseClone() as Student;
        
        newStudent.StudentCard = new StudentCard(StudentCard.Number, StudentCard.Series);
        
        return newStudent;
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
         
    }
}