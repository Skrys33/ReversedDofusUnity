using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x2000028")]
public struct SkinAssetPart : IEquatable<SkinAssetPart>
{
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string name;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public DisplayListEntry[] DisplayListEntry;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SkinChunk[] skinChunks;

	[SpecialName]
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x7F7900", Offset = "0x7F6300", VA = "0x1807F7900")]
	public static bool bkeq(SkinAssetPart a, SkinAssetPart b)
	{
		return default(bool);
	}

	[SpecialName]
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x7F7960", Offset = "0x7F6360", VA = "0x1807F7960")]
	public static bool bker(SkinAssetPart a, SkinAssetPart b)
	{
		return default(bool);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x7F79D0", Offset = "0x7F63D0", VA = "0x1807F79D0")]
	public bool bkes(SkinAssetPart a, SkinAssetPart b)
	{
		return default(bool);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x7F7A30", Offset = "0x7F6430", VA = "0x1807F7A30")]
	public int bket(SkinAssetPart a)
	{
		return default(int);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x7F7780", Offset = "0x7F6180", VA = "0x1807F7780", Slot = "4")]
	public bool Equals(SkinAssetPart other)
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7F77E0", Offset = "0x7F61E0", VA = "0x1807F77E0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7F7890", Offset = "0x7F6290", VA = "0x1807F7890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x7F7AB0", Offset = "0x7F64B0", VA = "0x1807F7AB0")]
	public bool bkeu()
	{
		return default(bool);
	}
}
