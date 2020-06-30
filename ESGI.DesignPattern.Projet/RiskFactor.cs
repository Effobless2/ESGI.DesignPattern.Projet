namespace ESGI.DesignPattern.Projet
{
    public class RiskFactor
    {
        private RiskFactor()
        {

        }

        public static RiskFactor GetFactors()
        {
            return new RiskFactor();
        }

        public double ForRating()
        {
            return 0.03;
        }
    }
}
