using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BrushGenerators
{
    public class RandomColorBrushGenerator : IBrushGenerator
    {
        public Brush GetBrush(uint seed)
        {
            unchecked
            {
                return new SolidBrush(Color.FromArgb(255, Color.FromArgb((int)seed)));
            }
        }
    }
}
