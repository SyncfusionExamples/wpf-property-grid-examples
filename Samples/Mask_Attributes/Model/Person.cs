using Syncfusion.Windows.PropertyGrid;
namespace Mask_Attributes
{
    [MaskAttribute("[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}", "Email_1,Email_2")]
    public class Person
    {

        public Person()
        {
            Name = "Carl Johnson";
            Age = 30;
            Mobile = "2054449786";
            Email_1 = "carljohnson@gta.com";
            Email_2 = "johnson@gta.com";
        }

        public string Name { get; set; }
        public object Email_1 { get; set; }
        public object Email_2 { get; set; }


        [MaskAttribute(@"\(\d{3}\) \d{3} - \d{4}")]
        public object Mobile { get; set; }

        [MaskAttribute(@"\d{3}")]
        public object Age { get; set; }
    }
}
