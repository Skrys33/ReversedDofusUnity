using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x2000031")]
public class ColorMatrixFilter : IEquatable<ColorMatrixFilter>
{
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x10")]
	public Vector4[] matrix;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x809990", Offset = "0x808390", VA = "0x180809990", Slot = "4")]
	public bool Equals(ColorMatrixFilter other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x7B90C0", Offset = "0x7B7AC0", VA = "0x1807B90C0")]
	public ColorMatrixFilter()
	{
	}
}
