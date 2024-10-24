using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x2000030")]
public class GlowFilter : IEquatable<GlowFilter>
{
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x10")]
	public Color32 glowColor;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x14")]
	public float blurX;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x18")]
	public float blurY;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x1C")]
	public float strength;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x20")]
	public bool inner;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x21")]
	public bool knockout;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x22")]
	public bool compositeSource;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x24")]
	public int numPasses;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x80D1E0", Offset = "0x80BBE0", VA = "0x18080D1E0", Slot = "4")]
	public bool Equals(GlowFilter other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x7B90C0", Offset = "0x7B7AC0", VA = "0x1807B90C0")]
	public GlowFilter()
	{
	}
}
