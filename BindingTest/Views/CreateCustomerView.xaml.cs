using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest.Models;
using BindingTest.ViewModels;
using BindingTest.Views;
using BindingTest.SQL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace BindingTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCustomerView : ContentPage
    {
        public CreateCustomerView()
        {
            try
            {
                InitializeComponent();
                CreateCustomerViewModel vm = new CreateCustomerViewModel();
                this.BindingContext = vm;
            
            } catch (Exception ex) {

                DisplayAlert("Exception Found", "Exception " + ex + " occured.", "Close");
            }
            
        }
    }
}