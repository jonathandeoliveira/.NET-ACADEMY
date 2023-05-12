using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0905
{
    internal class Pessoa
    {
        private string _nome;
        private string _email;
        private Endereco _endereco;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) { Console.WriteLine("Nome não pode ser vazio"); }
                else { _nome = value; }
            }
        }
        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Email
        {
            get { return _email; }
                set { _email = value; }
        }

    }
}
