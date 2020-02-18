using Syncfusion.Windows.Shared;
using System;
using System.Windows;

namespace Grouping_Sorting_Ordering
{
    public class ViewModel : NotificationObject
    {
        private Visibility searchBoxVisibility;
        private Object selectedEmployee;
        private bool enableGrouping;

        public Visibility SearchBoxVisibility
        {
            get { return searchBoxVisibility; }
            set
            {
                searchBoxVisibility = value;
                this.RaisePropertyChanged(nameof(SearchBoxVisibility));
            }
        }
        public bool EnableGrouping
        {
            get { return enableGrouping; }
            set
            {
                enableGrouping = value;
                this.RaisePropertyChanged(nameof(EnableGrouping));
            }
        }

        public object SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {
                selectedEmployee = value;
                this.RaisePropertyChanged(nameof(SelectedEmployee));
            }
        }

        public ViewModel()
        {
            SelectedEmployee = new Employee()
            {
                Address = "10,Martin Street, New Yark",
                Age = 30,
                DOB = new DateTime(1990, 04, 19),
                EmailID = "johnson@gta.com",
                EmployeeType = EmployeeType.Fulltime_Employee,
                Experience = 5,
                Gender = Gender.Male,
                ID = "678",
                MobileNo = "48762345",
                Name = "John Son"
            };
        }
    }
}