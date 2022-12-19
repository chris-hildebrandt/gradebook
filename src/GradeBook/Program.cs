

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
            DisplaySumOfGrades();
            
        }
    }
}
