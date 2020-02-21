using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyGrid_Apperance
{
    class Employee
    {
        [Category("Basic Info")]
        public string EmployeeName { get; set; }       
        [Category("Additional Info")]
        public int Age { get; set; }
        [Category("Basic Info")]
        [Editable(false)]
        public int EmployeeID { get; set; }
        [Category("Additional Info")]
        [ReadOnly(true)]
        public DateTime DOB { get; set; }
    }
}
