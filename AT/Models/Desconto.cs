namespace AT.Models
{
    public class Desconto
    {
        public delegate decimal CalculateDelegate(decimal valor);

        public static decimal DarDesconto(decimal valor)
        {
            return valor * 0.9m;
        }
    }
}
