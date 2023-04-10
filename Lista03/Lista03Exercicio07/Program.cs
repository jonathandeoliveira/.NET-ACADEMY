namespace Lista03Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  7- Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
                um usuário. Apresente o resultado.  */
            int numero; int conta_par = 0; int conta_impar = 0;  
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Digite um número: ({i}) de 20");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0) {
                    conta_par += 1;
                }
                else { 
                    conta_impar += 1;
                }
            }
            Console.WriteLine($"A quantidade de numeros ímpares é de: {conta_impar}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"A quantidade de numeros ímpares é de: {conta_par}");

        }
    }
}