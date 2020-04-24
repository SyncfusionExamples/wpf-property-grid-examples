using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.PropertyGrid;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Reflection;
using System.ComponentModel;

namespace CustomEditor_sample
{
    public class ComboEditor : BaseTypeEditor
    {
        ComboBox comboBox;
      
        public override void Attach(PropertyViewItem property, PropertyItem info)
        {
            var binding = new Binding("Value")
            {
                Mode = BindingMode.TwoWay,
                Source = info,
                ValidatesOnExceptions = true,
                ValidatesOnDataErrors = true
            };
            BindingOperations.SetBinding(comboBox, ComboBox.SelectedItemProperty, binding);
        }

        public override object Create(PropertyInfo PropertyInfo)
        {
            throw new NotImplementedException();
        }

        public override object Create(PropertyDescriptor PropertyDescriptor)
        {
            comboBox = new ComboBox();
            dynamic comboBoxItemsList = PropertyDescriptor.GetValue(PropertyDescriptor.Name);
            foreach (dynamic items in comboBoxItemsList)
            {
                comboBox.Items.Add(items);
            }

            comboBox.SelectedIndex = 0;
            return comboBox;
        }

        public override void Detach(PropertyViewItem property)
        {
            comboBox = null;
        }
    }
}
