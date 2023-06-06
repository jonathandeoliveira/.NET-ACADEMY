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
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            btnExecutar.Clicked += BtnExecutar_Clicked;
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(etValor.Text);
            String resp = "O número " + etValor.Text + " é: ";
            if (n % 2 == 0) 
            {
                resp += "par";
            }
            else
            {
                resp += "ímpar";
            }
            lblResp.Text = resp;
        }
    }
}