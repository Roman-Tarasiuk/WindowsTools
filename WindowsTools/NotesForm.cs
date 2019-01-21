using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class NotesForm : Form
    {
        private bool m_MainMenuIsVisible = true;
        private bool m_BorderIsVisible = true;
        private int m_BorderOffsetX = 0;
        private int m_BorderOffsetY = 0;
        private Form m_HostForm;

        public NotesForm(Form hostForm = null)
        {
            InitializeComponent();

            m_HostForm = hostForm;
            InitializeComponentsOther();
            BackgroundColorToolStripMenuItemColor(Color.White);
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


        #region Public methods

        public void ToggleTopmost(bool topmost)
        {
            this.TopMost = topmost;
            this.topmostWindowToolStripMenuItem.Checked = this.TopMost;
            this.topmostWindowToolStripMenuItem1.Checked = this.TopMost;
        }

        #endregion


        #region Event Handlers

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.Focus();
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string text = richTextBox1.SelectedText;
            var strA = Regex.Match(text, @"\w+");
            var length = strA.Value.Length;
            char c;
            while ( (richTextBox1.SelectionStart + length < richTextBox1.Text.Length) &&
                (c = richTextBox1.Text[richTextBox1.SelectionStart + length]) != ' '
                && c != '\t'
                && c != '\n'
                && c != ','
                && c != '.')
            {
                length++;
            }
            
            richTextBox1.Select(richTextBox1.SelectionStart, length);
        }

        private void richtextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    ToggleBorder(false);
                    ToggleMainMenu(false);
                    break;
                case Keys.N:
                    if (e.Control && m_HostForm != null)
                    {
                        ((MainForm)m_HostForm).RunNotes();
                    }
                    break;
                case Keys.F4:
                case Keys.W:
                    if (e.Control)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void richTextBox1_SelectionChanged(Object sender, EventArgs e)
        {
            this.copyToolStripMenuItem.Enabled = this.richTextBox1.SelectedText.Length > 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleTopmost(!this.TopMost);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordWrap();
        }

        private void wordWrapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WordWrap();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
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

        private void toggleMainMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleMainMenu(!m_MainMenuIsVisible);
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

        private void toggleBorderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleBorder(!m_BorderIsVisible);
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

        private void toggleBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleBorder(!m_BorderIsVisible);
        }

        private void toggleMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMainMenu(!m_MainMenuIsVisible);
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
            this.Cursor = Cursors.SizeAll;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var host = m_HostForm as MainForm;
            if (host != null)
            {
                host.MinimizeNotes();
            }
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var host = m_HostForm as MainForm;
            if (host != null)
            {
                host.RestoreNotes();
            }
        }

        private void topmostWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleTopmost(!this.TopMost);
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
            //this.panel1.Calibrate();

            ToggleBorder(!m_BorderIsVisible);
            ToggleMainMenu(!m_MainMenuIsVisible);
        }

        private void NotesForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.richTextBox1.TextLength > 0)
            {
                var result = MessageBox.Show("There are your notes in this notebook.\n"
                    + "Are you sure to close?",
                    this.Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
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
            this.panel1.Cursor = Cursors.SizeAll;
            this.panel1.MouseUp += (object sender, MouseEventArgs e) => {
                this.panel1.SendToBack();
                this.Cursor = Cursors.Default;
            };

            this.Controls.Add(this.panel1);
        }

        private void WordWrap()
        {
            this.richTextBox1.WordWrap = !this.richTextBox1.WordWrap;
            wordWrapToolStripMenuItem.Checked = this.richTextBox1.WordWrap;
            wordWrapToolStripMenuItem1.Checked = this.richTextBox1.WordWrap;
        }

        private void CopyText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
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

        private void ToggleMainMenu(bool visibility)
        {
            if (m_MainMenuIsVisible == visibility)
            {
                return;
            }
            
            m_MainMenuIsVisible = visibility;

            var currentEditorSize = richTextBox1.Size;
            var menuDefaultHeight = 27;

            if (!visibility)
            {
                menuStrip1.Hide();
                richTextBox1.Location = new Point(2, 2);
                panel1.Location = new Point(0, 0);
                this.Size = new Size(this.Size.Width, this.Size.Height - menuDefaultHeight);
            }
            else
            {
                menuStrip1.Show();
                richTextBox1.Location = new Point(2, 29);
                panel1.Location = new Point(0, 27);
                this.Size = new Size(this.Size.Width, this.Size.Height + menuDefaultHeight);
            }

            richTextBox1.Size = currentEditorSize;
            panel1.Size = new Size(currentEditorSize.Width + 8, currentEditorSize.Height + 8);

            toggleMainMenuToolStripMenuItem1.Checked = m_MainMenuIsVisible;
            toggleMainMenuToolStripMenuItem.Checked = m_MainMenuIsVisible;
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

                BackgroundColorToolStripMenuItemColor(dlg.Color);
            }
        }

        private void BackgroundColorToolStripMenuItemColor(Color c)
        {
            var image = new Bitmap(20, 20);
                using (var graphics = Graphics.FromImage(image))
                {
                    graphics.DrawRectangle(new Pen(Color.Black), 0, 0, 19, 19);
                    graphics.FillRectangle(new SolidBrush(c), 1, 1, 18, 18);
                }
            this.backgroundColorToolStripMenuItem.Image = image;
        }

        private void ClearNotes()
        {
            this.richTextBox1.Clear();
        }

        private void ToggleBorder(bool visibility)
        {
            if (m_BorderIsVisible == visibility)
            {
                return;
            }

            m_BorderIsVisible = visibility;

            if (!visibility)
            {
                this.FormBorderStyle = FormBorderStyle.None;

                this.Location = new Point(this.Location.X + m_BorderOffsetX, this.Location.Y + m_BorderOffsetY);
            }
            else
            {
                var currentLocation = this.richTextBox1.PointToScreen(this.richTextBox1.Location);
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;

                if (m_BorderOffsetX == 0 || m_BorderOffsetY == 0)
                {
                    var newLocation = this.richTextBox1.PointToScreen(this.richTextBox1.Location);
                    m_BorderOffsetX = newLocation.X - currentLocation.X;
                    m_BorderOffsetY = newLocation.Y - currentLocation.Y;
                }

                this.Location = new Point(this.Location.X - m_BorderOffsetX, this.Location.Y - m_BorderOffsetY);
            }

            toggleBorderToolStripMenuItem.Checked = m_BorderIsVisible;
            toggleBorderToolStripMenuItem1.Checked = m_BorderIsVisible;
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
