namespace GradeBook
{
    public class Book
    {
        private List<double> grades;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        private string name;

        private double sumOfGrades;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public char GetLetterGrade(double grade)
        {
            switch (grade)
            {
                case var g when g >= 90:
                    return 'A';
                case var g when g >= 80:
                    return 'B';
                case var g when g >= 70:
                    return 'C';
                case var g when g >= 60:
                    return 'D';
                default:
                    return 'F';

            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
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
                // grade.Letter = AddLetterGrade(grade); add per grade in the future
            }
            result.Average /= grades.Count;
            result.Letter = GetLetterGrade(result.Average);
            Console.WriteLine($"Statistics for {Name}'s class:");
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
            var index = 0;
            while (index < grades.Count)
            {
                highScore = Math.Max(grades[index], highScore);
                index += 1;
            };
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
            Console.WriteLine($"Statistics for {Name}'s class:");
            Console.WriteLine($"Number of Students: {grades.Count}");
        }
    }
}