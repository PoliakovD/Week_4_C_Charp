using System.Collections;

namespace BaseInterfaces;

public class Week : IEnumerable, IEnumerable<string>
{
    private string[] days =
    {
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
    };

    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        return new WeekTypedEnumerator(days);
    }

    public IEnumerator GetEnumerator()
    {
        return new WeekEnumerator(days);
    }
}

public class WeekEnumerator : IEnumerator
{
    private string[] days;
    int position = -1;
    private object? _current;

    public WeekEnumerator(string[] days)
    {
        this.days = days;
    }

    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
       return false;
    }

    public void Reset()
    {
        position = -1;
    }

    public object? Current
    {
        get
        {
            if (position == -1 || position >= days.Length) throw new ArgumentException();
            return days[position];
        }
    }
}
public class WeekTypedEnumerator : IEnumerator<string>
{
    private string[] days;
    int position = -1;
    private object? _current;
    private object? _current1;
    private string _current2;
    private object? _current3;

    public WeekTypedEnumerator(string[] days)
    {
        this.days = days;
    }


    public void Dispose()
    {
        // TODO release managed resources here
    }

    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        position = -1;
    }

    public object? Current
    {
        get
        {
            if (position == -1 || position >= days.Length) throw new ArgumentException();
            return days[position];
        }
    }

    string? IEnumerator<string>.Current
    {
        get
        {
            if (position == -1 || position >= days.Length) throw new ArgumentException();
            return days[position];
        }
    }
    
}