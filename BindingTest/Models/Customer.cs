using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BindingTest.Views;

namespace BindingTest.Models
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string InsuranceNumber { get; set; }
        public string Street { get; set; }
        public string PLZ { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

    }
}
