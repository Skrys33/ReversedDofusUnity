using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ankama.Animator2D.Sources.Rendering.CustomPasses
{

    [Serializable]
    public class OutlineInTexturePassSettings
    {

        public LayerMask layerMask;

        public int shaderOutlinedInWhitePassIndex;

        [Range(0f, 1f)]
        public float alphaClip;

        public OutlineInTexturePassSettings()
        {
            alphaClip = 0.6f;

            // Todo : Ankama.Logging.Log$$Initialize(param_1);
        }
    }

}
