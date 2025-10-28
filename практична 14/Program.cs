class Button
{
    private int Count = 0;
    public string Name { get; set; }

    public void Click()
    {
        Count++;
    }

    public void Show()
    {
        Console.WriteLine("У " + Name + " к-сть кліків: " + Count);
    }
}

class Program
{
    static void Main()
    {
        Button b1 = new Button() { Name = "перша кнопочка" };
        Button b2 = new Button() { Name = "друга кнопочка" };

        b1.Click();
        b2.Click();
        b1.Click();

        b1.Show();
        b2.Show();
    }
}
