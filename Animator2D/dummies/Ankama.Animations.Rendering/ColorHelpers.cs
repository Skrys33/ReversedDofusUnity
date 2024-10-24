using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000042")]
public static class ColorHelpers
{
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint SWFColorOpaqueWhite;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint SWFColorTransparentBlack;

	[Token(Token = "0x40001D9")]
	public const int MaxCustomisationColorCount = 16;

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x8096E0", Offset = "0x8080E0", VA = "0x1808096E0")]
	public static Color32 FromRGB(uint rgb)
	{
		return default(Color32);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x8096B0", Offset = "0x8080B0", VA = "0x1808096B0")]
	public static Color32 FromARGB(uint argb)
	{
		return default(Color32);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x809800", Offset = "0x808200", VA = "0x180809800")]
	public static uint ToRGB(Color input)
	{
		return default(uint);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x809780", Offset = "0x808180", VA = "0x180809780")]
	public static uint ToARGB(Color input)
	{
		return default(uint);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x8098B0", Offset = "0x8082B0", VA = "0x1808098B0")]
	public static uint ToRGB(Color32 input)
	{
		return default(uint);
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x809750", Offset = "0x808150", VA = "0x180809750")]
	public static uint ToARGB(Color32 input)
	{
		return default(uint);
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x809410", Offset = "0x807E10", VA = "0x180809410")]
	public static uint ConvertSWFColor(float red, float green, float blue, float alpha = 1f)
	{
		return default(uint);
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x809690", Offset = "0x808090", VA = "0x180809690")]
	public static uint ConvertSWFColor(sbyte red, sbyte green, sbyte blue, sbyte alpha)
	{
		return default(uint);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x809240", Offset = "0x807C40", VA = "0x180809240")]
	public static Color ConvertFromEncodedColor(uint encodedColor)
	{
		return default(Color);
	}
}
