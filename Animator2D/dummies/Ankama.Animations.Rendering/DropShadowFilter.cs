using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x200002F")]
public class DropShadowFilter : IEquatable<DropShadowFilter>
{
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x10")]
	public Color32 dropShadowColor;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x14")]
	public float blurX;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x18")]
	public float blurY;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x1C")]
	public float angle;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x24")]
	public float strength;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x28")]
	public bool inner;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x29")]
	public bool knockout;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x2A")]
	public bool compositeSource;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x2C")]
	public int numPasses;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x809DE0", Offset = "0x8087E0", VA = "0x180809DE0", Slot = "4")]
	public bool Equals(DropShadowFilter other)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x7B90C0", Offset = "0x7B7AC0", VA = "0x1807B90C0")]
	public DropShadowFilter()
	{
	}
}
