using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BlockGenerators
{
    public interface IBlockGenerator
    {
        int Weight { get; }
        void Draw(Graphics g, Rectangle r, Brush bg, Brush fg, uint seed, bool fliphorizontal);
        bool IsSymmetric { get; }
    }
}
