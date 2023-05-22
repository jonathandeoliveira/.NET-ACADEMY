using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AlunosXYZ
{
    internal class Aluno : Pessoa
    {
        private string v1;
        private string v2;

        public string Matricula { get; set; }
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }
        public Aluno(string matricula, string codigoCurso, string nomeCurso, Pessoa pessoa): base(pessoa.Nome, pessoa.Telefone, pessoa.Cidade, pessoa.Rg, pessoa.Cpf)
        {
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
    }
}
