using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Ankama.Animator2D.Playables
{
    [Serializable]
    [DisplayName("Animator2D Clip")]
    internal sealed class Animator2DPlayableAsset : PlayableAsset, ITimelineClipAsset
    {
        [SerializeField]
        internal string animationName;

        [SerializeField]
        internal bool loop;

        public ClipCaps clipCaps
        {
            get
            {
                return string.IsNullOrEmpty(animationName) ? ClipCaps.None : ClipCaps.Blending;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            throw new System.NotImplementedException("CreatePlayable method is not implemented in Animator2DPlayableAsset.");
        }

        public Animator2DPlayableAsset()
        {
            // Todo : Probably not the right implementation
            // https://github.com/AlpaGit/waven-old/blob/6a3f33ee63b8cd7a02d42fb363cce675ccbab91b/Animator2D/Playables/Animator2DPlayableAsset.cs

            if (string.IsNullOrEmpty(animationName))
            {
                animationName = "Default Animation";
            }

            // Todo : Core.Characters.Data.BonesLabelEventsIndexData$$.ctor(param_1, (MethodInfo*)0x0);

            base.OnEnable();
        }
    }
}
