namespace L03P2Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14. Mostrar as potências de 2 variando de 0 a 10. */

            for (int i = 0; i <= 10 ; i++)
            {
                double potencia = Math.Pow(2, i);
                Console.WriteLine($"A potenciação de 2 elevado a {i} é de: {potencia}");
            }
        }
    }
}