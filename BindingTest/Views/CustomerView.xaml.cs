using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest.Models;
using BindingTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BindingTest.SQL;

namespace BindingTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerView : ContentPage
    {
        ListViewViewModel vm;

        public CustomerView()
        {
           
            vm = new ListViewViewModel();
            this.BindingContext = vm;

            InitializeComponent();
                //new ObservableCollection<Customer>(App.CustomersSQL.GetCustomersAsync());
        }

        private async void btnAddCustomer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCustomerView());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType());
            Console.WriteLine((sender as Button).BindingContext);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}