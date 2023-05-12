using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
EmitirSom, que imprime na tela o som do animal. */
namespace Exercicio10
{
    internal class Animal
    {
        private string nome;
        private string especie;
        private int idade;

        public Animal(string nome, string especie, string idade)
        {
            this.nome = _nome;
            this.especie = especie;
            this.idade = idade;
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

        public string Especie
        {
            get { return especie; }
            set
            {
                if (string.IsNullOrEmpty(value)) { Console.WriteLine("Espécie não pode ser vazio"); }
                else { especie = value; }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0) { Console.WriteLine("Idade não pode ser vazio"); }
                else { idade = value; }
            }
        }


    }


}