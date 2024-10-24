using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200004A")]
internal struct MaterialDescriptor
{
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x0")]
	public Texture texture;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x8")]
	public uint textureRequestId;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0xC")]
	public FlashMaskState maskFlags;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x10")]
	public int maskRef;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x14")]
	public Animation.gux blendMode;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x18")]
	public Vector4[] colorMatrix;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x20")]
	public int renderQueue;

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x28")]
	public Color[] customisationColors;

	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x30")]
	public Color rootColor;

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x40")]
	public bool requireUseColorEffectsKeyword;

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x80F710", Offset = "0x80E110", VA = "0x18080F710")]
	public bool Equals(MaterialDescriptor other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x80F940", Offset = "0x80E340", VA = "0x18080F940", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x80FA00", Offset = "0x80E400", VA = "0x18080FA00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x80F6A0", Offset = "0x80E0A0", VA = "0x18080F6A0")]
	private static bool AreArraysEqual(Vector4[] a, Vector4[] b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x80FA20", Offset = "0x80E420", VA = "0x18080FA20")]
	public static bool operator ==(MaterialDescriptor left, MaterialDescriptor right)
	{
		return default(bool);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x80FD00", Offset = "0x80E700", VA = "0x18080FD00")]
	public static bool operator !=(MaterialDescriptor left, MaterialDescriptor right)
	{
		return default(bool);
	}
}
