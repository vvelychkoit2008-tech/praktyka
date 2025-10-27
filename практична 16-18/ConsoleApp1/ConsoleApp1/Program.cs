
public class Figure
{
    public virtual float CalculateArea()
    {
        Console.WriteLine("Площу фігури розраховано");
        return 0;
    }
}
class Rectangle : Figure
{
    public float Width { get; set; }
    public float Height { get; set; }
    public override float CalculateArea()
    {
        float area = Width * Height;
        Console.WriteLine($"площа прямокутника {area}");
        return area;
    }
}
class Circle : Figure
{
    public float Radius { get; set; }
    public override float CalculateArea()
    {
        float area = (float) (Math.PI *  Radius*Radius);
        Console.WriteLine($"Площа кола = {area}");
        return area;
    }
}
class Triangle : Figure
{
    public float Base { get; set; }
    public float Height { get; set; }
    public override float CalculateArea()
    {
        float area = 0.5f * Base * Height;
        Console.WriteLine($"Площа трикутника = {area}");
        return area;
    }
}
class Program
{
    static void Main()
    {
            Figure[] figures = new Figure[5];
            figures[0] = new Circle { Radius = 2 };
            figures[1] = new Rectangle { Width = 3, Height = 4 };
            figures[2] = new Triangle { Base = 5, Height = 2 };
            figures[3] = new Circle { Radius = 5 };
            figures[4] = new Rectangle { Width = 10, Height = 2 };
        for (int i =0;i<figures.Length;i++)
        {
            Console.WriteLine($"Фігура №{i + 1}");
            figures[i].CalculateArea();
            Console.WriteLine();
        }
    }
}
