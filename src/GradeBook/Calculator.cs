namespace GradeBook
{
    class Calculator
    {
        private double sumOfGrades;
        private double lowestGrade = 101;
        private double highestGrade = double.MinValue;
        private double averageScore = 0;

        public void AddGrade(double grade, List<double>grades)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public void GetSumOfGrades(List<double>grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                sumOfGrades += grades[i];
            }
        }
        public void GetHighestGrade(List<double>grades)
        {
            foreach (var number in grades)
            {
                highestGrade = Math.Max(number, highestGrade);
            }
        }
        public void GetLowestGrade(List<double>grades)
        {
            foreach (var number in grades)
            {
                lowestGrade = Math.Min(number, lowestGrade);
            }
        }
        public void GetAverageGrade(List<double>grades)
        {
            averageScore = sumOfGrades / grades.Count;
        }
    }
}