using System;

namespace ESGI.DesignPattern.Projet
{
    public class LoanBuilder
    {
        private double commitment = 1.0;
        private DateTime start = ApplicationDateTime.Now;
        private DateTime? expiry;
        private DateTime? maturity;
        private CapitalStrategy strategy;
        private int riskRating;
        private double unusedPercentage = 1.0;
        private double outstanding = 0;

        public Loan Build()
        {
            return new Loan(
                commitment,
                start,
                expiry,
                maturity,
                riskRating,
                strategy,
                unusedPercentage,
                outstanding
            );
        }

        public static Loan NewRevolver(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            return new LoanBuilder()
                .WithCommitment(commitment)
                .WithStartDate(start)
                .WithExpiryDate(expiry)
                .WithMaturityDate(null)
                .WithRiskRating(riskRating)
                .WithOutstanding(0)
                .WithStrategy(new CapitalStrategyRevolver())
                .Build();
        }

        public static Loan NewAdvisedLine(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            if (riskRating > 3)
                return null;
            return new LoanBuilder()
                .WithCommitment(commitment)
                .WithStartDate(start)
                .WithExpiryDate(expiry)
                .WithMaturityDate(null)
                .WithRiskRating(riskRating)
                .WithOutstanding(0)
                .WithStrategy(new CapitalStrategyAdvisedLine())
                .WithUnusedPercentage(0.1)
                .Build();
        }

        public static Loan NewTermLoan(double commitment, DateTime start, DateTime maturity, int riskRating)
        {
            return new LoanBuilder()
                .WithCommitment(commitment)
                .WithStartDate(start)
                .WithExpiryDate(null)
                .WithMaturityDate(maturity)
                .WithRiskRating(riskRating)
                .WithOutstanding(0)
                .WithStrategy(new CapitalStrategyTermLoan())
                .Build();
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

        public LoanBuilder WithOutstanding(double outstanding)
        {
            this.outstanding = outstanding;
            return this;
        }
    }
}
