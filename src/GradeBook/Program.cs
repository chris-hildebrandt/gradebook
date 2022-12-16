using System;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] grades = {25, 50, 99, 50, 75, 25, 50};
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
            {
                float sumOfGrades = 0;
                for(int i = 0; i < grades.Length; i++)
                {
                    sumOfGrades += grades[i];
                }
                Console.WriteLine($"average score: {sumOfGrades/grades.Length}");
            }
            {
                float highestGrade = 0;
                for(int i = 0; i < grades.Length; i++)
                {
                    if(grades[i] > highestGrade){
                        highestGrade = grades[i];
                    }
                }
                Console.WriteLine("highest grade: " +highestGrade);

            }
        }
    }
}
