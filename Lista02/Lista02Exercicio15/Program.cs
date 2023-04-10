namespace Lista02Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
            e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
            Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

            double area; double qtd_tinta; double qtd_lata; ; double valor_lata = 80; double valor_total;
            Console.WriteLine("Olá, bem vindo ao assistente de tintas!\n Digite o valor da área em m² que deseja pintar:");
            area = double.Parse(Console.ReadLine());
            qtd_tinta = (area / 3);
            qtd_lata = (qtd_tinta / 18);
            valor_total = (qtd_lata * valor_lata);
            Console.WriteLine($"Para cobrir uma área de {area}m² você precisará de {qtd_tinta} litros de tinta," +
                $" que são aproximadamente {qtd_lata} latas em um total de aproximadamente R${valor_total}");
            
        }
    }
}