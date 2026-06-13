namespace Indexator;

class Program
{
    static void Main(string[] args)
    {
        var tool1 = new Tool("Отвертка", 2);
        var tool2 = new Tool("Посатижи");
        var tool3 = new Tool("Пила") {Type = ToolType.Saw};
        
        var toolbox = new ToolBox([tool1, tool2, tool3]);
        
        //toolbox.Print();

        Console.WriteLine(toolbox[2]);
        Console.WriteLine(toolbox["Saw"]);
        Console.WriteLine(toolbox["Посатижи"]);
        Console.WriteLine(toolbox["Отвертка"]);
    }
}
