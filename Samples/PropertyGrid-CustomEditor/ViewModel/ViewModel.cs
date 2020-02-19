using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;

namespace PropertyGrid_CustomEditor
{
    class ViewModel : NotificationObject
    {
        private object selectedEmployee;
        private CustomEditorCollection customEditorCollection = new CustomEditorCollection();

        public object SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }
            set
            {
                selectedEmployee = value;
                this.RaisePropertyChanged(nameof(SelectedEmployee));
            }
        }

        public CustomEditorCollection CustomEditorCollection
        {
            get
            {
                return customEditorCollection;
            }
            set
            {
                customEditorCollection = value;
                this.RaisePropertyChanged(nameof(CustomEditorCollection));
            }
        }
        public ViewModel()
        {
            SelectedEmployee = new Employee() { Age = 25, Name = "mark", Experience = 5, EmailID = "mark@gt" };
            // IntegerEditor added to the CustomEditorCollection and will applied to the "int" type properties
            CustomEditor editor = new CustomEditor();
            editor.Editor = new IntegerEditor();
            editor.HasPropertyType = true;
            editor.PropertyType = typeof(int);
            CustomEditorCollection.Add(editor);
        }
    }
}
