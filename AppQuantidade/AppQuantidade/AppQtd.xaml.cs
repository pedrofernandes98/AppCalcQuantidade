using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;

namespace AppQuantidade
{
    public partial class AppQtd : ContentPage
    {
        int quantidade = 1;
        

        public AppQtd()
        {
            InitializeComponent(); //Inicialização dos Componentes da Tela

        }

        private void OnClickMais(object sender, EventArgs e)
        {
            ++quantidade;
            lblResultado.Text = quantidade.ToString();
        }

        private void OnClickMenos(object sender, EventArgs e)
        {
            if(quantidade > 0)
            {
                --quantidade;
                lblResultado.Text = quantidade.ToString();
            }
            
        }

        private void RedirectToCalculadora(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
