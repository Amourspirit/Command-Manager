using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{
    /// <summary>
    /// Toolbar Command Executor
    /// </summary>
    public class ToolbarCommandExecutor : CommandExecutor<ToolBarButton>
    {
        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ToolBarButton.Click Event
        /// </summary>
        /// <param name="item">A ToolBarButton</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(System.Windows.Forms.ToolBarButton item, Command cmd)
        {
            ToolBarButtonClickEventHandler handler = new ToolBarButtonClickEventHandler(toolbar_ButtonClick);

            // Attempt to remove the handler first, in case we have already 
            // signed up for the event in this toolbar
            item.Parent.ButtonClick -= handler;
            item.Parent.ButtonClick += new ToolBarButtonClickEventHandler(toolbar_ButtonClick);


            base.OnInstanceAdded(item, cmd);
        }


        // Execution event handler
        private void toolbar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

            Command cmd = GetCommandForInstance(e.Button);
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
        /// Sets the checked state of the ToolBarButton
        /// </summary>
        /// <param name="item">A ToolBarButton</param>
        /// <param name="bCheck">If true then the <paramref name="item"/> will be Checked; Otherwise unchecked.</param>
        public override void Check(System.Windows.Forms.ToolBarButton item, bool bCheck)
        {
            item.Style = ToolBarButtonStyle.ToggleButton;
            item.Pushed = bCheck;
        }

        /// <summary>
        /// Sets the enabled state of the ToolBarButton
        /// </summary>
        /// <param name="item">A ToolBarButton</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        public override void Enable(System.Windows.Forms.ToolBarButton item, bool bEnable)
        {
            item.Enabled = bEnable;
        }

        /// <summary>
        /// Sets the Visible state of the ToolBarButton
        /// </summary>
        /// <param name="item">A ToolBarButton</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ToolBarButton item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
    //ToolbarCommandExecutor 
}
