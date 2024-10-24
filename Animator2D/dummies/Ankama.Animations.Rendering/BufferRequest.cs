using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000040")]
internal struct BufferRequest
{
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x0")]
	public readonly Animator2D target;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x8")]
	public readonly guy animation;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x8091F0", Offset = "0x807BF0", VA = "0x1808091F0")]
	public BufferRequest(Animator2D target, guy animation, int id)
	{
	}
}
