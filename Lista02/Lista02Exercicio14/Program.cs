namespace Lista02Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
            do arquivo usando este link (em minutos). */

            double file; double internet_vel; double download_time;
            Console.WriteLine("Digite o tamanho do arquivo em MB:");
            file = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade da sua internet em Mbps");
            internet_vel = double.Parse(Console.ReadLine());
            download_time = (file * 8 / (internet_vel));

            Console.WriteLine($"O tempo de download do seu arquivo será de: {download_time} segundos");


        }
    }
}