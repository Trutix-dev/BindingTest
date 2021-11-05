using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BindingTest.Models;
using SQLite;
using Xamarin.Essentials;
using Xamarin.Forms;
using BindingTest.Views;
using BindingTest.ViewModels;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BindingTest.SQL
{
    public class CustomersSQL
    {
        private readonly SQLiteAsyncConnection db;


        public CustomersSQL()
        {
            db = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "customers.db3"));
            db.CreateTableAsync<Customer>();
        }

        public Task<List<Customer>> GetCustomers()
        {
            //return AllCustomersCollection;

            return db.Table<Customer>().ToListAsync();

        }


        public Task<int> SaveCustomerAsync(Customer customer)
        {
            if (customer.ID == 0)
            {
                return db.InsertAsync(customer);

            } else {

                return db.UpdateAsync(customer);
            }
        }

        public Task<int> DeleteCustomerAsync(Customer customer)
        {
            return db.DeleteAsync(customer);

        }
    } 
}
        
    

