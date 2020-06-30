namespace ESGI.DesignPattern.Projet
{
    public class UnusedRiskFactors
    {
        private UnusedRiskFactors()
        {

        }

        public static UnusedRiskFactors GetFactors()
        {
            return new UnusedRiskFactors();
        }

        public double ForRating()
        {
            return 0.01;
        }
    }
}