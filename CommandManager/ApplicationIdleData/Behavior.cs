using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData
{
    /// <summary>
    /// 
    /// </summary>
    public enum Behavior : byte
    {
        /// <summary>
        /// No Action Taken
        /// </summary>
        None = 0,
        /// <summary>
        /// Stops the Timer
        /// </summary>
        Stop = 1,
        /// <summary>
        /// Re-start the Timer
        /// </summary>
        ReStart = 2
    }
}
