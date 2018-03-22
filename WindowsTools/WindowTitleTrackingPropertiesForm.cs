using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class WindowTitleTrackingPropertiesForm : Form
    {
        private TitleTrackingFormProperties m_Properties;
        const int DragMouseRegionWidth = 8;

        public TitleTrackingFormProperties Properties
        {
            get
            {
                return m_Properties;
            }

            set
            {
                m_Properties = value;

                if (this.Visible)
                {
                    Apply(m_Properties);
                }
            }
        }


        #region Constructors

        public WindowTitleTrackingPropertiesForm()
        {
            InitializeComponent();
        }

        public WindowTitleTrackingPropertiesForm(TitleTrackingFormProperties prop)
            : this()
        {
            this.m_Properties = prop;
        }

        #endregion


        #region Event Listeners

        private void WindowTitleTrackingPropertiesForm_Shown(object sender, EventArgs e)
        {
            if (m_Properties != null)
            {
                Apply(m_Properties);
            }
        }

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            m_Properties.Width = int.Parse(txtWidth.Text);
            this.labelSample.Width = m_Properties.Width - DragMouseRegionWidth * 2;
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            m_Properties.Height = int.Parse(txtHeight.Text);
            this.labelSample.Height = m_Properties.Height - m_Properties.BorderWidth * 2;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = m_Properties.Font;
            var result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_Properties.Font = fontDialog1.Font;
                this.labelSample.Font = fontDialog1.Font;
            }
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = m_Properties.BackColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_Properties.BackColor = colorDialog1.Color;
                this.labelSample.BackColor = colorDialog1.Color;
            }
        }

        private void btnForeground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = m_Properties.ForeColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                m_Properties.ForeColor = colorDialog1.Color;
                this.labelSample.ForeColor = colorDialog1.Color;
            }
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = m_Properties.BorderColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.m_Properties.BorderColor = colorDialog1.Color;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadProperties();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region

        private void Apply(TitleTrackingFormProperties m_Properties)
        {
            this.labelSample.BackColor = m_Properties.BackColor;
            this.labelSample.ForeColor = m_Properties.ForeColor;
            this.labelSample.Font = m_Properties.Font;
            this.labelSample.Width = m_Properties.Width - DragMouseRegionWidth * 2;
            this.labelSample.Height = m_Properties.Height - m_Properties.BorderWidth * 2;
            this.txtWidth.Text = m_Properties.Width.ToString();
            this.txtHeight.Text = m_Properties.Height.ToString();
            this.txtInterval.Text = m_Properties.Interval.ToString();
            this.numBorderWidht.Value = m_Properties.BorderWidth;
        }

        private void ReadProperties()
        {
            m_Properties.BorderWidth = (int)numBorderWidht.Value;
            m_Properties.Interval = int.Parse(txtInterval.Text);
        }

        #endregion
    }
}
