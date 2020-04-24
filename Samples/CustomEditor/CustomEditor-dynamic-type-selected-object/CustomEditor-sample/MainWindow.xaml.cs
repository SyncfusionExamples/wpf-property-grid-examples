using Syncfusion.Windows.PropertyGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomEditor_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CanididateDetails _CanididateDetails = new CanididateDetails();
        public MainWindow()
        {
            InitializeComponent();

            string candidateName = "John";
            int age = 25;
            _CanididateDetails.Values.Add("Name", candidateName);
            _CanididateDetails.Values.Add("Address", new List<string>() { "A", "B", "C" });
            _CanididateDetails.Values.Add("Age", age);
            this.propertyGrid.SelectedObject = _CanididateDetails;
            CustomEditor comboeditor = new CustomEditor() { HasPropertyType = true, PropertyType = typeof(List<string>), Editor = new ComboEditor() };
            comboeditor.Properties.Add("Address");
            propertyGrid.CustomEditorCollection.Add(comboeditor);
            propertyGrid.RefreshPropertygrid();
        }
    }
}
