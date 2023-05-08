using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHospital
{
    internal class UnidadeSaude 
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public ProfissionalSaude Responsavel { get; set; }

        public UnidadeSaude()
        {
        }

        public UnidadeSaude(string nome, string codigo)
        {
            Nome = nome;
            Codigo = codigo;
            Responsavel = new ProfissionalSaude();
        }
    }
}
