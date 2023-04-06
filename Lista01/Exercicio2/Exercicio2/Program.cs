namespace Exercicio2;
class Program
{
    static void Main(string[] args)
    {
        // 2)Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
        Console.WriteLine("Digite quatro números");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int median = (n1 + n2 + n3 + n4)/4;
        Console.WriteLine("A média dos números digitados é:" + median);
    }
}
