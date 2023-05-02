namespace Aula0205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa:");
            p.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade pessoa:");
            p.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine($"A pessoa instanciada é: {p.nome}");
            //Console.WriteLine($"E tem {p.idade} anos");
            p.exibeDados();

        }
    }
}