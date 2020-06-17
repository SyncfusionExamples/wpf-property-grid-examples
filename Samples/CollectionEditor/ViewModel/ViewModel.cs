
namespace Company
{
    public class ViewModel
    {
        public Product DemoProduct { get; set; }
        public ViewModel()
        {
            DemoProduct = new Product()
            {
                CompanyID = 157,
                ProductName = "Laptop",
                Customers = new CustomerCollection
                {
                   new Customer() { ID = 0, Name = "John", Phone = "2065349857" },
                   new Customer() { ID = 1, Name = "Peter", Phone = "2065981189" }
                },
                Employees = new EmployeeList
                {
                   new Employee() { ID = 0, Name = "Mark", Phone = "2065489864" },
                   new Employee() { ID = 1, Name = "David", Phone = "2063481135" }
                }
            };
        }
    }
}