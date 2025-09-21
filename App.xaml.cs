
using MauiLayouts.Pages;

namespace MauiLayouts
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            //MainPage = new StackLayoutDemo();
            var navigationPage = new NavigationPage(new StackLayoutDemo());
            MainPage = navigationPage;
        }


    }
}