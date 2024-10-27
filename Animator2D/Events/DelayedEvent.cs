using System;

namespace Ankama.Animator2D.Events
{
    internal readonly struct DelayedEvent
    {
        public enum EventType
        {
            Initialised,
            AnimationStarted,
            AnimationLooped,
            LabelChanged,
            AnimationEnded
        }

        public readonly EventType type; // EventType = gvi

        public readonly EventArgs args; 

        public DelayedEvent(EventType eventType, EventArgs eventArgs)
        {
            type = eventType;
            args = eventArgs;
        }
    }
}