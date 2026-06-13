namespace Indexator;

public class Tool
{
    public string Name { get; set; }
    public int? Size { get; set; }
    public ToolType Type { get; set; } = ToolType.Tool;

    public Tool(string name, int size = 0)
    {
        this.Name = name;
        this.Size = size;
    }
    
    public override string ToString() => $"{this.Name} ({this.Size})";
}

public enum ToolType {Saw ,Tool, Hammer};