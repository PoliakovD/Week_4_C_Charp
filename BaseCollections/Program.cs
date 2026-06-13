using System.Collections;
using BaseInterfaces;

namespace BaseCollections;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student
        {
            FirstName = "John",
            LastName = "Miller",
            BirthDate = new DateTime(1997, 3, 12),
            StudentCard = new StudentCard
            {
                Number = 189356,
                Series = "AB"
            }
        };
        
        
        // IList arrayList =new ArrayList() {
        //     1,"23232",23.5,112,123,student
        // };
        ArrayList arrayList =new ArrayList() {
            1,"23232",23.5,112,123,student
        };
        
        // foreach (object ob in arrayList) Console.WriteLine(ob);
        //
        // Console.WriteLine("Capacity: " + arrayList.Capacity);
        // Console.WriteLine("Count: " +arrayList.Count);
        //
        // arrayList.Add(1);
        // arrayList.Add(2);
        // arrayList.Add(2);
        // Console.WriteLine("После добавления 1 и 2 2 ");
        //
        // Console.WriteLine("Capacity: " + arrayList.Capacity);
        // Console.WriteLine("Count: " +arrayList.Count);
        //
        // arrayList.TrimToSize();
        // Console.WriteLine("После TrimToSize");
        //
        // Console.WriteLine("Capacity: " + arrayList.Capacity);
        // Console.WriteLine("Count: " +arrayList.Count);
        //
        // arrayList.AddRange(arrayList);
        // Console.WriteLine("После AddRange");
        // arrayList.Add(2);
        // Console.WriteLine("Capacity: " + arrayList.Capacity);
        // Console.WriteLine("Count: " +arrayList.Count);
        //
        //
        
    //     Stack stack = new Stack(){};
    //     
    //     stack.Push(student);
    //     stack.Push(12);
    //     stack.Push(123);
    //     stack.Push("stroka");
    //
    //     Console.WriteLine(" Count "+stack.Count);
    //     
    //     Console.WriteLine(stack.Peek());
    //     
    //     Console.WriteLine(" Count after Peek: "+stack.Count);
    //
    //     Console.WriteLine(stack.Pop());
    //     Console.WriteLine(" Count after Pop: "+stack.Count);
    //     Console.WriteLine(stack.Pop());
    //     Console.WriteLine(" Count after Pop: "+stack.Count);
    //     Console.WriteLine(stack.Pop());
    //     Console.WriteLine(" Count after Pop: "+stack.Count);
    //     Console.WriteLine(stack.Pop());
    //     Console.WriteLine(" Count after Pop: "+stack.Count);
    //     
    //     
    //     
    //     stack.Push(arrayList);
    //     Console.WriteLine(" Count after Push arrayList: "+stack.Count);
    //     
    //     
    //     var stack2 = new Stack(arrayList);
    //
    //     object[] array = new  object[10];
    //     
    //     stack2.CopyTo(array,0);
    //     
    //     foreach (var item in array) Console.WriteLine(item);
    //
        // Queue  queue = new Queue();
        //
        // queue.Enqueue(student);
        // queue.Enqueue(arrayList);
        // var student2 = queue.Dequeue();
        // Console.WriteLine(student2);
        //
        // var arrayList2 = queue.Peek();
        // Console.WriteLine(arrayList2);
        //
        // Console.WriteLine(queue.Count);
        
        // Hashtable table = new Hashtable();
        //
        // table.Add(1, "23232");
        // table.Add(21, "23232");
        // table.Add("23", "2322232");
        // table.Add(student, "student");
        //
        // Console.WriteLine("Count before remove: " + table.Count);
        // table.Remove(21);
        // Console.WriteLine("Count after remove: " + table.Count);
        //
        //
        // Console.WriteLine("table[1]: "+ table[1]);
        // Console.WriteLine("table[\"23\"]: "+ table["23"]);
        // Console.WriteLine("table[student]: "+ table[student]);

        SortedList sortedList = new SortedList();
        
        sortedList.Add(1, "student");
        sortedList.Add(45, "asdasda");
        sortedList.Add(12, "assssdsdsdsd");
        sortedList.Add(14, "lorem picture");
        sortedList.Add(34, student);
        //sortedList.Add(student, "unsorted student");

        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
        foreach (var item in sortedList.Keys)
        {
            Console.WriteLine(item);
        }
        foreach (var item in sortedList.Values)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("sortedList.Contains(45);:"+
                          sortedList.Contains(45));
        
       

    }
}