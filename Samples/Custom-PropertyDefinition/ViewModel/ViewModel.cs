using System;
using Syncfusion.Windows.PropertyGrid;

namespace Custom_PropertyDefinition
{
    public class EmailEditor : MaskEditor
    {
        public EmailEditor()
        {
            Mask = @"[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";
        }
    }

    public class ViewModel
    {
        public Object SelectedEmployee { get; set; }
        public ViewModel()
        {
            SelectedEmployee = new Employee()
            {
                DOB = new DateTime(1995, 01, 31),
                Name = "Johnson",
                ID = "895",
                Age = 25,
                EmailID = "john@123.c"
            };
        }
    }
}
