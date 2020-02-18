using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping_Sorting_Ordering
{
    class Employee
    {
        /// <summary>
        /// Gets or sets the Address of the Employee.
        /// </summary>        
        [Display(Order = 3)]
        [Category("Basic Info")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the Mobile number of the Employee.
        /// </summary>
        [Display(Order = 8)]
        public string MobileNo { get; set; }

        /// <summary>
        /// Gets or sets the Experience of the Employee.
        /// </summary>
        [Display(Order = 6)]
        [Category("Employee Info")]
        public int Experience { get; set; }

        /// <summary>
        /// Gets or sets of the Email Id of the Employee.
        /// </summary>
        [Display(Order = 7)]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or sets the Name of the Employee.
        /// </summary>
        [Display(Order = 0)]
        [Category("Basic Info")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Date of Birth of the Employee.
        /// </summary>
        [Display(Order = 2)]
        [Category("Basic Info")]
        public DateTime DOB { get; set; }

        /// <summary>
        /// Gets or sets the Gender of the Employee.
        /// </summary> 
        [Display(Order = 4)]
        [Category("Basic Info")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Employee.
        /// </summary>
        [Category("Basic Info")]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the Age of the Employee.
        /// </summary>
        [Display(Order = 3)]
        [Category("Basic Info")]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the type of the Employee.
        /// </summary>
        [Display(Order = 5)]
        [Category("Employee Info")]
        public EmployeeType EmployeeType { get; set; }
    }
    public enum EmployeeType
    {
        Fulltime_Employee,
        Parttime_Employee
    }
    public enum Gender
    {
        Male,
        Female
    }
}
