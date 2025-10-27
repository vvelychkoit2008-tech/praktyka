class Button
{
    private int Count = 0; // приватний лічильник для кожної кнопки
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

        b1.Show(); // У перша кнопочка к-сть кліків: 2
        b2.Show(); // У друга кнопочка к-сть кліків: 1
    }
}
