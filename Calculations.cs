using System;
namespace laba2
{
    class Calculations:Screen
    {
        public double Value { get; set; }
        public double Counting(double percent, double investment, double intAnswerTerm)
        {
            Value = investment / intAnswerTerm;
            percent = (percent * Value) / 100;
            Value += percent;
            return Value;
        }
    }
}
