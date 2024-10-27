using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Ankama.Animator2D.Events
{
    [PublicAPI]
    public sealed class AnimationStartedEventArgs : EventArgs
    {
        [PublicAPI] public string animation; // animation = dmge

        [PublicAPI] public string previousAnimation; // previousAnimation = dgmf

        [PublicAPI] public int frame; // frame = dgmg

        [PublicAPI]
        public void bkgd(string animation, string previousAnimation, int frame)
        {
            // Todo : It seems possible to merge with the constructor
            this.animation = animation;
            this.previousAnimation = previousAnimation;
            this.frame = frame;
        }

        public AnimationStartedEventArgs()
        {
        }
    }
}