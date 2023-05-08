namespace Aula0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Marca = "VW";
            c.Ano = 1999;
            c.Modelo = "Polo";
            c.Motor = new Motor();
            c.Motor.Cilindradas = 2000;
       
            while (true)
            {
                Console.WriteLine("Digite 1 para ligar e 2 para desligar");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    c.LigarCarro();
                }
                else if (op == 2)
                {
                    c.DesligarCarro();
                }
                else if (op == 0) 
                {
                    break;
                }
            }
        }
    }
}