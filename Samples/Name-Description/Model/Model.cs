using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyGrid_Name_Description
{
    public class Employee
    {        
        // Display name and description for the following properties sets by using "DisplayName" and "Display attribute's Description field".
        [DisplayName("Email ID")]
        [Display(Description = "Mail ID of the Employee")]
        public string Mail { get; set; }

        [DisplayName("Address")]
        [Display(Description = "Address of the Employee")]
        public string Add { get; set; }

        [DisplayName("Employee Name")]
        [Display(Description = "Name of the Employee")]
        public string Name { get; set; }

        [DisplayName("Date of Birth")]
        [Display(Description = "Birth date of the Employee")]
        public DateTime DOB { get; set; }



        // Display name and description for the following properties sets by using Display attribute's Name field" and "Description" attribute.
        [Display(Name = "Gender")]
        [Description("Gender of the Employee")]
        public Gender Gen { get; set; }

        [Display(Name = "Employee ID")]
        [Description("ID of the Employee")]
        public string ID { get; set; }

        [Description("Age of the Employee")]
        public int Age { get; set; }

        [Display(Name = "Experience")]
        [Description("Experience of the Employee")]
        public int Exp { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }

}
