using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BaseInterfaces;

namespace GenericCollections;

class Program
{
    static void Main(string[] args)
    {
        // List<T> ArrayList

        List<int> intList = [1, 2, 3, 4, 5];
        List<string> stringList = ["", "222", "sadsada"];
        
        intList.AddRange(intList);

        var student1 = new Student()
        {
            FirstName = "John",
            LastName = "Week",
            StudentCard = new StudentCard(1562, "AA")
        };
        var student2 = new Student()
        {
            FirstName = "Mike",
            LastName = "Week",
            StudentCard = new StudentCard(1442, "AA")
        };
        var student3 = new Student()
        {
            FirstName = "Jake",
            LastName = "Week",
            StudentCard = new StudentCard(122, "AA")
        };
        var student4 = new Student()
        {
            FirstName = "Simon",
            LastName = "Week",
            StudentCard = new StudentCard(123, "AA")
        };


        // List<Student> studentList =
        // [
        //     student1, student2
        // ];
        //
        // // Dictionary<TKey, TValue> Hastable
        //
        // var dictionary = new Dictionary<int, Student>();
        //
        // dictionary.Add(121, student1);
        // dictionary.Add(235, student2);
        // dictionary.Add(236, student2);
        //
        // var winner = dictionary[121];
        // Console.WriteLine("winner == " + winner);
        //
        // // SortedList<TKey, TValue> SortedList
        //
        // var sortedList = new SortedList<int, Student>();
        //
        // sortedList.Add(student1.StudentCard.Number, student1);
        // sortedList.Add(student2.StudentCard.Number, student2);
        // sortedList.Add(student3.StudentCard.Number, student3);
        // sortedList.Add(student4.StudentCard.Number, student4);
        //
        // foreach (var item in sortedList)
        // {
        //     Console.WriteLine("Key = " + item.Key + "\tValue = " + item.Value);
        // }


        // var stack = new Stack<Student>();
        //
        // stack.Push(student1);
        // stack.Push(student3);
        // stack.Push(student4);
        // stack.Push(student2);
        //
        //
        // Console.WriteLine(" Count " + stack.Count);
        //
        // Console.WriteLine(stack.Peek());
        //
        // Console.WriteLine(" Count after Peek: " + stack.Count);
        //
        // Console.WriteLine(stack.Pop());
        // Console.WriteLine(" Count after Pop: " + stack.Count);
        // Console.WriteLine(stack.Pop());
        // Console.WriteLine(" Count after Pop: " + stack.Count);
        // Console.WriteLine(stack.Pop());
        // Console.WriteLine(" Count after Pop: " + stack.Count);
        // Console.WriteLine(stack.Pop());
        // Console.WriteLine(" Count after Pop: " + stack.Count);

        // var queue = new Queue<Student>();
        //
        // queue.Enqueue(student2);
        // queue.Enqueue(student1);
        // queue.Enqueue(student3);
        // queue.Enqueue(student4);
        //
        //
        // Console.WriteLine("Первый в очереди: "+queue.Dequeue());
        // Console.WriteLine("Второй в очереди: "+queue.Dequeue());
        // Console.WriteLine("Третий в очереди: "+queue.Dequeue());
        // Console.WriteLine("Четвертый в очереди: "+queue.Dequeue());
        //
         
        
        var linkedList = new LinkedList<Student>();
        
        linkedList.AddFirst(student1);
        linkedList.AddLast(student2);
        linkedList.AddLast(student2);
        linkedList.AddLast(student3);
        linkedList.AddLast(student4);

        // var first = linkedList.First();
        // linkedList.Remove(first);
        // var last = linkedList.Last();
        // linkedList.Remove(last);
        

        // var node = linkedList.Find(student3);
        // Console.WriteLine("Current student = "+ node.Value);
        // Console.WriteLine("Previous student = "+ node.Previous?.Value);
        // Console.WriteLine("Next student = "+ node.Next?.Value);
        
        var observable = new ObservableCollection<Student>();

        observable.CollectionChanged += (obj, ev) =>
        {
            switch (ev.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен новый элемент в коллекцию:{ev?.NewItems?[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален элемент из коллекции:{ev?.OldItems?[0]}");
                    break;
                default: Console.WriteLine("Сработало событие"); break;
            };
        };
        observable.Add(student1);
        student1.LastName = "Wazovski";
        observable.Remove(student1);
        observable.Add(student2);
        observable.AddRange(new[] { student3, student4 });

        string strasdasd = " asdasdasdasdasdasdgkljsdoghlsdjhglkjdshglkjsdh";
        Console.WriteLine($"символов {strasdasd.CharCount('a')} a в строке: {strasdasd}");
        Console.WriteLine($"IsNumber: {strasdasd.IsNumber}");
        Console.WriteLine($"IsNumber: {"12312312556789".IsNumber}");
        
    }

   
}
public static class MyExtensions
{
    public static bool AddRange<T>(this ObservableCollection<T> original, IEnumerable<T> collection)
    {
        try
        {
            foreach (var item in collection)
            {
                original.Add(item);
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    extension(string str)
    {
        public int CharCount(char c)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c) count++;
            }
            return count;
        }

        public bool IsNumber
        {
            get
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i]<'0'||str[i]>'9') return false;
                }
                return true;
            }
        }
    }
}