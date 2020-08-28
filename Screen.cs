using System;
namespace laba2
{
    public class Screen
    {
        public string Answer { get; set; }
        public string Bank { get; set; }
        public double Term { get; set; }
        public double Investment { get; set; }
        public double Percent { get; set; }

        public void WantYesOrNo()
        {
            while (true)
            {
                Console.Write("Do you want to take a loan? (Yes/No) ");
                Answer = Console.ReadLine();
                if (Answer == "Yes" ^ Answer == "No") { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }

        public void SecectOrSearch()
        {
            while (true)
            {
                Console.Write("Do you want to find or search a loan? (Search/Select) ");
                Answer = Console.ReadLine();
                if(Answer == "Search" ^ Answer == "Select") { break; }
                else {Console.WriteLine("Your answer is incorrect. Try again");}
            }
        }

        public void Search()
        {
            while (true)
            {
                Console.Write("Search the banks:");
                Bank = Console.ReadLine();
                if (Bank == "Privat" ^ Bank == "Alfa" ^ Bank == "OTP") { break; }
                else { Console.WriteLine("We do not have such a bank, please choose from these: Privat/Alfa/OTP"); }
            }

            while (true)
            {
                Console.Write("Write a loan term (mounth): ");
                Term = double.Parse(Console.ReadLine());
                if(Term > 0) { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }

            while (true)
            {
                Console.Write("Enter investment amount: ");
                Investment = double.Parse(Console.ReadLine());
                if (Investment > 0) { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }


        public void Select()
        {
            while (true)
            {
                Console.WriteLine("Select one of the banks:Privat   Alfa   OTP ");
                Bank = Console.ReadLine();
                if (Bank == "Privat" ^ Bank == "Alfa" ^ Bank == "OTP"){break;}
                else {Console.WriteLine("Your answer is incorrect. Try again");}
            }
        
            while (true)
            {
                Console.WriteLine("Choose one of the term:3   6   12 ");
                Term = double.Parse(Console.ReadLine());
                if (Term == 3 ^ Term == 6 ^ Term == 12) { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        
            while (true)
            {
                Console.WriteLine("Select the desired investment amount:1000   2000   3000 ");
                Investment = double.Parse(Console.ReadLine());
                if (Investment == 1000 ^ Investment == 2000 ^ Investment == 3000) { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }

        public void Increase()
        {
            while (true)
            {
                Console.Write("Would you like to increase your credit limit? (Yes/No) ");
                Answer = Console.ReadLine();
                if (Answer == "Yes" ^ Answer == "No") { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }

        public void IncreaseLimit()
        {
            while (true)
            {
                Console.Write("Enter a new investment amount: ");
                Investment = double.Parse(Console.ReadLine());
                if (Investment > 0) { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }

        public void RepaymentOfLoan()
        {
            while (true)
            {
                Console.Write("You want early repayment of the loan? (Yes/No) ");
                Answer = Console.ReadLine();
                if (Answer == "Yes" ^ Answer == "No") { break; }
                else { Console.WriteLine("Your answer is incorrect. Try again"); }
            }
        }
    }
}
