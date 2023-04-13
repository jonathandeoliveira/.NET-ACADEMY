namespace L04Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
                a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                b.	escreve: 	|22|7|31|63|0|21|9|3|40|7| */

             int[] vetor = new int[10];
             int[] vetor_reverso = new int[10];

             Random random = new Random();
             for (int i = 0; i < vetor.Length; i++)
             {
                 vetor[i] = random.Next(1, 101);
                 Console.WriteLine($"Valor da posição {i + 1} do vetor 1 é de {vetor[i]}");
             }
             Console.WriteLine("----------------------------------");

             for (int i = 0 ; i < vetor.Length; i++)
             {
                 vetor_reverso[i] = vetor[vetor.Length - i - 1];
                 Console.WriteLine($"Valor da posição {i+1} do vetor reverso é de {vetor_reverso[i]}");
             }
        }
    }
}