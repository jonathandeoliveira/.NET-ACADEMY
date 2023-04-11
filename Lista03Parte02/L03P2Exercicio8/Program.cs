namespace L03P2Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8. Faça um programa em VS que solicite um numero inteiro. S
            e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
            Finalmente, pergunte ao usuário se ele quer repetir o programa em VS. */

            int num, restart;
            bool parse;
            while (true)
            {
                do
                {
                    Console.WriteLine("Digite um número inteiro:");
                    parse = int.TryParse(Console.ReadLine(), out num);

                } while (!parse);

                if (num % 2 == 0) { Console.WriteLine($"O número {num} é par"); }
                else { Console.WriteLine($"O número {num} é impar"); }

                Console.WriteLine("Deseja repetir o programa? \n Sim = 1 | Não = 0 \n");
                restart = int.Parse(Console.ReadLine());
                if (restart == 0)
                {
                    Console.WriteLine("Encerrando Programa");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}