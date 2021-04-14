using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                currentFont = fontDialog.Font;
                iFontName.Text = $"{currentFont.Name}, {currentFont.SizeInPoints}pt";
            }
        }
    }
}
