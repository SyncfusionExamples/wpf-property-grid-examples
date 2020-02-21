using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_ReadOnlyProperty
{
    public class ViewModel
    {
        public Object SelectedEmployee { get; set; }
        public ViewModel()
        {
            SelectedEmployee = new Employee()
            {
                Name = "John Son",
                DOB = new DateTime(1990, 01, 28),
                EmailID = "johnson@gta.com",
                Gender = Gender.Male,
                ID = "397"                
            };
        }
    }
}
