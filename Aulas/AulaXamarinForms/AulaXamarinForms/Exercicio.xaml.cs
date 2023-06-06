using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AulaXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio : ContentPage
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void btnEmail(object sender, EventArgs e)
        {
            string[] nome = etName.Text.Split(' ');
            string email = $"{nome[nome.Length - 1].ToLower()}{nome[0].ToLower()}@ufn.edu.br";
            lblEmail.Text = "Email Gerado: " + email;
        }
        private void btnIMC(object sender, EventArgs e)
        {
            double peso, altura;
            peso = double.Parse(etWeight.Text);
            altura = double.Parse(etHeight.Text);
            if (altura > 2.5) 
            {
                altura = altura / 100;
            }
            double imc = peso / (altura * altura);
            lblIMC.Text = "Seu valor de IMC é de: " + imc.ToString("F2");
        }
    }
}