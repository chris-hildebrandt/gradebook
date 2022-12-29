namespace GradeBook
{
    public class Stats
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double HighScore;
        public double LowScore;
        public char Letter
        {
            get
            {
                switch (Average)
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
        }
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count++;
            LowScore = Math.Min(number, LowScore);
            HighScore = Math.Max(number, HighScore);
        }

        public Stats()
        {
            Count = 0;
            HighScore = double.MinValue;
            LowScore = 101;
            Sum = 0;
        }
    }
}