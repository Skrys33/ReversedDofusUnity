using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000051")]
internal struct RenderState
{
	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x0")]
	public float m00;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x4")]
	public float m01;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x8")]
	public float m03;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0xC")]
	public float m10;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x10")]
	public float m11;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x14")]
	public float m13;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x18")]
	public uint multiplicativeColor;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x1C")]
	public uint additiveColor;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x20")]
	public short spriteIndex;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x22")]
	public short customisationIndex;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x24")]
	public short childrenRecursiveCount;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x26")]
	public byte alpha;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x27")]
	public Animation.guw maskFlags;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x28")]
	public Animation.gux blendMode;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x30")]
	public Vector4[] colorMatrix;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x38")]
	public FlashFilters flashFilters;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x810D00", Offset = "0x80F700", VA = "0x180810D00")]
	public int Compute(byte[] animationData, int dataPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x810930", Offset = "0x80F330", VA = "0x180810930")]
	private int ComputeExtendedFilterAndBlendState(byte[] animationData, int dataPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x810650", Offset = "0x80F050", VA = "0x180810650")]
	private int ComputeBlurFilterState(byte[] animationData, int dataPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x810B70", Offset = "0x80F570", VA = "0x180810B70")]
	private int ComputeGlowFilterState(byte[] animationData, int dataPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x810790", Offset = "0x80F190", VA = "0x180810790")]
	private int ComputeDropShadowFilterState(byte[] animationData, int dataPosition)
	{
		return default(int);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x810E90", Offset = "0x80F890", VA = "0x180810E90")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x810F50", Offset = "0x80F950", VA = "0x180810F50")]
	private static int StepToAlignment(int dataPosition, int alignment)
	{
		return default(int);
	}
}
