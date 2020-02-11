using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;

namespace PropertyGrid_Nested_Properties
{
    public class ViewModel : NotificationObject
    {
        private PropertyExpandModes propertyExpandMode;
        private object selectedEmployee;

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
        public PropertyExpandModes PropertyExpandMode
        {
            get { return propertyExpandMode; }
            set
            {
                propertyExpandMode = value;
                this.RaisePropertyChanged(nameof(PropertyExpandMode));
            }
        }
        public ViewModel()
        {
           
            SelectedEmployee = new Employee() { Address = new Address() { State = "New Yark", DoorNo = "10", StreetName = "Martin street" }, Age = 23, ID = "1207", Name = "Mark" };
        }
    }

}
