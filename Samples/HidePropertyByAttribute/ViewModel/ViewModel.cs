using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_HideProp_attribute
{
    public class ViewModel {
        public Object SelectedEmployee { get; set; }
        public ViewModel() {
            SelectedEmployee = new Employee()
            {
                Email = "john@gta.com",
                AccountNumber = "23456784",
                Bank = "ABC bank",
                Name = "Johnson",
                Experience = 5,
                ID = "895",
                Age = 35,
            };
        }
    }
}
