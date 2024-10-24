using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Ankama.Animations.Playables;

[Serializable]
[Token(Token = "0x2000054")]
[DisplayName("Animator2D Clip")]
internal sealed class Animator2DPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal string animationName;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal bool loop;

	[Token(Token = "0x1700002D")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x803350", Offset = "0x801D50", VA = "0x180803350", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x8032B0", Offset = "0x801CB0", VA = "0x1808032B0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x8032F0", Offset = "0x801CF0", VA = "0x1808032F0")]
	public Animator2DPlayableAsset()
	{
	}
}
