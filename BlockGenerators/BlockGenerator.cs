using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BlockGenerators
{
    public abstract class BlockGenerator : IBlockGenerator
    {
        public int Weight { get; private set; }
        public abstract bool IsSymmetric { get; }

        public BlockGenerator(int weight)
        {
            Weight = weight;
        }

        public abstract void Draw(Graphics g, Rectangle r, Brush bg, Brush fg, uint seed, bool fliphorizontal);
    }
}
