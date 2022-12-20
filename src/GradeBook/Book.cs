namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;
        private double sumOfGrades;
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
        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.HighScore = double.MinValue;
            result.LowScore = 101;
            foreach (var grade in grades)
            {
                result.LowScore = Math.Min(grade, result.LowScore);
                result.HighScore = Math.Max(grade, result.HighScore);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            Console.WriteLine($"Statistics for {name}'s class:");
            Console.WriteLine($"Number of Students: {grades.Count}");
            return result;
        }
        public void GetSumOfGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                sumOfGrades += grades[i];
            }
        }
        public double GetHighestGrade()
        {
            double highScore = double.MinValue;
            foreach (var number in grades)
            {
                highScore = Math.Max(number, highScore);
            }
            return highScore;
        }
        public double GetLowestGrade()
        {
            double lowScore = 101;
            foreach (var number in grades)
            {
                lowScore = Math.Min(number, lowScore);
            }
            return lowScore;
        }
        public double GetAverageGrade()
        {
            double averageScore = sumOfGrades / grades.Count;
            return averageScore;
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Statistics for {name}'s class:");
            Console.WriteLine($"Number of Students: {grades.Count}");
        }
    }
}