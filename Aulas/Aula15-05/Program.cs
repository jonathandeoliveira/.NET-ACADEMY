namespace Aula15_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.potencia = 150;
            veiculo.modelo = "Gol";
            veiculo.Ligar();


            VeiculoEletrico veiculoEletrico = new VeiculoEletrico();
            veiculoEletrico.potencia = 100;
            veiculoEletrico.modelo = "Tesla";
            veiculoEletrico.autonomia = 10;
            veiculoEletrico.Ligar();
            veiculoEletrico.Carregar();
        }
    }
}