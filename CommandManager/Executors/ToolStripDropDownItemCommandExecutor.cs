using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Tool Strip Drop down Item Command Executor
    /// </summary>
    public class ToolStripDropDownItemCommandExecutor : CommandExecutor<ToolStripDropDownItem>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ToolStripDropDownItem.Click Event
        /// </summary>
        /// <param name="item">A ToolStripDropDownItem</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(ToolStripDropDownItem item, Command cmd)
        {
            item.Click += ToolStripMenuItem_Click;

            base.OnInstanceAdded(item, cmd);
        }


        private void ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((ToolStripDropDownItem)sender);
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
        /// Sets the checked state of the ToolStripDropDownItem
        /// </summary>
        /// <param name="item">A ToolStripDropDownItem</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to ToolStripDropDownItem so no action is take on this method.</remarks>
        public override void Check(ToolStripDropDownItem item, bool bCheck)
        {
            // do nothing
        }

        /// <summary>
        /// Sets the enabled state of the ToolStripDropDownItem
        /// </summary>
        /// <param name="item">A ToolStripDropDownItem</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(ToolStripDropDownItem item, bool bEnable)
        {
            System.Windows.Forms.ToolStripDropDownItem tItem = (System.Windows.Forms.ToolStripDropDownItem)item;
            tItem.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the ToolStripDropDownItem
        /// </summary>
        /// <param name="item">A ToolStripDropDownItem</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ToolStripDropDownItem item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
}
