
using System.Collections.ObjectModel;

namespace DirectCollectionEditor.ViewModel
{
    public class ViewModel {
        private ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons {
            get {
                return persons;
            }
            set {
                persons = value;
            }
        }

        public ViewModel() {
            persons.Add(new Person() { Name = "Mark", Address = "United States" });
            persons.Add(new Person() { Name = "Smith", Address = "United States" });

        }
    }
}
