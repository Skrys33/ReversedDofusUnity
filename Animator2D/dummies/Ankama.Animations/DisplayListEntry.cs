using System;
using Ankama.Animations.Rendering;
using Il2CppDummyDll;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x2000026")]
public struct DisplayListEntry
{
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x0")]
	public short symbolId;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x2")]
	public short entries;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x4")]
	public AnimTransform transform;
}
