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
    public partial class mockTest : ContentPage
    {
        public mockTest()
        {
            InitializeComponent();
        }
        private async void shutdownTapped(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopModalAsync();

                //Environment.Exit(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}