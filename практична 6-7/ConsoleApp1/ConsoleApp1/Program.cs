class MathOperation
{
    public float Calculate (float a, float b) {return 0;}
}
class SumOperation : MathOperation
{
    public float Calculate(float a, float b)
    {
        return a + b;
    }
}
class MultiplyOperation: MathOperation
{
    public float Calculate(float a, float b)
    {
        return (a * b);
    }
}
class Program
{
    static void Main()
    {
        SumOperation sum = new SumOperation();
        MultiplyOperation multiply = new MultiplyOperation();
        Console.WriteLine("Сума: " + sum.Calculate(865,7865));
        Console.WriteLine("Множення: " + multiply.Calculate(43,76));
    }
}