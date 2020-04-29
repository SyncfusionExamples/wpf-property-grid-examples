using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_FocusHandling
{
    [Editor("Gender", typeof(ComboBoxEditor))]
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);
            Gender = Gender.Male;
        }

        public Gender Gender
        {
            get;

            set;
        }

        public string Email
        {
            get;

            set;
        }

        public string FirstName
        {
            get;

            set;
        }
        
        public string LastName
        {
            get;

            set;
        }

        public string ID
        {
            get;

            set;
        }

        public DateTime DOB
        {
            get;

            set;
        }


        public long Mobile
        {
            get;

            set;
        }

        public int Age
        {
            get;

            set;
        }
    }


    public enum Gender
    {
        Male,

        Female
    }
}
