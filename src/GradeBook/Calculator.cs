namespace GradeBook
{
    class Calculator
    {
        public void DisplaySumOfGrades()
        {
            var sumOfGrades = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sumOfGrades += grades[i];
            }
            Console.WriteLine($"average score: {sumOfGrades / grades.Length}");
        }
        public void DisplayHighestGrade()
        {
            var highestGrade = double.MinValue;
            foreach (var number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
            }
            Console.WriteLine("highest grade: " + highestGrade);
        }
        public void DisplayLowestGrade()
        {
            var lowestGrade = 0;
            foreach (var number in grades)
            {
                lowestGrade = Math.Max(number, lowestGrade);
            }
            Console.WriteLine("highest grade: " + lowestGrade);
        }
        public void DisplayAverageGrade()
        {
            double averageScore = 0;
            double sum = 0;
            foreach (double number in scores)
            {
                sum += number;
            }
            averageScore = sum / scores.Count;
            Console.WriteLine($"average score: {averageScore:N2}");
        }
    }
}