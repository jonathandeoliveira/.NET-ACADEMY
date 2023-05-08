namespace Exercicio5
{
    internal class Program
    {
        /* 5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite. Utilize o encapsulamento para 
                garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
                ser alterado */
        static void Main(string[] args)
        {
            int numero = 123456789;
            double saldo = 1000000;
            double limite = 5000000;

            Conta c = new Conta(numero,saldo,limite);

            Console.WriteLine($"Sua conta é {c.Numero}, com saldo de: ${c.Saldo} e limite de: ${c.Limite}");

            Console.WriteLine("Digite um novo valor para seu saldo:");
            c.Saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para seu novo limite");
            c.Limite = double.Parse(Console.ReadLine());
            // c.Numero = int.Parse(Console.ReadLine()); <- não é possivel alterar pois não tem o set

            Console.WriteLine($"Sua conte é {c.Numero}, com o novo saldo de: ${c.Saldo} e o novo limite de: ${c.Limite}");

        }
    }
}