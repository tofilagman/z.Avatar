using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BlockGenerators
{
    public class RotatedRectangleGenerator : BlockGenerator
    {
        public override bool IsSymmetric
        {
            get { return true; }
        }

        public RotatedRectangleGenerator(int weight)
            : base(weight) { }

        public override void Draw(Graphics g, Rectangle r, Brush bg, Brush fg, uint seed, bool fliphorizontal)
        {
            g.FillPolygon(fg, new[] {
                    new Point(r.Left + (r.Width / 2), r.Top),
                    new Point(r.Right, r.Top + (r.Height / 2)),
                    new Point(r.Left + (r.Width / 2), r.Bottom),
                    new Point(r.Left, r.Top + (r.Height / 2)),
                });
        }
    }
}
