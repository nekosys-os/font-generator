using System;
using System.Drawing;
using System.Text;

namespace font_generator.Generator
{
    class CFontGenerator : IFontFileGenerator
    {
        public string FileExtension => "c";

        private StringBuilder builder = new StringBuilder();
        private bool firstChar = true;
        private int width;
        private int height;

        public void WriteHead(string name, int width, int height)
        {
            this.width = width;
            this.height = height;
            builder.AppendLine($"uint16_t* {name}[] = {{");
        }

        public void WriteChar(char c, Bitmap bitmap)
        {
            if (firstChar)
            {
                firstChar = false;
            } else
            {
                builder.Append(", \n");
            }

            builder.Append("  (uint16_t[]) {");
            for (int row = 0; row < height; row++)
            {
                ushort rowValue = 0;
                for (int col = 0; col < width; col++)
                {
                    if (bitmap.GetPixel(col, row).R != 0)
                        rowValue |= (ushort)(1 << col);
                }

                builder.Append("0x" + rowValue.ToString("X") + (row < 15 ? ", " : ""));
            }
            builder.Append("}");
        }

        public void WriteTail()
        {
            builder.AppendLine("};");
        }

        public byte[] ToByteArray()
        {
            return Encoding.UTF8.GetBytes(builder.ToString());
        }
    }
}
