

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeting = new Greeting(args);
            greeting.Message(args);
            var book = new Book("Professor H");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var stats = book.GetStats();

            Console.WriteLine($"Highest Score: {stats.LowScore}");
            Console.WriteLine($"Lowest Score: {stats.HighScore}");
            Console.WriteLine($"Average Score: {stats.Average:N2}");
        }
    }
}
