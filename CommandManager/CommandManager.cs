using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
//******************************************************************************
//Dictionary
//-------------------------------------------------------------------------------
//CommandManager          -   Global service that manages a collection of 
//                            _Commands

//Command                 -   A conceptual representation for an application
//                            operation (ie.  Save, Edit, Load, etc...)

//Command Instance        -   A UI element associated with a command (ie, Menu
//                            item, Toolbar Item, etc...).  A command can have
//                            multiple instances

//Command Type            -   A UI class that can house a command Instance (ie
//                            "System.Windows.Forms.MenuItem",
//                            "System.Windows.Forms.ToolbarItem" )

//CommandExecutor         -   An object that can handle all communication between
//                            the command manager and a particular command instance
//                            for a particular command type.

//UpdateHandler           -   Event handler for the Commands Update event.
//******************************************************************************/
using System.Timers;
using System.Windows.Forms;
using System.ComponentModel;
using BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData;
using BigByteTechnologies.Library.Windows.CommandManagement.Executors;

namespace BigByteTechnologies.Library.Windows.CommandManagement
{
    /// <summary>
    /// A WinForms component that determines whether an application is idle and updates the User Interface (UI), enabling
    /// , disabling and displaying user interface controls as needed using a list of commands.
    /// </summary>
    public class CommandManager : ApplicationIdle
    {
        #region Fields
        // Member Variables
        private CommandsList _commands;
        private Hashtable hashCommandExecutors;
        //private hashCommandExecutors2 As Generic.Dictionary(Of String, Of T)
        #endregion

        #region Event Handlers
        /// <summary>
        /// Event Raised before commands are processed
        /// </summary>
        /// <remarks>If CancelEventArgs is false then processing will not take place</remarks>
        public EventHandler<CancelEventArgs> PreCommandProcess;
        /// <summary>
        /// Event Raise after commands are processed
        /// </summary>
        public EventHandler PostCommandProcess;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a instance
        /// </summary>
        /// <remarks>
        /// <see cref="IdleTime"/> default value is set to 500 milliseconds.
        /// <see cref="TickInterval"/> default value is set to 250 milliseconds.
        /// The following Command Executors are automatically registered.
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="MenuCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ToolbarCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ButtonCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ListViewCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ToolStripMenuItemCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ToolStripDropDownItemCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ToolStripButtonCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="TextBoxCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="LabelCommandExecutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="ComboBoxCommandExeutor"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="NumericUpDownCommandExecutor"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public CommandManager() : base()
        {
            this.IdleTime = new TimeSpan(0, 0, 0, 0, 500);
            this.IdleAction = Behavior.None;
            this.TickInterval = new TimeSpan(0, 0, 0, 0, 250);
            base.WarnSetting = WarnSettings.Off;

            _commands = new CommandManager.CommandsList(this);
            hashCommandExecutors = new Hashtable();


            // By default, menus and toolbars are known
            MenuCommandExecutor Mce = new MenuCommandExecutor();
            RegisterCommandExecutor(Mce.StringType, Mce);

            //RegisterCommandExecutor("System.Windows.Forms.MenuItem", New MenuCommandExecutor())
            ToolbarCommandExecutor TCE = new ToolbarCommandExecutor();
            RegisterCommandExecutor(TCE.StringType, TCE);
            //RegisterCommandExecutor("System.Windows.Forms.ToolBarButton", New ToolbarCommandExecutor())

            ButtonCommandExecutor BCE = new ButtonCommandExecutor();
            RegisterCommandExecutor(BCE.StringType, BCE);
            //RegisterCommandExecutor("System.Windows.Forms.Button", New ButtonCommandExecutor())

            ListViewCommandExecutor LVCE = new ListViewCommandExecutor();
            RegisterCommandExecutor(LVCE.StringType, LVCE);
            //RegisterCommandExecutor("System.Windows.Forms.ListView", New ListViewCommandExecutor())

            ToolStripMenuItemCommandExecutor TSMICE = new ToolStripMenuItemCommandExecutor();
            RegisterCommandExecutor(TSMICE.StringType, TSMICE);
            //RegisterCommandExecutor("System.Windows.Forms.ToolStripMenuItem", New ToolStripMenuItemCommandExecutor())

            ToolStripDropDownItemCommandExecutor TSDDICE = new ToolStripDropDownItemCommandExecutor();
            RegisterCommandExecutor(TSDDICE.StringType, TSDDICE);
            //RegisterCommandExecutor("System.Windows.Forms.ToolStripDropDownItem", New ToolStripDropDownItemCommandExecutor())

            ToolStripButtonCommandExecutor TSBCE = new ToolStripButtonCommandExecutor();
            RegisterCommandExecutor(TSBCE.StringType, TSBCE);
            //RegisterCommandExecutor("System.Windows.Forms.ToolStripButton", New ToolStripButtonCommandExecutor())

            TextBoxCommandExecutor TXTC = new TextBoxCommandExecutor();
            RegisterCommandExecutor(TXTC);

            LabelCommandExecutor LBLC = new LabelCommandExecutor();
            RegisterCommandExecutor(LBLC);

            ComboBoxCommandExeutor CBXC = new ComboBoxCommandExeutor();
            RegisterCommandExecutor(CBXC);

            CheckBoxCommandExecutor CBEX = new CheckBoxCommandExecutor();
            RegisterCommandExecutor(CBEX);

            RegisterCommandExecutor(new NumericUpDownCommandExecutor());
            this.Idle += CommandIdle;

            this.Start();

        }
        //New
        #endregion

