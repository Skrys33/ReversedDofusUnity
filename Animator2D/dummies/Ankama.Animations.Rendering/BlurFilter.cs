using System;
using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x200002E")]
public class BlurFilter : IEquatable<BlurFilter>
{
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x10")]
	public float blurX;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x14")]
	public float blurY;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x18")]
	public int numPasses;

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8091B0", Offset = "0x807BB0", VA = "0x1808091B0", Slot = "4")]
	public bool Equals(BlurFilter other)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x7B90C0", Offset = "0x7B7AC0", VA = "0x1807B90C0")]
	public BlurFilter()
	{
	}
}
