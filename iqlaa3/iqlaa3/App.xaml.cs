using iqlaa3.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iqlaa3
{
    public partial class App : Application
    {
        static Iqla3DB database;

        public static Iqla3DB Database
        {
            get
            {
                if (database == null)
                {
                    database = new Iqla3DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "iqlaa3.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