        #region Property Overrides
        /// <summary>
        /// Gets or set the Action to be taken when Idle is met.
        /// </summary>
        [Browsable(false)]
        public new Behavior IdleAction
        {
            get { return base.IdleAction; }
            set { base.IdleAction = value; }
        }

        /// <summary>
        /// Gets or sets the TimeSpan after which the application should be considered idle if no defined ActivityMessages are received.
        /// </summary>
        [Browsable(false), DefaultValue(typeof(TimeSpan), "00:00:00.250")]
        public new TimeSpan IdleTime
        {
            get { return base.IdleTime; }
            set { base.IdleTime = value; }
        }

        /// <summary>
        /// Gets or sets the TimeSpan at which the component 'ticks'.
        /// </summary>
        [Browsable(false), DefaultValue(typeof(TimeSpan), "00:00:00.500")]
        public new TimeSpan TickInterval
        {
            get { return base.TickInterval; }
            set { base.TickInterval = value; }
        }

        /// <summary>
        /// Gets or sets the TimeSpan at which warning events will be generated depending on the WarnSettings.
        /// </summary>
        [Browsable(false)]
        public new TimeSpan WarnTime
        {
            get { return base.WarnTime; }
            set { base.WarnTime = value; }
        }

        /// <summary>
        /// Gets or sets the WarnSettings value used to control warning events generation.
        /// </summary>
        [Browsable(false)]
        public new WarnSettings WarnSetting
        {
            get { return base.WarnSetting; }
            set { base.WarnSetting = value; }
        }
        #endregion

        /// <summary>
        /// Gets the command collection
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CommandsList Commands
        {
            get { return _commands; }
        }

        // Command Executor association methods
        /// <summary>
        /// Registers a Command Executor with the <see cref="CommandManager"/>.
        /// </summary>
        /// <typeparam name="T">Generic control type of Command Executor</typeparam>
        /// <param name="executor">The Generic Command Executor instance</param>
        public void RegisterCommandExecutor<T>(CommandExecutor<T> executor)
        {
            RegisterCommandExecutor(executor.StringType, executor);
        }
        //RegisterCommandExecutor


        // Command Executor association methods
        private void RegisterCommandExecutor<T>(string strType, CommandExecutor<T> executor)
        {
            hashCommandExecutors.Add(strType, executor);
        }
        //RegisterCommandExecutor



        internal CommandExecutor<T> GetCommandExecutor<T>(T instance)
        {
            string TypeName = instance.GetType().ToString();
            if (hashCommandExecutors.ContainsKey(TypeName) == false)
            {
                return null;
            }
            CommandExecutor<T> Obj = (CommandExecutor<T>)hashCommandExecutors[TypeName];
            return Obj;
        }
        //GetCommandExecutor



        internal object GetCommandExecutor(object instance)
        {
            string TypeName = instance.GetType().ToString();
            if (hashCommandExecutors.ContainsKey(TypeName) == false)
            {
                return null;
            }
            object Obj = hashCommandExecutors[TypeName];
            return Obj;
        }
        //GetCommandExecutor


        /// <summary>
        /// Handler for the Idle application event. Runs all the Update Commands
        /// </summary>
        /// <param name="sender">The Sender of the Event</param>
        /// <param name="e">The Event args</param>
        protected void CommandIdle(object sender, EventArgs e)
        {
            CancelEventArgs ce = new CancelEventArgs(false);
            if (this.PreCommandProcess != null)
                this.PreCommandProcess(this, ce);
            if (ce.Cancel == true)
                return;
            foreach (Command c in _commands.Values)
            {
                c.ProcessUpdates();
            }
            if (this.PostCommandProcess != null)
                this.PostCommandProcess(this, e);
        }
        //OnIdle
        #region Dispose
        /// <summary>
        /// Releases all resources used by the component.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            this.Idle -= CommandIdle;
            base.Dispose(disposing);
        }
        #endregion

        /// <summary>
        /// Command List
        /// </summary>
        public class CommandsList : SortedList<string, Command>
        {


            private CommandManager cmdmgr;
            internal CommandManager Manager
            {
                get { return cmdmgr; }
                set { cmdmgr = value; }
            }


            internal CommandsList(CommandManager amgr)
            {
                cmdmgr = amgr;

            }
            //New
            /// <summary>
            /// Add a <see cref="Command"/> instance to the list
            /// </summary>
            /// <param name="c"></param>
            public void Add(Command c)
            {
                if ((c != null))
                {
                    c.Manager = Manager;
                    base.Add(c.Tag, c);
                }

            }

        }

    }
    //CommandManager ' end class CommandManager
}
//CommandManagement

// end name-space

