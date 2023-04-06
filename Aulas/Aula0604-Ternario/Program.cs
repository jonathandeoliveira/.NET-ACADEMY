namespace Aula0604_Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Digite um numéro:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i+" é "+(i % 2 == 0 ? "par" : "impar"));
        }
    }
}