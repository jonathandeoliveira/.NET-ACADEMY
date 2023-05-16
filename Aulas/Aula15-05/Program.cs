namespace Aula15_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Veiculo veiculo = new Veiculo();
            veiculo.potencia = 150;
            veiculo.modelo = "Gol";
            veiculo.Ligar();


            VeiculoEletrico veiculoEletrico = new VeiculoEletrico();
            veiculoEletrico.potencia = 100;
            veiculoEletrico.modelo = "Tesla";
            veiculoEletrico.autonomia = 10;
            veiculoEletrico.Ligar();
            veiculoEletrico.Carregar();
            */



            /* Cavalo cavalo = new Cavalo("Pangaré",21,"mestiço");
            cavalo.emitirSom(); */

            IMotor motor;
  
            Console.WriteLine("Digite 1 para motor eletrico e 2 para motor a combustao");
            int op = int.Parse(Console.ReadLine());
            if (op == 1) 
            { 
                motor = new MotorEletrico();
                motor.Ligar();
                motor.Desligar();
            }
            else if (op == 2) 
            {
                motor = new MotorCombustao();
                motor.Ligar();
                motor.Desligar();
            }

           
        }
    }
}