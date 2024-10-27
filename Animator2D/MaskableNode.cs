using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Ankama.Animator2D
{
    [Serializable]
    public struct MaskableNode
    {
        [SerializeField]
        internal string name;

        [SerializeField]
        internal string graphicSymbolId;

        internal MaskableNode(string name, string graphicSymbolId)
        {
            this.name = name;
            this.graphicSymbolId = graphicSymbolId;
        }
    }
}