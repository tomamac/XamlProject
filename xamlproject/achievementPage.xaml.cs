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
    public partial class achievementPage : ContentPage
    {
        public achievementPage()
        {
            InitializeComponent();
            button.Clicked += Button_Clicked;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}