using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

    /* 4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
    que o nome não seja vazio e que a idade seja maior que zero. */ 
namespace Exercicio4
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        public string Nome
        {
            get { return nome; }
            set 
            { 
                if (string.IsNullOrEmpty(nome)) { Console.WriteLine("Nome não pode ser vazio"); }
                else { nome = value; }
            }
        }

        public int Idade  {
            get { return idade; }
            set 
            {
                if (idade > 0) { idade = value; }
                else { Console.WriteLine("Nome não pode menor que zero"); }
            }
        }
    }
}
