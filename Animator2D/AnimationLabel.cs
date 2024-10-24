using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ankama.Animator2D
{
    public readonly struct AnimationLabel
    {
        public readonly int frame;
        public readonly string label;
        internal AnimationLabel(int frame, string label)
        {
            this.frame = frame;
            this.label = label;
        }
    }
}
