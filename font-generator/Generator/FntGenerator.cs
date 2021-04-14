using System;
using System.Drawing;
using System.IO;

namespace font_generator.Generator
{
    class FntGenerator : IFontFileGenerator
    {
        /*
         * fnt file structure
         * ==================
         * 
         * header:       FNT[u8 name_len][chars NAME][u8 w][u8 h]
         * for each row: [u8[][] data][u8 char_width]
         * tail: 0x0216
         */

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

            // Name, prefixed with uint8
            writer.Write((byte)name.Length);
            writer.Write(name.ToCharArray());

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
                }

                if (rowWidth > charWidth)
                    charWidth = rowWidth;

                writer.Write(rowValue); // Write the column mask for each row
            }

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
