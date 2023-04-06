namespace Lista02Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
                O programa deve exibir se a hora digitada está ou não válida. 
                Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/

            Console.WriteLine("Olá, digite uma hora entre 0 e 23:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite um minuto entre 0 e 59:");
            int min = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
            {
                Console.WriteLine("Hora válida!");
            }
            else
            {
                Console.WriteLine("Hora inválida!");
            }
        }
    }
}