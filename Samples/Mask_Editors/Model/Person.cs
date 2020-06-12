using System.ComponentModel;

namespace Mask_Editors
{
    //Custom mask editor
    public class EmailEditor : MaskEditor
    {
        public EmailEditor()
        {
            Mask = "[A-Za-z0-9._%-]+@[A-Za-z0-9]+.[A-Za-z]{2,3}"
        }
    }

    //Custom mask editor
    public class MobileNoEditor : MaskEditor
    {
        public MobileNoEditor()
        {
            Mask = @"\(\d{3}\) \d{3} - \d{4}";
        }
    }

    //Setting custom mask editors for the properties
    [Editor("Email_1, Email_2", typeof(EmailEditor))]
    [Editor("Mobile", typeof(MobileNoEditor))]
    public class Person
    {
        public Person()
        {
            Name = "Carl Johnson";
            Age = 3;
            Mobile = "2054449";
            Email_1 = "carljohnson@gta.c";
            Email_2 = "johnson@gta.com";
        }

        public string Name { get; set; }
        public string Email_1 { get; set; }
        public object Email_2 { get; set; }
        public string Mobile { get; set; }
        public object Age { get; set; }
    }

}
