class auto
{
    private int zapal;
    public string Model { get; set; }
    private int Speed { get; set; } = 0;
    public auto(string model, int kod)
    {
        Model = model;
        zapal = kod;
    }
    public void ac()
    {
        Speed += 3;
        Console.WriteLine($"{Model} прискорюється, швидкість: {Speed}");
    }
    public void slow()
    {
        Speed -= 10;
        if (Speed < 0)
        {
            Speed = 0;
        }
        Console.WriteLine($"{Model} гальмує, поточна швидкість: {Speed}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        auto a = new auto("Toyota", 1);
        var random = new Random();
        int r = random.Next(5, 15);
        Console.WriteLine("\n--- Розгін ---");
        for (int i = 0; i < r; i++)
        {
            a.ac();
        }
        Console.WriteLine("\n--- Гальмування ---");
        for (int i = 0; i < r + 1; i++)
        {
            a.slow();
        }
    }
}