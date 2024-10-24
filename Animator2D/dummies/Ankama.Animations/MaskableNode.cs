using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x2000021")]
public struct MaskableNode
{
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal string name;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	internal string graphicSymbolId;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x7F76B0", Offset = "0x7F60B0", VA = "0x1807F76B0")]
	internal MaskableNode(string name, string graphicSymbolId)
	{
	}
}
