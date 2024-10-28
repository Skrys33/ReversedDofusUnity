using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Ankama.Animator2D
{
    [Serializable]
    public sealed class CustomisationSlot
    {
        [SerializeField]
        public string nodeName;

        [SerializeField]
        public SkinAsset asset;

        [SerializeField]
        public SkinAssetPart part;

        public CustomisationSlot()
        {
            // Ankama.Logging.Log.Initialize(param);
        }
    }
}