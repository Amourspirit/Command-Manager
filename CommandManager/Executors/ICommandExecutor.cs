using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Command Exectuor interface
    /// </summary>
    /// <typeparam name="T">The Control type to create the Executor for</typeparam>
    public interface ICommandExecutor<T>
    {
        /// <summary>
        /// Gets string Representing the Type of <typeparamref name="T"/>
        /// </summary>
        string StringType { get; }
        /// <summary>
        /// Sets the Enabled state of control <typeparamref name="T"/>
        /// </summary>
        /// <param name="item">Instance of a Control</param>
        /// <param name="bEnable">Sets the state of <paramref name="item"/> to enabled or disabled</param>
        void Enable(T item, bool bEnable);
        /// <summary>
        /// Sets the Checked stated of a control if the control of <typeparamref name="T"/> supports being checked
        /// </summary>
        /// <param name="item">Instance of Control</param>
        /// <param name="bCheck">Sets the state of <paramref name="item"/> to checked or un-checked</param>
        void Check(T item, bool bCheck);
        /// <summary>
        /// Sets the visible state of control <typeparamref name="T"/>
        /// </summary>
        /// <param name="item">Instance of Control</param>
        /// <param name="bVisible">Set the stated of <paramref name="item"/> to visible or invisible</param>
        void Visible(T item, bool bVisible);
    }
}
