namespace Aula0604_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operation;
            double n1; double n2; double result;
            int op = 0;
            Console.WriteLine("Olá, Bem vindo a Calculadora!\n");
            Console.WriteLine("Digite + Para somar!\n");
            Console.WriteLine("Digite - Para Subtrair!\n");
            Console.WriteLine("Digite x Para multiplicar!\n");
            Console.WriteLine("Digite / Para Dividir!\n");
            operation = Console.ReadLine()[0];
            switch (operation)
            {
                case '+':
                    Console.WriteLine("Soma selecionada, digite dois números para realizar a operação:");
                    Console.WriteLine("Digite n1:");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite n2:");
                    n2 = double.Parse(Console.ReadLine());
                    result = n1 + n2;
                    Console.WriteLine("O resultado da operação é: " + result);
                    break;

                case '-':
                    Console.WriteLine("Subtração selecionada, digite dois números para realizar a operação:");
                    Console.WriteLine("Digite n1:");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite n2:");
                    n2 = double.Parse(Console.ReadLine());
                    result = n1 - n2;
                    Console.WriteLine("O resultado da operação é: " + result);
                    break;

                case 'x':
                    Console.WriteLine("Multiplicação selecionada, digite dois números para realizar a operação:");
                    Console.WriteLine("Digite n1:");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite n2:");
                    n2 = double.Parse(Console.ReadLine());
                    result = n1 * n2;
                    Console.WriteLine("O resultado da operação é: " + result);
                    break;
                case '/':
                    Console.WriteLine("Divisão selecionada, digite dois números para realizar a operação:");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                    result = n1 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine("Erro: divisão por zero");
                        break;
                    }
                    Console.WriteLine("O resultado da operação é: " + result);
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    return;
            }

        

        }
    }
}