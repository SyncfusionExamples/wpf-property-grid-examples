using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropertyGrid_Name_Description
{
    public class ViewModel :NotificationObject
    {
        private Visibility descriptionPanelVisibility;

        public Object SelectedEmployee { get; set; }
        public Visibility DescriptionPanelVisibility
        {
            get { return descriptionPanelVisibility; }
            set
            {
                descriptionPanelVisibility = value;
                this.RaisePropertyChanged(nameof(DescriptionPanelVisibility));
            }
        }
        public ViewModel()
        {
            SelectedEmployee = new Employee()
            {
                Name = "John",
                ID = "381",
                DOB = new DateTime(1995, 12, 24),
                Add="New Yark",
                Age=30,
                Exp=3,
                Gen= Gender.Male,
                Mail="john@gta.com"
            };
        }
    }
}
