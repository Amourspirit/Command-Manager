using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData
{
    /// <summary>
    /// Command Item Event Arguments
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CommandItemEventArgs<T>: EventArgs
    {
        /// <summary>
        /// The Command associated with the <see cref="CommandItemEventArgs{T}"/>
        /// </summary>
        public Command Cmd { get; set; }
        /// <summary>
        /// The Item associated with the <see cref="CommandItemEventArgs{T}"/>
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item">Control Item</param>
        /// <param name="Cmd">Command associated with <paramref name="item"/></param>
        public CommandItemEventArgs(T item, Command Cmd)
        {
            this.Item = item;
            this.Cmd = Cmd;
        }
    }
}
