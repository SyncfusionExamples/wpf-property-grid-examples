using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace PropertyGrid_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    public partial class MainWindow : Window
    {       
        /// <summary> 
        /// Initializes a new instance of the <see cref="MainWindow"/> class.    
        /// </summary>       
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class TestClassConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
        CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string)) { return "___"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

}
