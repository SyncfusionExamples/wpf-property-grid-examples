using Syncfusion.Windows.PropertyGrid;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace PropertyGrid_WPF
{
    /// <summary>
    /// A class that represents the SortDirection selection changed action 
    /// </summary>
    class OrderingAction : TargetedTriggerAction<PropertyGrid>
    {
#if Framework3_5
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }


        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(ListSortDirection), new UIPropertyMetadata(null));
#endif
        protected override void Invoke(object parameter)
        {
            if (((parameter as SelectionChangedEventArgs).AddedItems[0] as ComboBoxItem).Content.ToString() == "Custom Order")
            {
                ((PropertyGrid)TargetObject).SortDirection = null;
            }
            else if (((parameter as SelectionChangedEventArgs).AddedItems[0] as ComboBoxItem).Content.ToString() == "Ascending")
            {
                ((PropertyGrid)TargetObject).SortDirection = ListSortDirection.Ascending;
            }
            else if (((parameter as SelectionChangedEventArgs).AddedItems[0] as ComboBoxItem).Content.ToString() == "Descending")
            {
                ((PropertyGrid)TargetObject).SortDirection = ListSortDirection.Descending;
            }
        }

    }
}
