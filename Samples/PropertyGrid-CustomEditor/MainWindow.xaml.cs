
using Syncfusion.Windows.PropertyGrid;
using System.Reflection;
using System.Windows;
using System.Windows.Data;

namespace PropertyGrid_CustomEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Assigning Custom Editor for the integer type properies.
            CustomEditor editor1 = new CustomEditor();
            editor1.Editor = new IntegerEditor();
            editor1.HasPropertyType = true;
            editor1.PropertyType = typeof(int);
            this.propertyGrid1.CustomEditorCollection.Add(editor1);
            this.DataContext = new ViewModel();
        }
    }
}
