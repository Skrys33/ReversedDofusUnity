using Ankama.Animations.Events;
using JetBrains.Annotations;

namespace Ankama.Animator2D.Events
{
    [PublicAPI]
    public delegate void AnimationStartedEventHandler(object sender, AnimationStartedEventArgs e);
}