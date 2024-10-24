using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ankama.Animator2D.Sources.Rendering.CustomPasses
{
    [Serializable]
    public class OutlinePrepassSettings
    {
        public LayerMask layerMask;

        public int shaderOutlinedInWhitePassIndex;

        public Color outlineColor;

        public float outlineWidth;

        [Range(0f, 1f)]
        public float alphaClip;

        public OutlinePrepassSettings()
        {
            alphaClip = 1.0f;
            outlineWidth = 0.6f;

            // Todo : Ankama.Logging.Log$$Initialize(param_1);
        }
    }
}
