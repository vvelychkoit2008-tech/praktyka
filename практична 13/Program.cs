class Vyraz
{
    public string Value { get; set; }
    // мій любімий пустий конструктор
    public Vyraz() { }
    public Vyraz(string text)
    {
        Value = text; 
    }
}
class LongVyraz : Vyraz
{
    public int Length { get; }
    public LongVyraz(string text)
    {
        Value = text;
        Length = text.Length;
    }
}
class Program
{
    static void Main()
    {
        LongVyraz vyraz = new LongVyraz("ещкере");
        Console.WriteLine($"Вираз: {vyraz.Value}, Довжина: {vyraz.Length}");
    }
}