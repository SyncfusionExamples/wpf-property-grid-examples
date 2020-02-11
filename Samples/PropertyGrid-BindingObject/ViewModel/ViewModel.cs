using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_BindingObject
{
    //Create ViewModel class with a property to be bounded with PropertyGrid.SelectedObject
    public class ViewModel
    {
        public object SelectedEmployee { get; set; }
        public ViewModel()
        {
            SelectedEmployee = new Employee() { EmployeeName = "Johnson", Age = 25, ID = "1234", Experiance=3 };
        }
    }
}
