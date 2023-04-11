namespace L03P2Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
                A cada solicitação, teste se o usuário informou um valor válido. 
                Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
                informe que ele está incorreto e saia do programa em VS. 
                Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
                informe que está errada e saia. Se estiver correta, solicite o salário. 
                Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
                Se estiver correto, mostre todos os valores lidos. */

            string nome;
            double salario;
            int idade;

            while (true)
            {
                Console.WriteLine("Olá, digite seu nome:");
                nome = Console.ReadLine();
                if (nome == null || !nome.All(char.IsLetter))
                {
                    Console.WriteLine("Nome em formato incorreto! Encerrando programa.");
                    break;
                }
                Console.WriteLine("Digite sua idade");
                idade = int.Parse(Console.ReadLine());
                if (idade == null || idade <= 0 )
                {
                    Console.WriteLine("Idade em formato incorreto! Encerrando programa.");
                    break;
                }
                Console.WriteLine("Digite seu salário");
                salario = double.Parse(Console.ReadLine());
                if (salario  == null || salario <= 0)
                {
                    Console.WriteLine("Idade em formato incorreto! Encerrando programa.");
                    break;
                }
                Console.WriteLine($"Dados informados:\n\n Nome: {nome} \n idade: {idade}\n Salario:{salario}");
                break;
            }

        }
    }
}