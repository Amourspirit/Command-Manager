using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Checkbox Command Executor
    /// </summary>
    public class CheckBoxCommandExecutor : CommandExecutor<System.Windows.Forms.CheckBox>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks CheckBox.CheckedChanged Event
        /// </summary>
        /// <param name="item">A CheckBox</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.CheckBox item, Command cmd)
        {
            item.CheckedChanged += Check_CheckedChanged;
            base.OnInstanceAdded(item, cmd);
        }

        /// <summary>
        /// Sets the checked state of the CheckBox
        /// </summary>
        /// <param name="item">A CheckBox</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        public override void Check(System.Windows.Forms.CheckBox item, bool bCheck)
        {
            item.Checked = bCheck;
        }

        /// <summary>
        /// Sets the enabled state of the CheckBox
        /// </summary>
        /// <param name="item">A CheckBox</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.CheckBox item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the CheckBox
        /// </summary>
        /// <param name="item">A CheckBox</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.CheckBox item, bool bVisible)
        {
            item.Visible = bVisible;
        }

        private void Check_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((System.Windows.Forms.CheckBox)sender);
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
