namespace exercicio_exemploFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  •Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x. */
            int x;
            Console.WriteLine("Olá, digite um número");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine('\n');
            for (int i = 0; i <= 100; i += x) {
                Console.WriteLine(i);
            }

        }
    }
}