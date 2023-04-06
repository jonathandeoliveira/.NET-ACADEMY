using System.Xml.Serialization;

namespace Lista2Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
            O cálculo do imc = peso / (altura * altura)
                        IMC 
            menor que 18                -> baixo peso
            maior que 18 e menor que 25 -> peso normal
            maior que 25 e menor que 30 -> sobrepeso
            maior que 30 e menor que 35 -> obesidade
            maior que 35                -> obesidade grau sério */

            Console.WriteLine("Insira seu nome");
            string name = Console.ReadLine();

            Console.WriteLine("Insira sua Altura (em Metros)");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu Peso (em Kg)");
            double weight = double.Parse(Console.ReadLine());

            double imc = weight / (height * height);

            Console.WriteLine("O IMC de " + name.ToUpper() + " é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("Situação: Magreza");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Situação: Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Situação: Sobrepeso");
            }
            else if (imc >= 30 && imc < 40)
            {
                Console.WriteLine("Situação: Obesidade");
            }
            else
            {
                Console.WriteLine("Situação: Obesidade grave");
            }
   

        }
    }
}