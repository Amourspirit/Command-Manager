using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Label Command Executor
    /// </summary>
    public class LabelCommandExecutor : CommandExecutor<System.Windows.Forms.Label>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks Label.TextChanged Event
        /// </summary>
        /// <param name="item">A Label</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.Label item, Command cmd)
        {
            item.TextChanged += Label_TextChanged;
            base.OnInstanceAdded(item, cmd);
        }

        /// <summary>
        /// Sets the checked state of the Label
        /// </summary>
        /// <param name="item">A Label</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to Label so no action is take on this method.</remarks>
        public override void Check(System.Windows.Forms.Label item, bool bCheck)
        {
            // do nothing
        }

        /// <summary>
        /// Sets the enabled state of the Label
        /// </summary>
        /// <param name="item">A Label</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.Label item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the Label
        /// </summary>
        /// <param name="item">A Label</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.Label item, bool bVisible)
        {
            item.Visible = bVisible;
        }

        private void Label_TextChanged(object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((System.Windows.Forms.Label)sender);
            CancelCommandEventArgs args = new CancelCommandEventArgs();
            args.Checked = cmd.Checked;
            args.Enabled = cmd.Enabled;
            args.Visible = cmd.Visible;
            if (this.CommandExecute != null)
                this.CommandExecute(sender, args);
            if (args.Cancel == true)
            {
                cmd.Enabled = args.Enabled;
                cmd.Checked = args.Checked;
                cmd.Visible = args.Visible;
                cmd.Execute();
            }

        }
    }
}
