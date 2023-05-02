namespace L01Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. 
             * Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.
             * Esses valores devem ser solicitados ao usuário, por linha de execução */


            Carro c1 = new Carro();
            Carro c2 = new Carro();
            Console.WriteLine("Digite a marca do carro 1: ");
            c1.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro 1: ");
            c1.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do carro 1: ");
            c1.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a marca do carro 2: ");
            c2.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro 2: ");
            c2.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do carro 2: ");
            c2.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Carro 1:");
            c1.exibeDados();
            Console.WriteLine("Carro 2:");
            c2.exibeDados();


        }
    }
}