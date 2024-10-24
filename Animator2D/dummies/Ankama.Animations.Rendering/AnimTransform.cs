using System;
using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x200003E")]
public struct AnimTransform
{
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x0")]
	public float rX;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x4")]
	public float uX;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x8")]
	public float rY;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0xC")]
	public float uY;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x10")]
	public float tX;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x14")]
	public float tY;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly AnimTransform Identity;

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x7FC330", Offset = "0x7FAD30", VA = "0x1807FC330")]
	public static AnimTransform FromArray(float[] transformArray)
	{
		return default(AnimTransform);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x7FC3B0", Offset = "0x7FADB0", VA = "0x1807FC3B0")]
	public static AnimTransform FromSkinTransformData(SkinTransformData skinTransform)
	{
		return default(AnimTransform);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x7FC380", Offset = "0x7FAD80", VA = "0x1807FC380")]
	internal static AnimTransform FromRenderState(ref RenderState renderState)
	{
		return default(AnimTransform);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x7FC4E0", Offset = "0x7FAEE0", VA = "0x1807FC4E0")]
	internal void SetRenderStateTransform(ref RenderState renderState)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x7FC510", Offset = "0x7FAF10", VA = "0x1807FC510")]
	public float[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x7FC460", Offset = "0x7FAE60", VA = "0x1807FC460")]
	public void SetArray(float[] transformArray)
	{
	}
}
