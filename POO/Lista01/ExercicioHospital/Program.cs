namespace ExercicioHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UnidadeSaude obj1 = new UnidadeSaude("Unidade de Pronto Atendimento", "UPA");

            obj1.Responsavel.Nome = "Fulano Beltrano de Ciclano";
            obj1.Responsavel.Tipo = "Médico";
            obj1.Responsavel.Credencial = "MED123";
            obj1.Responsavel.identificacao();

            Paciente pac1 = new Paciente("Joao das Neves","12345678910", DateOnly.Parse("01/02/2003"),"joao@email.com");
            ProfissionalSaude resp1 = new ProfissionalSaude("Fulano Beltrano de Ciclano", "Médico", "MED123");
            Triagem t1 = new Triagem(resp1,pac1,108,1.90,122,38,"vermelho");
        }
    }
}