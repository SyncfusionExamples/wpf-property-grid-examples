
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Company
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

    public class CustomerCollection : ObservableCollection<Customer>
    {
        public CustomerCollection() { }
        public override string ToString()
        {
            return "Customer List";
        }
    }

    public class EmployeeList : List<Employee>
    {
        public EmployeeList() { }
        public override string ToString()
        {
            return "Employee List";
        }
    }
    public class Product
    {
        public int CompanyID { get; set; }
        public string ProductName { get; set; }
        public CustomerCollection Customers { get; set; }
        public EmployeeList Employees { get; set; }
    }
}
