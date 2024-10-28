using JetBrains.Annotations;

namespace Ankama.Animator2D
{
    [PublicAPI]
    public enum Animator2DInitialisationState // Animator2DInitialisationState = gva
    {
        [PublicAPI]
        None,
        [PublicAPI]
        Initialising,
        [PublicAPI]
        InitialisationPending,
        [PublicAPI]
        Initialised
    }

}