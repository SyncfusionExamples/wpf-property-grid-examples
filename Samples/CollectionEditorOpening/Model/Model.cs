using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEditorOpening
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class Product
    {
        public int CompanyID { get; set; }
        public string ProductName { get; set; }
        public List<Employee> Employees { get; set; }

        internal List<Customer> customers;
        public ReadOnlyCollection<Customer> Customers
        {
            get
            {
                return customers.AsReadOnly();
            }
        }
    }
}
