namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* •Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço.
            Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.
            Já, os valores do segundo objeto, deverão ser definidos no código-fonte da classe que o criou. Exiba na tela os resultados. */

            string marca, modelo;
            int tipo;
            double preco;
            Computador pc1 = new Computador();
            Console.WriteLine("Digite os dados de um Computador");
            Console.WriteLine("Marca:");
            pc1.marca = Console.ReadLine();
            Console.WriteLine("Modelo:");
            pc1.modelo = Console.ReadLine();
            Console.WriteLine("Tipo: 1-Notebook | 2-Desktop | 3-Tablet | 4- Outros ");
            pc1.tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço:");
            pc1. preco = double.Parse(Console.ReadLine());

            Computador pc2 = new Computador("Apple","Macbook", 1 ,99999.99);

            Console.WriteLine("Dados do Computador 1");
            pc1.exibeDados();
            Console.WriteLine("Dados do Computador 2");
            pc2.exibeDados();

        }


    }
}