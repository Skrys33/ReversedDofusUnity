using Il2CppDummyDll;

namespace Ankama.Animations;

[Token(Token = "0x2000022")]
public struct NamedTransform
{
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x0")]
	public int materialCount;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x8")]
	public Animator2D animator;
}
