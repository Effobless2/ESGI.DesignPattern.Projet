using System;

namespace ESGI.DesignPattern.Projet

{
    public class Payment
    {
        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public Payment(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}