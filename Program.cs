namespace HelloEdugrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var name = Console.ReadLine(); //InmatningsHanterare, läser vad som skrivs in i konsollen
            var currentDate = DateTime.Now;
            Console.WriteLine(value: $"Hej, {name}, på {currentDate}");
        }
    }
}