
using System;

namespace laba2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculations calculations = new Calculations();
            Screen screen = new Screen();
            screen.WantYesOrNo();
            if (screen.Answer == "No") { Console.WriteLine("Thank you bye"); return; }
            screen.SecectOrSearch();
            if (screen.Answer == "Select") { screen.Select(); }
            else { screen.Search(); }
            if (screen.Bank == "Privat") { screen.Percent = 7; }
            else if (screen.Bank == "Alfa") { screen.Percent = 5.01; }
            else { screen.Percent = 2.25; }
            calculations.Counting(screen.Percent, screen.Investment, screen.Term);
            Console.WriteLine($"Your monthly payment: {calculations.Value}");
            screen.Increase();
            if (screen.Answer == "Yes")
            {
                screen.IncreaseLimit();
                calculations.Counting(screen.Percent, screen.Investment, screen.Term);
                Console.WriteLine($"Your monthly payment: {calculations.Value}");
            }
            screen.RepaymentOfLoan();
            if (screen.Answer == "Yes") { Console.WriteLine("Congratulations, you repaid the loan!"); return; }
            
        }
        
    }
}
