namespace Lista02Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
            R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
            armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
            No final do processamento, exibir o salário total e o salário excedente do operário.*/

            Console.WriteLine("Informe o Código do trabalhador:");
            double codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas trabalhas pelo trabalhador:");
            double numeroHoras = double.Parse(Console.ReadLine());
            double horasExtra = 0; double salario; double salarioExtra = 0;

            if (numeroHoras > 50)
            {
                horasExtra = numeroHoras - 50;
                salarioExtra = horasExtra * 20;
                salario = (50 * 10) + salarioExtra;
                Console.WriteLine($"O salário total do funcionário será de:{salario}, sendo {salarioExtra} o valor das horas extras.");
            }
            else{
                salario = (numeroHoras * 10);
                Console.WriteLine($"O salário total do funcionário será de:{salario}, sendo {salarioExtra} o valor das horas extras.");
            }
        }
    }
}