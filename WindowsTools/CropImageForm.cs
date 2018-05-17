using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsTools
{
    public partial class CropImageForm : Form
    {
        #region Fields

        private bool m_Cropping = false;
        private Crop m_Crop;

        #endregion


        #region Internal Helper Structures

        private enum Crop
        {
            Left,
            Right,
            Top,
            Bottom
        }

        #endregion


        #region Constructors

        public CropImageForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        private void toolStripBtnPaste_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
        }

        private void toolStripBtnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show(String.Format("{0}, {1}", e.X, e.Y));
            var x = e.X;
            var y = e.Y;
            var pixel = ((Bitmap)pictureBox1.Image).GetPixel(x, y);

            //MessageBox.Show(String.Format("{0}, {1}, {2}", pixel.R, pixel.G, pixel.B));
            if (m_Cropping)
            {
                pictureBox1.Image = CropImage(pictureBox1.Image, m_Crop, x, y);
            }

            m_Cropping = false;
            UncheckCropButtons();
        }

        private void toolStripBtnCropLeft_Click(object sender, EventArgs e)
        {
            ToggleCropLeft();
        }

        private void toolStripBtnCropRight_Click(object sender, EventArgs e)
        {
            ToggleCropRight();
        }

        private void toolStripBtnCropTop_Click(object sender, EventArgs e)
        {
            ToggleCropTop();
        }

        private void toolStripBtnCropBottom_Click(object sender, EventArgs e)
        {
            ToggleCropBottom();
        }

        private void toolStripBtnEscapeCrop_Click(object sender, EventArgs e)
        {
            EscapeCrop();
        }

        private void toolStripBtnEraseImage_Click(object sender, EventArgs e)
        {
            EraseImage();
        }

        private void CropImageForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.V:
                    if (e.Control)
                    {
                        PasteFromClipboard();
                    }
                    break;

                case Keys.C:
                    if (e.Control)
                    {
                        CopyToClipboard();
                    }
                    break;

                case Keys.Escape:
                    EscapeCrop();
                    break;

                case Keys.Delete:
                    EraseImage();
                    break;

                case Keys.D1:
                    ToggleCropLeft();
                    break;

                case Keys.D2:
                    ToggleCropTop();
                    break;

                case Keys.D3:
                    ToggleCropRight();
                    break;

                case Keys.D4:
                    ToggleCropBottom();
                    break;
            }
        }

        #endregion


        #region Helper Methods

        private void ToggleCropLeft()
        {
            m_Cropping = true;
            m_Crop = Crop.Left;

            CheckCropButton(m_Crop);
        }

        private void ToggleCropRight()
        {
            m_Cropping = true;
            m_Crop = Crop.Right;

            CheckCropButton(m_Crop);
        }

        private void ToggleCropTop()
        {
            m_Cropping = true;
            m_Crop = Crop.Top;

            CheckCropButton(m_Crop);
        }

        private void ToggleCropBottom()
        {
            m_Cropping = true;
            m_Crop = Crop.Bottom;

            CheckCropButton(m_Crop);
        }

        private Image CropImage(Image image, Crop crop, int x, int y)
        {
            var bitmap = (Bitmap)image;

            int left = 0, 
                top = 0,
                width = bitmap.Width,
                height = bitmap.Height;

            if (crop == Crop.Left)
            {
                left = x;
                while (bitmap.GetPixel(left+1, y) == bitmap.GetPixel(left, y))
                {
                    left++;
                }

                left++;

                width = bitmap.Width - left;
            }
            else if (crop == Crop.Right)
            {
                left = x;
                while (bitmap.GetPixel(left - 1, y) == bitmap.GetPixel(left, y))
                {
                    left--;
                }

                width = left;
                left = 0;
            }
            else if (crop == Crop.Top)
            {
                top = y;
                while (bitmap.GetPixel(x, top + 1) == bitmap.GetPixel(x, top))
                {
                    top++;
                }

                top++;

                height = bitmap.Height - top;
            }
            else if (crop == Crop.Bottom)
            {
                top = y;
                while (bitmap.GetPixel(x, top - 1) == bitmap.GetPixel(x, top))
                {
                    top--;
                }

                height = top;
                top = 0;
            }

            return ((Bitmap)image).Clone(new Rectangle(left, top, width, height), System.Drawing.Imaging.PixelFormat.DontCare);
        }

        private void UncheckCropButtons()
        {
            toolStripBtnCropLeft.CheckState = CheckState.Unchecked;
            toolStripBtnCropTop.CheckState = CheckState.Unchecked;
            toolStripBtnCropRight.CheckState = CheckState.Unchecked;
            toolStripBtnCropBottom.CheckState = CheckState.Unchecked;
        }

        private void CheckCropButton(Crop crop)
        {
            toolStripBtnCropLeft.CheckState = (crop == Crop.Left ? CheckState.Checked : CheckState.Unchecked);
            toolStripBtnCropTop.CheckState = (crop == Crop.Top ? CheckState.Checked : CheckState.Unchecked);
            toolStripBtnCropRight.CheckState = (crop == Crop.Right ? CheckState.Checked : CheckState.Unchecked);
            toolStripBtnCropBottom.CheckState = (crop == Crop.Bottom ? CheckState.Checked : CheckState.Unchecked);
        }

        private void PasteFromClipboard()
        {
            pictureBox1.Image = Clipboard.GetImage();
            m_Cropping = false;

            UncheckCropButtons();
        }

        private void CopyToClipboard()
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
            m_Cropping = false;

            UncheckCropButtons();
        }

        private void EscapeCrop()
        {
            m_Cropping = false;
            UncheckCropButtons();
        }

        private void EraseImage()
        {
            pictureBox1.Image = null;
        }

        #endregion
    }
}
