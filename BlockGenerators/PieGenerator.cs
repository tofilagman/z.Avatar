﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace z.Avatar.BlockGenerators
{
    public class PieGenerator : BlockGenerator
    {
        public override bool IsSymmetric
        {
            get { return false; }
        }

        public PieGenerator(int weight)
            : base(weight) { }

        public override void Draw(Graphics g, Rectangle r, Brush bg, Brush fg, uint seed, bool fliphorizontal)
        {
            switch ((seed + (fliphorizontal ? 2 : 0)) % 4)
            {
                case 0: //  ◞
                    g.FillPie(fg, new Rectangle(r.Left - r.Width, r.Top - r.Height, r.Width * 2, r.Height * 2), 0, 90);
                    break;
                case 1: //  ◜
                    g.FillPie(fg, new Rectangle(r.Left, r.Top, r.Width * 2, r.Height * 2), -90, -90);
                    break;
                case 2: //  ◟
                    g.FillPie(fg, new Rectangle(r.Left, r.Top - r.Height, r.Width * 2, r.Height * 2), 90, 90);
                    break;
                case 3: //  ◝
                default:
                    g.FillPie(fg, new Rectangle(r.Left - r.Width, r.Top, r.Width * 2, r.Height * 2), 0, -90);
                    break;
            }
        }
    }
}
