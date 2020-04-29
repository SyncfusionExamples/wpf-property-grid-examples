using Syncfusion.Windows.PropertyGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace PropertyGrid_FocusHandling
{
    public class ComboBoxEditor : BaseTypeEditor
    {
        ComboBox enumCombo;

        public override void Attach(PropertyViewItem property, PropertyItem info)
        {
            var binding = base.CreatePropertyInfoBinding(info, enumCombo);
            BindingOperations.SetBinding(enumCombo, ComboBox.SelectedItemProperty, binding);
        }

        public override object Create(PropertyInfo PropertyInfo)
        {
            return this.CreateEditor(PropertyInfo.PropertyType);
        }

        public override object Create(PropertyDescriptor PropertyDescriptor)
        {
            return this.CreateEditor(PropertyDescriptor.PropertyType);
        }

        public override void Detach(PropertyViewItem property)
        {
            if (enumCombo != null)
            {
                BindingOperations.ClearAllBindings(enumCombo);
                BindingOperations.ClearBinding(enumCombo, ComboBox.SelectedItemProperty);
            }
            enumCombo.ItemsSource = null;
            enumCombo.Items.Clear();
            enumCombo = null;
        }

        public override bool ShouldPropertyGridTryToHandleKeyDown(Key key)
        {
            if (key == Key.Up || key == Key.Down)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Creates and initializes a new instance of the ComboBox editor.
        /// </summary>
        /// <param name="propertyType">The property type</param>
        /// <returns>The EnumComboEditor</returns>
        private ComboBox CreateEditor(Type propertyType)
        {
            enumCombo = new ComboBox()
            {
                ItemsSource = EnumHelper.GetValues(propertyType),
                BorderThickness = new Thickness(0)
            };
            return enumCombo;
        }

    }
}
