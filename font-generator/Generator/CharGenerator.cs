using System;
using System.Drawing;
using System.Drawing.Text;

namespace font_generator.Generator
{
    public class CharGenerator : IDisposable
    {
        public Bitmap Bitmap { get; }

        private readonly Font font;
        private readonly bool useHinting;
        private readonly Graphics graphics;

        public CharGenerator(Font font, bool useHinting, int width, int height)
        {
            this.font = font;
            this.useHinting = useHinting;
            Bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(Bitmap);
        }

        public void Draw(char c, int xOffset, int yOffset, bool alignLeft)
        {
            graphics.TextRenderingHint = useHinting ? TextRenderingHint.SingleBitPerPixelGridFit : TextRenderingHint.SingleBitPerPixel;
            graphics.Clear(Color.Black);
            graphics.DrawString(c.ToString(), font, Brushes.White, new PointF(xOffset, yOffset));

            if (alignLeft)
            {
                int minX = Bitmap.Width - 1;
                for (int y = 0; y < Bitmap.Height; y++)
                {
                    for (int x = 0; x < Bitmap.Width; x++)
                    {
                        if (Bitmap.GetPixel(x, y).R != 0)
                        {
                            if (x < minX)
                                minX = x;
                            break;
                        }
                    }
                }

                Draw(c, xOffset - minX, yOffset, false);
            }
        }

        public void Dispose()
        {
            graphics.Dispose();
        }
    }
}
