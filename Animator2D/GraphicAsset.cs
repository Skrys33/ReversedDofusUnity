using System.Runtime.InteropServices;
using Ankama.Animator2D.Rendering;
using UnityEngine;

namespace Ankama.Animator2D
{
    public sealed class GraphicAsset : ScriptableObject
    {
        public Texture2D atlas;

        public AnimationGeometryVertex[] vertices;

        public ushort[] triangles;

        public GraphicAsset() : base()
        {
            
        }
    }

}