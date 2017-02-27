using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Combo box Command Executor
    /// </summary>
    public class ComboBoxCommandExeutor : CommandExecutor<System.Windows.Forms.ComboBox>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ComboBox.SelectionChangeCommitted Event
        /// </summary>
        /// <param name="item">A ComboBox</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.ComboBox item, Command cmd)
        {
            item.SelectionChangeCommitted += Combo_SelectionChangeCommitted;
            base.OnInstanceAdded(item, cmd);
        }

        /// <summary>
        /// Sets the checked state of the ComboBox
        /// </summary>
        /// <param name="item">A ComboBox</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to ComboBox so no action is take on this method.</remarks>
        public override void Check(System.Windows.Forms.ComboBox item, bool bCheck)
        {
            // do nothing
        }

        /// <summary>
        /// Sets the enabled state of the ComboBox
        /// </summary>
        /// <param name="item">A ComboBox</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.ComboBox item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the ComboBox
        /// </summary>
        /// <param name="item">A ComboBox</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ComboBox item, bool bVisible)
        {
            item.Visible = bVisible;
        }

        private void Combo_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((System.Windows.Forms.ComboBox)sender);
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
