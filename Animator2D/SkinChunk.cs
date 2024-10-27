using System;
using System.Runtime.InteropServices;
using Ankama.Animations.Rendering;

namespace Ankama.Animator2D
{
    [Serializable]
    public struct SkinChunk
    {
        public int startVertexIndex;

        public int indexCount;

        public int startIndexIndex;

        public int vertexCount;
        
        public int textureIndex;

        public FlashMaskState maskState;
    }

}