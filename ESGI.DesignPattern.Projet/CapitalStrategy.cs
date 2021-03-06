﻿using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {

        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;

        public abstract double Capital(Loan loan);

        protected double RiskFactorFor()
        {
            return RiskFactors.Basic;
        }

        public virtual double Duration(Loan loan)
        {
            return YearsTo(loan.Expiry, loan);
        }

        protected double YearsTo(DateTime? endDate, Loan loan)
        {
            DateTime? beginDate = (loan.Today.HasValue ? loan.Today : loan.Start);
            return (double)((endDate?.Ticks - beginDate?.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }
    }
}