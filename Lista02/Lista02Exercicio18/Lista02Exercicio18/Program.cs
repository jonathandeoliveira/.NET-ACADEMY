namespace Lista02Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles. */

            Console.WriteLine("Olá digite 3 valores:");
            Console.WriteLine("Digite n1:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite n2:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite n3:");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 == n2 || n1 == n3 || n2 == n3) {
                Console.WriteLine("Algum dos números são iguais!");
                return;
            }
            else if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"N1 é o número maior:{n1}");
                if (n2 > n3)
                {
                    Console.WriteLine($"N2 é o segundo número maior:{n2}");
                    Console.WriteLine($"N3 é o número menor:{n3}");
                }
                else if (n3 > n2)
                {
                    Console.WriteLine($"N3 é o  segundo número maior:{n3}");
                    Console.WriteLine($"N3 é o número menor:{n3}");
                }
            }

            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"N2 é o número maior{n2}");
                if (n1 > n3)
                {
                    Console.WriteLine($"N1 é o segundo número maior:{n1}");
                    Console.WriteLine($"N3 é o número menor:{n3}");
                }
                else if (n3 > n1)
                {
                    Console.WriteLine($"N3 é o segundo número maior:{n3}");
                    Console.WriteLine($"N1 é o número menor:{n1}");
                }

            }
            else if (n3 > n1 && n3 > n2) ; { Console.WriteLine($"N3 é o número maior{n3}");
                if (n1 > n2)
                {
                    Console.WriteLine($"N1 é o segundo número maior:{n1}");
                    Console.WriteLine($"N2 é o número menor:{n2}");
                }
                else if (n2 > n1) {
                    Console.WriteLine($"N2 é o segundo número maior:{n2}");
                    Console.WriteLine($"N1 é o número menor:{n1}");
                }
            }
        }
    }
}