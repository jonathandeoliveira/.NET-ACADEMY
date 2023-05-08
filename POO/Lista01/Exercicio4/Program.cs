namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
            que o nome não seja vazio e que a idade seja maior que zero. */

            Pessoa p = new Pessoa();
            Console.WriteLine("Digite seu nome");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            p.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("-------- Fim ---------");
        }
    }
}