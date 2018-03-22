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
            this.TopMost = !this.TopMost;
            this.topmostWindowToolStripMenuItem.Checked = this.TopMost;
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

        private void hideBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_BorderIsVisible)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                hideBorderToolStripMenuItem.Checked = false;
                m_BorderIsVisible = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                hideBorderToolStripMenuItem.Checked = true;
                m_BorderIsVisible = true;
            }
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

        #endregion


        #region Helper Methods

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
                this.Size = new Size(this.Size.Width, this.Size.Height - menuDefaultHeight);
                richTextBox1.Size = currentEditorSize;
                hideMainMenuToolStripMenuItem.Checked = false;
                m_MainMenuIsVisible = false;
            }
            else
            {
                menuStrip1.Show();
                richTextBox1.Location = new Point(0, 27);
                this.Size = new Size(this.Size.Width, this.Size.Height + menuDefaultHeight);
                richTextBox1.Size = currentEditorSize;
                hideMainMenuToolStripMenuItem.Checked = true;
                m_MainMenuIsVisible = true;
            }
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

        private void ClearNotes()
        {
            this.richTextBox1.Clear();
        }

        #endregion
    }
}
