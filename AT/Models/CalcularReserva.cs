namespace AT.Models
{
    public class CalcularReserva
    {
        public static Func<int, int, decimal> CalcReserva = (numDiarias, valorDiarias) =>
        {
            return numDiarias * valorDiarias;
        };
    }
}
