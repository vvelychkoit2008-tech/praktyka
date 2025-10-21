class tochka
{
    public int X { get; set; }
    public int Y { get; set; }
    // конструктор за замовчуванням бо c# не знає який конструктор викликати
    public tochka() { }
    // p.s: до мене це дійшло не зразу
    public tochka(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void hello()
    {
        Console.WriteLine($"координати точки: X = {X}, Y = {Y}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // конструктор з параметрами ❤
        tochka t1 = new tochka(5, 10);
        t1.hello();

        // конструктор тільки більше розписувать блін 💔
        tochka t2 = new tochka();
        t2.X = 15;
        t2.Y = 20;
        t2.hello();
    }
}

//я такими темпами почну писати код на Assembly, бо це просто жесть якась.