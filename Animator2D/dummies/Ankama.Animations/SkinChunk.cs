using System;
using Ankama.Animations.Rendering;
using Il2CppDummyDll;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x2000025")]
public struct SkinChunk
{
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x0")]
	public int startVertexIndex;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x4")]
	public int indexCount;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x8")]
	public int startIndexIndex;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0xC")]
	public int vertexCount;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x10")]
	public int textureIndex;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x14")]
	public FlashMaskState maskState;
}
