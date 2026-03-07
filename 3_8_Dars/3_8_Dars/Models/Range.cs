namespace _3_8_Dars.Models;

public class Range<T> where T : struct
{
    public T Start { get; set; }
    public T End { get; set; }

    public Range(T start, T end)
    {
        if ((dynamic)Start > (dynamic)End)
        {
            start = end;
            end = start;
        }
        else
        {
            Start = start;
            End = end;
        }

    }
}
