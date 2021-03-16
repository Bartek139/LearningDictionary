using LearningDictionaryUI.Mobile.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningDictionaryUI.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WordsPage();
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
