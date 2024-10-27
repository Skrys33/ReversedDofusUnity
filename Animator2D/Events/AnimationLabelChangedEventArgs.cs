using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Ankama.Animator2D.Events
{
    [PublicAPI]
    public sealed class AnimationLabelChangedEventArgs : EventArgs
    {
        [PublicAPI] public string animation; // animation = dgmc

        [PublicAPI] public string label; // label = dgmd

        [PublicAPI]
        public void bkfw(string animation, string label)
        {
            // Todo : It seems possible to merge with the constructor
            this.animation = animation;
            this.label = label;
        }

        public AnimationLabelChangedEventArgs()
        {
        }
    }
}