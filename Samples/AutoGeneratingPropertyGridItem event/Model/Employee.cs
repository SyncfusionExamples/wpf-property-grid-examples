using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_AutoGeneratingPropertyGridItem
{
    public class Employee {
        [Description("Name of the employee")]
        public string Name { get; set; }
        [Description("ID of the employee")]
        public string ID { get; set; }
        [Description("Date of Birth of the employee")]
        public DateTime DOB { get; set; }
        [Description("Experiance of the employee")]
        public int Exp { get; set; }
        [Description("Age of the employee")]
        public int Age { get; set; }
        [Description("Address of the employee")]
        public string Address { get; set; }
    }
}
