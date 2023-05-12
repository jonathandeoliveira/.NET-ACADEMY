using System.Security.Cryptography;

namespace Aula0905
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Joao das neves";
            p.Email = "joao@email.com";
            Console.WriteLine($"Nome:{p.Nome}");
            Console.WriteLine($"Endereço: {p.Email}");
            p.Endereco = new Endereco();
            p.Endereco.Rua = "Rua Um";
            p.Endereco.Num = 1;
            p.Endereco.Complemento = "Depois da casa 0, antes da casa 2";
            Console.WriteLine($"Endereço: Rua:{p.Endereco.Rua}\n Numero: :{p.Endereco.Num} \n Complemento: {p.Endereco.Complemento} ");
            Pessoa p1 = new Pessoa();
            p1.Endereco = new Endereco();
            p1.Nome = "Fabio Silva";
            p1.Email = "fabio@email.com";
            p1.Endereco.Rua = "Rua dois";
            p1.Endereco.Num = 2;
            p1.Endereco.Complemento = "Depois da casa 1, antes da casa 3";
            Pessoa p2 = new Pessoa();
            p2.Endereco = new Endereco();
            p2.Nome = "Zé das Couve ";
            p2.Email = "couve@email.com";
            p2.Endereco.Rua = "Rua tres";
            p2.Endereco.Num = 3;
            p2.Endereco.Complemento = "Depois da casa 2, antes da casa 4";


            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            foreach(Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine($"Nome:{pessoa.Nome}");
                Console.WriteLine($"Endereço: {pessoa.Email}");
                Console.WriteLine($"Endereço: Rua:{pessoa.Endereco.Rua}\n Numero: :{pessoa.Endereco.Num} \n Complemento: {pessoa.Endereco.Complemento} ");

            }

            for(int i = 0; i < listaPessoas.Count; i++)
            {
                Console.WriteLine($"Nome:{listaPessoas[i].Nome}");
                Console.WriteLine($"Endereço: {listaPessoas[i].Email}");
                Console.WriteLine($"Endereço: Rua:{listaPessoas[i].Endereco.Rua}\n Numero: :{listaPessoas[i].Endereco.Num} \n Complemento: {listaPessoas[i].Endereco.Complemento} ");
            }















        }
    }
}