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
        public string Name { get; set; }
        public string ID { get; set; }
        public DateTime DOB { get; set; }
        public int Exp { get; set; }
        public string Address { get; set; }
    }
}
