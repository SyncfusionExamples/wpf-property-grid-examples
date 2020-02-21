using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_ReadOnlyProperty
{
    class Employee {
        [ReadOnly(true)]
        public string EmailID { get; set; }
        [Editable(false)]
        public string Name { get; set; }
        [Editable(false)]
        public Gender Gender { get; set; }
        [ReadOnly(true)]
        public string ID { get; set; }
        //ReadOnly attribute have higer priority than the Editable attribute.
        [ReadOnly(true)]
        [Editable(true)]
        public DateTime DOB { get; set; }
    }
    public enum Gender {
        Male, 
        Female
    }
}
