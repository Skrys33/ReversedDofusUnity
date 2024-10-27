using Ankama.Animations.Rendering;
using UnityEngine;

namespace Ankama.Animator2D
{
    internal struct BackgroundObject
    {
        public int id;

        public GameObject gameObject;

        public IApplyMaterialSortOrder applyMaterialSortOrder;

        public bool requiresAutoPosition;
    }
}