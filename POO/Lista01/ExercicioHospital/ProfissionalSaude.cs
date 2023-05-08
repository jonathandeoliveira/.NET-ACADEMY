using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHospital
{
    internal class ProfissionalSaude
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Credencial { get; set; }

        public ProfissionalSaude(string nome, string tipo, string credencial)
        {
            Nome = nome.ToUpper();
            Tipo = tipo.ToUpper();
            Credencial = credencial.ToUpper();
        }
        public ProfissionalSaude()
        {
        }

        public string identificacao()
        {
            string[] lista = Nome.Split();
            return lista[lista.Length - 1] + " - " + Credencial;
        }



    }
}
