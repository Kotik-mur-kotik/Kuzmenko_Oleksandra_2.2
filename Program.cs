
using System;

namespace laba2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculations calculations = new Calculations();
            Text text = new Text();
            Screen screen = new Screen();
            Screen limit = new Calculations();
            screen.WantYesOrNo();
            if (screen.No()){ text.Bye(); return; }
            screen.SecectOrSearch();
            if (screen.SelectVerity()) { screen.Select(); }
            else { screen.Search(); }
            screen.PercentVerity();
            calculations.Counting(screen.Percent, screen.Investment, screen.Term);
            Console.WriteLine($"Your monthly payment: {calculations.Value}");
            screen.Increase();
            if (screen.Yes())
            {
                limit.IncreaseLimit();
                calculations.Counting(screen.Percent, limit.Investment, screen.Term);
                Console.WriteLine($"Your monthly payment: {calculations.Value}");
            }
            screen.RepaymentOfLoan();
            if (screen.Yes()) { text.Congratulations(); return; }
            
        }
        
    }
}
