using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/* 5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite. Utilize o encapsulamento para 
        garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
        ser alterado */
namespace Exercicio5
{
    internal class Conta
    {
        private double limite;
        private double saldo;
        private int numero;

        public Conta(int numero, double saldo, double limite)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
        }

        public double Limite 
        { 
            get { return limite; }
            set 
            { 
                if (limite >0) { limite = value;}
                else { Console.WriteLine("O limite deve ser um valor positivo."); }
            } 
        }

        public double Saldo 
        {
            get { return saldo; }
            set 
            { 
                if (saldo >= 0) { saldo = value;}
                else { Console.WriteLine("O saldo deste cliente deve ser um valor positivo."); }
            }
        }

        public int Numero 
        {
            get { return numero; }
        }
    }
}
