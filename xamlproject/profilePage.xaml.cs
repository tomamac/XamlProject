using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace xamlproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class profilePage : ContentPage
    {
        public profilePage()
        {
            InitializeComponent();
        }

        private void facebookTapped(object sender, EventArgs e)
        {
            try
            {
                Browser.OpenAsync("https://www.facebook.com/Tomamacz");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void youtubeTapped(object sender, EventArgs e)
        {
            try
            {
                Browser.OpenAsync("https://www.youtube.com/channel/UCS4RqYonbbmOElkLTjdco1A");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void twitchTapped(object sender, EventArgs e)
        {
            try
            {
                Browser.OpenAsync("https://www.twitch.tv/tomamac");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void profileTapped(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}