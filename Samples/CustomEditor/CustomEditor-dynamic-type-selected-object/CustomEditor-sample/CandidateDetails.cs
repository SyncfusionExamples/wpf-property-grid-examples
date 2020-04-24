using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace CustomEditor_sample
{
    public class CanididateDetails :  ICustomTypeDescriptor,INotifyPropertyChanged
    {
        private Dictionary<string, object> _Properties = new Dictionary<string, object>();
        private Dictionary<string, string> _DisplayNames = new Dictionary<string, string>();

        #region Properties

        public Dictionary<string, object> Values
        {
            get { return _Properties; }
            set
            {
                _Properties = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Values"));
            }
        }

        public Dictionary<string, string> DisplayNames
        {
            get { return _DisplayNames; }
            set
            {
                _DisplayNames = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayNames)));
            }
        }

        #endregion

        #region ICustomTypeDescriptor Members

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public PropertyDescriptorCollection GetProperties()
        {
            ArrayList properties = new ArrayList();
            foreach (var e in this.Values)
            {
                properties.Add(new CustomPropertyDescriptor(this, e.Key, e.Key, e.Value.GetType(), new Attribute[0]));
            }

            PropertyDescriptor[] props = (PropertyDescriptor[])properties.ToArray(typeof(PropertyDescriptor));

            return new PropertyDescriptorCollection(props);
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        { 
            ArrayList properties = new ArrayList();

            foreach (var e in this.Values)
            {
                properties.Add(new CustomPropertyDescriptor(this, e.Key, e.Key, e.Value.GetType(), new Attribute[0]));
            }

            PropertyDescriptor[] props = (PropertyDescriptor[])properties.ToArray(typeof(PropertyDescriptor));

            return new PropertyDescriptorCollection(props);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

    public class CustomPropertyDescriptor : PropertyDescriptor
    {
        private readonly CanididateDetails candidateDetails;

        #region Constructors

        public CustomPropertyDescriptor(CanididateDetails candidateDetails,
                                        string propertyName,
                                        string propertyDisplayName,
                                        Type propertyType,
                                        Attribute[] propertyAttributes)
            : base(propertyName, propertyAttributes)
        {
            this.candidateDetails = candidateDetails;
            PropertyType = propertyType;
            DisplayName = propertyDisplayName;
        }

        #endregion

        #region Properties

        public override Type ComponentType
        {
            get { return typeof(CanididateDetails); }
        }

        public override string DisplayName { get; }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType { get; }

        #endregion

        #region Override members

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override object GetValue(object component)
        {
            object x = candidateDetails.Values[base.Name];
            return x;
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
            candidateDetails.Values[Name] = value;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        #endregion
    }
}