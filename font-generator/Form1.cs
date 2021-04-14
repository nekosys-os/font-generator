using font_generator.Generator;
using System;
using System.Drawing;
using System.IO;
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
                iSelectedFont.Text = $"{currentFont.Name}, {currentFont.SizeInPoints}pt";
                RefreshPreview();
            }
        }

        private void btnRefreshPreview_Click(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!EnsureFont())
                return;

            if (string.IsNullOrWhiteSpace(iFontName.Text))
            {
                MessageBox.Show("Error: Please choose a font name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IFontFileGenerator generator = null;
            if (iFntFile.Checked)
            {
                generator = new FntGenerator();
            }
            else if (iCArray.Checked)
            {
                generator = new CFontGenerator();
            }
            else
            {
                MessageBox.Show("Error: Please select an output format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var fileDialog = new SaveFileDialog();
            fileDialog.Filter = $".{generator.FileExtension}-Files|*.{generator.FileExtension}";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                GenerateFont(fileDialog.FileName, generator);
            }
        }

        private void GenerateFont(string file, IFontFileGenerator generator)
        {
            generator.WriteHead(iFontName.Text, (int)iWidth.Value, (int)iHeight.Value);
            for (char c = '\0'; c < 127; c++)
            {
                GenerateChar(c);
                generator.WriteChar(c, (Bitmap) pbPreview.Image);
            }
            generator.WriteTail();

            File.WriteAllBytes(file, generator.ToByteArray());
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
    }
}
