using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ColorsForm : Form
    {

        public ColorsForm(Color color)
        {
            InitializeComponent();
            hSB_Blue.Tag = nUD_Blue;
            hSB_Green.Tag = nUD_Green;
            hSB_Red.Tag = nUD_Red;
            nUD_Red.Tag = hSB_Red;
            nUD_Blue.Tag = hSB_Blue;
            nUD_Green.Tag = hSB_Green;
            nUD_Blue.Value = color.B;
            nUD_Green.Value = color.G;
            nUD_Red.Value = color.R;

        }
        
        private void ColorsForm_Load(object sender, EventArgs e)
        {

        }

        private void hSB_Red_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hSB_Red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (HScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void nUD_Red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void hSB_Green_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (HScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void hSB_Blue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (HScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }

        private void nUD_Blue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }

        private void nUD_Green_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor();
        }
        private void UpdateColor()
        {
            Color result = Color.FromArgb(hSB_Red.Value,hSB_Green.Value,hSB_Blue.Value);
            pictureBox1.BackColor = result;
            Data.Value = result.ToArgb();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            globals.currentPen.Color = Color.FromArgb(Data.Value);
        }

        private void btn_OtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hSB_Red.Value = colorDialog.Color.R;
                hSB_Green.Value = colorDialog.Color.G;
                hSB_Blue.Value = colorDialog.Color.B;
                Color colorResult = colorDialog.Color;
                UpdateColor();
            }

        }
    }
}
