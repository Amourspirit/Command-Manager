using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Tool Strip Button Command Executor
    /// </summary>
    public class ToolStripButtonCommandExecutor : CommandExecutor<ToolStripButton>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ToolStripButton.Click Event
        /// </summary>
        /// <param name="item">A ToolStripButton</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(ToolStripButton item, Command cmd)
        {
            item.Click += ToolStripButton_Click;
            base.OnInstanceAdded(item, cmd);
        }

        private void ToolStripButton_Click(System.Object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((ToolStripButton)sender);
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
        /// Sets the checked state of the ToolStripButton
        /// </summary>
        /// <param name="item">A ToolStripButton</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        public override void Check(ToolStripButton item, bool bCheck)
        {
            item.Enabled = bCheck;
        }

        /// <summary>
        /// Sets the enabled state of the ToolStripButton
        /// </summary>
        /// <param name="item">A ToolStripButton</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(ToolStripButton item, bool bEnable)
        {
            System.Windows.Forms.ToolStripButton tItem = (System.Windows.Forms.ToolStripButton)item;
            tItem.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the ToolStripButton
        /// </summary>
        /// <param name="item">A ToolStripButton</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ToolStripButton item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
}
