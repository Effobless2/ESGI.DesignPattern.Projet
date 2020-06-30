using System;

namespace ESGI.DesignPattern.Projet
{
    public class LoanBuilder
    {
        private double commitment = 0;
        private DateTime start = DateTime.Now;
        private DateTime? expiry;
        private DateTime? maturity;
        private CapitalStrategy strategy;
        private int riskRating;
        private double unusedPercentage = 1;

        public Loan Build()
        {
            return new Loan(
                commitment,
                start,
                expiry,
                maturity,
                riskRating,
                strategy,
                unusedPercentage
            );
        }

        public LoanBuilder WithCommitment(double commitment)
        {
            this.commitment = commitment;
            return this;
        }

        public LoanBuilder WithUnusedPercentage(double unusedPercentage)
        {
            this.unusedPercentage = unusedPercentage;
            return this;
        }

        public LoanBuilder WithStartDate(DateTime start)
        {
            this.start = start;
            return this;
        }

        public LoanBuilder WithExpiryDate(DateTime? expiry)
        {
            this.expiry = expiry;
            return this;
        }

        public LoanBuilder WithMaturityDate(DateTime? maturity)
        {
            this.maturity = maturity;
            return this;
        }

        public LoanBuilder WithRiskRating(int riskRating)
        {
            this.riskRating = riskRating;
            return this;
        }

        public LoanBuilder WithStrategy(CapitalStrategy strategy)
        {
            this.strategy = strategy;
            return this;
        }

    }
}
