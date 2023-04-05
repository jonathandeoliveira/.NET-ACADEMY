namespace lista2exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado”  se a média das duas notas for maior ou igual a 7,0. */
            Console.WriteLine("Digite duas notas de um aluno");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double median = (n1 + n2)/2;
            if (median >= 7) {
                Console.WriteLine("Aluno Aprovado");
            }
            else{
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}