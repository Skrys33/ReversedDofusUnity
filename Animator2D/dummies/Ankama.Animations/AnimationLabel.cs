using Il2CppDummyDll;

namespace Ankama.Animations;

[Token(Token = "0x2000017")]
public readonly struct AnimationLabel
{
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x0")]
	public readonly int frame;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x8")]
	public readonly string label;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7E09B0", Offset = "0x7DF3B0", VA = "0x1807E09B0")]
	internal AnimationLabel(int frame, string label)
	{
	}
}
