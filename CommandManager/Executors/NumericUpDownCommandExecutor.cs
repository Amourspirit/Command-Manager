using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Numeric Up Down Command Executor
    /// </summary>
    public class NumericUpDownCommandExecutor : CommandExecutor<System.Windows.Forms.NumericUpDown>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks NumericUpDown.ValueChanged Event
        /// </summary>
        /// <param name="item">A NumericUpDown</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.NumericUpDown item, Command cmd)
        {
            item.ValueChanged += ValueChanged;
            base.OnInstanceAdded(item, cmd);
        }

        /// <summary>
        /// Sets the checked state of the NumericUpDown
        /// </summary>
        /// <param name="item">A NumericUpDown</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to NumericUpDown so no action is take on this method.</remarks>
        public override void Check(System.Windows.Forms.NumericUpDown item, bool bCheck)
        {
            // do nothing
        }

        /// <summary>
        /// Sets the enabled state of the NumericUpDown
        /// </summary>
        /// <param name="item">A NumericUpDown</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.NumericUpDown item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the NumericUpDown
        /// </summary>
        /// <param name="item">A NumericUpDown</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.NumericUpDown item, bool bVisible)
        {
            item.Visible = bVisible;
        }

        private void ValueChanged(object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((System.Windows.Forms.NumericUpDown)sender);
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
    }
}
