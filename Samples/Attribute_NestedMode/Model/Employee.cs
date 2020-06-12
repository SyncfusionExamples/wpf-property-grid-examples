using System;

namespace Attribute_NestedMode
{
    public class Address
    {
        public string State { get; set; }
        public string StreetName { get; set; }
        public string DoorNo { get; set; }
        public override string ToString()
        {
            return DoorNo + ", " + StreetName + ", " + State;
        }
    }

    public class Bank
    {
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public override string ToString()
        {
            return BankName + ", " + AccountNo;
        }
    }

    //Allow to explore nested property for the multiple property item
    [PropertyGridAttribute(NestedPropertyDisplayMode = NestedPropertyDisplayMode.Show, PropertyName = "Bank, DOB")]
    public class Employee
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoiningDate { get; set; }
        public Bank Bank { get; set; }

        //Allow to explore nested property for the single property item
        [PropertyGridAttribute(NestedPropertyDisplayMode = NestedPropertyDisplayMode.Show)]
        public Address Address { get; set; }

        public Employee()
        {
            Name = "Mark";
            DOB = new DateTime(1997, 2, 25);
            JoiningDate = new DateTime(2020, 10, 5);
            Address = new Address()
            {
                State = "New Yark",
                DoorNo = "10",
                StreetName = "Martin street"
            };
            Bank = new Bank()
            {
                AccountNo = "84946448",
                BankName = "ABCBank"
            };
        }
    }
}
