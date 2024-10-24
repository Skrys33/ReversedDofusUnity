using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ankama.Animator2D.Rendering
{
    [Serializable]
    public struct AnimationGeometryVertex
    {
        [SerializeField]
        public Vector3 pos;

        [SerializeField]
        public Vector2 uv;

        [SerializeField]
        public uint multiplicativeColor;

        [SerializeField]
        public uint additiveColor;

        public static readonly VertexAttributeDescriptor[] s_layout;

        static AnimationGeometryVertex()
        {
            // TODO : Probably not the right implementation
            if (s_layout == null)
            {
                s_layout = new VertexAttributeDescriptor[4];

                s_layout[0] = new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3, 0);
                s_layout[1] = new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2, 1);
                s_layout[2] = new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Uint32, 1, 2);
                s_layout[3] = new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Uint32, 1, 3);
            }
        }
    }
}
