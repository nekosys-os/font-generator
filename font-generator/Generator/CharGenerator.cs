using System;
using System.Drawing;
using System.Drawing.Text;

namespace font_generator.Generator
{
    public class CharGenerator : IDisposable
    {
        public Bitmap Bitmap { get; }

        private readonly Font font;
        private readonly Graphics graphics;

        public CharGenerator(Font font, int width, int height)
        {
            this.font = font;
            Bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(Bitmap);
        }

        public void Draw(char c, int xOffset, int yOffset)
        {
            graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            graphics.Clear(Color.Black);
            graphics.DrawString(c.ToString(), font, Brushes.White, new PointF(xOffset, yOffset));
        }

        public void Dispose()
        {
            graphics.Dispose();
        }
    }
}
