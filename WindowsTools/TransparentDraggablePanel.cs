using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    public class TransparentDraggablePanel : Panel
    {
        private bool m_MouseIsDown = false;
        private Point m_MouseDownCoordinates;
        private Form m_HostForm;

        public TransparentDraggablePanel(Form host)
        {
            this.m_HostForm = host;

            InitializeComponents();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private void InitializeComponents()
        {
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            this.MouseDown += (sender, e) =>
            {
                m_MouseIsDown = true;
                m_MouseDownCoordinates = e.Location;
            };

            this.MouseUp += (sender, e) =>
            {
                m_MouseIsDown = false;
            };

            this.MouseMove += (sender, e) =>
            {
                if (m_MouseIsDown)
                {
                    Point LocationNew = new Point(m_HostForm.Location.X + e.Location.X - m_MouseDownCoordinates.X,
                        m_HostForm.Location.Y + e.Location.Y - m_MouseDownCoordinates.Y);

                    m_HostForm.Location = LocationNew;
                }
            };
        }
    }
}
