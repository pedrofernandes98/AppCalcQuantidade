using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppQuantidade
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();//Ao terminar de carregar a APP inicial

            MainPage = new MainPage();//Propriedade = new Instância da Classe MainPage()
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
