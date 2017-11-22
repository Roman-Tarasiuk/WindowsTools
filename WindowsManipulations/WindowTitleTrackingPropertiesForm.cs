using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class WindowTitleTrackingPropertiesForm : Form
    {
        private TitleTrackingFormProperties m_Properties;

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
            this.labelSample.Width = int.Parse(txtWidth.Text);
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            this.labelSample.Height = int.Parse(txtHeight.Text);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = labelSample.Font;
            var result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.labelSample.Font = fontDialog1.Font;
            }
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = labelSample.BackColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.labelSample.BackColor = colorDialog1.Color;
            }
        }

        private void btnForeground_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = labelSample.ForeColor;
            var result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.labelSample.ForeColor = colorDialog1.Color;
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

        private void ReadProperties()
        {
            m_Properties.BackColor = labelSample.BackColor;
            m_Properties.ForeColor = labelSample.ForeColor;
            m_Properties.Font = labelSample.Font;
            m_Properties.Width = labelSample.Width;
            m_Properties.Height = labelSample.Height;
            m_Properties.Interval = int.Parse(txtInterval.Text);
        }

        private void Apply(TitleTrackingFormProperties m_Properties)
        {
            this.labelSample.BackColor = m_Properties.BackColor;
            this.labelSample.ForeColor = m_Properties.ForeColor;
            this.labelSample.Font = m_Properties.Font;
            this.labelSample.Width = m_Properties.Width;
            this.labelSample.Height = m_Properties.Height;
            this.txtWidth.Text = m_Properties.Width.ToString();
            this.txtHeight.Text = m_Properties.Height.ToString();
            this.txtInterval.Text = m_Properties.Interval.ToString();
        }

        #endregion
    }
}
