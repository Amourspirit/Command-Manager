using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Button Command Executor
    /// </summary>
    public class ButtonCommandExecutor : CommandExecutor<Button>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks Button.Click Event
        /// </summary>
        /// <param name="item">A Button</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(Button item, Command cmd)
        {
            Button Btn = (Button)item;
            Btn.Click += Button_Click;

            base.OnInstanceAdded(item, cmd);
        }


        private void Button_Click(System.Object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((Button)sender);
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
        //menuItem_Click

        /// <summary>
        /// Sets the checked state of the Button
        /// </summary>
        /// <param name="item">A Button</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to Button so no action is take on this method.</remarks>
        public override void Check(System.Windows.Forms.Button item, bool bCheck)
        {
            //Nothing to do for buttons
        }

        /// <summary>
        /// Sets the enabled state of the Button
        /// </summary>
        /// <param name="item">A Button</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.Button item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the Button
        /// </summary>
        /// <param name="item">A Button</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.Button item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
}
