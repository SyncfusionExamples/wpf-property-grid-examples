using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionEditorOpening
{  

    public class ViewModel :NotificationObject
    {
        private Product demoProduct;
        private ICommand collectionEditorOpeningCommand;
        private bool isReadOnly= false;
        private bool restrictOpening =false;

        public ICommand CollectionEditorOpeningCommand
        {
            get
            {
                return collectionEditorOpeningCommand;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
            set
            {
                isReadOnly = value;
                this.RaisePropertyChanged(nameof(IsReadOnly));
            }
        }
        
        public bool RestrictOpening
        {
            get
            {
                return restrictOpening;
            }
            set
            {
                restrictOpening = value;
                this.RaisePropertyChanged(nameof(RestrictOpening));
            }
        }
        
        public Product DemoProduct
        {
            get
            {
                return demoProduct;
            }
            set
            {
                demoProduct = value;
                this.RaisePropertyChanged(nameof(DemoProduct));
            }
        }
        public void CollectionEditorOpeningChanged(object parameter)
        {
            (parameter as PropertyGrid).CollectionEditorOpening += PropertyGrid_CollectionEditorOpening;
        }

        private void PropertyGrid_CollectionEditorOpening(object sender, CollectionEditorOpeningEventArgs e)
        {
            e.Cancel = this.RestrictOpening;
            e.IsReadonly = this.IsReadOnly;
        }

        public ViewModel()
        {
            collectionEditorOpeningCommand = new DelegateCommand<object>(CollectionEditorOpeningChanged);

            demoProduct = new Product()
            {
                CompanyID = 157,
                ProductName = "Laptop",
                customers = new List<Customer>
            {
                new Customer() { ID = 0, Name = "John", Phone = "2065349857" },
                new Customer() { ID = 1, Name = "Peter", Phone = "2065981189" }
            },
                Employees = new List<Employee>()
            {
                new Employee() { ID = 0, Name = "Mark", Phone = "2065489864" },
                new Employee() { ID = 1, Name = "David", Phone = "2063481135" }
            }
            };
        }
    }
}
