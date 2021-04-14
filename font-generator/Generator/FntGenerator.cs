using System;
using System.Drawing;

namespace font_generator.Generator
{
    class FntGenerator : IFontFileGenerator
    {
        public string FileExtension => "fnt";

        public void WriteHead(string name, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void WriteChar(char c, Bitmap bitmap)
        {
            throw new NotImplementedException();
        }

        public void WriteTail()
        {
            throw new NotImplementedException();
        }

        public byte[] ToByteArray()
        {
            throw new NotImplementedException();
        }
    }
}
