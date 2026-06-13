namespace BaseInterfaces;

public record StudentCard
{
    public int Number { get; set; }
    public string Series { get; set; }

    public StudentCard(int number = 0, string series = "")
    {
        this.Number = number;
        this.Series = series;
    }
}