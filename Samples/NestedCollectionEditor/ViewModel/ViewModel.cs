using System.Collections.ObjectModel;

namespace NestedCollectionEditor
{
    public class ViewModel
    {
        public Product DemoProduct { get; set; }
        public ViewModel()
        {
            DemoProduct = new Product()
            {
                ID = 0,
                ProductName = "Office Table",
                Suppliers = new SupplierList
                {
                    new Supplier()
                    {
                        ID = 0,
                        Name = "Jack Plank",
                        Phone = "2065559857",
                        Address = new ObservableCollection<AddressDetails>()
                        {
                            new AddressDetails
                            {
                                City="Mexico",
                                DoorNo=456
                            }
                        }
                    }
                }
            };
        }
    }
}
