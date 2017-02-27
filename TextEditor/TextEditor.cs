using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BigByteTechnologies.Library.Windows.CommandManagement;

namespace BigByte.TextEditor
{
    public partial class TextEditor : Form
    {
        #region Commands
        #region Command Events
        private void CommandPreProcess(object sender, CancelEventArgs e)
        {
            // use pre process event to trigger setting of value only once per idle event
            this.m_IsClipboardText = null;
        }

        #endregion

        #region Command Management Init
        private void InitializeCommandManager()
        {
            // set up an event the fires before any of the commands fire in case we need them later
            cmdMgr.PreCommandProcess += CommandPreProcess;
            Command.UpdateHandler NullUpDateHandler = new Command.UpdateHandler(CmdNullHandler);

            #region About
            cmdMgr.Commands.Add(new Command("CmdAbout", new Command.ExecuteHandler(CmdAbout), NullUpDateHandler));
            cmdMgr.Commands["CmdAbout"].CommandInstances.Add(mnuAbout);
            #endregion

            #region Open / Save / new
            cmdMgr.Commands.Add(new Command("CmdOpen", new Command.ExecuteHandler(CmdOpen), NullUpDateHandler));
            cmdMgr.Commands["CmdOpen"].CommandInstances.AddRange(tb_Open, file_Open);

            cmdMgr.Commands.Add(new Command("CmdSave", new Command.ExecuteHandler(CmdSave), NullUpDateHandler));
            cmdMgr.Commands["CmdSave"].CommandInstances.AddRange(tb_Save, file_Save);

            cmdMgr.Commands.Add(new Command("CmdNew", new Command.ExecuteHandler(CmdNew), NullUpDateHandler));
            cmdMgr.Commands["CmdNew"].CommandInstances.AddRange(tb_New, file_New);
            #endregion

            #region Cut / copy / Paste / Select / Delete/ Undo/ Redo

            cmdMgr.Commands.Add(new Command("CmdEditCopy", new Command.ExecuteHandler(CmdEditCopy), new Command.UpdateHandler(CmdEditCopyHandler)));
            cmdMgr.Commands["CmdEditCopy"].CommandInstances.AddRange(mnuEditCopy, cMnuEditCopy,tb_Copy);

            cmdMgr.Commands.Add(new Command("CmdMainCut", new Command.ExecuteHandler(CmdEditCut), new Command.UpdateHandler(CmdEditCutHandler)));
            cmdMgr.Commands["CmdMainCut"].CommandInstances.AddRange( mnuEditCut, cMnuEditCut, tb_Cut);

            cmdMgr.Commands.Add(new Command("CmdMainPaste", new Command.ExecuteHandler(CmdEditPaste), new Command.UpdateHandler(CmdEditPasteHandler)));
            cmdMgr.Commands["CmdMainPaste"].CommandInstances.Add(mnuEditPaste);
            cmdMgr.Commands["CmdMainPaste"].CommandInstances.Add(cMnuEditPaste);
            cmdMgr.Commands["CmdMainPaste"].CommandInstances.Add(tb_Paste);

            cmdMgr.Commands.Add(new Command("CmdMainSelectAll", new Command.ExecuteHandler(CmdEditSelect), new Command.UpdateHandler(CmdEditSelectHandler)));
            cmdMgr.Commands["CmdMainSelectAll"].CommandInstances.Add(mnuEditSelectAll);
            cmdMgr.Commands["CmdMainSelectAll"].CommandInstances.Add(cMnuEditSelectAll);

            cmdMgr.Commands.Add(new Command("CmdMainDelete", new Command.ExecuteHandler(CmdEditDelete), new Command.UpdateHandler(CmdEditCopyHandler)));
            cmdMgr.Commands["CmdMainDelete"].CommandInstances.Add(mnuEditDelete);
            cmdMgr.Commands["CmdMainDelete"].CommandInstances.Add(cMnuEditDelete);
            cmdMgr.Commands["CmdMainDelete"].CommandInstances.Add(tb_Delete);

            cmdMgr.Commands.Add(new Command("CmdMainUndo", new Command.ExecuteHandler(CmdEditUndo), new Command.UpdateHandler(CmdEditUndoHandler)));
            cmdMgr.Commands["CmdMainUndo"].CommandInstances.Add(mnuEditUndo);
            cmdMgr.Commands["CmdMainUndo"].CommandInstances.Add(cMnuEditUndo);

            cmdMgr.Commands.Add(new Command("CmdMainRedo", new Command.ExecuteHandler(CmdEditRedo), new Command.UpdateHandler(CmdEditRedoHandler)));
            cmdMgr.Commands["CmdMainUndo"].CommandInstances.Add(mnuEditRedo);
            cmdMgr.Commands["CmdMainUndo"].CommandInstances.Add(cMnuEditRedo);
            #endregion

            #region Bold / Italics / Underline / StrikeThrough
            cmdMgr.Commands.Add(new Command("CmdBold", new Command.ExecuteHandler(CmdBold), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdBold"].CommandInstances.AddRange(tb_Bold, mnuFormatTextBold, cMnuTextBold);

            cmdMgr.Commands.Add(new Command("CmdItalics", new Command.ExecuteHandler(CmdItalics), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdItalics"].CommandInstances.AddRange(tb_Italic, mnuFormatTextItalic, cMnuTextItalic);

            cmdMgr.Commands.Add(new Command("CmdUnderline", new Command.ExecuteHandler(CmdUnderline), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdUnderline"].CommandInstances.AddRange(tb_UnderLine, mnuFormatTextUnderline, cMnuTextUnderline);

            cmdMgr.Commands.Add(new Command("CmdStrikeThrough", new Command.ExecuteHandler(CmdStrikeThrought), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdStrikeThrough"].CommandInstances.AddRange(tb_Strike, mnuFormatTextStrikethrought, cMnuTextStrikethrough);
            #endregion

            #region Alignment
            cmdMgr.Commands.Add(new Command("CmdAlignLeft", new Command.ExecuteHandler(CmdAlignLeft), NullUpDateHandler));
            cmdMgr.Commands["CmdAlignLeft"].CommandInstances.AddRange(tb_AlignLeft, mnuFormatAlignLeft,cMnuAlignLeft);

            cmdMgr.Commands.Add(new Command("CmdAlignCenter", new Command.ExecuteHandler(CmdAlignCenter), NullUpDateHandler));
            cmdMgr.Commands["CmdAlignCenter"].CommandInstances.AddRange(tb_AlignCenter, mnuFormatAlignCenter, cMnuAlignCenter);

            cmdMgr.Commands.Add(new Command("CmdAlignRight", new Command.ExecuteHandler(CmdAlignRight), NullUpDateHandler));
            cmdMgr.Commands["CmdAlignRight"].CommandInstances.AddRange(tb_AlignRight, mnuFormatAlignRight, cMnuAlignRight);
            #endregion

            #region lowercase / uppercase
            cmdMgr.Commands.Add(new Command("CmdUpperCase", new Command.ExecuteHandler(CmdUpperCase), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdUpperCase"].CommandInstances.AddRange(tb_UpperCase, mnuFormatTextUpper, cMnuTextUpper);

            cmdMgr.Commands.Add(new Command("CmdLowerCase", new Command.ExecuteHandler(CmdLowerCase), new Command.UpdateHandler(CmdSelectedHandler)));
            cmdMgr.Commands["CmdLowerCase"].CommandInstances.AddRange(tb_LowerCase, mnuFormatTextLower, cMnuTextLower);
            #endregion

            #region Zoom
            cmdMgr.Commands.Add(new Command("CmdZoomIn", new Command.ExecuteHandler(CmdZoomIn), new Command.UpdateHandler(CmdZoomInHandler)));
            cmdMgr.Commands["CmdZoomIn"].CommandInstances.AddRange(tb_ZoomIn, mnuViewZoomIn, cMnuZoomIn);

            cmdMgr.Commands.Add(new Command("CmdZoomOut", new Command.ExecuteHandler(CmdZoomOut), new Command.UpdateHandler(CmdZoomOutHandler)));
            cmdMgr.Commands["CmdZoomOut"].CommandInstances.AddRange(tb_ZoomOut, mnuViewZoomOut, cMnuZoomOut);

            cmdMgr.Commands.Add(new Command("CmdZoomDefault", new Command.ExecuteHandler(CmdZoomDefault), new Command.UpdateHandler(CmdZoomDefaultHandler)));
            cmdMgr.Commands["CmdZoomDefault"].CommandInstances.AddRange( mnuViewZoomDefault, cMnuZoomDefault);
            #endregion

        }
        #endregion

        #region Command Handlers
        #region Cut / Copy / Paste / Select / Delete/ Undo / Redo / Handlers
        private void CmdEditUndoHandler(Command Cmd)
        {
            Cmd.Enabled = (this.txtDocument.Enabled
                && this.txtDocument.CanUndo);
        }
        private void CmdEditRedoHandler(Command Cmd)
        {
            Cmd.Enabled = (this.txtDocument.Enabled
                && this.txtDocument.CanRedo);
        }
        private void CmdEditCutHandler(Command Cmd)
        {
            Cmd.Enabled = (this.txtDocument.Enabled
                && this.txtDocument.SelectionLength > 0);
        }

        private void CmdEditCopyHandler(Command Cmd)
        {
            Cmd.Enabled = (this.txtDocument.SelectionLength > 0);
        }

        private void CmdEditSelectHandler(Command Cmd)
        {
            if (this.txtDocument.CanSelect == false)
            {
                Cmd.Enabled = false;
                return;
            }
            bool b = this.txtDocument.Text.Length > 0;
            if (this.txtDocument.Text.Length > 0)
            {
                b &= this.txtDocument.SelectedText.Length < this.txtDocument.Text.Length;
            }
            Cmd.Enabled = b;
        }

        private void CmdEditPasteHandler(Command Cmd)
        {
            Cmd.Enabled = (this.IsClipboardText == true);
        }
        #endregion

        #region Bold / Italics / Underline / StrikeThrough / Handlers
        private void CmdSelectedHandler(Command Cmd)
        {
            Cmd.Enabled = txtDocument.SelectedText.Length > 0;
        }
        #endregion

        #region Other Command Handlers
        private void CmdNullHandler(Command Cmd)
        {
            // do nothing 
        }
        #endregion

        #region Zoom Handlers
        private void CmdZoomInHandler(Command Cmd)
        {
            Cmd.Enabled = txtDocument.ZoomFactor < 63;
        }

        private void CmdZoomOutHandler(Command Cmd)
        {
            Cmd.Enabled = txtDocument.ZoomFactor > 1;
        }
        private void CmdZoomDefaultHandler(Command Cmd)
        {
            Cmd.Enabled = txtDocument.ZoomFactor != 1;
        }
        #endregion
        #endregion

        #region Command Methods

        #region Open / Save / New
        private void CmdOpen(Command Cmd)
        {
            this.Open();
        }
        private void CmdSave(Command Cmd)
        {
            this.Save();
        }
        private void CmdNew(Command Cmd)
        {
            txtDocument.Clear();
        }
        #endregion

        #region Cut / Copy / Paste / Select / Delete / Undo / Redo / Methods
        private void CmdEditCopy(Command Cmd)
        {
            Clipboard.SetText(this.txtDocument.SelectedText);
        }

        private void CmdEditCut(Command Cmd)
        {
            Clipboard.SetText(txtDocument.SelectedText);
            txtDocument.SelectedText = string.Empty;
        }

        private void CmdEditPaste(Command Cmd)
        {
            txtDocument.Paste();
        }

        private void CmdEditSelect(Command Cmd)
        {
            txtDocument.SelectAll();
        }

        private void CmdEditDelete(Command Cmd)
        {
            txtDocument.SelectedText = "";
        }

        private void CmdEditUndo(Command Cmd)
        {
            txtDocument.Undo();
        }

        private void CmdEditRedo(Command Cmd)
        {
            txtDocument.Redo();
        }

        #endregion

        #region Bold / Italics / Underline / Strikethrough
        private void CmdBold(Command Cmd)
        {
            Font bfont = new Font(txtDocument.Font, FontStyle.Bold);
            Font rfont = new Font(txtDocument.Font, FontStyle.Regular);

            if (txtDocument.SelectedText.Length == 0)
                return;
            if (txtDocument.SelectionFont.Bold)
            {
                txtDocument.SelectionFont = rfont;
            }
            else
            {
                txtDocument.SelectionFont = bfont;
            }
        }

        private void CmdItalics(Command Cmd)
        {
            Font Ifont = new Font(txtDocument.Font, FontStyle.Italic);
            Font rfont = new Font(txtDocument.Font, FontStyle.Regular);

            if (txtDocument.SelectedText.Length == 0)
                return;
            if (txtDocument.SelectionFont.Italic)
            {
                txtDocument.SelectionFont = rfont;
            }
            else
            {
                txtDocument.SelectionFont = Ifont;
            }
        }

        private void CmdUnderline(Command Cmd)
        {
            Font Ufont = new Font(txtDocument.Font, FontStyle.Underline);
            Font rfont = new Font(txtDocument.Font, FontStyle.Regular);

            if (txtDocument.SelectedText.Length == 0)
                return;
            if (txtDocument.SelectionFont.Underline)
            {
                txtDocument.SelectionFont = rfont;
            }
            else
            {
                txtDocument.SelectionFont = Ufont;
            }
        }

        private void CmdStrikeThrought(Command Cmd)
        {
            Font Sfont = new Font(txtDocument.Font, FontStyle.Strikeout);
            Font rfont = new Font(txtDocument.Font, FontStyle.Regular);


            if (txtDocument.SelectedText.Length == 0)
                return;
            if (txtDocument.SelectionFont.Strikeout)
            {
                txtDocument.SelectionFont = rfont;
            }
            else
            {
                txtDocument.SelectionFont = Sfont;
            }
        }
        #endregion

        #region Alignment
        private void CmdAlignLeft(Command Cmd)
        {
            txtDocument.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void CmdAlignCenter(Command Cmd)
        {
            txtDocument.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void CmdAlignRight(Command Cmd)
        {
            txtDocument.SelectionAlignment = HorizontalAlignment.Right;
        }
        #endregion

        #region Lowercase / Uppercase
        private void CmdUpperCase(Command Cmd)
        {
            txtDocument.SelectedText = txtDocument.SelectedText.ToUpper();
        }

        private void CmdLowerCase(Command Cmd)
        {
            txtDocument.SelectedText = txtDocument.SelectedText.ToLower();
        }
        #endregion

        #region Zoom
        private void CmdZoomIn(Command Cmd)
        {
            if (txtDocument.ZoomFactor == 63)
            {
                return;
            }
            else
                txtDocument.ZoomFactor = txtDocument.ZoomFactor + 1;
        }

        private void CmdZoomOut(Command Cmd)
        {
            if (txtDocument.ZoomFactor == 1)
            {
                return;
            }
            else
                txtDocument.ZoomFactor = txtDocument.ZoomFactor - 1;
        }

        private void CmdZoomDefault(Command Cmd)
        {
            txtDocument.ZoomFactor = 1;
        }
        #endregion

        #region About
        private void CmdAbout(Command Cmd)
        {
            var frm = new About();
            frm.ShowDialog(this);
        }
        #endregion

        #endregion
        #endregion

        #region Constructor
        public TextEditor()
        {
            InitializeComponent();
            InitializeCommandManager();
            appIdle.Start();
        }

        #endregion

        #region Properties
        private bool? m_IsClipboardText = null;
        /// <summary>
        /// Gets if the Clipboard contains text
        /// </summary>
        /// <remarks>
        /// This property is reset on each CommandPrePorcess event
        /// </remarks>
        private bool IsClipboardText
        {
            get
            {
                if (m_IsClipboardText == null)
                {
                    if (Clipboard.GetDataObject().GetDataPresent(typeof(string)) == true)
                    {
                        m_IsClipboardText = true;
                    }
                    else
                    {
                        m_IsClipboardText = false;
                    }
                }
                return m_IsClipboardText == true;
            }
        }
        #endregion

        #region MainMenu

        //FILE
       
        private void file_Exit_Click(object sender, EventArgs e)
        {
            Exit();
        }


        // EDIT MENU
      
        //TOOLS MENU

        private void tools_Customise_Click(object sender, EventArgs e)
        {
            customise();
        }

        #endregion

        #region Toolbar

        private void tb_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Font ComboFonts = null;

            try
            {
                ComboFonts = txtDocument.SelectionFont;
                Font fnt = new System.Drawing.Font(tb_Font.Text, txtDocument.SelectionFont.Size, txtDocument.SelectionFont.Style);
                if (txtDocument.SelectionLength > 0)
                {
                    txtDocument.SelectionFont = fnt;
                }
               // txtDocument.Font = fnt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtDocument.SelectionFont = new Font(tb_FontSize.SelectedItem.ToString(), int.Parse(tb_FontSize.SelectedItem.ToString()), txtDocument.SelectionFont.Style);
        }

        #endregion

        #region Methods

        #region file

        void Open()
        {
            if (openWork.ShowDialog() == DialogResult.OK)
            {
                txtDocument.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        void Save()
        {

            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    txtDocument.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Exit()
        {
            Application.Exit();
        }
        #endregion

        #region tools

        void customise()
        {
            ColorDialog myDialog = new ColorDialog();
            if (myDialog.ShowDialog() == DialogResult.OK)
            {

                mainMenu.BackColor = myDialog.Color;
                Status.BackColor = myDialog.Color;
                Tools.BackColor = myDialog.Color;
            }

        }


        #endregion

        #endregion

        #region Font related

        void FontSize()
        {

            for (int fntSize = 10; fntSize <= 75; fntSize++)
            {
                tb_FontSize.Items.Add(fntSize.ToString());
            }
            if (Properties.Settings.Default.FontSizeIndex < tb_FontSize.Items.Count)
            {
                tb_FontSize.SelectedIndex = Properties.Settings.Default.FontSizeIndex;
            }

        }

        void InstalledFonts()
        {

            InstalledFontCollection fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
            {
                tb_Font.Items.Add(fonts.Families[i].Name);
            }

            if (Properties.Settings.Default.FontIndex >= 0 && Properties.Settings.Default.FontIndex < tb_Font.Items.Count)
            {
                tb_Font.SelectedIndex = Properties.Settings.Default.FontIndex;
                Font fnt = new System.Drawing.Font(tb_Font.Text, txtDocument.SelectionFont.Size, txtDocument.SelectionFont.Style);
                txtDocument.Font = fnt;
            }
        }
        #endregion

        #region Events

        #region Form Events
        private void TextEditor_Load(object sender, EventArgs e)
        {
            FontSize();
            InstalledFonts();
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tb_FontSize.SelectedItem != null)
            {
                Properties.Settings.Default.FontSizeIndex = tb_FontSize.SelectedIndex;
            }
            else
            {
                Properties.Settings.Default.FontSizeIndex = 0;
            }
            if (tb_Font.SelectedItem != null)
            {
                Properties.Settings.Default.FontIndex = tb_Font.SelectedIndex;
            }
            else
            {
                Properties.Settings.Default.FontIndex = -1;
            }
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Application Idle Event
        private void appIdle_Idle(object sender, EventArgs e)
        {
            charCount.Text = "Characters in the current document: " + txtDocument.TextLength.ToString();

            status_ZoomFactor.Text = txtDocument.ZoomFactor.ToString();
        }
        #endregion

        #region Editor Link Click Event

        private void Document_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }



        #endregion
        #endregion
    }

}   
