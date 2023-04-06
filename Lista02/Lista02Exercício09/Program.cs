using System.Numerics;

namespace Lista02Exercício09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
            menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
            150, avisá-lo que será necessário adicionar 2 unidades de insulina. */

            int v1; int v2; int v3; double median;
            Console.WriteLine("Digite o valor 1 da glicemia:");
            v1 = int.Parse(Console.ReadLine());
            if (v1 < 65) { Console.WriteLine("Cuidado! Risco de Hipoglicemia"); }
            if (v1 > 250) { Console.WriteLine("Cuidado! Risco de Hiperclicemia"); }

            Console.WriteLine("Digite o valor 2 da glicemia:");
            v2 = int.Parse(Console.ReadLine());
            if (v2 < 65) { Console.WriteLine("Cuidado! Risco de Hipoglicemia"); }
            if (v2 > 250) { Console.WriteLine("Cuidado! Risco de Hiperclicemia"); }

            Console.WriteLine("Digite o valor 3 da glicemia:");
            v3 = int.Parse(Console.ReadLine());
            if (v3 < 65) { Console.WriteLine("Cuidado! Risco de Hipoglicemia");}
            if (v3 > 250) { Console.WriteLine("Cuidado! Risco de Hiperclicemia");}
            median = (v1 + v2 + v3) / 3;
            if (median < 80) { Console.WriteLine("Diminua duas doses de insulina");}
            if (median > 150) { Console.WriteLine("Aumente duas doses de insulina");}
        }
    }
}