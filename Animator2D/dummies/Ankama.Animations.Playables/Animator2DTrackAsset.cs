using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Ankama.Animations.Playables;

[Serializable]
[Token(Token = "0x2000056")]
[DisplayName("Animator2D/Track")]
[TrackColor(0.9254902f, 1f / 17f, 7f / 85f)]
[TrackBindingType(typeof(Animator2D))]
[TrackClipType(typeof(Animator2DPlayableAsset))]
internal sealed class Animator2DTrackAsset : TrackAsset
{
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x808F70", Offset = "0x807970", VA = "0x180808F70", Slot = "32")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x809150", Offset = "0x807B50", VA = "0x180809150", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x809160", Offset = "0x807B60", VA = "0x180809160")]
	public Animator2DTrackAsset()
	{
	}
}
