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
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }
        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double a = 0, b = 0, t = 0;
            a = Convert.ToDouble(etValorA.Text);
            b = Convert.ToDouble(etValorB.Text);
            if (btn.Text == "+")
            {
                t = a + b;
            }
            if (btn.Text == "-")
            {
                t = a - b;
            }
            if (btn.Text == "*")
            {
                t = a * b;
            }
            if (btn.Text == "/")
            {
                t = a / b;
            }
            lblResp.Text = t.ToString();
        }
    }
}