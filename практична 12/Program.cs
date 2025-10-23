class Animal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    public void Hello()
    {
        Console.WriteLine($"{Name} каже {Sound}");
    }
}
class Dog : Animal
{
    public Dog()
    {
        Name = "собака";
        Sound = "мяу";
    }
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Hello();
    }
}