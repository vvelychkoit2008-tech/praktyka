class IntValue
{
    public int Value { get; set; }
    public IntValue(int value)
    {
        Value = value;
    }
    public static bool operator >(IntValue a, IntValue b)
    {
        return a.Value > b.Value;
    }
    public static bool operator <(IntValue a, IntValue b)
    {
        return a.Value < b.Value;
    }
}
class Program
{
    static void Main()
    {
        IntValue x = new IntValue(10);
        IntValue y = new IntValue(20);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y); 
    }
}
