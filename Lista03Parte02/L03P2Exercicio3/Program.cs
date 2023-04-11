namespace L03P2Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
                    Se o usuário digitar 0 o programa em VS deve parar. 
                    Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. */

            int num;
            do {
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());
                if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0 && num % num == 0)
                {
                    Console.WriteLine($"O número {num} é um número primo");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine($"O número {num} é par");
                    if (num == 2)
                    {
                        Console.WriteLine("e também é um número primo");
                    }
                }
                else {
                    Console.WriteLine($"O número {num} é impar");
                }

            } while (num != 0);

        }
    }
}