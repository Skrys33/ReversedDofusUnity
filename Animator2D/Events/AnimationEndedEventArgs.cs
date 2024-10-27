using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Ankama.Animator2D.Events
{
    [PublicAPI]
    public sealed class AnimationEndedEventArgs : EventArgs
    {
        [PublicAPI] public string animation; // animation = dgmj

        [PublicAPI]
        public void bkgl(string animation)
        {
            // Todo : It seems possible to merge with the constructor
            this.animation = animation;
        }

        public AnimationEndedEventArgs()
        {
        }
    }

}