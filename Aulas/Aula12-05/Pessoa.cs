﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_05
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }

        public Pessoa(string nome, string email, string dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = gerarEmail();
        }

        public string gerarEmail()
        {
            try
            {
                string[] linha = Nome.Split();
                if (linha.Length == 1)
                {
                    Email = linha[0].ToLower() + "@aula.ufn.br";
                }
                else
                {
                    Email = linha[linha.Length - 1].ToLower() + "_" + linha[0].ToLower() + "@aula.ufn.br";
                }
            }
            catch (Exception)
            {
                Email = "sem email";
            }
        }

        public override string ToString()
        {
            return Nome + " : " + Email;
        }
    }
}