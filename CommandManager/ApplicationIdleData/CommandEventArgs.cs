using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData
{
    /// <summary>
    /// Command Event Arguments
    /// </summary>
    public class CommandEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>
        /// <see cref="Checked"/> is set to false.
        /// <see cref="Visible"/> is set to true.
        /// <see cref="Checked"/> is set to true.
        /// </remarks>
        public CommandEventArgs()
        {
            this.Checked = false;
            this.Visible = true;
            this.Enabled = true;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Enabled">Sets the state of <see cref="Enabled"/></param>
        /// <param name="Visible">Sets the state of <see cref="Visible"/></param>
        /// <param name="Checked">Sets the state of <see cref="Checked"/></param>
        public CommandEventArgs(bool Enabled, bool Visible, bool Checked)
        {
            this.Enabled = Enabled;
            this.Visible = Visible;
            this.Checked = Checked;
        }

        /// <summary>
        /// Gets/Sets if the Command is Enabled
        /// </summary>
        public bool Enabled { get; set; }
        /// <summary>
        /// Gets/Sets if the Command is Visible
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// Gets/Sets if Command is Checked
        /// </summary>
        public bool Checked { get; set; }

    }

    /// <summary>
    /// Cancel Command Event Arguments
    /// </summary>
    public class CancelCommandEventArgs : CommandEventArgs
    {
        /// <summary>
        /// Gets/Sets if the Command is to be canceled
        /// </summary>
        public bool Cancel { get; set; } = false;
       
    }

}
