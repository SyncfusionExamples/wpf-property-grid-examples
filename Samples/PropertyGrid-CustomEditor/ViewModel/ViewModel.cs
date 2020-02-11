
using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;

namespace PropertyGrid_CustomEditor
{
    class ViewModel : NotificationObject
    {
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
        public ViewModel()
        {
            SelectedEmployee = new Employee() { Age = 25, Name = "mark", Experience = 5, EmailID = "mark@gt" };
        }
    }
}
