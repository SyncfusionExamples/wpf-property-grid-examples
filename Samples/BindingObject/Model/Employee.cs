using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_BindingObject
{
    // Employee class to be explored in property grid.
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public int Experiance { get; set; }
    }
}
