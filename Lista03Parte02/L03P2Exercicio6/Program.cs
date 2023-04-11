namespace L03P2Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
                ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
                Ao final, mostre a idade digitada. */

            int idade;
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite uma idade válida!");
                idade = int.Parse(Console.ReadLine());
            } while (idade < 0);
            Console.WriteLine($"Sua idade é: {idade} ano(s)");
        }
    }
}