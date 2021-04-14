using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace font_generator.Generator
{
    class FntGenerator : IFontFileGenerator
    {
        public string FileExtension => "fnt";

        public byte[] ToByteArray()
        {
            throw new NotImplementedException();
        }

        public void WriteChar(char c, Bitmap bitmap)
        {
            throw new NotImplementedException();
        }

        public void WriteHead(string name, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void WriteTail()
        {
            throw new NotImplementedException();
        }
    }
}
