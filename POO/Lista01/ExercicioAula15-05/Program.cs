namespace ExercicioAula15_05
{
    /* 
            Criar uma classe Veiculo que contém as propriedades Marca e Modelo. 
            Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. 
            A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. 
            Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>".
            Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas"
            e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.marca = "Ford";
            carro.modelo = "Mustang";
            carro.QuantidadeDePortas = 2;
            carro.Dirigir();
            Motocicleta motocicleta = new Motocicleta();
            motocicleta.marca = "Indian";
            motocicleta.modelo = "Scout";
            motocicleta.Cilindrada = 1200;
            motocicleta.Dirigir();
        }
    }
}