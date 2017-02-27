using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Command Executors that Perform command various Controls
/// </summary>
namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Menu Command Executor
    /// </summary>
    public class MenuCommandExecutor : CommandExecutor<System.Windows.Forms.MenuItem>
    {


        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks MenuItem.Click Event
        /// </summary>
        /// <param name="item">A MenuItem</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.MenuItem item, Command cmd)
        {
            EventHandler handler = new EventHandler(menuItem_Click);

            // Attempt to remove the handler first, in case we have already 
            // signed up for the event in this tool-bar
            item.Click -= handler;
            item.Click += new EventHandler(menuItem_Click);

            base.OnInstanceAdded(item, cmd);
        }
        //InstanceAdded


        /// <summary>
        /// Sets the enabled state of the MenuItem
        /// </summary>
        /// <param name="item">A MenuItem</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.MenuItem item, bool bEnable)
        {
            item.Enabled = bEnable;
        }
        //Enable


        /// <summary>
        /// Sets the checked state of the MenuItem
        /// </summary>
        /// <param name="item">A MenuItem</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        public override void Check(System.Windows.Forms.MenuItem item, bool bCheck)
        {
            item.Checked = bCheck;
        }
        //Check

        /// <summary>
        /// Sets the Visible state of the MenuItem
        /// </summary>
        /// <param name="item">A MenuItem</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.MenuItem item, bool bVisible)
        {
            item.Visible = bVisible;
        }


        // Execution event handler
        private void menuItem_Click(object sender, System.EventArgs e)
        {

            Command cmd = GetCommandForInstance((System.Windows.Forms.MenuItem)sender);
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



    }
    //MenuCommandExecutor
}
