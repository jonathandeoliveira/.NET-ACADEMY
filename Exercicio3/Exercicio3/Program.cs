namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.
            int a = 10; int b = 30; int memoria = 0;
            Console.WriteLine($"Vamos trocar os valores atuais?" + "Os Valores atuais são: A= " + a + " e B= " + b);
            memoria = a;
            a = b;
            b = memoria;
            Console.WriteLine("Os novos valores são: A= " + a + " e B=" + b);
;        }
    }
}