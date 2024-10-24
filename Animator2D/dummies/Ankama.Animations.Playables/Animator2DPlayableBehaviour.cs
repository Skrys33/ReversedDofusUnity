using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Ankama.Animations.Playables;

[Serializable]
[Token(Token = "0x2000055")]
internal sealed class Animator2DPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	internal string animationName;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal bool loop;

	[NonSerialized]
	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x20")]
	internal Animator2D dglm;

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x803360", Offset = "0x801D60", VA = "0x180803360", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x803400", Offset = "0x801E00", VA = "0x180803400", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x7B4670", Offset = "0x7B3070", VA = "0x1807B4670")]
	public Animator2DPlayableBehaviour()
	{
	}
}
