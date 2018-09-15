using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace pwp
{
    public partial class App : Application
    {
        private static AcessoDB database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static AcessoDB DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new AcessoDB(DependencyService.Get<IConfig>().getLocalPath("banco.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
