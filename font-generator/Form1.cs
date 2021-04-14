using font_generator.Generator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace font_generator
{
    public partial class Form1 : Form
    {
        private Font currentFont;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            using var fontDialog = new FontDialog();
            if (currentFont != null)
            {
                fontDialog.Font = currentFont;
            }
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontDialog.Font;
                iFontName.Text = $"{currentFont.Name}, {currentFont.SizeInPoints}pt";
                RefreshPreview();
            }
        }

        private bool EnsureFont()
        {
            if (currentFont == null)
            {
                MessageBox.Show("Error: Please select a font.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void RefreshPreview()
        {
            if (EnsureFont() && iPreviewChar.TextLength != 0)
                GenerateChar(iPreviewChar.Text[0]);
        }

        private void GenerateChar(char c)
        {
            using var charGenerator = new CharGenerator(currentFont, (int)iWidth.Value, (int)iHeight.Value);
            charGenerator.Draw(c, (int)iXOffset.Value, (int)iYOffset.Value);
            pbPreview.Image = charGenerator.Bitmap;
            pbPreview.Update();
        }

        private void btnRefreshPreview_Click(object sender, EventArgs e)
        {
            RefreshPreview();
        }
    }
}
