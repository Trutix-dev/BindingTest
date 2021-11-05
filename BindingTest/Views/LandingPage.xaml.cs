using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void LandingPageToList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomerView());
        }

        private async void LandingPageToCreate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCustomerView());
        }
    }
}