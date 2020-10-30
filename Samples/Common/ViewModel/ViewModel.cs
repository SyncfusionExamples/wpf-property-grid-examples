using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System;
using System.ComponentModel;
using System.Dynamic;
using System.Windows;
using System.Windows.Input;

namespace PropertyGrid_WPF
{
    public class ViewModel : NotificationObject
    {
        private object selectedEmployee = null;
        private DynamicObject dynamicObject = null;
        private Visibility buttonPanelVisibility;
        private Visibility descriptionPanelVisibility;
        private Visibility searchBoxVisibility;
        private ListSortDirection sortDirection;
        private bool enableGrouping;
        private PropertyExpandModes propertyExpandMode;
        private bool enableToolTip;     
        private double propertyNameColumnDefinition =100;       


        public Visibility DescriptionPanelVisibility
        {
            get { return descriptionPanelVisibility; }
            set
            {
                descriptionPanelVisibility = value;
                this.RaisePropertyChanged(nameof(DescriptionPanelVisibility));
            }
        }
        
        public double PropertyNameColumnDefinition
        {
            get { return propertyNameColumnDefinition; }
            set
            {
                propertyNameColumnDefinition = value;
                this.RaisePropertyChanged(nameof(PropertyNameColumnDefinition));
            }
        }

        public Visibility ButtonPanelVisibility
        {
            get { return buttonPanelVisibility; }
            set
            {
                buttonPanelVisibility = value;
                this.RaisePropertyChanged(nameof(ButtonPanelVisibility));
            }
        }

        public Visibility SearchBoxVisibility
        {
            get { return searchBoxVisibility; }
            set
            {
                searchBoxVisibility = value;
                this.RaisePropertyChanged(nameof(SearchBoxVisibility));
            }
        }

        public ListSortDirection SortDirection
        {
            get { return sortDirection; }
            set
            {
                sortDirection = value;
                this.RaisePropertyChanged(nameof(SortDirection));
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

        public bool EnableToolTip
        {
            get { return enableToolTip; }
            set
            {
                enableToolTip = value;
                this.RaisePropertyChanged(nameof(EnableToolTip));
            }
        }

        public PropertyExpandModes PropertyExpandMode
        {
            get { return propertyExpandMode; }
            set
            {
                propertyExpandMode = value;
                this.RaisePropertyChanged(nameof(PropertyExpandMode));
            }
        }

        public object SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                this.RaisePropertyChanged(nameof(SelectedEmployee));
            }
        }

        public DynamicObject DynamicObject
        {
            get
            {
                return dynamicObject;
            }
            set
            {
                dynamicObject = value;
                this.RaisePropertyChanged(nameof(DynamicObject));
            }
        }

        private ICommand autoGeneratingPropertyGridItemEventCommand;
        public ICommand AutoGeneratingPropertyGridItemEventCommand
        {
            get
            {
                if (autoGeneratingPropertyGridItemEventCommand == null)
                    autoGeneratingPropertyGridItemEventCommand = new Updater();
                return autoGeneratingPropertyGridItemEventCommand;
            }
            set
            {
                autoGeneratingPropertyGridItemEventCommand = value;
            }
        }
        public ViewModel()
        {
            SelectedEmployee = new Employee() {Name="John Son", Age=25, DOB= new DateTime(1995,12,28), EmployeeType=  EmployeeType.FullTime_Employee, Experience=5, Gender= Gender.Male, ID="0423", MobileNo = "4556789", EmailID = "john@gta.com", Address = new Address() { Country = "United States", DoorNo = "10", StreetName = "Martin Street", State = "New Yark" } };
        }
    }   
}