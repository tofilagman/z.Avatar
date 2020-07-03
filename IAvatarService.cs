using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar
{
    public interface IAvatarService
    {
        void AddRandomColors(params Color[] colors);
        Image Generate(string Text);
        Image Generate(string Text, Size size);
        Image Generate(byte[] value);
        Image Generate(byte[] value, Size size);
        string ConvertImagetoBase64(Image img);
    }
}
