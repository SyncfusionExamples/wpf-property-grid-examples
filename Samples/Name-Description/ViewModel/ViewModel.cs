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
           
        }
    }
}
