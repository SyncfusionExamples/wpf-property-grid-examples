using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_Nested_Properties
{
    /// <summary>
    /// A Class that represents the nested properties for the Address property
    /// </summary>
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

    /// <summary>
    /// A class that represents the properties which are loaded in the PropertyGrid.
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Property contains the sub properties
        /// </summary>
        public Address Address { get; set; }
    }

}
