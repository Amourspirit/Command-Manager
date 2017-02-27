using System;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using BigByteTechnologies.Library.Windows.CommandManagement.Executors;

namespace BigByteTechnologies.Library.Windows.CommandManagement
{
    /// <summary>
    /// Represents a command that manages the state of a control
    /// </summary>
    public class Command
    {
        #region Fields
        private CommandInstanceList _commandInstances;
        private CommandManager _Manager;
        private string strTag;
        private bool _Enabled = true;
        private bool _Check = true;

        private bool _Visible = true;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor to create a new instance of a <see cref="Command"/>.
        /// </summary>
        /// <param name="strTag">The key word tag associated with this instance of <see cref="Command"/></param>
        /// <param name="handlerExecute">
        /// The <see cref="ExecuteHandler"/> that executes when the
        /// <paramref name="handlerUpdate"/> conditions are met.
        /// </param>
        /// <param name="handlerUpdate">
        /// The <see cref="UpdateHandler"/> that executes on idle to check and see if conditions are met to run
        /// <paramref name="handlerExecute"/>
        /// </param>
        public Command(string strTag, ExecuteHandler handlerExecute, UpdateHandler handlerUpdate)
        {
            _commandInstances = new CommandInstanceList(this);
            this.strTag = strTag;

            OnUpdate += handlerUpdate;
            OnExecute += handlerExecute;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets the Command instances for the current command
        /// </summary>
        public CommandInstanceList CommandInstances
        {
            get { return _commandInstances; }
        }


        /// <summary>
        /// Gets the Tag of the Command. Tag property: Unique internal name for each command
        /// </summary>
        public string Tag
        {
            get { return strTag; }
        }
        // Manager property: maintain association with parent command _Manager

        internal CommandManager Manager
        {
            get { return _Manager; }
            set { _Manager = value; }
        }

        /// <summary>
        /// Overrides Base ToString method and return <see cref="Tag"/>
        /// </summary>
        /// <returns><see cref="Tag"/> Property Value</returns>
        public override string ToString()
        {
            return Tag;
        }
        //ToString


        /// <summary>
        /// Method to trigger Events for the Command instance
        /// </summary>
        public void Execute()
        {
            if (OnExecute != null)
            {
                OnExecute(this);
            }

        }
        //Execute


        internal void ProcessUpdates()
        {
            if (OnUpdate != null)
            {
                OnUpdate(this);
            }

        }
        //ProcessUpdates 

        /// <summary>
        /// Gets/Sets if the <see cref="Command"/> is Enabled
        /// </summary>
        /// <remarks>
        /// Setting the Enabled property requires extra processing. Therefore it is not recommended to use the Enabled
        /// property for multiple setting within a single method.
        /// </remarks>
        public bool Enabled
        {
            get { return _Enabled; }
            set
            {
                if (_Enabled == value)
                {
                    return;
                }
                _Enabled = value;


                // Create a type object representing the generic Dictionary 
                // type, by omitting the type arguments (but keeping the 
                // comma that separates them, so the compiler can infer the
                // number of type parameters).
                //Dim generic As Type = GetType(CommandExecutor(Of ))


                object instance = null;

                foreach (var instance_loopVariable in _commandInstances)
                {
                    instance = instance_loopVariable;
                    
                    Type ItemType = instance.GetType();
                    switch (ItemType.ToString())
                    {
                        case "System.Windows.Forms.ToolBarButton":
                            System.Windows.Forms.ToolBarButton ItmToolBarButton = (System.Windows.Forms.ToolBarButton)instance;
                            Manager.GetCommandExecutor(ItmToolBarButton).Enable(ItmToolBarButton, _Enabled);
                            break;
                        case "System.Windows.Forms.MenuItem":
                            System.Windows.Forms.MenuItem ItmMenuItem = (System.Windows.Forms.MenuItem)instance;
                            Manager.GetCommandExecutor(ItmMenuItem).Enable(ItmMenuItem, _Enabled);
                            break;
                        case "System.Windows.Forms.Button":
                            System.Windows.Forms.Button ItmButton = (System.Windows.Forms.Button)instance;
                            Manager.GetCommandExecutor(ItmButton).Enable(ItmButton, _Enabled);
                            break;
                        case "System.Windows.Forms.ListView":
                            System.Windows.Forms.ListView ItmListView = (System.Windows.Forms.ListView)instance;
                            Manager.GetCommandExecutor(ItmListView).Enable(ItmListView, _Enabled);
                            break;
                        case "System.Windows.Forms.ToolStripDropDownItem":
                            System.Windows.Forms.ToolStripDropDownItem ItmToolStripDropDownItem = (System.Windows.Forms.ToolStripDropDownItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripDropDownItem).Enable(ItmToolStripDropDownItem, _Enabled);
                            break;
                        case "System.Windows.Forms.ToolStripMenuItem":
                            System.Windows.Forms.ToolStripMenuItem ItmToolStripMenuItem = (System.Windows.Forms.ToolStripMenuItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripMenuItem).Enable(ItmToolStripMenuItem, _Enabled);
                            break;
                        case "System.Windows.Forms.ToolStripButton":
                            System.Windows.Forms.ToolStripButton ItmToolStripButton = (System.Windows.Forms.ToolStripButton)instance;
                            Manager.GetCommandExecutor(ItmToolStripButton).Enable(ItmToolStripButton, _Enabled);
                            break;
                        case "System.Windows.Forms.TextBox":
                            System.Windows.Forms.TextBox ItmTextBox = (System.Windows.Forms.TextBox)instance;
                            Manager.GetCommandExecutor(ItmTextBox).Enable(ItmTextBox, _Enabled);
                            break;
                        case "System.Windows.Forms.Label":
                            System.Windows.Forms.Label ItmLabel = (System.Windows.Forms.Label)instance;
                            Manager.GetCommandExecutor(ItmLabel).Enable(ItmLabel, _Enabled);
                            break;
                        case "System.Windows.Forms.ComboBox":
                            System.Windows.Forms.ComboBox ItmComboBox = (System.Windows.Forms.ComboBox)instance;
                            Manager.GetCommandExecutor(ItmComboBox).Enable(ItmComboBox, _Enabled);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox ItmCheckBox = (System.Windows.Forms.CheckBox)instance;
                            Manager.GetCommandExecutor(ItmCheckBox).Enable(ItmCheckBox, _Enabled);
                            break;
                        case "System.Windows.Forms.NumericUpDown":
                            System.Windows.Forms.NumericUpDown ItmNumericUpDown = (System.Windows.Forms.NumericUpDown)instance;
                            CommandExecutor<System.Windows.Forms.NumericUpDown> ItmUdCe = Manager.GetCommandExecutor(ItmNumericUpDown);
                            ItmUdCe.Enable(ItmNumericUpDown, _Enabled);
                            break;
                        default:
                            // use late binding
                            // This would only come into play when command manager is extended
                            // to handel a new type outside the library
                           
                            object Ce = Manager.GetCommandExecutor(instance_loopVariable);
                            if (Ce == null)
                            {
                                break;
                            }
                            MethodInfo method = Ce.GetType().GetMethod("Enable");
                            if (method == null)
                            {
                                break;
                            }
                            method.Invoke(Ce, new object[] { instance, _Enabled });
                            break;
                    }


                }
            }
        }

        /// <summary>
        /// Gets/Sets if the <see cref="Command"/> is Checked
        /// </summary>
        /// <remarks>
        /// Setting the Checked property requires extra processing. Therefore it is not recommended to use the Checked
        /// property for multiple setting within a single method.
        /// </remarks>
        public bool Checked
        {
            get { return _Check; }
            set
            {
                if (_Check == value)
                {
                    return;
                }
                _Check = value;



                object instance = null;
                foreach (object instance_loopVariable in _commandInstances)
                {
                    instance = instance_loopVariable;
                    Type ItemType = instance.GetType();
                    switch (ItemType.ToString())
                    {
                        case "System.Windows.Forms.ToolBarButton":
                            System.Windows.Forms.ToolBarButton ItmToolBarButton = (System.Windows.Forms.ToolBarButton)instance;
                            Manager.GetCommandExecutor(ItmToolBarButton).Check(ItmToolBarButton, _Check);
                            break;
                        case "System.Windows.Forms.MenuItem":
                            System.Windows.Forms.MenuItem ItmMenuItem = (System.Windows.Forms.MenuItem)instance;
                            Manager.GetCommandExecutor(ItmMenuItem).Check(ItmMenuItem, _Check);
                            break;
                        case "System.Windows.Forms.Button":
                            System.Windows.Forms.Button ItmButton = (System.Windows.Forms.Button)instance;
                            Manager.GetCommandExecutor(ItmButton).Check(ItmButton, _Check);
                            break;
                        case "System.Windows.Forms.ListView":
                            System.Windows.Forms.ListView ItmListView = (System.Windows.Forms.ListView)instance;
                            Manager.GetCommandExecutor(ItmListView).Check(ItmListView, _Check);
                            break;
                        case "System.Windows.Forms.ToolStripDropDownItem":
                            System.Windows.Forms.ToolStripDropDownItem ItmToolStripDropDownItem = (System.Windows.Forms.ToolStripDropDownItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripDropDownItem).Check(ItmToolStripDropDownItem, _Check);
                            break;
                        case "System.Windows.Forms.ToolStripMenuItem":
                            System.Windows.Forms.ToolStripMenuItem ItmToolStripMenuItem = (System.Windows.Forms.ToolStripMenuItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripMenuItem).Check(ItmToolStripMenuItem, _Check);
                            break;
                        case "System.Windows.Forms.ToolStripButton":
                            System.Windows.Forms.ToolStripButton ItmToolStripButton = (System.Windows.Forms.ToolStripButton)instance;
                            Manager.GetCommandExecutor(ItmToolStripButton).Check(ItmToolStripButton, _Check);
                            break;
                        case "System.Windows.Forms.TextBox":
                            System.Windows.Forms.TextBox ItmTextBox = (System.Windows.Forms.TextBox)instance;
                            Manager.GetCommandExecutor(ItmTextBox).Check(ItmTextBox, _Check);
                            break;
                        case "System.Windows.Forms.Label":
                            System.Windows.Forms.Label ItmLabel = (System.Windows.Forms.Label)instance;
                            Manager.GetCommandExecutor(ItmLabel).Check(ItmLabel, _Check);
                            break;
                        case "System.Windows.Forms.ComboBox":
                            System.Windows.Forms.ComboBox ItmComboBox = (System.Windows.Forms.ComboBox)instance;
                            Manager.GetCommandExecutor(ItmComboBox).Check(ItmComboBox, _Check);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox ItmCheckBox = (System.Windows.Forms.CheckBox)instance;
                            Manager.GetCommandExecutor(ItmCheckBox).Check(ItmCheckBox, _Check);
                            break;
                        case "System.Windows.Forms.NumericUpDown":
                            System.Windows.Forms.NumericUpDown ItmNumericUpDown = (System.Windows.Forms.NumericUpDown)instance;
                            Manager.GetCommandExecutor(ItmNumericUpDown).Check(ItmNumericUpDown, _Check);
                            break;
                        default:
                            // use late binding
                            // This would only come into play when command manager is extended
                            // to handel a new type outside the library

                            object Ce = Manager.GetCommandExecutor(instance_loopVariable);
                            if (Ce == null)
                            {
                                break;
                            }
                            MethodInfo method = Ce.GetType().GetMethod("Check");
                            if (method == null)
                            {
                                break;
                            }
                            method.Invoke(Ce, new object[] { instance, _Check });
                            break;
                            
                    }

                }


            }
        }

        /// <summary>
        /// Gets/Sets if the <see cref="Command"/> is visible
        /// </summary>
        /// <remarks>
        /// Setting the Visible property requires extra processing. Therefore it is not recommended to use the visible
        /// property for multiple setting within a single method.
        /// </remarks>
        public bool Visible
        {
            get { return _Visible; }
            set
            {
                if (_Visible == value)
                {
                    return;
                }
                _Visible = value;



                object instance = null;
                foreach (object instance_loopVariable in _commandInstances)
                {
                    instance = instance_loopVariable;
                    Type ItemType = instance.GetType();
                    switch (ItemType.ToString())
                    {
                        case "System.Windows.Forms.ToolBarButton":
                            System.Windows.Forms.ToolBarButton ItmToolBarButton = (System.Windows.Forms.ToolBarButton)instance;
                            Manager.GetCommandExecutor(ItmToolBarButton).Visible(ItmToolBarButton, _Visible);
                            break;
                        case "System.Windows.Forms.MenuItem":
                            System.Windows.Forms.MenuItem ItmMenuItem = (System.Windows.Forms.MenuItem)instance;
                            Manager.GetCommandExecutor(ItmMenuItem).Visible(ItmMenuItem, _Visible);
                            break;
                        case "System.Windows.Forms.Button":
                            System.Windows.Forms.Button ItmButton = (System.Windows.Forms.Button)instance;
                            Manager.GetCommandExecutor(ItmButton).Visible(ItmButton, _Visible);
                            break;
                        case "System.Windows.Forms.ListView":
                            System.Windows.Forms.ListView ItmListView = (System.Windows.Forms.ListView)instance;
                            Manager.GetCommandExecutor(ItmListView).Visible(ItmListView, _Visible);
                            break;
                        case "System.Windows.Forms.ToolStripDropDownItem":
                            System.Windows.Forms.ToolStripDropDownItem ItmToolStripDropDownItem = (System.Windows.Forms.ToolStripDropDownItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripDropDownItem).Visible(ItmToolStripDropDownItem, _Visible);
                            break;
                        case "System.Windows.Forms.ToolStripMenuItem":
                            System.Windows.Forms.ToolStripMenuItem ItmToolStripMenuItem = (System.Windows.Forms.ToolStripMenuItem)instance;
                            Manager.GetCommandExecutor(ItmToolStripMenuItem).Visible(ItmToolStripMenuItem, _Visible);
                            break;
                        case "System.Windows.Forms.ToolStripButton":
                            System.Windows.Forms.ToolStripButton ItmToolStripButton = (System.Windows.Forms.ToolStripButton)instance;
                            Manager.GetCommandExecutor(ItmToolStripButton).Visible(ItmToolStripButton, _Visible);
                            break;
                        case "System.Windows.Forms.TextBox":
                            System.Windows.Forms.TextBox ItmTextBox = (System.Windows.Forms.TextBox)instance;
                            Manager.GetCommandExecutor(ItmTextBox).Visible(ItmTextBox, _Visible);
                            break;
                        case "System.Windows.Forms.Label":
                            System.Windows.Forms.Label ItmLabel = (System.Windows.Forms.Label)instance;
                            Manager.GetCommandExecutor(ItmLabel).Visible(ItmLabel, _Visible);
                            break;
                        case "System.Windows.Forms.ComboBox":
                            System.Windows.Forms.ComboBox ItmComboBox = (System.Windows.Forms.ComboBox)instance;
                            Manager.GetCommandExecutor(ItmComboBox).Visible(ItmComboBox, _Visible);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox ItmCheckBox = (System.Windows.Forms.CheckBox)instance;
                            Manager.GetCommandExecutor(ItmCheckBox).Visible(ItmCheckBox, _Visible);
                            break;
                        case "System.Windows.Forms.NumericUpDown":
                            System.Windows.Forms.NumericUpDown ItmNumericUpDown = (System.Windows.Forms.NumericUpDown)instance;
                            Manager.GetCommandExecutor(ItmNumericUpDown).Visible(ItmNumericUpDown, _Visible);
                            break;
                        default:
                            // use late binding
                            // This would only come into play when command manager is extended
                            // to handel a new type outside the library

                            object Ce = Manager.GetCommandExecutor(instance_loopVariable);
                            if (Ce == null)
                            {
                                break;
                            }
                            MethodInfo method = Ce.GetType().GetMethod("Visible");
                            if (method == null)
                            {
                                break;
                            }
                            method.Invoke(Ce, new object[] { instance, _Visible });
                            break;
                    }

                }


            }
        }
        #endregion

        #region Methods

        internal bool IsKnownCommandInstance<T>(T Item)
        {
            string itmType = Item.GetType().ToString();

            switch (itmType)
            {
                case "System.Windows.Forms.ToolBarButton":
                case "System.Windows.Forms.MenuItem":
                case "System.Windows.Forms.Button":
                case "System.Windows.Forms.ListView":
                case "System.Windows.Forms.ToolStripDropDownItem":
                case "System.Windows.Forms.ToolStripMenuItem":
                case "System.Windows.Forms.ToolStripButton":
                case "System.Windows.Forms.TextBox":
                case "System.Windows.Forms.Label":
                case "System.Windows.Forms.ComboBox":
                case "System.Windows.Forms.CheckBox":
                case "System.Windows.Forms.NumericUpDown":
                    return true;
                //Case TypeOf Item Is TabPage
                //    Return True
                default:
                    return false;
            }
        }
        #endregion

        #region Delegates/Events

        // Events
        /// <summary>
        /// Update handler for <see cref="Command"/> instances
        /// </summary>
        /// <param name="cmd">Instance of <see cref="Command"/></param>
        public delegate void UpdateHandler(Command cmd);
        /// <summary>
        /// Event that is raised when a <see cref="Command"/> is updated
        /// </summary>
        public event UpdateHandler OnUpdate;

        /// <summary>
        /// Execute handler for <see cref="Command"/> instances
        /// </summary>
        /// <param name="cmd">Instance of <see cref="Command"/></param>
        public delegate void ExecuteHandler(Command cmd);
        /// <summary>
        /// Event that is raised when a <see cref="Command"/> is executed
        /// </summary>
        public event ExecuteHandler OnExecute;
        #endregion

        #region Nested Classes
        /// <summary>
        /// Represents a list of <see cref="Command"/> instances
        /// </summary>
        public class CommandInstanceList : System.Collections.CollectionBase
        {

            #region Constructor

            internal CommandInstanceList(Command acmd)
            {
                command = acmd;
            }
            #endregion

            #region Properties
            private MethodInfo m_AddMethodInfo = null;
            // cache the Add Method for generic use
            private MethodInfo AddMethodInfo
            {
                get
                {
                    if (this.m_AddMethodInfo == null)
                    {
                        this.m_AddMethodInfo = this.GetType().GetMethod("Add");
                    }
                    return this.m_AddMethodInfo;
                }
            }

            private MethodInfo m_OnInsertCompMethodInfo = null;
            // cache the Add Method for generic use
            private MethodInfo OnInsertCompMethodInfo
            {
                get
                {
                    if (this.m_OnInsertCompMethodInfo == null)
                    {
                        this.m_OnInsertCompMethodInfo = this.GetType().GetMethod("OnInsertComp");
                    }
                    return this.m_OnInsertCompMethodInfo;
                }
            }

            // Test to see if an object is an array
            private bool IsArray(object o) { return o is Array; }
            #endregion

            #region Fields
            private Command command;
            #endregion

            #region Add Methods

            #region Add Single Item
            /// <summary>
            /// Adds A new instance to Commands
            /// </summary>
            /// <typeparam name="T">The Type of the command</typeparam>
            /// <param name="instance">The instance to add</param>
            /// <returns>
            /// returns the index of the newly added instance
            /// </returns>
            /// <exception cref="ArgumentNullException"></exception>
            /// <exception cref="Exception">If instance is array</exception>
            /// <exception cref="Exception">If No <see cref="CommandExecutor{T}"/>exist for <paramref name="instance"/></exception>
            public int Add<T>(T instance)
            {
                int i = -1;
                if (instance == null)
                {
                    throw new ArgumentNullException("instance");
                }
                if (IsArray(instance))
                {
                    throw new Exception("Adding of Commands as object Array is not supported by the Add<T> method" + Environment.NewLine + "Use the AddRange Method instead");
                }
                if (command.IsKnownCommandInstance(instance) == true)
                {
                    base.InnerList.Add(instance);
                    OnInsertComp(this, instance);
                }
                else
                {
                    var ex = command.Manager.GetCommandExecutor<T>(instance);
                    if (ex == null)
                    {
                        throw new Exception("Unable to add instance. No Command Excutor coulde be Located for:" + instance.GetType().ToString());
                    }
                    i = base.InnerList.Add(instance);
                    OnInsertComp(this, instance);
                }
                return i;
            }
            #endregion

            /// <summary>
            /// Removes an instance from the Commands
            /// </summary>
            /// <param name="index">The Index to remove</param>
            /// <returns>
            /// True if the index has been remove; Otherwise false
            /// </returns>
            public new bool RemoveAt(int index)
            {
                if (index >= 0 && base.InnerList.Count < index)
                {
                    var itm = base.InnerList[index];

                    base.InnerList.RemoveAt(index);
                    MethodInfo generic = this.OnInsertCompMethodInfo.MakeGenericMethod(itm.GetType());
                    generic.Invoke(this, new object[] { this, itm });
                   
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Removes an Instance from the list
            /// </summary>
            /// <typeparam name="T">The Type of command</typeparam>
            /// <param name="instance">The instance to remove</param>
            /// <returns>
            /// True if instance was removed; Otherwise false
            /// </returns>
            /// <exception cref="ArgumentNullException"></exception>
            /// <exception cref="Exception">If No <see cref="CommandExecutor{T}"/>exist for <paramref name="instance"/></exception>
            public bool Remove<T>(T instance)
            {
                if (instance == null)
                {
                    throw new ArgumentNullException("instance");
                }
                var ex = command.Manager.GetCommandExecutor<T>(instance);
                if (ex == null)
                {
                    throw new Exception(string.Format(Properties.Resources.Errror_UanbleToAddCommand, instance.GetType().ToString()));
                }
                int index = -1;
                for (int i = 0; i < base.InnerList.Count; i++)
                {
                    if (ReferenceEquals(base.InnerList[i], instance))
                    {
                        index = i;
                        break;
                    }
                }
                if (index > -1)
                {
                    this.InnerList.RemoveAt(index);
                    OnRemoveComp(this, instance);
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Get the index of the Command instance
            /// </summary>
            /// <typeparam name="T">The Type of the command</typeparam>
            /// <param name="instance">The instance to get the index for</param>
            /// <returns>
            /// The index of the command if it is found; Otherwise -1
            /// </returns>
            /// <exception cref="ArgumentNullException"></exception>
            /// <exception cref="Exception">If No <see cref="CommandExecutor{T}"/>exist for <paramref name="instance"/></exception>
            public int IndexOfCommand<T>(T instance)
            {
                if (instance == null)
                {
                    throw new ArgumentNullException("instance");
                }
                var ex = command.Manager.GetCommandExecutor<T>(instance);
                if (ex == null)
                {
                    throw new Exception(string.Format(Properties.Resources.Errror_UanbleToAddCommand, instance.GetType().ToString()));
                }
                int index = -1;
                for (int i = 0; i < base.InnerList.Count; i++)
                {
                    if (ReferenceEquals(base.InnerList[i], instance))
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }

            #region AddRange
            /// <summary>
            /// Adds a range of controls to the Command list at once
            /// </summary>
            /// <param name="Items">Array of Commands to add to the list.</param>
            public void AddRange(params object[] Items)
            {
                foreach (object instance in Items)
                {
                    Type ObjType = instance.GetType();
                    string sObjType = ObjType.ToString();

                    switch (sObjType)
                    {
                        case "System.Windows.Forms.ToolBarButton":
                            System.Windows.Forms.ToolBarButton ItmToolBarButton = (System.Windows.Forms.ToolBarButton)instance;
                            this.Add(ItmToolBarButton);
                            break;
                        case "System.Windows.Forms.MenuItem":
                            System.Windows.Forms.MenuItem ItmMenuItem = (System.Windows.Forms.MenuItem)instance;
                            this.Add(ItmMenuItem);
                            break; 
                        case "System.Windows.Forms.Button":
                            System.Windows.Forms.Button ItmButton = (System.Windows.Forms.Button)instance;
                            this.Add(ItmButton);
                            break; 
                        case "System.Windows.Forms.ListView":
                            System.Windows.Forms.ListView ItmListView = (System.Windows.Forms.ListView)instance;
                            this.Add(ItmListView);
                            break; 
                        case "System.Windows.Forms.ToolStripDropDownItem":
                            System.Windows.Forms.ToolStripDropDownItem ItmToolStripDropDownItem = (System.Windows.Forms.ToolStripDropDownItem)instance;
                            this.Add(ItmToolStripDropDownItem);
                            break;
                        case "System.Windows.Forms.ToolStripMenuItem":
                            System.Windows.Forms.ToolStripMenuItem ItmToolStripMenuItem = (System.Windows.Forms.ToolStripMenuItem)instance;
                            this.Add(ItmToolStripMenuItem);
                            break; 
                        case "System.Windows.Forms.ToolStripButton":
                            System.Windows.Forms.ToolStripButton ItmToolStripButton = (System.Windows.Forms.ToolStripButton)instance;
                            this.Add(ItmToolStripButton);
                            break;
                        case "System.Windows.Forms.TextBox":
                            System.Windows.Forms.TextBox itmTextBox = (System.Windows.Forms.TextBox)instance;
                            this.Add(itmTextBox);
                            break; 
                        case "System.Windows.Forms.Label":
                            System.Windows.Forms.Label itmLabel = (System.Windows.Forms.Label)instance;
                            this.Add(itmLabel);
                            break; 
                        case "System.Windows.Forms.ComboBox":
                            System.Windows.Forms.ComboBox itmComboBox = (System.Windows.Forms.ComboBox)instance;
                            this.Add(itmComboBox);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            System.Windows.Forms.CheckBox itmCheckBox = (System.Windows.Forms.CheckBox)instance;
                            this.Add(itmCheckBox);
                            break;
                        case "System.Windows.Forms.NumericUpDown":
                            System.Windows.Forms.NumericUpDown itmNumericUpDown = (System.Windows.Forms.NumericUpDown)instance;
                            this.Add(itmNumericUpDown);
                            break;
                        default:
                            // use late binding
                            // This would only come into play when command manager is extended
                            // to handle a new type outside the library

                            MethodInfo generic = this.AddMethodInfo.MakeGenericMethod(ObjType);
                            generic.Invoke(this, new object[] { instance });
                            
                            break;
                    }

                }

            }
            #endregion

            #endregion


            #region OnMethods
            /// <summary>
            /// Method is called when Insert of a control is complete
            /// </summary>
            /// <typeparam name="T">The Type of control that has been added</typeparam>
            /// <param name="Sender">The Object sender</param>
            /// <param name="value">The control that has been added</param>
            protected virtual void OnInsertComp<T>(object Sender, T value)
            {
                command.Manager.GetCommandExecutor(value).OnInstanceAdded(value, command);
            }

            /// <summary>
            /// Method is called when removal of a control is complete.
            /// </summary>
            /// <typeparam name="T">The Type of control that has been removed</typeparam>
            /// <param name="Sender">The object sender</param>
            /// <param name="value">The control that has been removed</param>
            protected virtual void OnRemoveComp<T>(object Sender, T value)
            {
                command.Manager.GetCommandExecutor(value).OnInstanceRemoved(value, command);
            }

            //OnInsertComplete
            /// <summary>
            ///Method is called when Insert of a control is complete
            /// </summary>
            /// <param name="Sender">The Object sender</param>
            /// <param name="value">The control that has been added</param>
            protected virtual void OnInsertComp(object Sender, object value)
            {
                Type oType = value.GetType();
                object Ce = command.Manager.GetCommandExecutor(oType.ToString());
                MethodInfo method = Ce.GetType().GetMethod("InstanceAdded");
                MethodInfo InstanceAddedMethod = method.MakeGenericMethod(oType);
                InstanceAddedMethod.Invoke(Ce, new object[] { value, command });
                //command.Manager.GetCommandExecutor(value.GetType().ToString()).InstanceAdded(value, command);
            }
            #endregion
        }
        #endregion
    }
    // Command
} // CommandManagement
