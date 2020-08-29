using System;
namespace laba2
{
    interface ICredit
    {
        string Answer { get; set; }
        string Bank { get; set; }
        double Term { get; set; }
        double Investment { get; set; }
        double Percent { get; set; }

        void ReadAnswer();
        void ReadBank();
        void ReadTerm();
        void ReadInvestment();
    }
}
