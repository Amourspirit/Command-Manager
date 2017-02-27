using System;
using System.Windows.Forms;
using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Abstract base class for Command Executor classes
    /// </summary>
    /// <typeparam name="T">The type of Control to create Command Executor for</typeparam>
    public abstract class CommandExecutor<T> : ICommandExecutor<T>
    {
        /// <summary>
        /// Dictionary of current commands in the command executor instance
        /// </summary>
        protected System.Collections.Generic.Dictionary<T, Command> hashInstances = new System.Collections.Generic.Dictionary<T, Command>();

        /// <summary>
        /// Event raised when Command instance is added to Command Executor instance
        /// </summary>
        public EventHandler<CommandItemEventArgs<T>> InstanceAdded;
        /// <summary>
        /// Event raised when Command instance is removed from Command Executor instance
        /// </summary>
        public EventHandler<CommandItemEventArgs<T>> InstanceRemoved;
        /// <summary>
        /// Event raised when a Command Executer has started to execute.
        /// </summary>
        public EventHandler<CancelCommandEventArgs> CommandExecute;


        /// <summary>
        /// Gets the <typeparamref name="T"/> type as string instance.
        /// </summary>
        public string StringType
        {
            get { return typeof(T).ToString(); }
        }

        /// <summary>
        /// Protected method that is call when a new Command as been added to instance of Command Manager
        /// </summary>
        /// <param name="item">Instance of Control</param>
        /// <param name="cmd">The <see cref="Command"/> associated with <paramref name="item"/></param>
        /// <remarks>
        /// Can be overridden in derived classes.
        /// Method is also responsible for calling <see cref="InstanceAdded"/> event on successful adding of <paramref name="item"/>.
        /// </remarks>
        protected internal virtual void OnInstanceAdded(T item, Command cmd)
        {

            hashInstances.Add(item, cmd);
            if (InstanceAdded != null)
            {
                CommandItemEventArgs<T> args = new CommandItemEventArgs<T>(item, cmd);
                InstanceAdded(this, args);
            }
        }
        /// <summary>
        /// Protected method that is call when a new Command as been removed from instance of Command Manager
        /// </summary>
        /// <param name="item">Instance of Control</param>
        /// <param name="cmd">The <see cref="Command"/> associated with <paramref name="item"/></param>
        /// <remarks>
        /// Can be overridden in derived classes.
        /// Method is also responsible for calling <see cref="InstanceRemoved"/> event on successful removing of <paramref name="item"/>.
        /// </remarks>
        protected internal virtual void OnInstanceRemoved(T item, Command cmd)
        {
            if (hashInstances.ContainsKey((T)item))
            {
                hashInstances.Remove((T)item);
                if (InstanceRemoved != null)
                {
                    CommandItemEventArgs<T> args = new CommandItemEventArgs<T>(item, cmd);
                    InstanceRemoved(this, args);
                }
            }

        }

        /// <summary>
        /// Gets a <see cref="Command"/> for control <paramref name="item"/>
        /// </summary>
        /// <param name="item">The Control to get the <see cref="Command"/> instance for</param>
        /// <returns>Instance of <see cref="Command"/></returns>
        protected Command GetCommandForInstance(T item)
        {
            return hashInstances[item];
            //

        }
        //GetCommandForInstance


        /// <summary>
        /// Set if <paramref name="item"/> is to be enable or disabled in derived class
        /// </summary>
        /// <param name="item">The control item to enabled or disabled</param>
        /// <param name="bEnable">The boolean value that is true for enabled and false for disabled</param>
        public abstract void Enable(T item, bool bEnable);

        /// <summary>
        /// Set if <paramref name="item"/> is to be checked or unchecked in derived class if supported by control
        /// </summary>
        /// <param name="item">The control item to check or unchecked</param>
        /// <param name="bCheck">The boolean value that is true for check and false of unchecked</param>
        public abstract void Check(T item, bool bCheck);

        /// <summary>
        /// Set if <paramref name="item"/> is to be visible or invisible in derived class
        /// </summary>
        /// <param name="item">The control item to set visible or invisible</param>
        /// <param name="bVisible">The boolean value that is true for visible and false for invisible</param>
        public abstract void Visible(T item, bool bVisible);

        //protected void Enable(bool bEnable)
        //{

        //}

    }
    //CommandExecutor
}
