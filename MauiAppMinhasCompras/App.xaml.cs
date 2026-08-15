using Microsoft.Extensions.DependencyInjection;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            //Mainpage = new AppShell());
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}