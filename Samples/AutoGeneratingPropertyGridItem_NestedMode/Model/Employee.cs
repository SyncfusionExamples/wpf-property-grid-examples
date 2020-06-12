using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratingPropertyGridItem_NestedMode
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


    public class Employee
    {
        public string Name { get; set; }


        public DateTime DOB { get; set; }
        public DateTime JoiningDate { get; set; }
        public Bank Bank { get; set; }
        public Address Address { get; set; }


        public Employee()
        {
            
        }
    }
}
