using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0205
{
    internal class Pessoa
    {
        public int idade;
        public string nome;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void exibeDados()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Idade:" + this.idade);
     
        }
    }
}
