using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoGeneratingPropertyGridItem_NestedMode
{
    public class ViewModel : NotificationObject
    {
        private ICommand autoGeneratingPropertyGridItemEventCommand;
        public object SelectedEmployee { get; set; }

        //Command for the AutoGeneratingPropertyGridItemEvent
        public ICommand AutoGeneratingPropertyGridItemEventCommand
        {
            get
            {
                if (autoGeneratingPropertyGridItemEventCommand == null)
                    autoGeneratingPropertyGridItemEventCommand = new UpdaterValue();
                return autoGeneratingPropertyGridItemEventCommand;
            }
            set
            {
                autoGeneratingPropertyGridItemEventCommand = value;
            }
        }
        public ViewModel()
        {
            SelectedEmployee = new Employee()
            {
                Name = "Mark",

                DOB = new DateTime(1997, 2, 25),
                JoiningDate = new DateTime(2020, 10, 5),
                Address = new Address()
                {
                    State = "New Yark",
                    DoorNo = "10",
                    StreetName = "Martin street"
                },
                Bank = new Bank()
                {
                    AccountNo = "84946448",
                    BankName = "ABCBank"
                }
            };
        }
    }
}