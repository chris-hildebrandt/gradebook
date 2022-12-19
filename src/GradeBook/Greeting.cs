namespace GradeBook
{
    class Greeting
    {
        public Greeting(string[] args)
        {
            
        }
        public void Message(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    Console.WriteLine("Hello " + arg + "!!!");
                }
            }
            else
            {
                Console.WriteLine("no input given");
            }
        }
    }
}