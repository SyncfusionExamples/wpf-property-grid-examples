using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;

namespace PropertyGrid_CustomEditor
{
    //Assigning Custom Editor for the EmailId property.
    [Editor("EmailID", typeof(EmailEditor))]   
    public class Employee : NotificationObject
    {

        private string emailID;
        private string name;
        private int age;
        private int experience;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        //[Editor(typeof(int), typeof(IntEditor))]
        public int Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
                RaisePropertyChanged(nameof(Experience));
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
                RaisePropertyChanged(nameof(Age));
            }
        }
        public string EmailID
        {
            get
            {
                return emailID;
            }

            set
            {
                emailID = value;
                RaisePropertyChanged(nameof(EmailID));
            }
        }
    }

    //Custom Editor for the integer type properties.
    public class IntegerEditor : ITypeEditor
    {
        UpDown upDown;
        public void Attach(PropertyViewItem property, PropertyItem info)
        {
            if (info.CanWrite)
            {
                var binding = new Binding("Value") { Mode = BindingMode.TwoWay, Source = info, ValidatesOnExceptions = true, ValidatesOnDataErrors = true };
                BindingOperations.SetBinding(upDown, UpDown.ValueProperty, binding);
            }
            else
            {
                upDown.IsEnabled = false;
                var binding = new Binding("Value") { Source = info, ValidatesOnExceptions = true, ValidatesOnDataErrors = true };
                BindingOperations.SetBinding(upDown, UpDown.ValueProperty, binding);
            }
        }
        public object Create(PropertyInfo propertyInfo)
        {
            upDown = new UpDown();
            upDown.ApplyZeroColor = false;
            upDown.MinValue = 0;
            upDown.MaxValue = 100;
            upDown.NumberDecimalDigits = 0;
            return upDown;
        }
        public void Detach(PropertyViewItem property)
        {

        }
    }

    //Custom Editor for the EmailId properties.
    public class EmailEditor : ITypeEditor
    {
        SfMaskedEdit maskededit;
        public void Attach(PropertyViewItem property, PropertyItem info)
        {
            if (info.CanWrite)
            {
                var binding = new Binding("Value") { Mode = BindingMode.TwoWay, Source = info, ValidatesOnExceptions = true, ValidatesOnDataErrors = true };
                BindingOperations.SetBinding(maskededit, SfMaskedEdit.ValueProperty, binding);
            }
            else
            {
                maskededit.IsEnabled = false;
                var binding = new Binding("Value") { Source = info, ValidatesOnExceptions = true, ValidatesOnDataErrors = true };
                BindingOperations.SetBinding(maskededit, SfMaskedEdit.ValueProperty, binding);
            }
        }
        public object Create(PropertyInfo propertyInfo)
        {
            maskededit = new SfMaskedEdit();
            maskededit.MaskType = MaskType.RegEx;
            maskededit.Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}";
            return maskededit;
        }
        public void Detach(PropertyViewItem property)
        {

        }
    }
}
