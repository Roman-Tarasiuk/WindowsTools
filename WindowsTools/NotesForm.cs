using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class NotesForm : Form
    {
        private bool m_MainMenuIsVisible = true;
        private bool m_BorderIsVisible = true;

        public NotesForm()
        {
            InitializeComponent();

            InitializeComponentsOther();
        }

        //
        // https://stackoverflow.com/questions/27561133/prevent-window-from-showing-in-alt-tab
        //
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }


        #region Event Handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleTopmost();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.WordWrap = !this.richTextBox1.WordWrap;
            wordWrapToolStripMenuItem.Checked = this.richTextBox1.WordWrap;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void pasteWithoutFormattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteWithoutFormatting();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void pasteWithoutFormattingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteWithoutFormatting();
        }

        private void pasteWithoutFormattingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PasteWithoutFormatting();
        }

        private void hideMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMainMenu();
        }

        private void selectionFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSelectionFont();
        }

        private void selectionColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionColor();
        }

        private void selectionBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionBackColor();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBackColor();
        }

        private void hideBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleBorder();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearNotes();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearNotes();
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClearNotes();
        }

        private void showInTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleShowInTaskbar();
        }

        private void showBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleBorder();
        }

        private void showMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMainMenu();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
            this.Cursor = Cursors.SizeAll;
        }

        private void topmostWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleTopmost();
        }

        private void showInTaskbarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleShowInTaskbar();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotesForm_Shown(object sender, EventArgs e)
        {
            this.panel1.Calibrate();

            ToggleBorder();
            ToggleMainMenu();
        }

        #endregion


        #region Helper Methods

        private void InitializeComponentsOther()
        {
            this.panel1 = new TransparentDraggablePanel(this);
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)
                System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 138);
            this.panel1.TabIndex = 2;
            this.panel1.MouseUp += (object sender, MouseEventArgs e) => {
                this.panel1.SendToBack();
                this.Cursor = Cursors.Default;
            };

            this.Controls.Add(this.panel1);
        }

        private void Paste()
        {
            richTextBox1.Paste();
        }

        private void PasteWithoutFormatting()
        {
            var txt = Clipboard.GetText();
            richTextBox1.SelectedText = txt;
        }

        private void ToggleMainMenu()
        {
            var currentEditorSize = richTextBox1.Size;
            var menuDefaultHeight = 27;

            if (m_MainMenuIsVisible)
            {
                menuStrip1.Hide();
                richTextBox1.Location = new Point(0, 0);
                panel1.Location = new Point(0, 0);
                this.Size = new Size(this.Size.Width, this.Size.Height - menuDefaultHeight);
                m_MainMenuIsVisible = false;
            }
            else
            {
                menuStrip1.Show();
                richTextBox1.Location = new Point(0, 27);
                panel1.Location = new Point(0, 27);
                this.Size = new Size(this.Size.Width, this.Size.Height + menuDefaultHeight);
                m_MainMenuIsVisible = true;
            }

            richTextBox1.Size = currentEditorSize;
            panel1.Size = currentEditorSize;

            hideMainMenuToolStripMenuItem.Checked = m_MainMenuIsVisible;
            showMainMenuToolStripMenuItem.Checked = m_MainMenuIsVisible;
        }

        private void SetSelectionFont()
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            var result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void SelectionColor()
        {
            var dlg = new ColorDialog();
            dlg.Color = this.richTextBox1.SelectionColor;

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.richTextBox1.SelectionColor = dlg.Color;
            }
        }

        private void SelectionBackColor()
        {
            var dlg = new ColorDialog();
            dlg.Color = this.richTextBox1.SelectionColor;

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.richTextBox1.SelectionBackColor = dlg.Color;
            }
        }

        private void SelectBackColor()
        {
            var dlg = new ColorDialog();
            dlg.Color = this.richTextBox1.BackColor;

            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.richTextBox1.BackColor = dlg.Color;
            }
        }

        private void ClearNotes()
        {
            this.richTextBox1.Clear();
        }

        private void ToggleBorder()
        {
            if (m_BorderIsVisible)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                m_BorderIsVisible = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                m_BorderIsVisible = true;
            }

            showBorderToolStripMenuItem.Checked = m_BorderIsVisible;
            hideBorderToolStripMenuItem.Checked = m_BorderIsVisible;
        }

        private void ToggleTopmost()
        {
            this.TopMost = !this.TopMost;
            this.topmostWindowToolStripMenuItem.Checked = this.TopMost;
            this.topmostWindowToolStripMenuItem1.Checked = this.TopMost;
        }

        private void ToggleShowInTaskbar()
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;
            showInTaskbarToolStripMenuItem.Checked = this.ShowInTaskbar;
            showInTaskbarToolStripMenuItem1.Checked = this.ShowInTaskbar;
        }

        #endregion
    }
}
