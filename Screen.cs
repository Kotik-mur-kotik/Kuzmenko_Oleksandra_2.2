using System;
namespace laba2
{
    class Screen : ICredit

    {
        readonly Text text = new Text();
        private bool Verity { get; set; }
        public string Answer { get; set; }
        public string Bank { get; set; }
        public double Term { get; set; }
        public double Investment { get; set; }
        public double Percent { get; set; }

        public void WantYesOrNo()
        {
            while (true)
            {
                text.TakeLoan();
                ReadAnswer();
                if (YesNo()) { break; }
                else { text.Mistake(); }
            }
        }

        public void SecectOrSearch()
        {
            while (true)
            {
                text.SecectOrSearchLoan();
                ReadAnswer();
                if (SecectSearch()) { break; }
                else { text.Mistake(); }
            }
        }

        public void Search()
        {
            while (true)
            {
                text.SearchBank();
                ReadBank();
                if (PrivatAlfaOTP()) { break; }
                else { text.Mistake(); }
            }

            while (true)
            {
                text.SearchTerm();
                ReadTerm();
                if(TermAboveZero()) { break; }
                else { text.Mistake(); }
            }

            while (true)
            {
                text.SearchInvestment();
                ReadInvestment();
                if (InvestmentAboveZero()) { break; }
                else { text.Mistake(); }
            }
        }
        

        public void Select()
        {
            while (true)
            {
                text.SelectBank();
                ReadBank();
                if (PrivatAlfaOTP()) {break;}
                else { text.Mistake(); }
            }
        
            while (true)
            {
                text.SelectTerm();
                ReadTerm();
                if (TermVerity()) { break; }
                else { text.Mistake(); }
            }
        
            while (true)
            {
                text.SelectInvestment();
                ReadInvestment();
                if (InvestmentVerity()) { break; }
                else { text.Mistake(); }
            }
        }
        
        public void Increase()
        {
            while (true)
            {
                text.IncreaseCredit();
                ReadAnswer();
                if (YesNo()) { break; }
                else { text.Mistake(); }
            }
        }

        public void IncreaseLimit()
        {
            while (true)
            {
                text.SearchInvestment();
                ReadInvestment();
                if (InvestmentAboveZero()) { break; }
                else { text.Mistake(); }
            }
        }

        public void RepaymentOfLoan()
        {
            while (true)
            {
                text.Repayment();
                ReadAnswer();
                if (YesNo()) { break; }
                else { text.Mistake(); }
            }
        }

        private bool YesNo()
        {
            Verity = (Answer == "Yes" ^ Answer == "No");
            return Verity;
        }

        private bool SecectSearch()
        {
            Verity = (Answer == "Search" ^ Answer == "Select");
            return Verity;
        }

        protected bool PrivatAlfaOTP()
        {
            Verity = (Bank == "Privat" ^ Bank == "Alfa" ^ Bank == "OTP");
            return Verity;
        }

        private bool TermAboveZero()
        {
            Verity = (Term > 0);
            return Verity;
        }

        private bool InvestmentAboveZero()
        {
            Verity = (Investment > 0);
            return Verity;
        }

        protected bool TermVerity()
        {
            Verity = (Term == 3 ^ Term == 6 ^ Term == 12);
            return Verity;
        }

        protected bool InvestmentVerity()
        {
            Verity = (Investment == 1000 ^ Investment == 2000 ^ Investment == 3000);
            return Verity;
        }

        public bool No()
        {
            Verity = (Answer == "No");
            return Verity;
        }

        public bool Yes()
        {
            Verity = (Answer == "Yes");
            return Verity;
        }

        public bool SelectVerity()
        {
            Verity = (Answer == "Select");
            return Verity;
        }

        public double PercentVerity()
        {
            Percent = (Answer == "Privat") ? Percent : 7;
            Percent = (Answer == "Alfa") ? Percent : 2.25;
            Percent = (Answer == "OTP") ? Percent : 5.01;
            return Percent;
        }

        public void ReadAnswer()
        {
            Answer = Console.ReadLine();
        }

        public void ReadBank()
        {
            Bank = Console.ReadLine();
        }

        public void ReadTerm()
        {
            Term = double.Parse(Console.ReadLine());
        }

        public void ReadInvestment()
        {
            Investment = double.Parse(Console.ReadLine());
        }
    }
}
