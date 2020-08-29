using System;
namespace laba2
{
    class Text
    {
        public void TakeLoan() => Console.Write("Do you want to take a loan? (Yes/No) ");

        public void SecectOrSearchLoan() => Console.Write("Do you want to select or search a loan? (Search/Select) ");

        public void SearchBank() => Console.Write("Search the banks (Privat/Alfa/OTP): ");

        public void SearchTerm() => Console.Write("Write a loan term (mounth): ");

        public void SearchInvestment() => Console.Write("Enter the desired credit limit amount: ");

        public void SelectBank() => Console.WriteLine("Select one of the banks: Privat   Alfa   OTP ");

        public void SelectTerm() => Console.WriteLine("Choose one of the term: 3   6   12 ");

        public void SelectInvestment() => Console.WriteLine("Select the desired investment amount: 1000   2000   3000 ");

        public void IncreaseCredit() => Console.Write("Would you like to increase your credit limit? (Yes/No) ");

        public void Repayment() => Console.Write("You want early repayment of the loan? (Yes/No) ");

        public void Mistake() => Console.WriteLine("Your answer is incorrect. Try again");

        public void Bye() => Console.WriteLine("Thank you bye");

        public void Congratulations() => Console.WriteLine("Congratulations, you repaid the loan!");
    }
}
