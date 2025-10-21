class auto
{
    private int zapal;
    public string Model { get; set; }
    public auto(string model, int kod)
    {
        Model = model;
        zapal = kod;
    }
    public void ac()
    {
        Console.WriteLine(Model + " прискорюється");
    }
    public void slow()
    {
        Console.WriteLine(Model + " гальмує");
    }
}
class Program
{
    static void Main(string[] args)
    {
        auto a = new auto("Toyota", 1);
        a.ac();
        a.slow();
    }
}