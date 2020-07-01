using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Loan
    {

        public readonly DateTime? Expiry;
        public readonly DateTime? Maturity;

        public IList<Payment> Payments { get; } = new List<Payment>();
        public double Outstanding { get; }
        public readonly DateTime? Today;
        public readonly DateTime Start;
        public readonly double RiskRating;
        public readonly double UnusedPercentage;
        private readonly CapitalStrategy capitalStrategy;

        public double Commitment { get; }

        internal Loan(double commitment,
                    DateTime start,
                    DateTime? expiry,
                    DateTime? maturity,
                    int riskRating,
                    CapitalStrategy capitalStrategy,
                    double unusedPercentage,
                    double outstanding)
        {
            Commitment = commitment;
            Expiry = expiry;
            Today = null;
            Start = start;
            Maturity = maturity;
            RiskRating = riskRating;
            this.capitalStrategy = capitalStrategy;
            UnusedPercentage = unusedPercentage;
            Outstanding = outstanding;
        }

        public void Payment(double amount, DateTime paymentDate)
        {
            Payments.Add(new Payment(amount, paymentDate));
        }

        public double Capital()
        {
            return capitalStrategy.Capital(this);
        }

        public double UnusedRiskAmount()
        {
            return Commitment - Outstanding;
        }

        public double Duration()
        {
            return capitalStrategy.Duration(this);
        }
    }
}