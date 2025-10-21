internal class Task
{
    public long id { get; set; }
    public string Text { get; set; } = "довгий текст";
    public Task(long id)
    {
        this.id = id;
        Console.WriteLine($"об'єкт з id={this.id} створено");
    }
    ~Task()
    {
        Console.WriteLine($"об'єкт з id={this.id} знищено");
    }
}
public class Host
{
    public void Run()
    {
        var array = new Task[10000];
        for(var i = 0; i<10000; i++)
        {
            array[i] = new Task(i);
        }
        array = new Task[0];
        Console.WriteLine("цикл завершено");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("виконано збирач сміття");
        
    }
}
class Program
{
    static void Main()
    {
        Host h = new Host();
        for (int i=0; i<30; i++)
        {
            Console.WriteLine($"запуск {i+1}");
            h.Run();
            Console.WriteLine();
        }
        Console.WriteLine("завершено");
    }
}