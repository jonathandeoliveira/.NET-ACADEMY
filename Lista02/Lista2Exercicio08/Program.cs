namespace Lista2Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
             total de vendas. */

            double worker_code; double default_salary; double total_sales; string worker_name; double bonus; double bonus_salary;
;           Console.WriteLine("Digite o nome do funcionário:");
            worker_name = Console.ReadLine();
            Console.WriteLine("Digite o código do funcionário:");
            worker_code = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Salário base do funcionário:");
            default_salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas, em reais, do funcionário:");
            total_sales = double.Parse(Console.ReadLine());

            if (total_sales > 500 && total_sales <= 1000){ 
                bonus = (default_salary * (5/100)); 
                bonus_salary = (default_salary + bonus); 
            }
            else if (total_sales > 1000 && total_sales <= 5000){ 
                bonus = default_salary * (7 / 100); 
                bonus_salary = default_salary + bonus;
            }
            else {
                bonus = default_salary * (10 / 100);
                bonus_salary = default_salary + bonus;
            }

            Console.WriteLine($"Parabéns, devido ao seu desempenho em vendas, seu salário será de: {bonus_salary}");

        }
    }
}