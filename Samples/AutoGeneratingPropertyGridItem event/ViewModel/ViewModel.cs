using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PropertyGrid_AutoGeneratingPropertyGridItem
{
    public class ViewModel :NotificationObject {
        private ICommand autoGeneratingPropertyGridItemEventCommand;
        public object SelectedEmployee { get; set; }

        //Command for the AutoGeneratingPropertyGridItemEvent
        public ICommand AutoGeneratingPropertyGridItemEventCommand {
            get { if (autoGeneratingPropertyGridItemEventCommand == null)
                    autoGeneratingPropertyGridItemEventCommand = new UpdaterValue();
                  return autoGeneratingPropertyGridItemEventCommand;
            }
            set {
                autoGeneratingPropertyGridItemEventCommand = value;
            }
        }
        public ViewModel() {
            SelectedEmployee = new Employee()
            {
                Name = "John",
                Age=35,
                ID = "381",
                DOB = new DateTime(1995, 12, 24),
                Exp = 5,
                Address="10, Martin street, New Yark"
            };
        }
    }
}
