namespace Exercicio1;
class Program
{
    static void Main(string[] args)
    {
        //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
        Console.WriteLine("Digite quatro números")
        int n1 = Console.ReadLine();
        int n2 = Console.ReadLine();
        int median = (n1 + n2) / 2;
        Console.WriteLine("A média dos números digitados é:" + median)
    }
}
