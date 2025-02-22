using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsTools.Infrastructure;

namespace WindowsTools
{
    public partial class PreventSleepForm : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        Task m_TheTask;
        CancellationTokenSource ts;

        public PreventSleepForm()
        {
            InitializeComponent();
        }

        private void PreventSleepForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void radioES_CONTINUOUS_CheckedChanged(object sender, EventArgs e)
        {
            txtSleepAfterTime.Enabled = !radioES_CONTINUOUS.Checked;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (m_TheTask != null && m_TheTask.Status != null && m_TheTask.Status == TaskStatus.Running)
            {
                ts.Cancel();
                btnStartStop.Text = "Start";
            }
            else
            {
                EXECUTION_STATE state = EXECUTION_STATE.ES_CONTINUOUS;
                state |= chkES_AWAYMODE_REQUIRED.Checked ? EXECUTION_STATE.ES_AWAYMODE_REQUIRED : (EXECUTION_STATE)0;
                state |= chkES_DISPLAY_REQUIRED.Checked ? EXECUTION_STATE.ES_DISPLAY_REQUIRED : (EXECUTION_STATE)0;
                state |= chkES_SYSTEM_REQUIRED.Checked ? EXECUTION_STATE.ES_SYSTEM_REQUIRED : (EXECUTION_STATE)0;

                if (state == EXECUTION_STATE.ES_CONTINUOUS)
                {
                    MessageBox.Show("Please select execution state options.");
                    return;
                }

                var startTime = DateTime.Now;
                TimeSpan sleepAfter = new TimeSpan();
                if (radioSleepAfterTime.Checked)
                {
                    if (!TimeSpan.TryParse(txtSleepAfterTime.Text, out sleepAfter))
                    {
                        MessageBox.Show("Please enter a valid time interval\r\nhh:mm:ss");
                        return;
                    }
                }

                ts = new CancellationTokenSource();

                m_TheTask = Task.Run(() =>
                {
                    SetThreadExecutionState(state);

                    while (true)
                    {
                        Task.Delay(1000).Wait();
                        
                        if (ts.IsCancellationRequested)
                        {
                            // MessageBox.Show("Canceled.");
                            AutoClosingMessageBox.Show("Canceled", String.Empty, 3000);
                            break;
                        }
                        else if (radioSleepAfterTime.Checked && (startTime + sleepAfter) <= DateTime.Now)
                        {
                            // MessageBox.Show("Time to sleep");
                            AutoClosingMessageBox.Show("Time to sleep", String.Empty, 3000);
                            break;
                        }
                    }

                    btnStartStop.SetPropertyThreadSafe(() => btnStartStop.Text, "Start");
                });

                btnStartStop.Text = "Stop";
            }
        }
    }
}
