using System.Drawing;

namespace font_generator.Generator
{
    interface IFontFileGenerator
    {
        string FileExtension { get; }

        void WriteHead(string name, int width, int height);

        void WriteChar(char c, Bitmap bitmap);

        void WriteTail();

        byte[] ToByteArray();
    }
}
