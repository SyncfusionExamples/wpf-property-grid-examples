using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Data;

namespace PropertyGrid_WPF
{    
    //Custom Editor for the EmailId property.
    [Editor("EmailID", typeof(EmailEditor))]
    public class Employee :NotificationObject
    {
       
        private string emailID;
        private Address address;
        private string name;
        private DateTime dOB;
        private Gender gender;
        private string id;
        private int age;
        private EmployeeType employeeType;
        private int experience;
        private string mobileNo;

        /// <summary>
        /// Gets or sets the Address of the Employee.
        /// </summary>
        [Description("Address of the Employee")]
        [Display(Order = 9)]
        [Category("Basic Info")]
        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
                RaisePropertyChanged(nameof(Address));
            }
        }

        /// <summary>
        /// Gets or sets the Mobile number of the Employee.
        /// </summary>
        [Description("Mobile number of the Employee")]
        [Display(Order = 8)]
        public string MobileNo
        {
            get
            {
                return mobileNo;
            }

            set
            {
                mobileNo = value;
                RaisePropertyChanged(nameof(MobileNo));
            }
        }

        /// <summary>
        /// Gets or sets the Experience of the Employee.
        /// </summary>
        [Display(Order = 6)]
        [Description("Experience of the Employee")]
        [Category("Employee Info")]
        public int Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
                RaisePropertyChanged(nameof(Experience));
            }
        }

        /// <summary>
        /// Gets or sets of the Email Id of the Employee.
        /// </summary>
        [Description("Mail ID of the Employee")]
        [Display(Order = 7)]
        public string EmailID
        {
            get
            {
                return emailID;
            }

            set
            {
                emailID = value;
                RaisePropertyChanged(nameof(EmailID));
            }
        }

        /// <summary>
        /// Gets or sets the Name of the Employee.
        /// </summary>
        [Display(Order = 0)]
        [Category("Basic Info")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Gets or sets the Date of Birth of the Employee.
        /// </summary>
        [Description("Birth date of the Employee")]
        [DisplayName("Date of Birth")]
        [Display(Order = 2)]
        [Category("Basic Info")]
        public DateTime DOB
        {
            get
            {
                return dOB;
            }

            set
            {
                dOB = value;
                RaisePropertyChanged(nameof(DOB));
            }
        }

        /// <summary>
        /// Gets or sets the Gender of the Employee.
        /// </summary> 
        [Description("Gender of the Employee")]
        [Display(Order = 4)]
        [Category("Basic Info")]
        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
                RaisePropertyChanged(nameof(Gender));
            }
        }

        /// <summary>
        /// Gets or sets the ID of the Employee.
        /// </summary>
        [Description("Employee ID of the Employee")]
        [Display(Order = 1)]
        [Category("Basic Info")]
        public string ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                RaisePropertyChanged(nameof(ID));
            }
        }

        /// <summary>
        /// Gets or sets the Age of the Employee.
        /// </summary>
        [Description("Age of the Employee")]
        [Display(Order = 3)]
        [Category("Basic Info")]
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
                RaisePropertyChanged(nameof(Age));
            }
        }

        /// <summary>
        /// Gets or sets the type of the Employee.
        /// </summary>
        [Description("Type of the Employee")]
        [Display(Order = 5)]
        [Category("Employee Info")]
        public EmployeeType EmployeeType
        {
            get
            {
                return employeeType;
            }

            set
            {
                employeeType = value;
                RaisePropertyChanged(nameof(EmployeeType));
            }
        }
       
    }

    /// <summary>
    /// A class that represents the address details of the Employee.
    /// </summary>
    public class Address : NotificationObject  
    {
        private string doorNo;
        private string country;
        private string state;
        private string streetName;

        /// <summary>
        /// Gets or sets the Door number of the Employee.
        /// </summary>
        [Description("Door number of the Employee")]
        public string DoorNo
        {
            get
            {
                return doorNo;
            }

            set
            {
                doorNo = value;
                RaisePropertyChanged(nameof(DoorNo));
            }
        }

        /// <summary>
        /// Gets or sets the street name of the Employee.
        /// </summary>
        [Description("Street Name of the Employee")]
        public string StreetName
        {
            get
            {
                return streetName;
            }

            set
            {
                streetName = value;
                RaisePropertyChanged(nameof(StreetName));
            }
        }

        /// <summary>
        /// Gets or sets the state of the Employee.
        /// </summary>
        [Description("State of the Employee")]
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                RaisePropertyChanged(nameof(State));
            }
        }

        /// <summary>
        /// Gets or sets the country of the Employee.
        /// </summary>
        [Description("Country of the Employee")]
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
                RaisePropertyChanged(nameof(Country));
            }
        }

        /// <summary>
        /// Returns the Address of the Employee.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return DoorNo+ ", "+ StreetName+", "+State;
        }

    }

    /// <summary>
    /// A class that represents the custom editor for the EmailID property.
    /// </summary>
    public class EmailEditor : ITypeEditor
    {
        SfMaskedEdit maskededit;
        public void Attach(PropertyViewItem property, PropertyItem info)
        {
            if (info.CanWrite)
            {
                var binding = new Binding("Value")
                {
                    Mode = BindingMode.TwoWay,
                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true
                };
                BindingOperations.SetBinding(maskededit, UpDown.ValueProperty, binding);
            }
            else
            {
                maskededit.IsEnabled = false;
                var binding = new Binding("Value")
                {

                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true
                };
                BindingOperations.SetBinding(maskededit, UpDown.ValueProperty, binding);
            }
        }

        public object Create(PropertyInfo propertyInfo)
        {
            maskededit = new SfMaskedEdit();
            maskededit.MaskType = MaskType.RegEx;
            maskededit.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";
            return maskededit;
        }
        public void Detach(PropertyViewItem property)
        {

        }
    }
}

