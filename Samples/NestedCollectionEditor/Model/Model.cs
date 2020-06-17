
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NestedCollectionEditor
{
   

    public class AddressDetails
    {
        public int DoorNo { get; set; }
        public string City { get; set; }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ObservableCollection<AddressDetails> Address { get; set; }
    }
    
    public class SupplierList : List<Supplier>
    {
        public SupplierList() : base() { }
        public override string ToString()
        {
            return "Supplier List";
        }
    }

    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public SupplierList Suppliers { get; set; }
    }
}
