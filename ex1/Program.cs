public class Ex1
{
    public delegate double CalculateDelegate(double valor);

    public static void Main(string[] args)
    {
        bool valorValido = false;
        do
        {
            Console.WriteLine("Insira o valor da diária: ");
            string valor = Console.ReadLine();

            if (!double.TryParse(valor, out double valorValidado))
            {
                if (valorValidado < 0)
                {
                    Console.WriteLine("Insira um valor válido.\n");
                }
            }
            else
            {
                valorValido = true;
            }
        }
        while (valorValido == false);
    }
}