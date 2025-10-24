class Button
{
    private static int Count = 0;
    public void Click()
    {
        Count++;
        Console.WriteLine("К-сть кліків: " + Count);
    }
}
class Program
{
    static void Main()
    {
        Button b1 = new Button();
        Button b2 = new Button();
        b1.Click();
        b2.Click();
        b1.Click();
    }
}