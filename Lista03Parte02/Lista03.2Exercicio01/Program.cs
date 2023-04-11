namespace Lista03._2Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
                                Exemplo:
                    Digite um número inteiro positivo: -8
                    Valor incorreto!
                    Digite um número inteiro positivo: 8
                    Numero digitado: 8
                    Números inteiros pares entre 1 e 8: 2, 4, 6. */

            int num;
            do
            {
                Console.WriteLine("Por favor, digite um numero positivo.");
                num = int.Parse(Console.ReadLine());
                ;
            }
            while (num < 1);
            Console.WriteLine($"Números pares entre 1 e {num};");
            for (int i = 1;  i < num; i++)
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}