using System.Runtime.CompilerServices;

namespace Exercicio6
{
    internal class Program
    {
        /* 6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
                Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
                seja vazio e que o preço seja positivo.  */
        static void Main(string[] args)
        {
            string nomeFabricante = "Brinquedos SA";
            string endereco = "Rua das brincadeiras 100";
            string cidade = "Cidade das Crianças";
            Fabricante fabricante = new Fabricante(nomeFabricante,endereco,cidade);
            Console.WriteLine("Novo nome do fabricante:");
            fabricante.Nome = Console.ReadLine();
            Produto produto = new Produto();
            produto.Fabricante = fabricante;
            Console.WriteLine("Preço do produto:");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome do produto");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"PRODUTO: \n nome: {produto.Nome} \n valor: {produto.Preco} \n Fabricado por:{produto.Fabricante.Nome}");
            Console.WriteLine($"FABRICANTE: \n nome: {fabricante.Nome} \n Endereço: {fabricante.Endereco},{fabricante.Cidade}");

        }
    }
}