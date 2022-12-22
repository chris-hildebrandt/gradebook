namespace GradeBook
{
    class RandomGradeArray
    {
        public RandomGradeArray(int studentCount)
        {
           List<double> grades = this.GetGrades(studentCount);
        }
           List<double> grades = new List<double>();
        public List<double> GetGrades(int studentCount)
        {
            Random grade = new Random();
            for (var i = 0; i < studentCount; i++)
            {
                grades.Add(Math.Round(grade.NextDouble() * 100, 2));
            }
            return grades;
        }
    }
}