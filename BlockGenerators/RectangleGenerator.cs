using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BlockGenerators
{
    public class RectangleGenerator : BlockGenerator
    {
        public override bool IsSymmetric
        {
            get { return true; }
        }

        public RectangleGenerator(int weight)
            : base(weight) { }

        public override void Draw(Graphics g, Rectangle r, Brush bg, Brush fg, uint seed, bool fliphorizontal)
        {
            if (seed % 2 == 0)
                g.FillRectangle(fg, r);
        }
    }
}
