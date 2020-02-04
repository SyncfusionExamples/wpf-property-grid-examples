using System;
using System.Windows;
using System.Windows.Data;

namespace PropertyGrid_CategoryEditor
{
    public class SelectedIndexToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int index = (int)value;
            Visibility vis;
            if (index == 0 && parameter.ToString() == "Foreground")
            {
                vis = Visibility.Visible;
            }
            else if (index == 1 && parameter.ToString() == "Background")
            {
                vis = Visibility.Visible;
            }
            else if (index == 2 && parameter.ToString() == "BorderBrush")
            {
                vis = Visibility.Visible;
            }
            else
            {
                vis = Visibility.Collapsed;
            }

            return vis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
