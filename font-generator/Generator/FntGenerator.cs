using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace font_generator.Generator
{
    class FntGenerator : IFontFileGenerator
    {

        public string FileExtension => "fnt";
        private MemoryStream stream;
        private BinaryWriter writer;
        private int width;
        private int height;

        public FntGenerator()
        {
            stream = new MemoryStream();
            writer = new BinaryWriter(stream);
        }

        public void WriteHead(string name, int width, int height)
        {
            this.width = width;
            this.height = height;

            // Magic
            writer.Write(new[] { 'F', 'N', 'T' });

            // Name, terminated with nullbyte
            writer.Write(name.ToCharArray());
            writer.Write((byte)0x00);

            // Width x Height
            writer.Write((byte)width);
            writer.Write((byte)height);
        }

        public void WriteChar(char c, Bitmap bitmap)
        {
            byte charWidth = 0;

            for (int row = 0; row < height; row++)
            {
                uint rowValue = 0;
                // Encode
                for (int col = 0; col < width; col++)
                {
                    if (bitmap.GetPixel(col, row).R != 0)
                        rowValue |= (uint)(1 << col);
                }

                // Scan width
                byte rowWidth = (byte)width;
                for (int col = width - 1; col >= 0; col--)
                {
                    if (bitmap.GetPixel(col, row).R == 0)
                        rowWidth--;
                    else break;
                }

                if (rowWidth > charWidth)
                    charWidth = rowWidth;

                writer.Write(rowValue); // Write the column mask for each row
            }

            if (charWidth == 0)
                charWidth = (byte)(width / 2);
            writer.Write(charWidth); // Character width ('advance') of that character
        }

        public void WriteTail()
        {
            writer.Write(0x0216);
        }

        public byte[] ToByteArray()
        {
            return stream.ToArray();
        }
    }
}
