namespace speed
{
    internal class speed { }
    public class auto
    {
        private class dvygun
        {
            public void start()
            {
                Console.WriteLine("пєрємога буде");
            }
        }
        public void zapusk()
        {
            dvygun d = new dvygun();
            d.start();
        }
    }
    class Program
    {
        static void Main()
        {
            auto a = new auto();
            a.zapusk();
        }
    }
}