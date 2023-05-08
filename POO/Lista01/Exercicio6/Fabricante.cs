using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* 6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
            Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
            seja vazio e que o preço seja positivo.  */
namespace Exercicio6
{
    internal class Fabricante
    {
        private string nome;
        private string endereco;
        private string cidade;

        public Fabricante(string nome, string endereco, string cidade)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
        }

        public string Nome 
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) { Console.WriteLine("Nome não pode ser vazio"); }
                else { nome = value; }
            }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }   
        }

        

    }
}
