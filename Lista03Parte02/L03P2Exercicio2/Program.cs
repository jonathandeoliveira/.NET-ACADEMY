namespace L03P2Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
                informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
                Exemplo:
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
 
                Deseja informar outro número (s/n)? S
 
                Digite um número inteiro positivo: 12
                Numero digitado: 20
                Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
                Deseja informar outro número (s/n)? N  */

            int num;
            while (true)
            {
                do
                {
                    Console.WriteLine("Por favor, digite um numero positivo.");
                    num = int.Parse(Console.ReadLine());
                    ;
                }
                while (num < 1);
                Console.WriteLine($"Números pares entre 1 e {num};");
                for (int i = 1; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Deseja digitar outro número (s/n)?");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 's')
                {
                    continue;
                }
                else if (resp == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            }
        }
    }
}