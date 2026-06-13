namespace Indexator;

public class ToolBox
{
    private Tool[] Tools { get; set; }

    public ToolBox(Tool[] tools)
    {
        this.Tools = tools;
    }

    public void Print()
    {
        foreach (var tool in this.Tools) Console.WriteLine(tool);
    }
    
    // тип_данных this[тип аргумета] {get;set;}

    public Tool this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Tools.Length) throw new ArgumentOutOfRangeException(nameof(index));
            Console.WriteLine($"обратились к индексатору, индекс: {index}");
            return this.Tools[index];
        }
        set
        {
            if (index < 0 || index >= this.Tools.Length) throw new ArgumentOutOfRangeException(nameof(index));
            this.Tools[index] = value;
        }
    }
    // public Tool this[string typeName]
    // {
    //     get
    //     {
    //         if (Enum.IsDefined(typeof(ToolType), typeName))
    //         {
    //             return Tools[(int)Enum.Parse(typeof(ToolType), typeName)];
    //         }
    //         else
    //         {
    //             return new Tool("Epmty");
    //         }
    //     }
    //     
    // }
    // public Tool this[string typeName]
    // {
    //     get
    //     {
    //         var type = (ToolType)Enum.Parse(typeof(ToolType), typeName);
    //         return Tools.Single(tool =>
    //         {
    //             if (tool.Type == type) return true;
    //             return false;
    //         });
    //     }
    //     
    // }
    public Tool? this[string name]
    {
        get
        {
            return Tools.SingleOrDefault(tool =>
            {
                if (tool.Name == name) return true;
                return false;
            });
        }
        
    }
    
    
    
    }