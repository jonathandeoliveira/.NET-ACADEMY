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
    internal class Produto
    {
        private string nome;
        private double preco;
        private Fabricante fab;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) { Console.WriteLine("Nome não pode ser vazio"); }
                else { nome = value; }
            }
        }

        public double Preco
        { 
            get { return preco; }
            set 
            {  
                if (value > 0) { preco = value; }
                else { Console.WriteLine("O preço não pode menor que zero"); }
                
            }
        }
        public Fabricante Fabricante
        { 
            get { return fab; }
            set { fab = value; }
        }

    }
}
