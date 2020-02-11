using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_Themes
{
    public class Employee
    {
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int Experience { get; set; }
        public string MobileNo { get; set; }
    }

    public enum Gender
    {
        Male , Female
    }
    public enum EmployeeType
    {
        Parttime_Employee, 
        Fulltime_Employee  
    }
}
