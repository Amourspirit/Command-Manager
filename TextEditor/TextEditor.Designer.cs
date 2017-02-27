namespace BigByte.TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_New = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewZoomDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTextBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTextItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTextUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTextStrikethrought = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFormatTextUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatTextLower = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mM_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_Customise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.tb_New = new System.Windows.Forms.ToolStripButton();
            this.tb_Open = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Cut = new System.Windows.Forms.ToolStripButton();
            this.tb_Copy = new System.Windows.Forms.ToolStripButton();
            this.tb_Paste = new System.Windows.Forms.ToolStripButton();
            this.tb_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tb_Italic = new System.Windows.Forms.ToolStripButton();
            this.tb_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.tb_Strike = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tb_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_UpperCase = new System.Windows.Forms.ToolStripButton();
            this.tb_LowerCase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tb_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_Font = new System.Windows.Forms.ToolStripComboBox();
            this.tb_FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_ZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDocument = new System.Windows.Forms.RichTextBox();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuTextBold = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuTextItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuTextUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuTextStrikethrough = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnuTextUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuTextLower = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.cMnuZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMnuZoomDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.openWork = new System.Windows.Forms.OpenFileDialog();
            this.saveWork = new System.Windows.Forms.SaveFileDialog();
            this.cmdMgr = new BigByteTechnologies.Library.Windows.CommandManagement.CommandManager();
            this.appIdle = new BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdle();
            this.mainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.Status.SuspendLayout();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mM_File,
            this.mM_Edit,
            this.mnuView,
            this.formatToolStripMenuItem,
            this.mM_Tools,
            this.mnuAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(746, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mM_File
            // 
            this.mM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_New,
            this.file_Open,
            this.toolStripSeparator11,
            this.file_Save,
            this.toolStripSeparator13,
            this.file_Exit});
            this.mM_File.Name = "mM_File";
            this.mM_File.Size = new System.Drawing.Size(37, 20);
            this.mM_File.Text = "&File";
            // 
            // file_New
            // 
            this.file_New.Image = ((System.Drawing.Image)(resources.GetObject("file_New.Image")));
            this.file_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_New.Name = "file_New";
            this.file_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.file_New.Size = new System.Drawing.Size(146, 22);
            this.file_New.Text = "&New";
            // 
            // file_Open
            // 
            this.file_Open.Image = ((System.Drawing.Image)(resources.GetObject("file_Open.Image")));
            this.file_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Open.Name = "file_Open";
            this.file_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_Open.Size = new System.Drawing.Size(146, 22);
            this.file_Open.Text = "&Open";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Save
            // 
            this.file_Save.Image = ((System.Drawing.Image)(resources.GetObject("file_Save.Image")));
            this.file_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_Save.Name = "file_Save";
            this.file_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_Save.Size = new System.Drawing.Size(146, 22);
            this.file_Save.Text = "&Save";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(143, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(146, 22);
            this.file_Exit.Text = "E&xit";
            this.file_Exit.Click += new System.EventHandler(this.file_Exit_Click);
            // 
            // mM_Edit
            // 
            this.mM_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo,
            this.mnuEditRedo,
            this.toolStripSeparator14,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.toolStripSeparator15,
            this.mnuEditSelectAll,
            this.mnuEditDelete});
            this.mM_Edit.Name = "mM_Edit";
            this.mM_Edit.Size = new System.Drawing.Size(39, 20);
            this.mM_Edit.Text = "&Edit";
            // 
            // mnuEditUndo
            // 
            this.mnuEditUndo.Image = global::BigByte.TextEditor.Properties.Resources.undo;
            this.mnuEditUndo.Name = "mnuEditUndo";
            this.mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuEditUndo.Size = new System.Drawing.Size(164, 22);
            this.mnuEditUndo.Text = "&Undo";
            // 
            // mnuEditRedo
            // 
            this.mnuEditRedo.Image = global::BigByte.TextEditor.Properties.Resources.redo;
            this.mnuEditRedo.Name = "mnuEditRedo";
            this.mnuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuEditRedo.Size = new System.Drawing.Size(164, 22);
            this.mnuEditRedo.Text = "&Redo";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Image = global::BigByte.TextEditor.Properties.Resources.cut;
            this.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuEditCut.Size = new System.Drawing.Size(164, 22);
            this.mnuEditCut.Text = "Cu&t";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Image = global::BigByte.TextEditor.Properties.Resources.copy;
            this.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEditCopy.Size = new System.Drawing.Size(164, 22);
            this.mnuEditCopy.Text = "&Copy";
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Image = global::BigByte.TextEditor.Properties.Resources.paste;
            this.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEditPaste.Size = new System.Drawing.Size(164, 22);
            this.mnuEditPaste.Text = "&Paste";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuEditSelectAll
            // 
            this.mnuEditSelectAll.Name = "mnuEditSelectAll";
            this.mnuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.mnuEditSelectAll.Text = "Select &All";
            // 
            // mnuEditDelete
            // 
            this.mnuEditDelete.Image = global::BigByte.TextEditor.Properties.Resources.delete;
            this.mnuEditDelete.Name = "mnuEditDelete";
            this.mnuEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuEditDelete.Size = new System.Drawing.Size(164, 22);
            this.mnuEditDelete.Text = "Delete";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewZoom});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            // 
            // mnuViewZoom
            // 
            this.mnuViewZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewZoomIn,
            this.mnuViewZoomOut,
            this.mnuViewZoomDefault});
            this.mnuViewZoom.Name = "mnuViewZoom";
            this.mnuViewZoom.Size = new System.Drawing.Size(106, 22);
            this.mnuViewZoom.Text = "&Zoom";
            // 
            // mnuViewZoomIn
            // 
            this.mnuViewZoomIn.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_In_16;
            this.mnuViewZoomIn.Name = "mnuViewZoomIn";
            this.mnuViewZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mnuViewZoomIn.Size = new System.Drawing.Size(300, 22);
            this.mnuViewZoomIn.Text = "Zoom &In";
            // 
            // mnuViewZoomOut
            // 
            this.mnuViewZoomOut.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_Out_16;
            this.mnuViewZoomOut.Name = "mnuViewZoomOut";
            this.mnuViewZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mnuViewZoomOut.Size = new System.Drawing.Size(300, 22);
            this.mnuViewZoomOut.Text = "Zoom &Out";
            // 
            // mnuViewZoomDefault
            // 
            this.mnuViewZoomDefault.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_To_Actual_Size_16;
            this.mnuViewZoomDefault.Name = "mnuViewZoomDefault";
            this.mnuViewZoomDefault.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemBackslash)));
            this.mnuViewZoomDefault.Size = new System.Drawing.Size(300, 22);
            this.mnuViewZoomDefault.Text = "&Restore Default Zoom";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.alignToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatTextBold,
            this.mnuFormatTextItalic,
            this.mnuFormatTextUnderline,
            this.mnuFormatTextStrikethrought,
            this.toolStripMenuItem4,
            this.mnuFormatTextUpper,
            this.mnuFormatTextLower});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.textToolStripMenuItem.Text = "Te&xt";
            // 
            // mnuFormatTextBold
            // 
            this.mnuFormatTextBold.Image = global::BigByte.TextEditor.Properties.Resources.font_bold;
            this.mnuFormatTextBold.Name = "mnuFormatTextBold";
            this.mnuFormatTextBold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuFormatTextBold.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextBold.Text = "&Bold";
            // 
            // mnuFormatTextItalic
            // 
            this.mnuFormatTextItalic.Image = global::BigByte.TextEditor.Properties.Resources.font_italic;
            this.mnuFormatTextItalic.Name = "mnuFormatTextItalic";
            this.mnuFormatTextItalic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuFormatTextItalic.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextItalic.Text = "&Italic";
            // 
            // mnuFormatTextUnderline
            // 
            this.mnuFormatTextUnderline.Image = global::BigByte.TextEditor.Properties.Resources.font_underline;
            this.mnuFormatTextUnderline.Name = "mnuFormatTextUnderline";
            this.mnuFormatTextUnderline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuFormatTextUnderline.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextUnderline.Text = "U&nderline";
            // 
            // mnuFormatTextStrikethrought
            // 
            this.mnuFormatTextStrikethrought.Image = global::BigByte.TextEditor.Properties.Resources.strikethrough;
            this.mnuFormatTextStrikethrought.Name = "mnuFormatTextStrikethrought";
            this.mnuFormatTextStrikethrought.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextStrikethrought.Text = "Strikethrou&gh";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuFormatTextUpper
            // 
            this.mnuFormatTextUpper.Image = global::BigByte.TextEditor.Properties.Resources.uppercase;
            this.mnuFormatTextUpper.Name = "mnuFormatTextUpper";
            this.mnuFormatTextUpper.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextUpper.Text = "&UPPERCASE";
            // 
            // mnuFormatTextLower
            // 
            this.mnuFormatTextLower.Image = global::BigByte.TextEditor.Properties.Resources.lowercase;
            this.mnuFormatTextLower.Name = "mnuFormatTextLower";
            this.mnuFormatTextLower.Size = new System.Drawing.Size(167, 22);
            this.mnuFormatTextLower.Text = "&lowercase";
            // 
            // alignToolStripMenuItem
            // 
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatAlignLeft,
            this.mnuFormatAlignCenter,
            this.mnuFormatAlignRight});
            this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            this.alignToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.alignToolStripMenuItem.Text = "Align&";
            // 
            // mnuFormatAlignLeft
            // 
            this.mnuFormatAlignLeft.Image = global::BigByte.TextEditor.Properties.Resources.text_align_left;
            this.mnuFormatAlignLeft.Name = "mnuFormatAlignLeft";
            this.mnuFormatAlignLeft.Size = new System.Drawing.Size(109, 22);
            this.mnuFormatAlignLeft.Text = "&Left";
            // 
            // mnuFormatAlignCenter
            // 
            this.mnuFormatAlignCenter.Image = global::BigByte.TextEditor.Properties.Resources.text_align_center;
            this.mnuFormatAlignCenter.Name = "mnuFormatAlignCenter";
            this.mnuFormatAlignCenter.Size = new System.Drawing.Size(109, 22);
            this.mnuFormatAlignCenter.Text = "&Center";
            // 
            // mnuFormatAlignRight
            // 
            this.mnuFormatAlignRight.Image = global::BigByte.TextEditor.Properties.Resources.text_align_right;
            this.mnuFormatAlignRight.Name = "mnuFormatAlignRight";
            this.mnuFormatAlignRight.Size = new System.Drawing.Size(109, 22);
            this.mnuFormatAlignRight.Text = "&Right";
            // 
            // mM_Tools
            // 
            this.mM_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_Customise});
            this.mM_Tools.Name = "mM_Tools";
            this.mM_Tools.Size = new System.Drawing.Size(48, 20);
            this.mM_Tools.Text = "&Tools";
            // 
            // tools_Customise
            // 
            this.tools_Customise.Name = "tools_Customise";
            this.tools_Customise.Size = new System.Drawing.Size(130, 22);
            this.tools_Customise.Text = "&Customize";
            this.tools_Customise.Click += new System.EventHandler(this.tools_Customise_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            // 
            // Tools
            // 
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_New,
            this.tb_Open,
            this.tb_Save,
            this.toolStripSeparator,
            this.tb_Cut,
            this.tb_Copy,
            this.tb_Paste,
            this.tb_Delete,
            this.toolStripSeparator1,
            this.tb_Bold,
            this.tb_Italic,
            this.tb_UnderLine,
            this.tb_Strike,
            this.toolStripSeparator3,
            this.tb_AlignLeft,
            this.tb_AlignCenter,
            this.tb_AlignRight,
            this.toolStripSeparator7,
            this.tb_UpperCase,
            this.tb_LowerCase,
            this.toolStripSeparator8,
            this.tb_ZoomIn,
            this.tb_ZoomOut,
            this.toolStripSeparator9,
            this.tb_Font,
            this.tb_FontSize,
            this.toolStripSeparator2});
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(746, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "toolStrip1";
            // 
            // tb_New
            // 
            this.tb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_New.Image = ((System.Drawing.Image)(resources.GetObject("tb_New.Image")));
            this.tb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_New.Name = "tb_New";
            this.tb_New.Size = new System.Drawing.Size(23, 22);
            this.tb_New.Text = "&New";
            // 
            // tb_Open
            // 
            this.tb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tb_Open.Image")));
            this.tb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(23, 22);
            this.tb_Open.Text = "&Open";
            // 
            // tb_Save
            // 
            this.tb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(23, 22);
            this.tb_Save.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Cut
            // 
            this.tb_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Cut.Image = global::BigByte.TextEditor.Properties.Resources.cut;
            this.tb_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Cut.Name = "tb_Cut";
            this.tb_Cut.Size = new System.Drawing.Size(23, 22);
            this.tb_Cut.Text = "C&ut";
            // 
            // tb_Copy
            // 
            this.tb_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Copy.Image = global::BigByte.TextEditor.Properties.Resources.copy;
            this.tb_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Copy.Name = "tb_Copy";
            this.tb_Copy.Size = new System.Drawing.Size(23, 22);
            this.tb_Copy.Text = "&Copy";
            // 
            // tb_Paste
            // 
            this.tb_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Paste.Image = global::BigByte.TextEditor.Properties.Resources.paste;
            this.tb_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Paste.Name = "tb_Paste";
            this.tb_Paste.Size = new System.Drawing.Size(23, 22);
            this.tb_Paste.Text = "&Paste";
            // 
            // tb_Delete
            // 
            this.tb_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_Delete.Image = global::BigByte.TextEditor.Properties.Resources.delete;
            this.tb_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.Size = new System.Drawing.Size(23, 22);
            this.tb_Delete.ToolTipText = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Bold
            // 
            this.tb_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bold.Image = global::BigByte.TextEditor.Properties.Resources.font_bold;
            this.tb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Bold.Name = "tb_Bold";
            this.tb_Bold.Size = new System.Drawing.Size(23, 22);
            this.tb_Bold.ToolTipText = "Bold";
            // 
            // tb_Italic
            // 
            this.tb_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Italic.Image = global::BigByte.TextEditor.Properties.Resources.font_italic;
            this.tb_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Italic.Name = "tb_Italic";
            this.tb_Italic.Size = new System.Drawing.Size(23, 22);
            this.tb_Italic.ToolTipText = "Italic";
            // 
            // tb_UnderLine
            // 
            this.tb_UnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UnderLine.Image = global::BigByte.TextEditor.Properties.Resources.font_underline;
            this.tb_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UnderLine.Name = "tb_UnderLine";
            this.tb_UnderLine.Size = new System.Drawing.Size(23, 22);
            this.tb_UnderLine.ToolTipText = "Underline";
            // 
            // tb_Strike
            // 
            this.tb_Strike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Strike.Image = global::BigByte.TextEditor.Properties.Resources.strikethrough;
            this.tb_Strike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Strike.Name = "tb_Strike";
            this.tb_Strike.Size = new System.Drawing.Size(23, 22);
            this.tb_Strike.ToolTipText = "Strikethrough";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_AlignLeft
            // 
            this.tb_AlignLeft.Image = global::BigByte.TextEditor.Properties.Resources.text_align_left;
            this.tb_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignLeft.Name = "tb_AlignLeft";
            this.tb_AlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignLeft.ToolTipText = "Align Left";
            // 
            // tb_AlignCenter
            // 
            this.tb_AlignCenter.Image = global::BigByte.TextEditor.Properties.Resources.text_align_center;
            this.tb_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignCenter.Name = "tb_AlignCenter";
            this.tb_AlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignCenter.ToolTipText = "Align Center";
            // 
            // tb_AlignRight
            // 
            this.tb_AlignRight.Image = global::BigByte.TextEditor.Properties.Resources.text_align_right;
            this.tb_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AlignRight.Name = "tb_AlignRight";
            this.tb_AlignRight.Size = new System.Drawing.Size(23, 22);
            this.tb_AlignRight.ToolTipText = "Align Right";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_UpperCase
            // 
            this.tb_UpperCase.Image = global::BigByte.TextEditor.Properties.Resources.uppercase;
            this.tb_UpperCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_UpperCase.Name = "tb_UpperCase";
            this.tb_UpperCase.Size = new System.Drawing.Size(23, 22);
            this.tb_UpperCase.ToolTipText = "Uppercase";
            // 
            // tb_LowerCase
            // 
            this.tb_LowerCase.Image = global::BigByte.TextEditor.Properties.Resources.lowercase;
            this.tb_LowerCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_LowerCase.Name = "tb_LowerCase";
            this.tb_LowerCase.Size = new System.Drawing.Size(23, 22);
            this.tb_LowerCase.ToolTipText = "Lowercase";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ZoomIn
            // 
            this.tb_ZoomIn.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_In_16;
            this.tb_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomIn.Name = "tb_ZoomIn";
            this.tb_ZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomIn.ToolTipText = "Zoom In";
            // 
            // tb_ZoomOut
            // 
            this.tb_ZoomOut.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_Out_16;
            this.tb_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_ZoomOut.Name = "tb_ZoomOut";
            this.tb_ZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tb_ZoomOut.ToolTipText = "Zoom Out";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_Font
            // 
            this.tb_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Font.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_Font.Name = "tb_Font";
            this.tb_Font.Size = new System.Drawing.Size(200, 25);
            this.tb_Font.SelectedIndexChanged += new System.EventHandler(this.tb_Font_SelectedIndexChanged);
            // 
            // tb_FontSize
            // 
            this.tb_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tb_FontSize.Name = "tb_FontSize";
            this.tb_FontSize.Size = new System.Drawing.Size(75, 25);
            this.tb_FontSize.SelectedIndexChanged += new System.EventHandler(this.tb_FontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charCount,
            this.toolStripStatusLabel2,
            this.status_ZoomFactor});
            this.Status.Location = new System.Drawing.Point(0, 413);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(746, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(63, 17);
            this.charCount.Text = "charCount";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(629, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // status_ZoomFactor
            // 
            this.status_ZoomFactor.Name = "status_ZoomFactor";
            this.status_ZoomFactor.Size = new System.Drawing.Size(39, 17);
            this.status_ZoomFactor.Text = "Zoom";
            // 
            // txtDocument
            // 
            this.txtDocument.ContextMenuStrip = this.rcMenu;
            this.txtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocument.Location = new System.Drawing.Point(0, 49);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(746, 364);
            this.txtDocument.TabIndex = 3;
            this.txtDocument.Text = "";
            this.txtDocument.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Document_LinkClicked);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuEditUndo,
            this.cMnuEditRedo,
            this.toolStripSeparator10,
            this.cMnuEditCut,
            this.cMnuEditCopy,
            this.cMnuEditPaste,
            this.toolStripMenuItem1,
            this.cMnuEditSelectAll,
            this.toolStripMenuItem2,
            this.cMnuEditDelete,
            this.toolStripMenuItem3,
            this.textToolStripMenuItem1,
            this.alignToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.cMnuZoom});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(123, 254);
            // 
            // cMnuEditUndo
            // 
            this.cMnuEditUndo.Image = global::BigByte.TextEditor.Properties.Resources.undo;
            this.cMnuEditUndo.Name = "cMnuEditUndo";
            this.cMnuEditUndo.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditUndo.Text = "Undo";
            // 
            // cMnuEditRedo
            // 
            this.cMnuEditRedo.Image = global::BigByte.TextEditor.Properties.Resources.redo;
            this.cMnuEditRedo.Name = "cMnuEditRedo";
            this.cMnuEditRedo.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditRedo.Text = "Redo";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(119, 6);
            // 
            // cMnuEditCut
            // 
            this.cMnuEditCut.Image = global::BigByte.TextEditor.Properties.Resources.cut;
            this.cMnuEditCut.Name = "cMnuEditCut";
            this.cMnuEditCut.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditCut.Text = "Cut";
            // 
            // cMnuEditCopy
            // 
            this.cMnuEditCopy.Image = global::BigByte.TextEditor.Properties.Resources.copy;
            this.cMnuEditCopy.Name = "cMnuEditCopy";
            this.cMnuEditCopy.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditCopy.Text = "Copy";
            // 
            // cMnuEditPaste
            // 
            this.cMnuEditPaste.Image = global::BigByte.TextEditor.Properties.Resources.paste;
            this.cMnuEditPaste.Name = "cMnuEditPaste";
            this.cMnuEditPaste.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditPaste.Text = "Paste";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // cMnuEditSelectAll
            // 
            this.cMnuEditSelectAll.Name = "cMnuEditSelectAll";
            this.cMnuEditSelectAll.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditSelectAll.Text = "Select All";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // cMnuEditDelete
            // 
            this.cMnuEditDelete.Image = global::BigByte.TextEditor.Properties.Resources.delete;
            this.cMnuEditDelete.Name = "cMnuEditDelete";
            this.cMnuEditDelete.Size = new System.Drawing.Size(122, 22);
            this.cMnuEditDelete.Text = "Delete";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuTextBold,
            this.cMnuTextItalic,
            this.cMnuTextUnderline,
            this.cMnuTextStrikethrough,
            this.toolStripMenuItem5,
            this.cMnuTextUpper,
            this.cMnuTextLower});
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.textToolStripMenuItem1.Text = "Text";
            // 
            // cMnuTextBold
            // 
            this.cMnuTextBold.Image = global::BigByte.TextEditor.Properties.Resources.font_bold;
            this.cMnuTextBold.Name = "cMnuTextBold";
            this.cMnuTextBold.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextBold.Text = "Bold";
            // 
            // cMnuTextItalic
            // 
            this.cMnuTextItalic.Image = global::BigByte.TextEditor.Properties.Resources.font_italic;
            this.cMnuTextItalic.Name = "cMnuTextItalic";
            this.cMnuTextItalic.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextItalic.Text = "Italic";
            // 
            // cMnuTextUnderline
            // 
            this.cMnuTextUnderline.Image = global::BigByte.TextEditor.Properties.Resources.font_underline;
            this.cMnuTextUnderline.Name = "cMnuTextUnderline";
            this.cMnuTextUnderline.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextUnderline.Text = "Underline";
            // 
            // cMnuTextStrikethrough
            // 
            this.cMnuTextStrikethrough.Image = global::BigByte.TextEditor.Properties.Resources.strikethrough;
            this.cMnuTextStrikethrough.Name = "cMnuTextStrikethrough";
            this.cMnuTextStrikethrough.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextStrikethrough.Text = "Strikethrough";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(143, 6);
            // 
            // cMnuTextUpper
            // 
            this.cMnuTextUpper.Image = global::BigByte.TextEditor.Properties.Resources.uppercase;
            this.cMnuTextUpper.Name = "cMnuTextUpper";
            this.cMnuTextUpper.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextUpper.Text = "UPPERCASE";
            // 
            // cMnuTextLower
            // 
            this.cMnuTextLower.Image = global::BigByte.TextEditor.Properties.Resources.lowercase;
            this.cMnuTextLower.Name = "cMnuTextLower";
            this.cMnuTextLower.Size = new System.Drawing.Size(146, 22);
            this.cMnuTextLower.Text = "lowercase";
            // 
            // alignToolStripMenuItem1
            // 
            this.alignToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuAlignLeft,
            this.cMnuAlignCenter,
            this.cMnuAlignRight});
            this.alignToolStripMenuItem1.Name = "alignToolStripMenuItem1";
            this.alignToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.alignToolStripMenuItem1.Text = "Align";
            // 
            // cMnuAlignLeft
            // 
            this.cMnuAlignLeft.Image = global::BigByte.TextEditor.Properties.Resources.text_align_left;
            this.cMnuAlignLeft.Name = "cMnuAlignLeft";
            this.cMnuAlignLeft.Size = new System.Drawing.Size(109, 22);
            this.cMnuAlignLeft.Text = "Left";
            // 
            // cMnuAlignCenter
            // 
            this.cMnuAlignCenter.Image = global::BigByte.TextEditor.Properties.Resources.text_align_center;
            this.cMnuAlignCenter.Name = "cMnuAlignCenter";
            this.cMnuAlignCenter.Size = new System.Drawing.Size(109, 22);
            this.cMnuAlignCenter.Text = "Center";
            // 
            // cMnuAlignRight
            // 
            this.cMnuAlignRight.Image = global::BigByte.TextEditor.Properties.Resources.text_align_right;
            this.cMnuAlignRight.Name = "cMnuAlignRight";
            this.cMnuAlignRight.Size = new System.Drawing.Size(109, 22);
            this.cMnuAlignRight.Text = "Right";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(119, 6);
            // 
            // cMnuZoom
            // 
            this.cMnuZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuZoomIn,
            this.cMnuZoomOut,
            this.cMnuZoomDefault});
            this.cMnuZoom.Name = "cMnuZoom";
            this.cMnuZoom.Size = new System.Drawing.Size(122, 22);
            this.cMnuZoom.Text = "Zoom";
            // 
            // cMnuZoomIn
            // 
            this.cMnuZoomIn.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_In_16;
            this.cMnuZoomIn.Name = "cMnuZoomIn";
            this.cMnuZoomIn.Size = new System.Drawing.Size(189, 22);
            this.cMnuZoomIn.Text = "Zoom In";
            // 
            // cMnuZoomOut
            // 
            this.cMnuZoomOut.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_Out_16;
            this.cMnuZoomOut.Name = "cMnuZoomOut";
            this.cMnuZoomOut.Size = new System.Drawing.Size(189, 22);
            this.cMnuZoomOut.Text = "Zoom Out";
            // 
            // cMnuZoomDefault
            // 
            this.cMnuZoomDefault.Image = global::BigByte.TextEditor.Properties.Resources.Zoom_To_Actual_Size_16;
            this.cMnuZoomDefault.Name = "cMnuZoomDefault";
            this.cMnuZoomDefault.Size = new System.Drawing.Size(189, 22);
            this.cMnuZoomDefault.Text = "Restore Default Zoom";
            // 
            // openWork
            // 
            this.openWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.openWork.Title = "Open Work";
            // 
            // saveWork
            // 
            this.saveWork.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveWork.Title = "Save Work";
            // 
            // cmdMgr
            // 
            this.cmdMgr.IdleAction = BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData.Behavior.None;
            this.cmdMgr.IdleTime = System.TimeSpan.Parse("00:00:01");
            this.cmdMgr.TickInterval = System.TimeSpan.Parse("00:00:01");
            this.cmdMgr.WarnSetting = BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData.WarnSettings.Off;
            this.cmdMgr.WarnTime = System.TimeSpan.Parse("00:00:01");
            // 
            // appIdle
            // 
            this.appIdle.IdleAction = BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData.Behavior.ReStart;
            this.appIdle.IdleTime = System.TimeSpan.Parse("00:00:01");
            this.appIdle.WarnSetting = BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdleData.WarnSettings.Off;
            this.appIdle.WarnTime = System.TimeSpan.Parse("00:00:01");
            this.appIdle.Idle += new System.EventHandler(this.appIdle_Idle);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 435);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(762, 473);
            this.Name = "TextEditor";
            this.ShowIcon = false;
            this.Text = "Command TextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton tb_New;
        private System.Windows.Forms.ToolStripButton tb_Open;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tb_Cut;
        private System.Windows.Forms.ToolStripButton tb_Copy;
        private System.Windows.Forms.ToolStripButton tb_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tb_Font;
        private System.Windows.Forms.ToolStripComboBox tb_FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_Bold;
        private System.Windows.Forms.ToolStripButton tb_Strike;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status_ZoomFactor;
        private System.Windows.Forms.RichTextBox txtDocument;
        private System.Windows.Forms.ToolStripButton tb_Italic;
        private System.Windows.Forms.ToolStripButton tb_UnderLine;
        private System.Windows.Forms.ToolStripButton tb_AlignLeft;
        private System.Windows.Forms.ToolStripButton tb_AlignCenter;
        private System.Windows.Forms.ToolStripButton tb_AlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tb_UpperCase;
        private System.Windows.Forms.ToolStripButton tb_LowerCase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tb_ZoomIn;
        private System.Windows.Forms.ToolStripButton tb_ZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mM_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mM_Tools;
        private System.Windows.Forms.ToolStripMenuItem tools_Customise;
        private System.Windows.Forms.ToolStripMenuItem mM_File;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.OpenFileDialog openWork;
        private System.Windows.Forms.SaveFileDialog saveWork;
        private BigByteTechnologies.Library.Windows.CommandManagement.CommandManager cmdMgr;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
        private System.Windows.Forms.ToolStripButton tb_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cMnuEditDelete;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextBold;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextUnderline;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextStrikethrought;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextBold;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextItalic;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextUnderline;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextStrikethrough;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cMnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem cMnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem cMnuAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextUpper;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatTextLower;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextUpper;
        private System.Windows.Forms.ToolStripMenuItem cMnuTextLower;
        private BigByteTechnologies.Library.Windows.CommandManagement.ApplicationIdle appIdle;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewZoom;
        private System.Windows.Forms.ToolStripMenuItem mnuViewZoomIn;
        private System.Windows.Forms.ToolStripMenuItem mnuViewZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem cMnuZoom;
        private System.Windows.Forms.ToolStripMenuItem cMnuZoomIn;
        private System.Windows.Forms.ToolStripMenuItem cMnuZoomOut;
        private System.Windows.Forms.ToolStripMenuItem mnuViewZoomDefault;
        private System.Windows.Forms.ToolStripMenuItem cMnuZoomDefault;
    }
}

