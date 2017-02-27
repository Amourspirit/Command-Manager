using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigByteTechnologies.Library.Windows.CommandManagement.Executors
{

    /// <summary>
    /// ListView Command Executor
    /// </summary>
    public class ListViewCommandExecutor : CommandExecutor<ListView>
    {

        /// <summary>
        /// Overrides <see cref="CommandExecutor{T}.OnInstanceAdded(T, Command)"/> and hooks ListView.DoubleClick Event
        /// </summary>
        /// <param name="item">A ListView</param>
        /// <param name="cmd">The <see cref="Command"/> associated with the <paramref name="item"/></param>
        protected internal override void OnInstanceAdded(ListView item, Command cmd)
        {
            //AddHandler Lv.Click, AddressOf ListView_Click
            item.DoubleClick += ListView_DoubleClick;

            base.OnInstanceAdded(item, cmd);
        }

        /// <summary>
        /// Sets the enabled state of the ListView
        /// </summary>
        /// <param name="item">A ListView</param>
        /// <param name="bEnable">If true then the <paramref name="item"/> will be Enabled; Otherwise Disabled.</param>
        /// <remarks>
        /// This method id ignore for ListView and takes no action.
        /// </remarks>
        public override void Enable(ListView item, bool bEnable)
        {
            //Dim Lv As ListView = CType(item, ListView)
            //Lv.Enabled = bEnable
        }
        //Enable

        /// <summary>
        /// Sets the checked state of the ListView
        /// </summary>
        /// <param name="ListView">A ListView</param>
        /// <param name="bCheck">If true then the <paramref name="ListView"/> will be Checked; Otherwise unchecked.</param>
        /// <remarks>This method does not Apply to ListView so not action is take on this method.</remarks>
        public override void Check(ListView ListView, bool bCheck)
        {
            // Nothing to do for buttons
        }
        //Check

        private void ListView_DoubleClick(object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((ListView)sender);
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
        private void ListView_Click(object sender, System.EventArgs e)
        {
            Command cmd = GetCommandForInstance((ListView)sender);
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
        /// Sets the Visible state of the ListView
        /// </summary>
        /// <param name="item">A ListView</param>
        /// <param name="bVisible">If true then the <paramref name="item"/> will be Visible; Otherwise Invisible.</param>
        public override void Visible(System.Windows.Forms.ListView item, bool bVisible)
        {
            item.Visible = bVisible;
        }
    }
}
