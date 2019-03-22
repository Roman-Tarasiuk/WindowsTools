using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTools
{
    // https://stackoverflow.com/questions/4463363/how-can-i-set-the-opacity-or-transparency-of-a-panel-in-winforms

    public class TransparentDraggablePanel : Panel
    {
        #region Fields

        private bool m_MouseIsDown = false;
        private Point m_MouseDownCoordinates;
        private Form m_HostForm;

        private int m_BorderDeltaX;
        private int m_BorderDeltaY;

        #endregion


        #region Constructors

        public TransparentDraggablePanel(Form host)
        {
            this.m_HostForm = host;

            InitializeComponents();
        }

        #endregion


        #region Properties

        public bool Locked { get; set; }

        #endregion


        #region Public Methods

        public void Calibrate(FormBorderStyle borderStyle)
        {
            Point locationBorder,
                locationNpBorder;
            //const int sleepTime = 400;

            if (this.m_HostForm.FormBorderStyle == borderStyle)
            {
                locationBorder = this.PointToScreen(this.Location);
                this.m_HostForm.FormBorderStyle = FormBorderStyle.None;
                //Thread.Sleep(sleepTime);
                locationNpBorder = this.PointToScreen(this.Location);
                this.m_HostForm.FormBorderStyle = borderStyle;
            }
            else // FormBorderStyle.None
            {
                locationNpBorder = this.PointToScreen(this.Location);
                this.m_HostForm.FormBorderStyle = borderStyle;
                //Thread.Sleep(sleepTime);
                locationBorder = this.PointToScreen(this.Location);
                this.m_HostForm.FormBorderStyle = FormBorderStyle.None;
            }

            m_BorderDeltaX = locationBorder.X - locationNpBorder.X;
            m_BorderDeltaY = locationBorder.Y - locationNpBorder.Y;
        }

        #endregion


        #region Protected Override Methods/Properties

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

        #endregion


        #region Helper Methods

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
                if (Locked)
                {
                    return;
                }
                if (m_MouseIsDown)
                {
                    Point LocationNew = new Point(m_HostForm.Location.X + e.Location.X - m_MouseDownCoordinates.X,
                        m_HostForm.Location.Y + e.Location.Y - m_MouseDownCoordinates.Y);

                    m_HostForm.Location = LocationNew;
                }
            };
        }

        #endregion
    }
}
