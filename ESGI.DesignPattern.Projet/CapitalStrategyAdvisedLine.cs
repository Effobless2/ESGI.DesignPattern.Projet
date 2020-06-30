namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.Commitment * loan.UnusedPercentage * Duration(loan) * RiskFactorFor();
        }
    }
}