class IntValue
{
    public int Value { get; set; } 
    public IntValue(int value) 
    {
        Value = value;
    }
    public static IntValue operator ++(IntValue a)
    {
        a.Value++; 
        return a;   
    }
}
class Program
{
    static void Main()
    {
        IntValue num = new IntValue(5); 
        num++; 
        Console.WriteLine(num.Value); 
        ++num;
        Console.WriteLine(num.Value);
    }
}