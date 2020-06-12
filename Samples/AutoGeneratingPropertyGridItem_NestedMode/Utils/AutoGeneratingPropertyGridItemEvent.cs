
using Syncfusion.Windows.PropertyGrid;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace AutoGeneratingPropertyGridItem_NestedMode
{

    /// <summary>
    /// A class that represents the AutoGeneratingPropertyGridItem event to AutoGeneratingPropertyGridItem Command
    /// </summary>
    public class EventToCommandBehavior : Behavior<FrameworkElement>
    {
        private Delegate _handler;
        private EventInfo _oldEvent;

        // Event
        public string Event
        {
            get { return (string)GetValue(EventProperty); }
            set { SetValue(EventProperty, value); }
        }
        public static readonly DependencyProperty EventProperty =
            DependencyProperty.Register("Event",
            typeof(string),
            typeof(EventToCommandBehavior),
            new PropertyMetadata(null, OnEventChanged));

        // Command
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command",
            typeof(ICommand),
            typeof(EventToCommandBehavior),
            new PropertyMetadata(null));

        // PassArguments (default: false)
        public bool PassArguments
        {
            get { return (bool)GetValue(PassArgumentsProperty); }
            set { SetValue(PassArgumentsProperty, value); }
        }
        public static readonly DependencyProperty PassArgumentsProperty =
            DependencyProperty.Register("PassArguments",
            typeof(bool),
            typeof(EventToCommandBehavior),
            new PropertyMetadata(false));

        private static void OnEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var beh = (EventToCommandBehavior)d;
            if (beh.AssociatedObject != null) // is not yet attached at initial load
                beh.AttachHandler((string)e.NewValue);
        }

        protected override void OnAttached()
        {
            AttachHandler(this.Event); // initial set
        }

        /// <summary>
        /// Attaches the handler to the event
        /// </summary>
        private void AttachHandler(string eventName)
        {
            // detach old event
            if (_oldEvent != null)
                _oldEvent.RemoveEventHandler(this.AssociatedObject, _handler);

            // attach new event
            if (!string.IsNullOrEmpty(eventName))
            {
                EventInfo ei = this.AssociatedObject.GetType().GetEvent(eventName);
                if (ei != null)
                {
                    MethodInfo mi = this.GetType().GetMethod("ExecuteCommand",
                        BindingFlags.Instance | BindingFlags.NonPublic);
                    _handler = Delegate.CreateDelegate(ei.EventHandlerType, this, mi);
                    ei.AddEventHandler(this.AssociatedObject, _handler);
                    _oldEvent = ei; // store to detach in case the Event property changes
                }
                else
                    throw new ArgumentException(string.Format
                        ("The event '{0}' was not found on type '{1}'",
                        eventName, this.AssociatedObject.GetType().Name));
            }
        }
        private void ExecuteCommand(object sender, EventArgs e)
        {
            object parameter = this.PassArguments ? e : sender;
            if (this.Command != null)
            {
                if (this.Command.CanExecute(parameter))
                    this.Command.Execute(parameter);
            }
        }
    }

    /// <summary>
    /// A clas that represents the Commend for the AutoGeneratingPropertyGridItem Event 
    /// </summary>
    class UpdaterValue : ICommand
    {
        #region ICommand Members  
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {
            if ((parameter as AutoGeneratingPropertyGridItemEventArgs).DisplayName == "Address" || 
                (parameter as AutoGeneratingPropertyGridItemEventArgs).DisplayName == "JoiningDate")
            {
                //PropertyGrid hides the nested properties of the specific property item in NestedMode
                (parameter as AutoGeneratingPropertyGridItemEventArgs).ExpandMode =  PropertyExpandModes.FlatMode;
            }
        }
        #endregion
    }
}
