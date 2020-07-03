using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BrushGenerators
{
    public interface IBrushGenerator
    {
        Brush GetBrush(uint seed);
    }
}
