class MathOperation
{
    public virtual float Calculate(float a, float b)
    {
        return 0;
    }
}
class SumOperation : MathOperation
{
    public override float Calculate(float a, float b)
    {
        return a + b;
    }
}
class MultiplyOperation : MathOperation
{
    public override float Calculate(float a, float b)
    {
        return a * b;
    }
}
class Program
{
    static void Main()
    {
        MathOperation sum = new SumOperation();
        MathOperation multiply = new MultiplyOperation();

        Console.WriteLine(sum.Calculate(5, 3));
        Console.WriteLine(multiply.Calculate(5, 3));
    }
}
