using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Tool Strip menu Item Command Executor
    /// </summary>
    public class ToolStripMenuItemCommandExecutor : CommandExecutor<ToolStripMenuItem>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ToolStripMenuItem.Click Event
        /// </summary>
        /// <param name="item">A ToolStripMenuItem</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(ToolStripMenuItem item, Command cmd)
        {
            item.Click += ToolStripMenuItem_Click;
            base.OnInstanceAdded(item, cmd);
        }

        private void ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((ToolStripMenuItem)sender);
            CancelCommandEventArgs args = new CancelCommandEventArgs();
            args.Checked = cmd.Checked;
            args.Enabled = cmd.Enabled;
            args.Visible = cmd.Visible;
            if (this.CommandExecute != null)
                this.CommandExecute(sender, args);
            if (args.Cancel == false)
            {
                cmd.Enabled = args.Enabled;
                cmd.Checked = args.Checked;
                cmd.Visible = args.Visible;
                cmd.Execute();
            }

        }
        /// <summary>
        /// Sets the checked state of the ToolStripMenuItem
        /// </summary>
        /// <param name="item">A ToolStripMenuItem</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        public override void Check(ToolStripMenuItem item, bool bCheck)
        {
            item.Checked = bCheck;
        }

        /// <summary>
        /// Sets the enabled state of the ToolStripMenuItem
        /// </summary>
        /// <param name="item">A ToolStripMenuItem</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(ToolStripMenuItem item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the ToolStripMenuItem
        /// </summary>
        /// <param name="item">A ToolStripMenuItem</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ToolStripMenuItem item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
}
