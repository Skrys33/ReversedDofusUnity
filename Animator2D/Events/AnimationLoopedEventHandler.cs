using Ankama.Animations.Events;
using JetBrains.Annotations;

namespace Ankama.Animator2D.Events
{
    [PublicAPI]
    public delegate void AnimationLoopedEventHandler(object sender, AnimationLoopedEventArgs e);
}