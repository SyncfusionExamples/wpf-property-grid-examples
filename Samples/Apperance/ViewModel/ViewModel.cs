using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_Apperance
{
    public class ViewModel : NotificationObject
    {
        private object selectedEmployee;
        private bool enableToolTip;

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

        public bool EnableToolTip
        {
            get { return enableToolTip; }
            set
            {
                enableToolTip = value;
                this.RaisePropertyChanged(nameof(EnableToolTip));
            }
        }


        public ViewModel()
        {
            SelectedEmployee = new Employee() { EmployeeName = "John", DOB = new DateTime(1995, 01, 08), Age=25, EmployeeID = 036 };
        }
    }
}
