namespace lista2exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            Mostrar na tela qual dos professores tem o maior salário total.  */
            Console.WriteLine("Olá Professor1, Insira a quantidade de horas de aulas dadas");
            float teacher1_hours = float.Parse(Console.ReadLine());
            Console.WriteLine("Olá Professor1, Insira sua quantidade recebida por hora");
            double teacher1_hour_value = double.Parse(Console.ReadLine());
            double teacher1_salary = (teacher1_hours * teacher1_hour_value);

            Console.WriteLine("Olá Professor2, Insira a quantidade de horas de aulas dadas");
            float teacher2_hours = float.Parse(Console.ReadLine());
            Console.WriteLine("Olá Professor1, Insira sua quantidade recebida por hora");
            double teacher2_hour_value = double.Parse(Console.ReadLine());
            double teacher2_salary = (teacher2_hours * teacher2_hour_value);


            if (teacher1_salary > teacher2_salary)
            {
                Console.WriteLine("O professor1 tem um salário maior.");
            }
            else if (teacher2_salary > teacher1_salary)
            {
                Console.WriteLine("O professor2 tem um salário maior.");
            }
            else {
                Console.WriteLine("Os professores tem um salário igual.");

            }
        }
    }
}