using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_HideProp_attribute
{
    public class Employee
    {
        [Browsable(false)]
        public string Bank { get; set; }
        [Bindable(false)]
        public string AccountNumber { get; set; }        
        [Browsable(true)]
        [Bindable(true)]
        [Display(AutoGenerateField = false)]
        public string Email { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
    }
}