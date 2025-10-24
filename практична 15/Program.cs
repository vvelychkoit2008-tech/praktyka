class Math
{
    public double ToPower(double number, int power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
    public double ToPower(double number)
    {
        return number * number;
    }
}
class Program
{
    static void Main()
    {
        Math math = new Math();
        Console.WriteLine(math.ToPower(3, 4));
    }
}