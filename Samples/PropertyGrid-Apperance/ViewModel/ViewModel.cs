using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_Apperance
{
    public class ViewModel
    {
        public Object SelectedEmployee { get; set; }
        public ViewModel()
        {
            SelectedEmployee = new Employee() { EmployeeName = "John", DOB = new DateTime(1995, 01, 08), Age=25, EmployeeID = 036 };
        }
    }
}
