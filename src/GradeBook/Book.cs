namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        private double sumOfGrades;
        private double lowestGrade = 101;
        private double highestGrade = double.MinValue;
        private double averageScore = 0;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }
        public void GetSumOfGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                sumOfGrades += grades[i];
            }
        }
        public void GetHighestGrade()
        {
            foreach (var number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
            }
        }
        public void GetLowestGrade()
        {
            foreach (var number in grades)
            {
                lowestGrade = Math.Min(number, lowestGrade);
            }
        }
        public void GetAverageGrade()
        {
            averageScore = sumOfGrades / grades.Count;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Statistics for {name}'s class:");
            Console.WriteLine($"Number of Students: {grades.Count}");
            Console.WriteLine($"Highest Score: {lowestGrade}");
            Console.WriteLine($"Lowest Score: {highestGrade}");
            Console.WriteLine($"Average Score: {averageScore:N2}");
        }
    }
}