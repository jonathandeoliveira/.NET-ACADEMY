using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWF_AlunosXYZ
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }
        public Aluno(string matricula, string codigoCurso, string nomeCurso, Pessoa pessoa) : base(pessoa.Nome, pessoa.Telefone, pessoa.Cidade, pessoa.Rg, pessoa.Cpf)
        {
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }




    }
}
