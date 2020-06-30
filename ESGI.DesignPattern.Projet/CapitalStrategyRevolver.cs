namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return (loan.Outstanding * Duration(loan) * RiskFactorFor())
                        + (loan.UnusedRiskAmount() * Duration(loan) * UnusedRiskFactorFor());
        }

        private double UnusedRiskFactorFor()
        {
            return UnusedRiskFactors.GetFactors().ForRating();
        }
    }
}