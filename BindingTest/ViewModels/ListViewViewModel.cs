using BindingTest.Models;
using System.Collections.ObjectModel;
using BindingTest.SQL;
using BindingTest;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;
using BindingTest.Views;
using System;

namespace BindingTest.ViewModels
{
    public partial class ListViewViewModel : BaseViewModel
    {
        private ObservableCollection<Customer> _lstCustomers { get; set; }

        public ObservableCollection<Customer> LstCustomers
        {
            get { return _lstCustomers; }
            set
            {
                _lstCustomers = value;
                OnPropertyChanged();
            }
        }

        
        public ListViewViewModel()
        {
            CustomersSQL customerDatabase = new CustomersSQL();
            LstCustomers = new ObservableCollection<Customer>(customerDatabase.GetCustomers().Result);

        }

       
    }
}

