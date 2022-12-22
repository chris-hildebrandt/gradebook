

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {         
            var greeting = new Greeting(args);
            greeting.Message(args);
            var book = new Book("Professor H");

            while(true)
            {
                Console.WriteLine("Enter a grade, or 'q' when done");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                book.AddGrade(double.Parse(input));
            }

            var stats = book.GetStats();

            Console.WriteLine($"Highest Score: {stats.LowScore}");
            Console.WriteLine($"Lowest Score: {stats.HighScore}");
            Console.WriteLine($"Average Score: {stats.Average:N2}");
        }
    }
}
