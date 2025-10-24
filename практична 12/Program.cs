
class Animal
{
    private string name;
    private string sound;
    public string Name { get { return name; } }
    public string Sound { get { return sound; } }

    protected Animal(string name, string sound)
    {
        this.name  = name;
        this.sound = sound;
    }

    public void Hello()
    {
        Console.WriteLine($"{Name} каже {Sound}");
    }
}
class Dog : Animal
{
    public Dog(): base("собака", "мяу")
    { }
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Hello();
    }
}