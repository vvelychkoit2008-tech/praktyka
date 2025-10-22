class IntValue
{
    public int Value { get; set; }
    public IntValue(int value)
    {
        Value = value;
    }
    public static IntValue operator +(IntValue a, IntValue b)
    {
        return new IntValue(a.Value + b.Value);
    }
}
class Program
{
    static void Main()
    {
        IntValue num1 = new IntValue(43); 
        IntValue num2 = new IntValue(79);

        IntValue result = num1 + num2;  

        Console.WriteLine(result.Value); 
    }
}