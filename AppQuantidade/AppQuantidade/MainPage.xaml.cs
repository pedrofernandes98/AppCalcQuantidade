using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        //int quantidade = 1;
        bool flagValor1 = false;
        int valor1 = 0;
        int valor2 = 0;
        int operacao;
        int resultado;

        public MainPage()
        {
            InitializeComponent(); //Inicialização dos Componentes da Tela

        }

        private void OnClickMais(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Entrada.Text))
            {
                operacao = 1;
                valor1 = Convert.ToInt32(Entrada.Text);
                Entrada.Text = "";
            }
            else
            {
                lblResultado.Text = "Digite um número para fazer uma operação";
            }
        }

        private void OnClickMenos(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Entrada.Text))
            {
                operacao = 2;
                valor1 = Convert.ToInt32(Entrada.Text);
                Entrada.Text = "";
            }
            else
            {
                lblResultado.Text = "Digite um número para fazer uma operação";
            }
        }

        private void OnClickCalcular(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Entrada.Text))
            {
                valor2 = Convert.ToInt32(Entrada.Text);
                Entrada.Text = "";

                switch (operacao)
                {
                    case 1:
                        resultado = valor1 + valor2;
                        lblResultado.Text = resultado.ToString();
                        break;
                    case 2:
                        resultado = valor1 - valor2;
                        lblResultado.Text = resultado.ToString();
                        break;
                    default:
                        lblResultado.Text = "Erro ao efetuar a operação";
                        break;
                }

                valor1 = 0;
                valor2 = 0;
            }
            else
            {
                lblResultado.Text = "Digite um número para fazer uma operação";
            }
        }

        private void redirectToAppQtd(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppQtd());
        }
    }
}
