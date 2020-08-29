using System;
namespace laba2
{
    class Calculations :Screen
    {
        public double Value { get; set; }
        public void Counting(double percent, double investment, double term)
        {
            
            percent = (percent * (investment / term)) / 100;
            Value = investment / term + percent;
        }
    }
}
