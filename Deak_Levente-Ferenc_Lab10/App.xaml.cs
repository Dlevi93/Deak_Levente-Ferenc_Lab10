using System;
using System.IO;
using Data;
using Deak_LeventeFerenc_Lab10;
using Xamarin.Forms;

namespace Deak_Levente_Ferenc_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase _database;
        public static ShoppingListDatabase Database => _database ?? (_database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3")));

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
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
