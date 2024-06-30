using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamlproject
{
    public partial class MainPage : ContentPage
    {
        bool state = true;
        public MainPage()
        {
            InitializeComponent();
            lightSwitch.Clicked += LightSwitch_Clicked;
            profile.Clicked += Profile_Clicked;
            achievement.Clicked += Achievement_Clicked;
        }

        private async void Achievement_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new achievementPage());
        }

        private async void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new profilePage());
        }

        private async void LightSwitch_Clicked(object sender, EventArgs e)
        {
            if (state == true) {
                darkLabel.FadeTo(0,1000);
                arrowGrid.FadeTo(0,1000);
                lightSwitchLabel.FadeTo(0,1000);
                light.Opacity = 0.5;
                profile.Opacity = 1;
                frame1.Opacity = 1;
                frame2.Opacity = 1;
                //profileLabel.Opacity = 1;
                achievement.Opacity = 1;
                desktop.Opacity = 1;
                roomWall.BackgroundColor = Color.FromHex("#333");
                room.BackgroundColor = Color.FromHex("#333");
                await Task.Delay(2000);
                wall.FadeTo(0, 2000);
                wall.ScaleTo(5, 2000);
                glass.FadeTo(0, 2000);
                room.ScaleTo(1, 2000);
                await Task.Delay(2000);
                roomWall.Children.RemoveAt(2);
                roomWall.Children.RemoveAt(1);
                await achievementLabel.FadeTo(1, 500);
                await profileLabel.FadeTo(1, 500);
                await desktopLabel .FadeTo(1, 500);
                state = !state;
            }
        }

        private async void desktopTapped(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new test());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
