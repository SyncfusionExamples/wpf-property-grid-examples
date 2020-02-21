using Syncfusion.Windows.Shared;
using System;
using System.Collections.ObjectModel;

namespace PropertyGrid_HideProp_Collection
{
    public class ViewModel :NotificationObject
    {
        private ObservableCollection<string> hidePropertyItems = new ObservableCollection<string>();
        public Object selectedEmployee;
        public Object SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                this.RaisePropertyChanged("selectedEmployee");
            }
        }

        public ObservableCollection<string> HidePropertyItems
        {
            get
            {
                return hidePropertyItems;
            }
            set
            {
                hidePropertyItems = value;
                this.RaisePropertyChanged("HidePropertyItems");
            }
        }

        public ViewModel()
        {
            var employee = new Employee()
            {
                Email = "john@gta.com",
                AccountNumber="23456784",
                Bank="ABC bank",
                Name = "Johnson",
                Experience=5,
                ID = "895",
                Age = 35,
            };
            HidePropertyItems.Add(nameof(employee.AccountNumber));
            HidePropertyItems.Add(nameof(employee.Email));
            HidePropertyItems.Add(nameof(employee.Bank));
            SelectedEmployee = employee;
        }
    }
}
