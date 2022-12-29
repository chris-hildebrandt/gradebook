

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {         
            var greeting = new Greeting(args);
            greeting.Message(args);
            var book = new Book("Professor H");
            book.GradeAdded += OnGradeAdded;

            while(true)
            {
                Console.WriteLine("Enter a grade, or 'q' when done");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try 
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("*****");
                }
            }

            var stats = book.GetStats();

            Console.WriteLine($"Highest Score: {stats.LowScore}");
            Console.WriteLine($"Lowest Score: {stats.HighScore}");
            Console.WriteLine($"Average Score: {stats.Average:N2}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A Grade Was Added");
        }
    }
}
