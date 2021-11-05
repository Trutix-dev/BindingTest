using System;
using System.Collections.Generic;
using System.Text;
using BindingTest.SQL;
using BindingTest.Models;
using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using BindingTest.Views;
using System.Runtime.CompilerServices;

namespace BindingTest.ViewModels
{
    public class CreateCustomerViewModel : INotifyPropertyChanged
    {
        private Customer _customers { get; set; }
        
        public Customer customer
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged();
            }
        }

        public Command btnSaveCustomer { get; set; }
        public Command btnClearEntries { get; set; }

        public CreateCustomerViewModel()
        {
            customer = new Customer();
            customer.ID = 0;
            customer.FirstName = "";
            customer.LastName = "";
            customer.Age = "";
            customer.InsuranceNumber = "";
            customer.Street = "";
            customer.PLZ = "";
            customer.City = "";
            customer.Tel = "";
            customer.Mobile = "";
            customer.Email = "";

            btnSaveCustomer = new Command(SaveCustomer);
            btnClearEntries = new Command(ClearEntries);
        }

        public void ClearEntries()
        {
            customer = new Customer();
            customer.ID = 0;
            customer.FirstName = "";
            customer.LastName = "";
            customer.Age = "";
            customer.InsuranceNumber = "";
            customer.Street = "";
            customer.PLZ = "";
            customer.City = "";
            customer.Tel = "";
            customer.Mobile = "";
            customer.Email = "";

        }
        public void SaveCustomer()
        {
            try
            {
                CustomersSQL customerDatabase = new CustomersSQL();

                int i = customerDatabase.SaveCustomerAsync(customer).Result;

                if (i == 0)
                {
                    ClearEntries();
                    //CreateCustomerView.DisplayAlert("Erfolgreich!", "Der Kunde wurde gespeichert!", "Schließen");

                } else if (i != 0) {

                    ClearEntries();
                    //Kunde Daten wurden Geändert!
                }


            } catch (Exception ex) {

                //Add a displayAlert for Exception
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
