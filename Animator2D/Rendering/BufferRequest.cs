using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ankama.Animator2D.Rendering
{
    internal struct BufferRequest
    {
        public readonly Animator2D target;
        public readonly AnimationInstance animation;
        public int id;

        public BufferRequest(Animator2D target, AnimationInstance animation, int id)
        {
            this.target = target;
            this.animation = animation;
            this.id = id + 1;
        }
    }
}
