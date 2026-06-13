namespace BaseInterfaces;

class Program
{
    static void Main(string[] args)
    {
        // var sc = new StudentCard(){Number = 12, Series = "AZ"};
        // var sc2 = new StudentCard(){Number = 12, Series = "AZ"};
        // Console.WriteLine(sc==sc2);

        // int[] mass = [1, 3, 32, 0, 1, 2, 2, 8, 3, 12];
        // mass.Sort();
       
        
        // Array.Sort(mass);
        //
        // foreach(int i in mass) Console.Write(i+" ");
        //
        // double[] massD = [1, 3, 32, 0, 1, 2, 2, 8, 3, 12];
        // Array.Sort(massD);
        //
        // foreach(int i in massD) Console.Write(i+" ");

        // var aud = new Auditory();
        // aud.Sort();
        // Console.WriteLine("Сортировка по дате");
        // foreach (var student in aud) Console.WriteLine(student);
        //
        // Console.WriteLine("Сортировка по имени");
        // aud.Sort(new NameCoparer());
        // foreach (var student in aud) Console.WriteLine(student);
        //
        // Console.WriteLine("Сортировка по фамилии");
        // aud.Sort(new SurnameCoparer());
        // foreach (var student in aud) Console.WriteLine(student);


        // var week = new Week();
        //
        // foreach (var day in week)
        // {
        //     Console.WriteLine(day);
        // }
        // foreach (string day in week)
        // {
        //     Console.WriteLine(day);
        // }

        // var student = new Student
        // {
        //     FirstName = "John",
        //     LastName = "Miller",
        //     BirthDate = new DateTime(1997, 3, 12),
        //     StudentCard = new StudentCard (189356,"AB")
        // };
        //
        // var student2 = student.Clone() as Student;
        // Console.WriteLine(student);
        // Console.WriteLine(student2);
        //
        // student2.FirstName = "Mike";
        // student2.StudentCard.Number = 1234;
        //
        // Console.WriteLine(student);
        // Console.WriteLine(student2);

        var aud = new Auditory();
        
        foreach(Student student in aud) Console.WriteLine(student);
    }
}