using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(this.Average)
                {   
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
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
            this.Sum += number;
            this.Count++;
            this.Low = Math.Min(number, this.Low);
            this.High = Math.Max(number, this.High);
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0.0;
            this.High = double.MinValue;
            this.Low = double.MaxValue;
        }
    }
}