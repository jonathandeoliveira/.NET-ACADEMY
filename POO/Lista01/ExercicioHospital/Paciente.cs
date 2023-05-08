using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHospital
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Paciente()
        {
        }
        public Paciente(string nome, string email, DateOnly dataNascimento, string cpf)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public Paciente(string nome, DateOnly dataNascimento, string cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public int Idade()
        {
             return DateTime.Now.Year;
        }
    }
}
