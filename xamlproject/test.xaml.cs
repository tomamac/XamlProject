using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamlproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class test : ContentPage
    {
        public test()
        {
            InitializeComponent();
            login.Clicked += Login_Clicked;
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            loginField.Children.Remove(password);
            loginField.Children.Remove(login);
            loading.IsRunning = true;
            await Task.Delay(10000);
            await Navigation.PushAsync(new mockMain());
            loading.IsRunning = false;
            //pc.Children.Remove(windows);
        }

        private async void shutdownTapped(object sender, EventArgs e)
        {
            try
            {
                //await Navigation.PopModalAsync();
                shutdownLabel.IsVisible = true;
                loading.IsRunning = true;
                await Task.Delay(5000);
                Environment.Exit(0);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}