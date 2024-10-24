using Il2CppDummyDll;

namespace Ankama.Animations;

[Token(Token = "0x2000027")]
public struct SkinTransformData
{
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x8")]
	public float scaleX;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0xC")]
	public float scaleY;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x10")]
	public short rotation;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x18")]
	public string originalClip;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x20")]
	public string overrideClip;
}
