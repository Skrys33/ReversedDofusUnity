using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Ankama.Animator2D.Rendering
{
    [Serializable]
    public class GlowFilter : IEquatable<GlowFilter>
    {
        public Color32 glowColor;

        public float blurX;

        public float blurY;

        public float strength;

        public bool inner;

        public bool knockout;

        public bool compositeSource;

        public int numPasses;

        public bool Equals(GlowFilter other)
        {
            if (other == null)
                return false;

            return glowColor.Equals(other.glowColor) &&
                   Mathf.Approximately(blurX, other.blurX) &&
                   Mathf.Approximately(blurY, other.blurY) &&
                   Mathf.Approximately(strength, other.strength) &&
                   inner == other.inner &&
                   knockout == other.knockout &&
                   compositeSource == other.compositeSource &&
                   numPasses == other.numPasses;
        }

        public GlowFilter()
        {
        }
    }
}